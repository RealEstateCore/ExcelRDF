using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RdfTranslationAddIn
{
    public partial class ExportOptionsForm : Form
    {

        public ExportOptionsForm()
        {
            InitializeComponent();
        }

        private void ExportOptionsForm_Load(object sender, EventArgs e)
        {

        }

        private void exportNamespaceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Uri.TryCreate(exportNamespaceTextBox.Text, UriKind.Absolute, out Uri tempValue) == false)
            {
                errorProvider1.SetError(exportNamespaceTextBox, "Please enter a correctly formatted URI.");
                okButton.Enabled = false;
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(exportNamespaceTextBox, "");
                okButton.Enabled = true;
                e.Cancel = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // TODO: Set this on OK-click instead based on form input.
            Globals.ThisAddIn.exportNamespace = new Uri("https://test.example.com/");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
