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
            this.exportNamespaceLabel = new System.Windows.Forms.Label();
            this.exportNamespaceTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.namespacePrefixesLabel = new System.Windows.Forms.Label();
            this.addPrefixButton = new System.Windows.Forms.Button();
            this.removePrefixButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prefixColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namespaceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(472, 393);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 45);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(368, 393);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 45);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.56813F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.43187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.exportNamespaceTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.namespacePrefixesLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportNamespaceLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.removePrefixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.addPrefixButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 1);
            this.errorProvider1.SetIconPadding(this.tableLayoutPanel1, 15);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 375);
            this.tableLayoutPanel1.TabIndex = 2;
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
            // exportNamespaceTextBox
            // 
            this.exportNamespaceTextBox.Location = new System.Drawing.Point(170, 3);
            this.exportNamespaceTextBox.Name = "exportNamespaceTextBox";
            this.exportNamespaceTextBox.Size = new System.Drawing.Size(260, 26);
            this.exportNamespaceTextBox.TabIndex = 1;
            this.exportNamespaceTextBox.Text = "https://example.com/test#";
            this.exportNamespaceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.exportNamespaceTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // namespacePrefixesLabel
            // 
            this.namespacePrefixesLabel.AutoSize = true;
            this.namespacePrefixesLabel.Location = new System.Drawing.Point(3, 39);
            this.namespacePrefixesLabel.Name = "namespacePrefixesLabel";
            this.namespacePrefixesLabel.Size = new System.Drawing.Size(157, 20);
            this.namespacePrefixesLabel.TabIndex = 2;
            this.namespacePrefixesLabel.Text = "Namespace prefixes:";
            // 
            // addPrefixButton
            // 
            this.addPrefixButton.Location = new System.Drawing.Point(436, 42);
            this.addPrefixButton.Name = "addPrefixButton";
            this.addPrefixButton.Size = new System.Drawing.Size(47, 37);
            this.addPrefixButton.TabIndex = 4;
            this.addPrefixButton.Text = "+";
            this.addPrefixButton.UseVisualStyleBackColor = true;
            // 
            // removePrefixButton
            // 
            this.removePrefixButton.Location = new System.Drawing.Point(436, 203);
            this.removePrefixButton.Name = "removePrefixButton";
            this.removePrefixButton.Size = new System.Drawing.Size(47, 43);
            this.removePrefixButton.TabIndex = 5;
            this.removePrefixButton.Text = "-";
            this.removePrefixButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prefixColumnHeader,
            this.namespaceColumnHeader});
            this.listView1.Location = new System.Drawing.Point(170, 42);
            this.listView1.Name = "listView1";
            this.tableLayoutPanel1.SetRowSpan(this.listView1, 2);
            this.listView1.Size = new System.Drawing.Size(260, 330);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // prefixColumnHeader
            // 
            this.prefixColumnHeader.Text = "Prefix";
            // 
            // namespaceColumnHeader
            // 
            this.namespaceColumnHeader.Text = "Namespace";
            // 
            // ExportOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "ExportOptionsForm";
            this.Text = "RDF Export Options";
            this.Load += new System.EventHandler(this.ExportOptionsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader prefixColumnHeader;
        private System.Windows.Forms.ColumnHeader namespaceColumnHeader;
    }
}