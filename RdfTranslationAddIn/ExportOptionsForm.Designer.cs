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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exportNamespaceTextBox = new System.Windows.Forms.TextBox();
            this.namespacePrefixesLabel = new System.Windows.Forms.Label();
            this.exportNamespaceLabel = new System.Windows.Forms.Label();
            this.removePrefixButton = new System.Windows.Forms.Button();
            this.addPrefixButton = new System.Windows.Forms.Button();
            this.addDataNamespaceToMappingsButton = new System.Windows.Forms.Button();
            this.namespacePrefixesView = new System.Windows.Forms.DataGridView();
            this.prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nspace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namespacePrefixesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(711, 626);
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
            this.cancelButton.Location = new System.Drawing.Point(607, 626);
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
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 482F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.Controls.Add(this.exportNamespaceTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.namespacePrefixesLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportNamespaceLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.removePrefixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.addPrefixButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.addDataNamespaceToMappingsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.namespacePrefixesView, 1, 1);
            this.errorProvider1.SetIconPadding(this.tableLayoutPanel1, 15);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 608);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // exportNamespaceTextBox
            // 
            this.exportNamespaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportNamespaceTextBox.Location = new System.Drawing.Point(172, 25);
            this.exportNamespaceTextBox.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.exportNamespaceTextBox.Name = "exportNamespaceTextBox";
            this.exportNamespaceTextBox.Size = new System.Drawing.Size(476, 26);
            this.exportNamespaceTextBox.TabIndex = 1;
            this.exportNamespaceTextBox.Text = "https://example.com/test#";
            this.exportNamespaceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.exportNamespaceTextBox_Validating);
            // 
            // namespacePrefixesLabel
            // 
            this.namespacePrefixesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namespacePrefixesLabel.AutoSize = true;
            this.namespacePrefixesLabel.Location = new System.Drawing.Point(3, 84);
            this.namespacePrefixesLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.namespacePrefixesLabel.Name = "namespacePrefixesLabel";
            this.namespacePrefixesLabel.Size = new System.Drawing.Size(163, 70);
            this.namespacePrefixesLabel.TabIndex = 2;
            this.namespacePrefixesLabel.Text = "Namespace prefixes:";
            this.namespacePrefixesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // exportNamespaceLabel
            // 
            this.exportNamespaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportNamespaceLabel.Location = new System.Drawing.Point(1, 27);
            this.exportNamespaceLabel.Margin = new System.Windows.Forms.Padding(1, 27, 1, 1);
            this.exportNamespaceLabel.Name = "exportNamespaceLabel";
            this.exportNamespaceLabel.Size = new System.Drawing.Size(167, 49);
            this.exportNamespaceLabel.TabIndex = 0;
            this.exportNamespaceLabel.Text = "Exported data prefix:";
            this.exportNamespaceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // removePrefixButton
            // 
            this.removePrefixButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removePrefixButton.Location = new System.Drawing.Point(654, 157);
            this.removePrefixButton.Name = "removePrefixButton";
            this.removePrefixButton.Size = new System.Drawing.Size(140, 71);
            this.removePrefixButton.TabIndex = 5;
            this.removePrefixButton.Text = "Remove prefix mapping";
            this.removePrefixButton.UseVisualStyleBackColor = true;
            this.removePrefixButton.Click += new System.EventHandler(this.removePrefixButton_Click);
            // 
            // addPrefixButton
            // 
            this.addPrefixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPrefixButton.Location = new System.Drawing.Point(654, 80);
            this.addPrefixButton.Name = "addPrefixButton";
            this.addPrefixButton.Size = new System.Drawing.Size(140, 71);
            this.addPrefixButton.TabIndex = 4;
            this.addPrefixButton.Text = "Add new prefix mapping";
            this.addPrefixButton.UseVisualStyleBackColor = true;
            this.addPrefixButton.Click += new System.EventHandler(this.addPrefixButton_Click);
            // 
            // addDataNamespaceToMappingsButton
            // 
            this.addDataNamespaceToMappingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDataNamespaceToMappingsButton.Location = new System.Drawing.Point(654, 3);
            this.addDataNamespaceToMappingsButton.Name = "addDataNamespaceToMappingsButton";
            this.addDataNamespaceToMappingsButton.Size = new System.Drawing.Size(140, 71);
            this.addDataNamespaceToMappingsButton.TabIndex = 7;
            this.addDataNamespaceToMappingsButton.Text = "Add to prefix mappings";
            this.addDataNamespaceToMappingsButton.UseVisualStyleBackColor = true;
            this.addDataNamespaceToMappingsButton.Click += new System.EventHandler(this.addDataNamespaceToMappingsButton_Click);
            // 
            // namespacePrefixesView
            // 
            this.namespacePrefixesView.AllowUserToAddRows = false;
            this.namespacePrefixesView.AllowUserToDeleteRows = false;
            this.namespacePrefixesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namespacePrefixesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.namespacePrefixesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.namespacePrefixesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namespacePrefixesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prefix,
            this.nspace});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.namespacePrefixesView.DefaultCellStyle = dataGridViewCellStyle2;
            this.namespacePrefixesView.Location = new System.Drawing.Point(172, 80);
            this.namespacePrefixesView.MultiSelect = false;
            this.namespacePrefixesView.Name = "namespacePrefixesView";
            this.namespacePrefixesView.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.namespacePrefixesView, 2);
            this.namespacePrefixesView.RowTemplate.Height = 28;
            this.namespacePrefixesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.namespacePrefixesView.Size = new System.Drawing.Size(476, 525);
            this.namespacePrefixesView.TabIndex = 6;
            this.namespacePrefixesView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.namespacePrefixesView_CellValidating);
            // 
            // prefix
            // 
            this.prefix.FillWeight = 40F;
            this.prefix.HeaderText = "Prefix";
            this.prefix.Name = "prefix";
            // 
            // nspace
            // 
            this.nspace.HeaderText = "Namespace";
            this.nspace.Name = "nspace";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ExportOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ExportOptionsForm";
            this.Text = "RDF Export Options";
            this.Load += new System.EventHandler(this.ExportOptionsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namespacePrefixesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button addDataNamespaceToMappingsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn nspace;
    }
}