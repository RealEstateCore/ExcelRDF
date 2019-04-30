using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using VDS.RDF;
using VDS.RDF.Ontology;

namespace RdfTranslationAddIn
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
            Globals.ThisAddIn.resourcesToImport.Clear();
            InitializeTreeView();
        }

        /// <summary>
        /// Recursively add an ontology class and its subclasses to a tree.
        /// </summary>
        /// <param name="c">Ontology class to add.</param>
        /// <param name="nodes">The collection of nodes to which this class is to be added.</param>
        private void AddToTreeView(OntologyClass c, TreeNodeCollection nodes)
        {
            string classLabel = GetLabel(c);
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

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Callback that re-renders the CheckedListBox holding properties when a node in
        /// in the left-hand TreeView is selected or checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ontologyClassesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertiesListBox.BeginUpdate();
            propertiesListBox.Items.Clear();
            foreach (OntologyProperty property in classToPropertyMap[e.Node])
            {
                // Re-check those boxes that were checked previously, i.e. keep state
                bool isChecked = Globals.ThisAddIn.resourcesToImport.Contains(property.ToString());
                propertiesListBox.Items.Add(new PropertyListItem(property), isChecked);
            }
            propertiesListBox.EndUpdate();
        }

        /// <summary>
        ///  Get a label for an ontology resource, if it exists; else get the full URI.
        /// </summary>
        /// <param name="ontologyResource"></param>
        /// <returns></returns>
        private static string GetLabel(OntologyResource ontologyResource)
        {
            string enLabel = "";
            // Iterate over all resource labels
            foreach (ILiteralNode label in ontologyResource.Label)
            {
                // If a language-agnostic label is found, return it immediately
                if (label.Language == "")
                {
                    return label.Value;
                }
                // If an english-language label is found, store it for later
                if (label.Language == "en")
                {
                    enLabel = label.Value;
                }
            }
            // Fallback option -- use the English label
            if (enLabel != "")
            {
                return enLabel;
            }
            else
            {
                // Fallback to the fallback option -- use resource IRI, either by extracting local name 
                // (if it is a URI node) or using whatever representation the resource provides
                if (ontologyResource.Resource.NodeType == NodeType.Uri)
                {
                    IUriNode uriNode = (IUriNode)ontologyResource.Resource;
                    return ThisAddIn.GetLocalName(uriNode.Uri);
                }
                else
                {
                    return ontologyResource.ToString();
                }
            }
        }

        private void ontologyClassesTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                Globals.ThisAddIn.resourcesToImport.Add(e.Node.Tag.ToString());
            }
            else
            {
                Globals.ThisAddIn.resourcesToImport.Remove(e.Node.Tag.ToString());
            }
            Debug.Print("resourcesToImport contains: " + Globals.ThisAddIn.resourcesToImport.Count);
        }

        private void propertiesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                Globals.ThisAddIn.resourcesToImport.Add(((PropertyListItem)propertiesListBox.Items[e.Index]).property.ToString());
            }
            else
            {
                Globals.ThisAddIn.resourcesToImport.Remove(((PropertyListItem)propertiesListBox.Items[e.Index]).property.ToString());
            }
            Debug.Print("resourcesToImport contains: " + Globals.ThisAddIn.resourcesToImport.Count);
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
                return GetLabel(property);
            }
        }
    }
}
