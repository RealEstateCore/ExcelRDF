using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VDS.RDF.Ontology;

namespace ExcelRDF
{
    public partial class ImportOptionsForm : Form
    {
        private OntologyGraph graph;
        private Dictionary<TreeNode, HashSet<OntologyProperty>> classToPropertyMap = new Dictionary<TreeNode, HashSet<OntologyProperty>>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graph"></param>
        public ImportOptionsForm(OntologyGraph graph)
        {
            InitializeComponent();
            this.graph = graph;
            RdfOntologyOperations.instance.resourcesToImport.Clear();
            InitializeTreeView();
        }

        /// <summary>
        /// Recursively add an ontology class and its subclasses to a tree.
        /// </summary>
        /// <param name="c">Ontology class to add.</param>
        /// <param name="nodes">The collection of nodes to which this class is to be added.</param>
        private void AddToTreeView(OntologyClass c, TreeNodeCollection nodes)
        {
            string classLabel = Helper.GetLabel(c);
            string classId = c.Resource.ToString();
            TreeNode newNode = nodes.Add(classId, classLabel);
            newNode.Tag = c;
            classToPropertyMap.Add(newNode, new HashSet<OntologyProperty>());
            foreach (OntologyProperty property in c.IsDomainOf.OrderBy(o => o.Types.First()).OrderBy(o => o.ToString()))
            {
                classToPropertyMap[newNode].Add(property);
            }
            
            // Recurse for all children
            foreach (OntologyClass sc in c.DirectSubClasses)
            {
                AddToTreeView(sc, newNode.Nodes);
            }
        }

        /// <summary>
        /// Render the class hierarchy of the loaded ontology into the TreeView on the left
        /// side of the import options window.
        /// </summary>
        private void InitializeTreeView()
        {
            ontologyClassesTreeView.BeginUpdate();
            foreach (OntologyClass c in graph.OwlClasses)
            {
                if (c.IsTopClass)
                {
                    AddToTreeView(c, ontologyClassesTreeView.Nodes);
                }
            }
            ontologyClassesTreeView.EndUpdate();
            ontologyClassesTreeView.ExpandAll();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Callback that re-renders the CheckedListBox holding properties when a node in
        /// in the left-hand TreeView is selected or checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OntologyClassesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertiesListBox.BeginUpdate();
            propertiesListBox.Items.Clear();
            foreach (OntologyProperty property in classToPropertyMap[e.Node])
            {
                // Re-check those boxes that were checked previously, i.e. keep state
                bool isChecked = RdfOntologyOperations.instance.resourcesToImport.Contains(property.ToString());
                propertiesListBox.Items.Add(new PropertyListItem(property), isChecked);
            }
            propertiesListBox.EndUpdate();
        }

        private void OntologyClassesTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                RdfOntologyOperations.instance.resourcesToImport.Add(e.Node.Tag.ToString());
            }
            else
            {
                RdfOntologyOperations.instance.resourcesToImport.Remove(e.Node.Tag.ToString());
            }
        }

        private void PropertiesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                RdfOntologyOperations.instance.resourcesToImport.Add(((PropertyListItem)propertiesListBox.Items[e.Index]).property.ToString());
            }
            else
            {
                RdfOntologyOperations.instance.resourcesToImport.Remove(((PropertyListItem)propertiesListBox.Items[e.Index]).property.ToString());
            }
        }

        /// <summary>
        /// Nested class for the property list, wrapping an OntologyProperty but changing its default
        /// default string representation to use the label. 
        /// </summary>
        private class PropertyListItem
        {
            public OntologyProperty property;
            public PropertyListItem(OntologyProperty property)
            {
                this.property = property;
            }
            public override string ToString()
            {
                return Helper.GetLabel(property);
            }
        }
    }
}
