using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (Uri.TryCreate(exportNamespaceTextBox.Text, UriKind.Absolute, out Uri tempValue) == true)
            {
                errorProvider1.SetError(exportNamespaceTextBox, "");
                okButton.Enabled = true;
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(exportNamespaceTextBox, "Please enter a correctly formatted URI.");
                okButton.Enabled = false;
                e.Cancel = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.exportNamespace = new Uri(exportNamespaceTextBox.Text);

            Dictionary<string, Uri> prefixMappings = new Dictionary<string, Uri>();
            foreach (DataGridViewRow row in namespacePrefixesView.Rows)
            {
                string prefix = (string)row.Cells["prefix"].Value;
                string nspace = (string)row.Cells["nspace"].Value;
                Uri nspaceUri = new Uri(nspace);
                prefixMappings.Add(prefix, nspaceUri);
            }
            Globals.ThisAddIn.exportPrefixMappings = prefixMappings;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPrefixButton_Click(object sender, EventArgs e)
        {
            namespacePrefixesView.Rows.Add();
        }

        private void removePrefixButton_Click(object sender, EventArgs e)
        {
            if (namespacePrefixesView.SelectedRows.Count > 0 && namespacePrefixesView.SelectedRows[0].Index != namespacePrefixesView.Rows.Count - 1)
            {
                namespacePrefixesView.Rows.RemoveAt(namespacePrefixesView.SelectedRows[0].Index);
            }
        }

        private void namespacePrefixesView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = namespacePrefixesView.Columns[e.ColumnIndex].HeaderText;
            string cellText = e.FormattedValue.ToString();
            
            if (headerText.Equals("Prefix"))
            {
                // Validate prefix cell
                Regex rx = new Regex(@"[\w\d]+");
                if (rx.Match(cellText).Success == true)
                {
                    errorProvider1.SetError(namespacePrefixesView, "");
                    okButton.Enabled = true;
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(namespacePrefixesView, "Please enter a correctly formatted prefix name.");
                    okButton.Enabled = false;
                    e.Cancel = true;
                }
            }
            else if (headerText.Equals("Namespace"))
            {
                // Validate namespace cell
                if (Uri.TryCreate(cellText, UriKind.Absolute, out Uri tempValue) == true)
                {
                    errorProvider1.SetError(namespacePrefixesView, "");
                    okButton.Enabled = true;
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(namespacePrefixesView, "Please enter a correctly formatted namespace URI.");
                    okButton.Enabled = false;
                    e.Cancel = true;
                }
            }
        }
    }
}
