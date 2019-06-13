using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VDS.RDF;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;

namespace ExcelRDF
{
    public partial class ImportOptionsForm : Form
    {
        private readonly String NAMED_INDIVIDUAL_LABEL = "Named individual";
        private readonly String NESTED_ANON_INDIVIDUAL_LABEL = "Nested anonymous individual";

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

        private void PropCtxMenuRangeTypeSelector_Click(object sender, EventArgs e)
        {
            String selectedOption = propCtxMenuRangeTypeSelector.SelectedItem.ToString();
            // TODO: This does not work, the else menu is only enabled in the inverse case, debug
            if (selectedOption.Equals(NESTED_ANON_INDIVIDUAL_LABEL))
            {
                propCtxMenuSubProperties.Enabled = true;
                // TODO: add this property to the nestedRangeProperties structure on RdfOntologyOperations
            }
            else
            {
                propCtxMenuSubProperties.Enabled = false;
                // TODO: remove this property from the nestedRangeProperties structure on RdfOntologyOperations
            }
        }

        private void PropertyContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Populate the range type selector
            propCtxMenuRangeTypeSelector.Items.AddRange(new String[] { NAMED_INDIVIDUAL_LABEL,
                NESTED_ANON_INDIVIDUAL_LABEL });

            // TODO: implement selection of PropCtxMenuRangeTypeSelector based on status in nestedRangeProperties structure on RdfOntologyOperations
            propCtxMenuRangeTypeSelector.SelectedIndex = 0;

            // Load submenus in propCtxMenuSubProperties based on the selected property
            propCtxMenuSubProperties.DropDownItems.Clear();
            List<OntologyProperty> subProperties = new List<OntologyProperty>();
            subProperties.Add(graph.CreateOntologyProperty(graph.CreateUriNode(new Uri(OntologyHelper.PropertyLabel))));
            OntologyProperty selectedProperty = ((PropertyListItem)propertiesListBox.SelectedItem).property;
            // TODO: This is horribly slow on non-trivial sized graphs; very likely needs to be changed!
            foreach (OntologyClass range in selectedProperty.Ranges)
            {
                foreach (OntologyProperty subPropertyCandidate in graph.OwlProperties)
                {
                    if (subPropertyCandidate.Domains.Contains(range))
                    {
                        subProperties.Add(subPropertyCandidate);
                    }
                }
            }
            foreach (OntologyProperty subProperty in subProperties)
            {
                // TODO: use label?
                ToolStripMenuItem newItem = new ToolStripMenuItem(subProperty.ToString());
                newItem.Checked = true;
                newItem.CheckOnClick = true;
                propCtxMenuSubProperties.DropDownItems.Add(newItem);
            }
        }
    }
}
