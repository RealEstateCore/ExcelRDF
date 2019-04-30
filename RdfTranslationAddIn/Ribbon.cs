using Microsoft.Office.Tools.Ribbon;

namespace RdfTranslationAddIn
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void loadOntologyButton_Click(object sender, RibbonControlEventArgs e)
        {
            RdfOntologyOperations.instance.LoadOntology();
        }

        private void exportRdfButton_Click(object sender, RibbonControlEventArgs e)
        {
            RdfOntologyOperations.instance.ExportRDF();
        }
    }
}
