using System;
using System.Collections.Generic;
using System.Linq;
using InteropExcel = Microsoft.Office.Interop.Excel;
using VDS.RDF.Ontology;
using Microsoft.Office.Interop.Excel;
using VDS.RDF;
using System.Windows.Forms;
using VDS.RDF.Parsing;
using System.IO;

namespace RdfTranslationAddIn
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
