namespace RdfTranslationAddIn
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.RdfTranslationGroup = this.Factory.CreateRibbonGroup();
            this.loadOntologyButton = this.Factory.CreateRibbonButton();
            this.exportRdfButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.RdfTranslationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabData";
            this.tab1.Groups.Add(this.RdfTranslationGroup);
            this.tab1.Label = "TabData";
            this.tab1.Name = "tab1";
            // 
            // RdfTranslationGroup
            // 
            this.RdfTranslationGroup.Items.Add(this.loadOntologyButton);
            this.RdfTranslationGroup.Items.Add(this.exportRdfButton);
            this.RdfTranslationGroup.Label = "RDF Translation";
            this.RdfTranslationGroup.Name = "RdfTranslationGroup";
            this.RdfTranslationGroup.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupGetExternalData");
            // 
            // loadOntologyButton
            // 
            this.loadOntologyButton.Label = "Load Ontology";
            this.loadOntologyButton.Name = "loadOntologyButton";
            this.loadOntologyButton.ShowImage = true;
            this.loadOntologyButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.loadOntologyButton_Click);
            // 
            // exportRdfButton
            // 
            this.exportRdfButton.Label = "Export RDF";
            this.exportRdfButton.Name = "exportRdfButton";
            this.exportRdfButton.ShowImage = true;
            this.exportRdfButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.exportRdfButton_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.RdfTranslationGroup.ResumeLayout(false);
            this.RdfTranslationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup RdfTranslationGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton loadOntologyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton exportRdfButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
