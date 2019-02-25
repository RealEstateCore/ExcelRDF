using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF;

namespace RdfTranslationAddIn
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        private void loadOntologyButton_Click(object sender, RibbonControlEventArgs e)
        {
            // Displays an OpenFileDialog so the user can select an ontology.  
            OpenFileDialog openOntologyFileDialog = new OpenFileDialog();
            openOntologyFileDialog.Filter = "OWL Ontologies|*.owl";
            openOntologyFileDialog.Title = "Select an OWL ontology file";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and an OWL file was selected, open it.  
            if (openOntologyFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OntologyGraph g = new OntologyGraph();
                FileLoader.Load(g, openOntologyFileDialog.FileName);

                // Iterate through the named bottom classes; generate one worksheet for each (named from URI fragment)
                foreach (OntologyClass oClass in g.OwlClasses)
                {
                    if (oClass.IsBottomClass && oClass.Resource.NodeType == NodeType.Uri)
                    {
                        Excel.Worksheet newWorksheet = Globals.ThisAddIn.Application.Worksheets.Add();
                        UriNode classAsUriNode = (UriNode)oClass.Resource;
                        string classFragment = classAsUriNode.Uri.Fragment.TrimStart('#');
                        newWorksheet.Name = classFragment;

                        // Iterate through the properties for which this class is in the domain; 
                        // generate one column for each property (named from IRI fragment)
                        int column = 1;
                        foreach (OntologyProperty oProperty in oClass.IsDomainOf)
                        {
                            if (oProperty.Resource.NodeType == NodeType.Uri)
                            {
                                // This is because Excel uses strange adressing, i.e., "A1" instead of something 
                                // numeric and zero-indexed such as "0,0".
                                string headerColumnName = GetExcelColumnName(column);
                                string headerCellIdentifier = String.Format("{0}1", headerColumnName);
                                Excel.Range headerCellRange = newWorksheet.get_Range(headerCellIdentifier);

                                UriNode propertyAsUriNode = (UriNode)oProperty.Resource;
                                string propertyFragment = propertyAsUriNode.Uri.Fragment.TrimStart('#');
                                headerCellRange.Value = propertyFragment;
                                column++;
                            }
                        }
                    }
                }
            }
        }

        private void exportRdfButton_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
