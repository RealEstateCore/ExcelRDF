using Microsoft.Office.Tools.Ribbon;

namespace ExcelRDF
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void LoadOntologyButton_Click(object sender, RibbonControlEventArgs e)
        {
            RdfOntologyOperations.instance.LoadOntology();
        }

        private void ExportRdfButton_Click(object sender, RibbonControlEventArgs e)
        {
            RdfOntologyOperations.instance.ExportRDF();
        }
    }
}
