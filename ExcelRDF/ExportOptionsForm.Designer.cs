namespace ExcelRDF
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
            this.outerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exportNamespaceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.exportNamespaceTextBox = new System.Windows.Forms.TextBox();
            this.addDataNamespaceToMappingsButton = new System.Windows.Forms.Button();
            this.namespacePrefixesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.namespacePrefixesView = new System.Windows.Forms.DataGridView();
            this.prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nspace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.removePrefixButton = new System.Windows.Forms.Button();
            this.addPrefixButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.outerLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namespacePrefixesView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(834, 4);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(125, 48);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(701, 4);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 48);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // outerLayoutPanel
            // 
            this.outerLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outerLayoutPanel.AutoSize = true;
            this.outerLayoutPanel.ColumnCount = 1;
            this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerLayoutPanel.Controls.Add(this.exportNamespaceLabel, 0, 0);
            this.outerLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.outerLayoutPanel.Controls.Add(this.namespacePrefixesLabel, 0, 2);
            this.outerLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.outerLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 5);
            this.errorProvider1.SetIconPadding(this.outerLayoutPanel, 15);
            this.outerLayoutPanel.Location = new System.Drawing.Point(16, 15);
            this.outerLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.outerLayoutPanel.Name = "outerLayoutPanel";
            this.outerLayoutPanel.RowCount = 6;
            this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.outerLayoutPanel.Size = new System.Drawing.Size(969, 669);
            this.outerLayoutPanel.TabIndex = 2;
            // 
            // exportNamespaceLabel
            // 
            this.exportNamespaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportNamespaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportNamespaceLabel.Location = new System.Drawing.Point(0, 0);
            this.exportNamespaceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.exportNamespaceLabel.Name = "exportNamespaceLabel";
            this.exportNamespaceLabel.Size = new System.Drawing.Size(969, 38);
            this.exportNamespaceLabel.TabIndex = 0;
            this.exportNamespaceLabel.Text = "Exported data prefix:";
            this.exportNamespaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.exportNamespaceTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addDataNamespaceToMappingsButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(963, 66);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // exportNamespaceTextBox
            // 
            this.exportNamespaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider1.SetIconPadding(this.exportNamespaceTextBox, 15);
            this.exportNamespaceTextBox.Location = new System.Drawing.Point(0, 15);
            this.exportNamespaceTextBox.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.exportNamespaceTextBox.Name = "exportNamespaceTextBox";
            this.exportNamespaceTextBox.Size = new System.Drawing.Size(723, 31);
            this.exportNamespaceTextBox.TabIndex = 1;
            this.exportNamespaceTextBox.Text = "https://example.com/test#";
            this.exportNamespaceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ExportNamespaceTextBox_Validating);
            // 
            // addDataNamespaceToMappingsButton
            // 
            this.addDataNamespaceToMappingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDataNamespaceToMappingsButton.Location = new System.Drawing.Point(767, 4);
            this.addDataNamespaceToMappingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.addDataNamespaceToMappingsButton.Name = "addDataNamespaceToMappingsButton";
            this.addDataNamespaceToMappingsButton.Size = new System.Drawing.Size(192, 54);
            this.addDataNamespaceToMappingsButton.TabIndex = 7;
            this.addDataNamespaceToMappingsButton.Text = "Add prefix";
            this.addDataNamespaceToMappingsButton.UseVisualStyleBackColor = true;
            this.addDataNamespaceToMappingsButton.Click += new System.EventHandler(this.AddDataNamespaceToMappingsButton_Click);
            // 
            // namespacePrefixesLabel
            // 
            this.namespacePrefixesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namespacePrefixesLabel.AutoSize = true;
            this.namespacePrefixesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namespacePrefixesLabel.Location = new System.Drawing.Point(4, 110);
            this.namespacePrefixesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namespacePrefixesLabel.Name = "namespacePrefixesLabel";
            this.namespacePrefixesLabel.Size = new System.Drawing.Size(961, 38);
            this.namespacePrefixesLabel.TabIndex = 2;
            this.namespacePrefixesLabel.Text = "Namespace prefixes:";
            this.namespacePrefixesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel4.Controls.Add(this.namespacePrefixesView, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 151);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(963, 453);
            this.tableLayoutPanel4.TabIndex = 11;
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
            this.errorProvider1.SetIconAlignment(this.namespacePrefixesView, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.errorProvider1.SetIconPadding(this.namespacePrefixesView, 20);
            this.namespacePrefixesView.Location = new System.Drawing.Point(4, 4);
            this.namespacePrefixesView.Margin = new System.Windows.Forms.Padding(4);
            this.namespacePrefixesView.MultiSelect = false;
            this.namespacePrefixesView.Name = "namespacePrefixesView";
            this.namespacePrefixesView.RowHeadersVisible = false;
            this.namespacePrefixesView.RowHeadersWidth = 82;
            this.namespacePrefixesView.RowTemplate.Height = 28;
            this.namespacePrefixesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.namespacePrefixesView.Size = new System.Drawing.Size(822, 445);
            this.namespacePrefixesView.TabIndex = 6;
            this.namespacePrefixesView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.NamespacePrefixesView_CellValidating);
            // 
            // prefix
            // 
            this.prefix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prefix.FillWeight = 40F;
            this.prefix.HeaderText = "Prefix";
            this.prefix.MinimumWidth = 10;
            this.prefix.Name = "prefix";
            this.prefix.Width = 113;
            // 
            // nspace
            // 
            this.nspace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nspace.HeaderText = "Namespace";
            this.nspace.MinimumWidth = 10;
            this.nspace.Name = "nspace";
            this.nspace.Width = 174;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.removePrefixButton, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.addPrefixButton, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(833, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(127, 447);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // removePrefixButton
            // 
            this.removePrefixButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removePrefixButton.Location = new System.Drawing.Point(4, 66);
            this.removePrefixButton.Margin = new System.Windows.Forms.Padding(4);
            this.removePrefixButton.Name = "removePrefixButton";
            this.removePrefixButton.Size = new System.Drawing.Size(119, 54);
            this.removePrefixButton.TabIndex = 5;
            this.removePrefixButton.Text = "Remove";
            this.removePrefixButton.UseVisualStyleBackColor = true;
            this.removePrefixButton.Click += new System.EventHandler(this.RemovePrefixButton_Click);
            // 
            // addPrefixButton
            // 
            this.addPrefixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPrefixButton.Location = new System.Drawing.Point(4, 4);
            this.addPrefixButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPrefixButton.Name = "addPrefixButton";
            this.addPrefixButton.Size = new System.Drawing.Size(119, 54);
            this.addPrefixButton.TabIndex = 4;
            this.addPrefixButton.Text = "Add";
            this.addPrefixButton.UseVisualStyleBackColor = true;
            this.addPrefixButton.Click += new System.EventHandler(this.AddPrefixButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 610);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 56);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ExportOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.outerLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ExportOptionsForm";
            this.Text = "RDF Export Options";
            this.Load += new System.EventHandler(this.ExportOptionsForm_Load);
            this.outerLayoutPanel.ResumeLayout(false);
            this.outerLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.namespacePrefixesView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel outerLayoutPanel;
        private System.Windows.Forms.Label exportNamespaceLabel;
        private System.Windows.Forms.TextBox exportNamespaceTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label namespacePrefixesLabel;
        private System.Windows.Forms.Button addPrefixButton;
        private System.Windows.Forms.Button removePrefixButton;
        private System.Windows.Forms.DataGridView namespacePrefixesView;
        private System.Windows.Forms.Button addDataNamespaceToMappingsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn nspace;
    }
}