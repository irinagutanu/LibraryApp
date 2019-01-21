namespace LibraryFinalProject.Forms
{
    partial class FrmEditBook
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
      this.Title = new DevExpress.XtraEditors.LabelControl();
      this.txtTitle = new DevExpress.XtraEditors.TextEdit();
      this.lblPublisher = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.txtYear = new DevExpress.XtraEditors.TextEdit();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.txtPublisher = new DevExpress.XtraEditors.TextEdit();
      this.gridChapters = new DevExpress.XtraGrid.GridControl();
      this.viewChapters = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.ChapterTitle = new DevExpress.XtraGrid.Columns.GridColumn();
      this.StartPage = new DevExpress.XtraGrid.Columns.GridColumn();
      this.EndPage = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Ok = new DevExpress.XtraEditors.SimpleButton();
      this.Cancel = new DevExpress.XtraEditors.SimpleButton();
      this.lookUpAuthor = new DevExpress.XtraEditors.LookUpEdit();
      this.libraryDS = new LibraryFinalProject.Model.LibraryDataSet();
      this.groupBook = new DevExpress.XtraEditors.GroupControl();
      ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPublisher.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridChapters)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewChapters)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpAuthor.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupBook)).BeginInit();
      this.groupBook.SuspendLayout();
      this.SuspendLayout();
      // 
      // Title
      // 
      this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.Title.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.Title.Location = new System.Drawing.Point(6, 5);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(55, 17);
      this.Title.TabIndex = 0;
      this.Title.Text = "Book Title";
      // 
      // txtTitle
      // 
      this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.txtTitle.Location = new System.Drawing.Point(67, 5);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtTitle.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtTitle.Properties.Appearance.Options.UseBackColor = true;
      this.txtTitle.Properties.Appearance.Options.UseForeColor = true;
      this.txtTitle.Size = new System.Drawing.Size(154, 20);
      this.txtTitle.TabIndex = 1;
      // 
      // lblPublisher
      // 
      this.lblPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblPublisher.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.lblPublisher.Location = new System.Drawing.Point(254, 5);
      this.lblPublisher.Name = "lblPublisher";
      this.lblPublisher.Size = new System.Drawing.Size(50, 17);
      this.lblPublisher.TabIndex = 2;
      this.lblPublisher.Text = "&Publisher";
      // 
      // labelControl2
      // 
      this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.labelControl2.Location = new System.Drawing.Point(6, 31);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(25, 17);
      this.labelControl2.TabIndex = 4;
      this.labelControl2.Text = "Year";
      // 
      // txtYear
      // 
      this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.txtYear.Location = new System.Drawing.Point(67, 31);
      this.txtYear.Name = "txtYear";
      this.txtYear.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtYear.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtYear.Properties.Appearance.Options.UseBackColor = true;
      this.txtYear.Properties.Appearance.Options.UseForeColor = true;
      this.txtYear.Size = new System.Drawing.Size(154, 20);
      this.txtYear.TabIndex = 5;
      // 
      // labelControl4
      // 
      this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.labelControl4.Location = new System.Drawing.Point(254, 31);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(37, 17);
      this.labelControl4.TabIndex = 6;
      this.labelControl4.Text = "Author";
      // 
      // txtPublisher
      // 
      this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPublisher.Location = new System.Drawing.Point(321, 5);
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtPublisher.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtPublisher.Properties.Appearance.Options.UseBackColor = true;
      this.txtPublisher.Properties.Appearance.Options.UseForeColor = true;
      this.txtPublisher.Size = new System.Drawing.Size(176, 20);
      this.txtPublisher.TabIndex = 3;
      // 
      // gridChapters
      // 
      this.gridChapters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridChapters.Location = new System.Drawing.Point(8, 66);
      this.gridChapters.MainView = this.viewChapters;
      this.gridChapters.Name = "gridChapters";
      this.gridChapters.Size = new System.Drawing.Size(502, 208);
      this.gridChapters.TabIndex = 1;
      this.gridChapters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewChapters});
      // 
      // viewChapters
      // 
      this.viewChapters.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ChapterTitle,
            this.StartPage,
            this.EndPage});
      this.viewChapters.GridControl = this.gridChapters;
      this.viewChapters.Name = "viewChapters";
      this.viewChapters.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      this.viewChapters.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
      this.viewChapters.OptionsDetail.EnableMasterViewMode = false;
      this.viewChapters.OptionsFind.AllowFindPanel = false;
      this.viewChapters.OptionsNavigation.AutoFocusNewRow = true;
      this.viewChapters.OptionsNavigation.EnterMoveNextColumn = true;
      this.viewChapters.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
      this.viewChapters.OptionsView.ShowGroupPanel = false;
      this.viewChapters.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.showChapterView_InitNewRow);
      // 
      // ChapterTitle
      // 
      this.ChapterTitle.Caption = "Title";
      this.ChapterTitle.FieldName = "Title";
      this.ChapterTitle.Name = "ChapterTitle";
      this.ChapterTitle.Visible = true;
      this.ChapterTitle.VisibleIndex = 0;
      // 
      // StartPage
      // 
      this.StartPage.Caption = "StartPage";
      this.StartPage.FieldName = "StartPage";
      this.StartPage.Name = "StartPage";
      this.StartPage.Visible = true;
      this.StartPage.VisibleIndex = 1;
      // 
      // EndPage
      // 
      this.EndPage.Caption = "EndPage";
      this.EndPage.FieldName = "EndPage";
      this.EndPage.Name = "EndPage";
      this.EndPage.Visible = true;
      this.EndPage.VisibleIndex = 2;
      // 
      // Ok
      // 
      this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Ok.Location = new System.Drawing.Point(354, 280);
      this.Ok.Name = "Ok";
      this.Ok.Size = new System.Drawing.Size(75, 23);
      this.Ok.TabIndex = 2;
      this.Ok.Text = "Ok";
      this.Ok.Click += new System.EventHandler(this.Ok_Click);
      // 
      // Cancel
      // 
      this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Cancel.Location = new System.Drawing.Point(435, 280);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(75, 23);
      this.Cancel.TabIndex = 3;
      this.Cancel.Text = "Cancel";
      this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
      // 
      // lookUpAuthor
      // 
      this.lookUpAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lookUpAuthor.Location = new System.Drawing.Point(321, 31);
      this.lookUpAuthor.Name = "lookUpAuthor";
      this.lookUpAuthor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpAuthor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "First Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "Last Name")});
      this.lookUpAuthor.Properties.DisplayMember = "FirstName";
      this.lookUpAuthor.Properties.NullText = "Select Author...";
      this.lookUpAuthor.Properties.ValueMember = "Id";
      this.lookUpAuthor.Size = new System.Drawing.Size(176, 20);
      this.lookUpAuthor.TabIndex = 7;
      this.lookUpAuthor.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lookUpAuthor_CustomDisplayText);
      // 
      // libraryDS
      // 
      this.libraryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // groupBook
      // 
      this.groupBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBook.Controls.Add(this.txtPublisher);
      this.groupBook.Controls.Add(this.lookUpAuthor);
      this.groupBook.Controls.Add(this.labelControl4);
      this.groupBook.Controls.Add(this.labelControl2);
      this.groupBook.Controls.Add(this.lblPublisher);
      this.groupBook.Controls.Add(this.txtTitle);
      this.groupBook.Controls.Add(this.txtYear);
      this.groupBook.Controls.Add(this.Title);
      this.groupBook.Location = new System.Drawing.Point(8, 4);
      this.groupBook.Name = "groupBook";
      this.groupBook.ShowCaption = false;
      this.groupBook.Size = new System.Drawing.Size(502, 56);
      this.groupBook.TabIndex = 0;
      // 
      // FrmEditBook
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 311);
      this.Controls.Add(this.groupBook);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.Ok);
      this.Controls.Add(this.gridChapters);
      this.Name = "FrmEditBook";
      this.Text = "Edit";
      this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmEditBook_PreviewKeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPublisher.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridChapters)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewChapters)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpAuthor.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupBook)).EndInit();
      this.groupBook.ResumeLayout(false);
      this.groupBook.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Title;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl lblPublisher;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPublisher;
        private DevExpress.XtraGrid.GridControl gridChapters;
        private DevExpress.XtraGrid.Views.Grid.GridView viewChapters;
        private DevExpress.XtraGrid.Columns.GridColumn ChapterTitle;
        private DevExpress.XtraGrid.Columns.GridColumn StartPage;
        private DevExpress.XtraGrid.Columns.GridColumn EndPage;
        private DevExpress.XtraEditors.SimpleButton Ok;
        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.LookUpEdit lookUpAuthor;
        private Model.LibraryDataSet libraryDS;
        private DevExpress.XtraEditors.GroupControl groupBook;
    }
}