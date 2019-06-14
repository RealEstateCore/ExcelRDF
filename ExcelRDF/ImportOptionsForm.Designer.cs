namespace ExcelRDF
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
            this.components = new System.ComponentModel.Container();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ontologyClassesTreeView = new System.Windows.Forms.TreeView();
            this.propertiesListBox = new System.Windows.Forms.CheckedListBox();
            this.propertyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propCtxMenuRangeTypeLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.propCtxMenuRangeTypeSelector = new System.Windows.Forms.ToolStripComboBox();
            this.propCtxMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.propCtxMenuSubProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.importedClassesLabel = new System.Windows.Forms.Label();
            this.importedPropertiesLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.classesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.propertiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outermostTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.propertyContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.classesTableLayoutPanel.SuspendLayout();
            this.propertiesTableLayoutPanel.SuspendLayout();
            this.outermostTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(837, 609);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(125, 54);
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
            this.cancelButton.Location = new System.Drawing.Point(704, 609);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 54);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ontologyClassesTreeView
            // 
            this.ontologyClassesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ontologyClassesTreeView.CheckBoxes = true;
            this.ontologyClassesTreeView.Location = new System.Drawing.Point(4, 42);
            this.ontologyClassesTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.ontologyClassesTreeView.Name = "ontologyClassesTreeView";
            this.ontologyClassesTreeView.Size = new System.Drawing.Size(446, 543);
            this.ontologyClassesTreeView.TabIndex = 2;
            this.ontologyClassesTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.OntologyClassesTreeView_AfterCheck);
            this.ontologyClassesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OntologyClassesTreeView_AfterSelect);
            // 
            // propertiesListBox
            // 
            this.propertiesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesListBox.ContextMenuStrip = this.propertyContextMenu;
            this.propertiesListBox.FormattingEnabled = true;
            this.propertiesListBox.IntegralHeight = false;
            this.propertiesListBox.Location = new System.Drawing.Point(4, 42);
            this.propertiesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.propertiesListBox.Name = "propertiesListBox";
            this.propertiesListBox.ScrollAlwaysVisible = true;
            this.propertiesListBox.Size = new System.Drawing.Size(469, 539);
            this.propertiesListBox.TabIndex = 3;
            this.propertiesListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PropertiesListBox_ItemCheck);
            // 
            // propertyContextMenu
            // 
            this.propertyContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.propertyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propCtxMenuRangeTypeLabel,
            this.propCtxMenuRangeTypeSelector,
            this.propCtxMenuSeparator,
            this.propCtxMenuSubProperties});
            this.propertyContextMenu.Name = "propertyContextMenu";
            this.propertyContextMenu.Size = new System.Drawing.Size(461, 170);
            this.propertyContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.PropertyContextMenu_Opening);
            // 
            // propCtxMenuRangeTypeLabel
            // 
            this.propCtxMenuRangeTypeLabel.Name = "propCtxMenuRangeTypeLabel";
            this.propCtxMenuRangeTypeLabel.Size = new System.Drawing.Size(460, 36);
            this.propCtxMenuRangeTypeLabel.Text = "Property range type:";
            // 
            // propCtxMenuRangeTypeSelector
            // 
            this.propCtxMenuRangeTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propCtxMenuRangeTypeSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.propCtxMenuRangeTypeSelector.Name = "propCtxMenuRangeTypeSelector";
            this.propCtxMenuRangeTypeSelector.Size = new System.Drawing.Size(400, 40);
            this.propCtxMenuRangeTypeSelector.SelectedIndexChanged += new System.EventHandler(this.PropCtxMenuRangeTypeSelector_SelectedIndexChanged);
            // 
            // propCtxMenuSeparator
            // 
            this.propCtxMenuSeparator.Name = "propCtxMenuSeparator";
            this.propCtxMenuSeparator.Size = new System.Drawing.Size(457, 6);
            // 
            // propCtxMenuSubProperties
            // 
            this.propCtxMenuSubProperties.Enabled = false;
            this.propCtxMenuSubProperties.Name = "propCtxMenuSubProperties";
            this.propCtxMenuSubProperties.Size = new System.Drawing.Size(460, 36);
            this.propCtxMenuSubProperties.Text = "Anonymous individual properties:";
            // 
            // importedClassesLabel
            // 
            this.importedClassesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importedClassesLabel.AutoSize = true;
            this.importedClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importedClassesLabel.Location = new System.Drawing.Point(4, 0);
            this.importedClassesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.importedClassesLabel.Name = "importedClassesLabel";
            this.importedClassesLabel.Size = new System.Drawing.Size(446, 38);
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
            this.importedPropertiesLabel.Location = new System.Drawing.Point(4, 0);
            this.importedPropertiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.importedPropertiesLabel.Name = "importedPropertiesLabel";
            this.importedPropertiesLabel.Size = new System.Drawing.Size(469, 38);
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
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.classesTableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertiesTableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(958, 597);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
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
            this.classesTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.classesTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.classesTableLayoutPanel.Name = "classesTableLayoutPanel";
            this.classesTableLayoutPanel.RowCount = 2;
            this.classesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.classesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.classesTableLayoutPanel.Size = new System.Drawing.Size(454, 589);
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
            this.propertiesTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.propertiesTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.propertiesTableLayoutPanel.Name = "propertiesTableLayoutPanel";
            this.propertiesTableLayoutPanel.RowCount = 2;
            this.propertiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.propertiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.propertiesTableLayoutPanel.Size = new System.Drawing.Size(477, 585);
            this.propertiesTableLayoutPanel.TabIndex = 0;
            // 
            // outermostTableLayoutPanel
            // 
            this.outermostTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outermostTableLayoutPanel.ColumnCount = 3;
            this.outermostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outermostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.outermostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.outermostTableLayoutPanel.Controls.Add(this.okButton, 2, 1);
            this.outermostTableLayoutPanel.Controls.Add(this.splitContainer1, 0, 0);
            this.outermostTableLayoutPanel.Controls.Add(this.cancelButton, 1, 1);
            this.outermostTableLayoutPanel.Location = new System.Drawing.Point(16, 15);
            this.outermostTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.outermostTableLayoutPanel.Name = "outermostTableLayoutPanel";
            this.outermostTableLayoutPanel.RowCount = 2;
            this.outermostTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outermostTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.outermostTableLayoutPanel.Size = new System.Drawing.Size(966, 667);
            this.outermostTableLayoutPanel.TabIndex = 5;
            // 
            // ImportOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.outermostTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportOptionsForm";
            this.Text = "Ontology Import Options";
            this.propertyContextMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.classesTableLayoutPanel.ResumeLayout(false);
            this.classesTableLayoutPanel.PerformLayout();
            this.propertiesTableLayoutPanel.ResumeLayout(false);
            this.propertiesTableLayoutPanel.PerformLayout();
            this.outermostTableLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip propertyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem propCtxMenuRangeTypeLabel;
        private System.Windows.Forms.ToolStripComboBox propCtxMenuRangeTypeSelector;
        private System.Windows.Forms.ToolStripMenuItem propCtxMenuSubProperties;
        private System.Windows.Forms.ToolStripSeparator propCtxMenuSeparator;
    }
}