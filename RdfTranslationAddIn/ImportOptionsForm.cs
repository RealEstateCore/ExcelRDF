using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDS.RDF;
using VDS.RDF.Ontology;

namespace RdfTranslationAddIn
{
    public partial class ImportOptionsForm : Form
    {
        private OntologyGraph graph;
        private Dictionary<TreeNode, HashSet<OntologyProperty>> classToPropertyMap = new Dictionary<TreeNode, HashSet<OntologyProperty>>();

        public ImportOptionsForm(OntologyGraph graph)
        {
            InitializeComponent();
            this.graph = graph;
            Globals.ThisAddIn.resourcesToImport.Clear();
            InitializeTreeView();
        }

        private void AddToTreeView(OntologyClass c, TreeNodeCollection nodes)
        {
            string classLabel = GetLabel(c, "en");
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

        private void ontologyClassesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertiesListBox.BeginUpdate();
            propertiesListBox.Items.Clear();
            foreach (OntologyProperty property in classToPropertyMap[e.Node])
            {
                // Re-check those boxes that were checked previously, i.e. keep state
                bool isChecked = Globals.ThisAddIn.resourcesToImport.Contains(property.ToString());
                propertiesListBox.Items.Add(property, isChecked);
            }
            propertiesListBox.EndUpdate();
        }

        private static string GetLabel(OntologyResource ontologyResource, string language)
        {
            foreach (ILiteralNode label in ontologyResource.Label)
            {
                if (label.Language == language)
                {
                    return label.Value;
                }
            }
            return ontologyResource.Resource.ToString();
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
                Globals.ThisAddIn.resourcesToImport.Add(((OntologyResource)propertiesListBox.Items[e.Index]).ToString());
            }
            else
            {
                Globals.ThisAddIn.resourcesToImport.Remove(((OntologyResource)propertiesListBox.Items[e.Index]).ToString());
            }
            Debug.Print("resourcesToImport contains: " + Globals.ThisAddIn.resourcesToImport.Count);
        }
    }
}
