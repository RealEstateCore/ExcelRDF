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
            Globals.ThisAddIn.LoadOntology();
        }

        private void exportRdfButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ExportRDF();
        }
    }
}
