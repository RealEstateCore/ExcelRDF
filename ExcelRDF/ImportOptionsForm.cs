using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VDS.RDF;
using VDS.RDF.Ontology;

namespace ExcelRDF
{
    public partial class ImportOptionsForm : Form
    {
        private readonly string NAMED_INDIVIDUAL_LABEL = "Named individual";
        private readonly string NESTED_ANON_INDIVIDUAL_LABEL = "Nested anonymous individual";

        private OntologyGraph graph;
        private Dictionary<TreeNode, HashSet<OntologyProperty>> classToPropertyMap = new Dictionary<TreeNode, HashSet<OntologyProperty>>();
        private bool _noise = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graph"></param>
        public ImportOptionsForm(OntologyGraph graph)
        {
            InitializeComponent();
            this.graph = graph;
            RdfOntologyOperations.instance.resourcesToImport.Clear();
            RdfOntologyOperations.instance.nestedProperties.Clear();
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
            foreach (OntologyClass sc in c.DirectSubClasses.Where(subClass => subClass.IsNamed()))
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
                if (c.IsTopNamedClass())
                {
                    AddToTreeView(c, ontologyClassesTreeView.Nodes);
                }
            }
            ontologyClassesTreeView.EndUpdate();
            ontologyClassesTreeView.ExpandAll();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void PropCtxMenuRangeTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_noise) return;
            string selectedOption = (string)propCtxMenuRangeTypeSelector.SelectedItem;
            OntologyProperty selectedProperty = ((PropertyListItem)propertiesListBox.SelectedItem).property;
            Uri selectedPropertyUri = ((UriNode)selectedProperty.Resource).Uri;
            if (selectedOption.Equals(NESTED_ANON_INDIVIDUAL_LABEL))
            {
                propCtxMenuSubProperties.Enabled = true;
                RdfOntologyOperations.instance.nestedProperties[selectedPropertyUri.AbsoluteUri] = new HashSet<string>();
            }
            else
            {
                propCtxMenuSubProperties.Enabled = false;
                RdfOntologyOperations.instance.nestedProperties.Remove(selectedPropertyUri.AbsoluteUri);
            }
        }

        private void PropertyContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OntologyProperty selectedProperty = ((PropertyListItem)propertiesListBox.SelectedItem).property;
            Uri selectedPropertyUri = ((UriNode)selectedProperty.Resource).Uri;

            // Populate the range type selector
            propCtxMenuRangeTypeSelector.Items.Clear();
            propCtxMenuRangeTypeSelector.Items.AddRange(new String[] { NAMED_INDIVIDUAL_LABEL,
                NESTED_ANON_INDIVIDUAL_LABEL });

            _noise = true;
            if (!RdfOntologyOperations.instance.nestedProperties.ContainsKey(selectedPropertyUri.AbsoluteUri)) {
                propCtxMenuRangeTypeSelector.SelectedIndex = 0;
                propCtxMenuSubProperties.Enabled = false;
            }
            else
            {
                propCtxMenuRangeTypeSelector.SelectedIndex = 1;
                propCtxMenuSubProperties.Enabled = true;
            }
            _noise = false;

            // Load submenus in propCtxMenuSubProperties based on the selected property
            propCtxMenuSubProperties.DropDownItems.Clear();
            List<Uri> subPropertyUris = new List<Uri>();
            subPropertyUris.Add(new Uri(OntologyHelper.PropertyLabel));

            // TODO: This is horribly slow on non-trivial sized graphs; very likely needs to be changed!
            foreach (OntologyClass range in selectedProperty.Ranges)
            {
                foreach (OntologyProperty subPropertyCandidate in graph.OwlProperties)
                {
                    if (subPropertyCandidate.Domains.Contains(range))
                    {
                        Uri subPropertyCandidateUri = ((UriNode)subPropertyCandidate.Resource).Uri;
                        subPropertyUris.Add(subPropertyCandidateUri);
                    }
                }
            }
            foreach (Uri subPropertyUri in subPropertyUris)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem(subPropertyUri.ToString())
                {
                    Checked = false,
                    CheckOnClick = true,
                    Tag = subPropertyUri,
                };
                newItem.CheckedChanged += new EventHandler(this.NestedProperty_CheckedChanged);
                propCtxMenuSubProperties.DropDownItems.Add(newItem);

                if (RdfOntologyOperations.instance.nestedProperties.ContainsKey(selectedPropertyUri.AbsoluteUri)) {
                    HashSet<string> nestedProperties = RdfOntologyOperations.instance.nestedProperties[selectedPropertyUri.AbsoluteUri];
                    if (nestedProperties.Contains(subPropertyUri.AbsoluteUri))
                    {
                        newItem.Checked = true;
                    }
                    else
                    {
                        newItem.Checked = false;
                    }
                }
            }
        }

        private void NestedProperty_CheckedChanged(object sender, EventArgs e)
        {
            OntologyProperty selectedProperty = ((PropertyListItem)propertiesListBox.SelectedItem).property;
            Uri selectedPropertyUri = ((UriNode)selectedProperty.Resource).Uri;
            Uri nestedPropertyUri = (Uri)((ToolStripMenuItem)sender).Tag;
            if (((ToolStripMenuItem)sender).Checked)
            {
                RdfOntologyOperations.instance.nestedProperties[selectedPropertyUri.AbsoluteUri].Add(nestedPropertyUri.AbsoluteUri);
            }
            else
            {
                RdfOntologyOperations.instance.nestedProperties[selectedPropertyUri.AbsoluteUri].Remove(nestedPropertyUri.AbsoluteUri);
            }
        }
    }
}
