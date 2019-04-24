namespace RdfTranslationAddIn
{
    partial class ImportOptionsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ontologyClassesTreeView = new System.Windows.Forms.TreeView();
            this.propertiesListBox = new System.Windows.Forms.CheckedListBox();
            this.importedClassesLabel = new System.Windows.Forms.Label();
            this.importedPropertiesLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.outermostTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.classesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.propertiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.outermostTableLayoutPanel.SuspendLayout();
            this.classesTableLayoutPanel.SuspendLayout();
            this.propertiesTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(839, 620);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 44);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(739, 620);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 44);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ontologyClassesTreeView
            // 
            this.ontologyClassesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ontologyClassesTreeView.CheckBoxes = true;
            this.ontologyClassesTreeView.Location = new System.Drawing.Point(3, 33);
            this.ontologyClassesTreeView.Name = "ontologyClassesTreeView";
            this.ontologyClassesTreeView.Size = new System.Drawing.Size(437, 569);
            this.ontologyClassesTreeView.TabIndex = 2;
            this.ontologyClassesTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.ontologyClassesTreeView_AfterCheck);
            this.ontologyClassesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ontologyClassesTreeView_AfterSelect);
            // 
            // propertiesListBox
            // 
            this.propertiesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesListBox.FormattingEnabled = true;
            this.propertiesListBox.IntegralHeight = false;
            this.propertiesListBox.Location = new System.Drawing.Point(3, 33);
            this.propertiesListBox.Name = "propertiesListBox";
            this.propertiesListBox.ScrollAlwaysVisible = true;
            this.propertiesListBox.Size = new System.Drawing.Size(465, 566);
            this.propertiesListBox.TabIndex = 3;
            this.propertiesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.propertiesListBox_ItemCheck);
            // 
            // importedClassesLabel
            // 
            this.importedClassesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importedClassesLabel.AutoSize = true;
            this.importedClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importedClassesLabel.Location = new System.Drawing.Point(3, 0);
            this.importedClassesLabel.Name = "importedClassesLabel";
            this.importedClassesLabel.Size = new System.Drawing.Size(437, 30);
            this.importedClassesLabel.TabIndex = 4;
            this.importedClassesLabel.Text = "Imported classes:";
            this.importedClassesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // importedPropertiesLabel
            // 
            this.importedPropertiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importedPropertiesLabel.AutoSize = true;
            this.importedPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importedPropertiesLabel.Location = new System.Drawing.Point(3, 0);
            this.importedPropertiesLabel.Name = "importedPropertiesLabel";
            this.importedPropertiesLabel.Size = new System.Drawing.Size(465, 30);
            this.importedPropertiesLabel.TabIndex = 5;
            this.importedPropertiesLabel.Text = "Imported properties:";
            this.importedPropertiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outermostTableLayoutPanel.SetColumnSpan(this.splitContainer1, 3);
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.classesTableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertiesTableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(930, 611);
            this.splitContainer1.SplitterDistance = 449;
            this.splitContainer1.TabIndex = 4;
            // 
            // outermostTableLayoutPanel
            // 
            this.outermostTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outermostTableLayoutPanel.ColumnCount = 3;
            this.outermostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outermostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.outermostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.outermostTableLayoutPanel.Controls.Add(this.okButton, 2, 1);
            this.outermostTableLayoutPanel.Controls.Add(this.splitContainer1, 0, 0);
            this.outermostTableLayoutPanel.Controls.Add(this.cancelButton, 1, 1);
            this.outermostTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.outermostTableLayoutPanel.Name = "outermostTableLayoutPanel";
            this.outermostTableLayoutPanel.RowCount = 2;
            this.outermostTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outermostTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.outermostTableLayoutPanel.Size = new System.Drawing.Size(936, 667);
            this.outermostTableLayoutPanel.TabIndex = 5;
            // 
            // classesTableLayoutPanel
            // 
            this.classesTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classesTableLayoutPanel.ColumnCount = 1;
            this.classesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.classesTableLayoutPanel.Controls.Add(this.importedClassesLabel, 0, 0);
            this.classesTableLayoutPanel.Controls.Add(this.ontologyClassesTreeView, 0, 1);
            this.classesTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.classesTableLayoutPanel.Name = "classesTableLayoutPanel";
            this.classesTableLayoutPanel.RowCount = 2;
            this.classesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.classesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.classesTableLayoutPanel.Size = new System.Drawing.Size(443, 605);
            this.classesTableLayoutPanel.TabIndex = 0;
            // 
            // propertiesTableLayoutPanel
            // 
            this.propertiesTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesTableLayoutPanel.ColumnCount = 1;
            this.propertiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.propertiesTableLayoutPanel.Controls.Add(this.importedPropertiesLabel, 0, 0);
            this.propertiesTableLayoutPanel.Controls.Add(this.propertiesListBox, 0, 1);
            this.propertiesTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.propertiesTableLayoutPanel.Name = "propertiesTableLayoutPanel";
            this.propertiesTableLayoutPanel.RowCount = 2;
            this.propertiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.propertiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.propertiesTableLayoutPanel.Size = new System.Drawing.Size(471, 602);
            this.propertiesTableLayoutPanel.TabIndex = 0;
            // 
            // ImportOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 691);
            this.Controls.Add(this.outermostTableLayoutPanel);
            this.Name = "ImportOptionsForm";
            this.Text = "Ontology Import Options";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.outermostTableLayoutPanel.ResumeLayout(false);
            this.classesTableLayoutPanel.ResumeLayout(false);
            this.classesTableLayoutPanel.PerformLayout();
            this.propertiesTableLayoutPanel.ResumeLayout(false);
            this.propertiesTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TreeView ontologyClassesTreeView;
        private System.Windows.Forms.CheckedListBox propertiesListBox;
        private System.Windows.Forms.Label importedClassesLabel;
        private System.Windows.Forms.Label importedPropertiesLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel outermostTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel classesTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel propertiesTableLayoutPanel;
    }
}