using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExcelRDF
{
    public partial class ExportOptionsForm : Form
    {

        public ExportOptionsForm()
        {
            InitializeComponent();
        }

        private void ExportOptionsForm_Load(object sender, EventArgs e)
        {
            int nsIndex = 0;
            foreach (Uri uri in RdfOntologyOperations.instance.candidateNamespacesToMap)
            {
                string pName = String.Format("ns{0}", nsIndex);
                nsIndex++;
                string[] row = { pName, uri.ToString() };
                namespacePrefixesView.Rows.Add(row);
            }
        }

        private void ExportNamespaceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Uri.TryCreate(exportNamespaceTextBox.Text, UriKind.Absolute, out Uri tempValue) == true)
            {
                errorProvider1.SetError(exportNamespaceTextBox, "");
                okButton.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(exportNamespaceTextBox, "Please enter a correctly formatted URI.");
                okButton.Enabled = false;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            RdfOntologyOperations.instance.exportNamespace = new Uri(exportNamespaceTextBox.Text);

            Dictionary<string, Uri> prefixMappings = new Dictionary<string, Uri>();
            foreach (DataGridViewRow row in namespacePrefixesView.Rows)
            {
                string prefix = (string)row.Cells["prefix"].Value;
                string nspace = (string)row.Cells["nspace"].Value;
                Uri nspaceUri = new Uri(nspace);
                prefixMappings.Add(prefix, nspaceUri);
            }
            RdfOntologyOperations.instance.exportPrefixMappings = prefixMappings;

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPrefixButton_Click(object sender, EventArgs e)
        {
            namespacePrefixesView.Rows.Add();
        }

        private void RemovePrefixButton_Click(object sender, EventArgs e)
        {
            if (namespacePrefixesView.SelectedRows.Count == 1)
            {
                namespacePrefixesView.Rows.RemoveAt(namespacePrefixesView.SelectedRows[0].Index);
            }
        }

        private void NamespacePrefixesView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
                }
                else
                {
                    errorProvider1.SetError(namespacePrefixesView, "Please enter a correctly formatted prefix name.");
                    okButton.Enabled = false;
                }
            }
            else if (headerText.Equals("Namespace"))
            {
                // Validate namespace cell
                if (Uri.TryCreate(cellText, UriKind.Absolute, out Uri tempValue) == true)
                {
                    errorProvider1.SetError(namespacePrefixesView, "");
                    okButton.Enabled = true;
                }
                else
                {
                    errorProvider1.SetError(namespacePrefixesView, "Please enter a correctly formatted namespace URI.");
                    okButton.Enabled = false;
                }
            }
        }

        private void AddDataNamespaceToMappingsButton_Click(object sender, EventArgs e)
        {
            string[] row = { "", exportNamespaceTextBox.Text };
            namespacePrefixesView.Rows.Add(row);
        }
    }
}
