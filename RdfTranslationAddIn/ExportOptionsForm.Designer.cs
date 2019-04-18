namespace RdfTranslationAddIn
{
    partial class ExportOptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exportNamespaceTextBox = new System.Windows.Forms.TextBox();
            this.namespacePrefixesLabel = new System.Windows.Forms.Label();
            this.exportNamespaceLabel = new System.Windows.Forms.Label();
            this.removePrefixButton = new System.Windows.Forms.Button();
            this.addPrefixButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.namespacePrefixesView = new System.Windows.Forms.DataGridView();
            this.prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nspace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namespacePrefixesView)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(766, 683);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 45);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(662, 683);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 45);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.20661F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.79339F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Controls.Add(this.exportNamespaceTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.namespacePrefixesLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportNamespaceLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.removePrefixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.addPrefixButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.namespacePrefixesView, 1, 1);
            this.errorProvider1.SetIconPadding(this.tableLayoutPanel1, 15);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 665);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // exportNamespaceTextBox
            // 
            this.exportNamespaceTextBox.Location = new System.Drawing.Point(186, 3);
            this.exportNamespaceTextBox.Name = "exportNamespaceTextBox";
            this.exportNamespaceTextBox.Size = new System.Drawing.Size(260, 26);
            this.exportNamespaceTextBox.TabIndex = 1;
            this.exportNamespaceTextBox.Text = "https://example.com/test#";
            this.exportNamespaceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.exportNamespaceTextBox_Validating);
            // 
            // namespacePrefixesLabel
            // 
            this.namespacePrefixesLabel.AutoSize = true;
            this.namespacePrefixesLabel.Location = new System.Drawing.Point(3, 95);
            this.namespacePrefixesLabel.Name = "namespacePrefixesLabel";
            this.namespacePrefixesLabel.Size = new System.Drawing.Size(157, 20);
            this.namespacePrefixesLabel.TabIndex = 2;
            this.namespacePrefixesLabel.Text = "Namespace prefixes:";
            // 
            // exportNamespaceLabel
            // 
            this.exportNamespaceLabel.AutoSize = true;
            this.exportNamespaceLabel.Location = new System.Drawing.Point(3, 0);
            this.exportNamespaceLabel.Name = "exportNamespaceLabel";
            this.exportNamespaceLabel.Size = new System.Drawing.Size(155, 20);
            this.exportNamespaceLabel.TabIndex = 0;
            this.exportNamespaceLabel.Text = "Exported data prefix:";
            // 
            // removePrefixButton
            // 
            this.removePrefixButton.Location = new System.Drawing.Point(729, 493);
            this.removePrefixButton.Name = "removePrefixButton";
            this.removePrefixButton.Size = new System.Drawing.Size(47, 43);
            this.removePrefixButton.TabIndex = 5;
            this.removePrefixButton.Text = "-";
            this.removePrefixButton.UseVisualStyleBackColor = true;
            this.removePrefixButton.Click += new System.EventHandler(this.removePrefixButton_Click);
            // 
            // addPrefixButton
            // 
            this.addPrefixButton.Location = new System.Drawing.Point(729, 98);
            this.addPrefixButton.Name = "addPrefixButton";
            this.addPrefixButton.Size = new System.Drawing.Size(47, 37);
            this.addPrefixButton.TabIndex = 4;
            this.addPrefixButton.Text = "+";
            this.addPrefixButton.UseVisualStyleBackColor = true;
            this.addPrefixButton.Click += new System.EventHandler(this.addPrefixButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // namespacePrefixesView
            // 
            this.namespacePrefixesView.AllowUserToAddRows = false;
            this.namespacePrefixesView.AllowUserToDeleteRows = false;
            this.namespacePrefixesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namespacePrefixesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namespacePrefixesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prefix,
            this.nspace});
            this.namespacePrefixesView.Location = new System.Drawing.Point(186, 98);
            this.namespacePrefixesView.Name = "namespacePrefixesView";
            this.namespacePrefixesView.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.namespacePrefixesView, 2);
            this.namespacePrefixesView.RowTemplate.Height = 28;
            this.namespacePrefixesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.namespacePrefixesView.Size = new System.Drawing.Size(537, 564);
            this.namespacePrefixesView.TabIndex = 6;
            this.namespacePrefixesView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.namespacePrefixesView_CellValidating);
            // 
            // prefix
            // 
            this.prefix.HeaderText = "Prefix";
            this.prefix.Name = "prefix";
            this.prefix.Width = 150;
            // 
            // nspace
            // 
            this.nspace.HeaderText = "Namespace";
            this.nspace.Name = "nspace";
            this.nspace.Width = 300;
            // 
            // ExportOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 740);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "ExportOptionsForm";
            this.Text = "RDF Export Options";
            this.Load += new System.EventHandler(this.ExportOptionsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namespacePrefixesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label exportNamespaceLabel;
        private System.Windows.Forms.TextBox exportNamespaceTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label namespacePrefixesLabel;
        private System.Windows.Forms.Button addPrefixButton;
        private System.Windows.Forms.Button removePrefixButton;
        private System.Windows.Forms.DataGridView namespacePrefixesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn nspace;
    }
}