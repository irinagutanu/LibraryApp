namespace LibraryFinalProject.Forms
{
    partial class FrmAddBook
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
      this.Ok = new DevExpress.XtraEditors.SimpleButton();
      this.Cancel = new DevExpress.XtraEditors.SimpleButton();
      this.Title = new DevExpress.XtraEditors.LabelControl();
      this.txtTitle = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.txtYear = new DevExpress.XtraEditors.TextEdit();
      this.txtPublisher = new DevExpress.XtraEditors.TextEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.lookUpAuthor = new DevExpress.XtraEditors.LookUpEdit();
      this.authorBindingSource = new System.Windows.Forms.BindingSource();
      this.libraryDataSet = new LibraryFinalProject.Model.LibraryDataSet();
      this.authorBindingSource1 = new System.Windows.Forms.BindingSource();
      this.gridChapter = new DevExpress.XtraGrid.GridControl();
      this.viewChapter = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPublisher.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpAuthor.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridChapter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewChapter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Ok
      // 
      this.Ok.Location = new System.Drawing.Point(430, 344);
      this.Ok.Name = "Ok";
      this.Ok.Size = new System.Drawing.Size(75, 23);
      this.Ok.TabIndex = 7;
      this.Ok.Text = "Ok";
      this.Ok.Click += new System.EventHandler(this.Ok_Click_1);
      // 
      // Cancel
      // 
      this.Cancel.Location = new System.Drawing.Point(517, 344);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(75, 23);
      this.Cancel.TabIndex = 8;
      this.Cancel.Text = "Cancel";
      this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
      // 
      // Title
      // 
      this.Title.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.Title.Location = new System.Drawing.Point(5, 5);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(55, 17);
      this.Title.TabIndex = 0;
      this.Title.Text = "&Book Title";
      // 
      // txtTitle
      // 
      this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.txtTitle.Location = new System.Drawing.Point(77, 5);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtTitle.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtTitle.Properties.Appearance.Options.UseBackColor = true;
      this.txtTitle.Properties.Appearance.Options.UseForeColor = true;
      this.txtTitle.Size = new System.Drawing.Size(154, 20);
      this.txtTitle.TabIndex = 1;
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.labelControl1.Location = new System.Drawing.Point(5, 34);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(25, 17);
      this.labelControl1.TabIndex = 4;
      this.labelControl1.Text = "&Year";
      // 
      // txtYear
      // 
      this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.txtYear.Location = new System.Drawing.Point(77, 31);
      this.txtYear.Name = "txtYear";
      this.txtYear.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtYear.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtYear.Properties.Appearance.Options.UseBackColor = true;
      this.txtYear.Properties.Appearance.Options.UseForeColor = true;
      this.txtYear.Size = new System.Drawing.Size(154, 20);
      this.txtYear.TabIndex = 5;
      // 
      // txtPublisher
      // 
      this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPublisher.Location = new System.Drawing.Point(336, 5);
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtPublisher.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtPublisher.Properties.Appearance.Options.UseBackColor = true;
      this.txtPublisher.Properties.Appearance.Options.UseForeColor = true;
      this.txtPublisher.Size = new System.Drawing.Size(154, 20);
      this.txtPublisher.TabIndex = 3;
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.labelControl2.Location = new System.Drawing.Point(266, 5);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(50, 17);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "&Publisher";
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.labelControl3.Location = new System.Drawing.Point(266, 34);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(37, 17);
      this.labelControl3.TabIndex = 6;
      this.labelControl3.Text = "&Author";
      // 
      // lookUpAuthor
      // 
      this.lookUpAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lookUpAuthor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.authorBindingSource, "FirstName", true));
      this.lookUpAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.authorBindingSource, "FirstName", true));
      this.lookUpAuthor.Location = new System.Drawing.Point(336, 31);
      this.lookUpAuthor.Name = "lookUpAuthor";
      this.lookUpAuthor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpAuthor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "First Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "Last Name")});
      this.lookUpAuthor.Properties.DisplayMember = "FirstName";
      this.lookUpAuthor.Properties.NullText = "Select Author...";
      this.lookUpAuthor.Properties.ValueMember = "Id";
      this.lookUpAuthor.Size = new System.Drawing.Size(154, 20);
      this.lookUpAuthor.TabIndex = 7;
      this.lookUpAuthor.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lookUpAuthor_CustomDisplayText);
      // 
      // authorBindingSource
      // 
      this.authorBindingSource.DataMember = "Author";
      this.authorBindingSource.DataSource = this.libraryDataSet;
      // 
      // libraryDataSet
      // 
      this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // authorBindingSource1
      // 
      this.authorBindingSource1.DataMember = "Author";
      this.authorBindingSource1.DataSource = this.libraryDataSet;
      // 
      // gridChapter
      // 
      this.gridChapter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridChapter.Location = new System.Drawing.Point(8, 66);
      this.gridChapter.MainView = this.viewChapter;
      this.gridChapter.Name = "gridChapter";
      this.gridChapter.Size = new System.Drawing.Size(505, 208);
      this.gridChapter.TabIndex = 1;
      this.gridChapter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewChapter});
      // 
      // viewChapter
      // 
      this.viewChapter.AppearancePrint.Row.BackColor = System.Drawing.Color.Transparent;
      this.viewChapter.AppearancePrint.Row.Options.UseBackColor = true;
      this.viewChapter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
      this.viewChapter.GridControl = this.gridChapter;
      this.viewChapter.Name = "viewChapter";
      this.viewChapter.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      this.viewChapter.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
      this.viewChapter.OptionsDetail.EnableMasterViewMode = false;
      this.viewChapter.OptionsFind.AllowFindPanel = false;
      this.viewChapter.OptionsLayout.Columns.StoreAllOptions = true;
      this.viewChapter.OptionsLayout.Columns.StoreAppearance = true;
      this.viewChapter.OptionsNavigation.AutoFocusNewRow = true;
      this.viewChapter.OptionsNavigation.EnterMoveNextColumn = true;
      this.viewChapter.OptionsSelection.MultiSelect = true;
      this.viewChapter.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
      this.viewChapter.OptionsView.ShowGroupPanel = false;
      // 
      // gridColumn1
      // 
      this.gridColumn1.Caption = "Title";
      this.gridColumn1.FieldName = "Title";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      // 
      // gridColumn2
      // 
      this.gridColumn2.Caption = "StartPage";
      this.gridColumn2.FieldName = "StartPage";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 1;
      // 
      // gridColumn3
      // 
      this.gridColumn3.Caption = "EndPage";
      this.gridColumn3.FieldName = "EndPage";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 2;
      // 
      // groupControl1
      // 
      this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupControl1.Controls.Add(this.lookUpAuthor);
      this.groupControl1.Controls.Add(this.labelControl3);
      this.groupControl1.Controls.Add(this.labelControl2);
      this.groupControl1.Controls.Add(this.txtPublisher);
      this.groupControl1.Controls.Add(this.Title);
      this.groupControl1.Controls.Add(this.txtYear);
      this.groupControl1.Controls.Add(this.labelControl1);
      this.groupControl1.Controls.Add(this.txtTitle);
      this.groupControl1.Location = new System.Drawing.Point(8, 4);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.ShowCaption = false;
      this.groupControl1.Size = new System.Drawing.Size(505, 56);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "groupControl1";
      // 
      // simpleButton1
      // 
      this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.simpleButton1.Location = new System.Drawing.Point(354, 280);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(75, 23);
      this.simpleButton1.TabIndex = 2;
      this.simpleButton1.Text = "&OK";
      this.simpleButton1.Click += new System.EventHandler(this.Ok_Click_1);
      // 
      // simpleButton2
      // 
      this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.simpleButton2.Location = new System.Drawing.Point(435, 280);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new System.Drawing.Size(75, 23);
      this.simpleButton2.TabIndex = 3;
      this.simpleButton2.Text = "&Cancel";
      this.simpleButton2.Click += new System.EventHandler(this.Cancel_Click);
      // 
      // FrmAddBook
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(519, 318);
      this.Controls.Add(this.simpleButton2);
      this.Controls.Add(this.simpleButton1);
      this.Controls.Add(this.groupControl1);
      this.Controls.Add(this.gridChapter);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.Ok);
      this.Name = "FrmAddBook";
      this.Text = "Add ";
      this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmAddBook_PreviewKeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPublisher.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpAuthor.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridChapter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewChapter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Ok;
        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.LabelControl Title;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.TextEdit txtPublisher;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpAuthor;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private Model.LibraryDataSet libraryDataSet;
        private DevExpress.XtraGrid.GridControl gridChapter;
        private DevExpress.XtraGrid.Views.Grid.GridView viewChapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingSource authorBindingSource1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;


    }
}