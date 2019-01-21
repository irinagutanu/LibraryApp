namespace LibraryFinalProject
{
    partial class FrmMain
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
      DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
      this.viewChapters = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTitle1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colStartPage = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colEndPage = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIdBook = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridBooks = new DevExpress.XtraGrid.GridControl();
      this.libraryDS = new LibraryFinalProject.Model.LibraryDataSet();
      this.viewBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPublisher = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colIdAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
      this.barManager1 = new DevExpress.XtraBars.BarManager();
      this.bar = new DevExpress.XtraBars.Bar();
      this.bbFile = new DevExpress.XtraBars.BarSubItem();
      this.bbSave = new DevExpress.XtraBars.BarButtonItem();
      this.bbLoad = new DevExpress.XtraBars.BarButtonItem();
      this.bbExit = new DevExpress.XtraBars.BarButtonItem();
      this.bbEdit = new DevExpress.XtraBars.BarSubItem();
      this.bbAuthor = new DevExpress.XtraBars.BarButtonItem();
      this.bbAddBook = new DevExpress.XtraBars.BarButtonItem();
      this.bbEditBook = new DevExpress.XtraBars.BarButtonItem();
      this.bbDeleteBook = new DevExpress.XtraBars.BarButtonItem();
      this.bbShowBook = new DevExpress.XtraBars.BarButtonItem();
      this.bbReport = new DevExpress.XtraBars.BarSubItem();
      this.bbLastBooks = new DevExpress.XtraBars.BarButtonItem();
      this.bbAuthorResume = new DevExpress.XtraBars.BarButtonItem();
      this.bbBookTimeline = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.viewChapters)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewBooks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // viewChapters
      // 
      this.viewChapters.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colTitle1,
            this.colStartPage,
            this.colEndPage,
            this.colIdBook});
      this.viewChapters.GridControl = this.gridBooks;
      this.viewChapters.Name = "viewChapters";
      this.viewChapters.OptionsBehavior.Editable = false;
      this.viewChapters.OptionsView.ShowGroupPanel = false;
      // 
      // colId1
      // 
      this.colId1.FieldName = "Id";
      this.colId1.Name = "colId1";
      // 
      // colTitle1
      // 
      this.colTitle1.FieldName = "Title";
      this.colTitle1.Name = "colTitle1";
      this.colTitle1.Visible = true;
      this.colTitle1.VisibleIndex = 0;
      // 
      // colStartPage
      // 
      this.colStartPage.FieldName = "StartPage";
      this.colStartPage.Name = "colStartPage";
      this.colStartPage.Visible = true;
      this.colStartPage.VisibleIndex = 1;
      // 
      // colEndPage
      // 
      this.colEndPage.FieldName = "EndPage";
      this.colEndPage.Name = "colEndPage";
      this.colEndPage.Visible = true;
      this.colEndPage.VisibleIndex = 2;
      // 
      // colIdBook
      // 
      this.colIdBook.FieldName = "IdBook";
      this.colIdBook.Name = "colIdBook";
      // 
      // gridBooks
      // 
      this.gridBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridBooks.DataMember = "Book";
      this.gridBooks.DataSource = this.libraryDS;
      gridLevelNode2.LevelTemplate = this.viewChapters;
      gridLevelNode2.RelationName = "Fk_Book_Chapter";
      this.gridBooks.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
      this.gridBooks.Location = new System.Drawing.Point(12, 28);
      this.gridBooks.MainView = this.viewBooks;
      this.gridBooks.MenuManager = this.barManager1;
      this.gridBooks.Name = "gridBooks";
      this.gridBooks.Size = new System.Drawing.Size(624, 341);
      this.gridBooks.TabIndex = 0;
      this.gridBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewBooks,
            this.viewChapters});
      this.gridBooks.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gridBooks_PreviewKeyDown);
      // 
      // libraryDS
      // 
      this.libraryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // viewBooks
      // 
      this.viewBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTitle,
            this.colAuthor,
            this.colYear,
            this.colPublisher,
            this.colIdAuthor});
      this.viewBooks.GridControl = this.gridBooks;
      this.viewBooks.Name = "viewBooks";
      this.viewBooks.OptionsBehavior.Editable = false;
      this.viewBooks.OptionsDetail.ShowDetailTabs = false;
      this.viewBooks.OptionsView.ColumnAutoWidth = false;
      this.viewBooks.OptionsView.ShowGroupPanel = false;
      this.viewBooks.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.mainViewBooks_CustomUnboundColumnData);
      // 
      // colId
      // 
      this.colId.FieldName = "Id";
      this.colId.Name = "colId";
      // 
      // colTitle
      // 
      this.colTitle.FieldName = "Title";
      this.colTitle.Name = "colTitle";
      this.colTitle.OptionsColumn.FixedWidth = true;
      this.colTitle.Visible = true;
      this.colTitle.VisibleIndex = 0;
      this.colTitle.Width = 134;
      // 
      // colAuthor
      // 
      this.colAuthor.Caption = "Author";
      this.colAuthor.FieldName = "colAuthor";
      this.colAuthor.Name = "colAuthor";
      this.colAuthor.UnboundType = DevExpress.Data.UnboundColumnType.String;
      this.colAuthor.Visible = true;
      this.colAuthor.VisibleIndex = 1;
      this.colAuthor.Width = 164;
      // 
      // colYear
      // 
      this.colYear.FieldName = "Year";
      this.colYear.Name = "colYear";
      this.colYear.Visible = true;
      this.colYear.VisibleIndex = 3;
      this.colYear.Width = 154;
      // 
      // colPublisher
      // 
      this.colPublisher.FieldName = "Publisher";
      this.colPublisher.Name = "colPublisher";
      this.colPublisher.Visible = true;
      this.colPublisher.VisibleIndex = 2;
      this.colPublisher.Width = 153;
      // 
      // colIdAuthor
      // 
      this.colIdAuthor.FieldName = "IdAuthor";
      this.colIdAuthor.Name = "colIdAuthor";
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.bbFile,
            this.bbSave,
            this.bbLoad,
            this.bbEdit,
            this.bbExit,
            this.bbAuthor,
            this.bbAddBook,
            this.bbEditBook,
            this.bbDeleteBook,
            this.bbShowBook,
            this.barButtonItem1,
            this.bbReport,
            this.bbLastBooks,
            this.bbAuthorResume,
            this.bbBookTimeline});
      this.barManager1.MainMenu = this.bar;
      this.barManager1.MaxItemId = 16;
      // 
      // bar
      // 
      this.bar.BarName = "Main menu";
      this.bar.DockCol = 0;
      this.bar.DockRow = 0;
      this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbReport)});
      this.bar.OptionsBar.MultiLine = true;
      this.bar.OptionsBar.UseWholeRow = true;
      this.bar.Text = "Main menu";
      // 
      // bbFile
      // 
      this.bbFile.Caption = "&File";
      this.bbFile.Id = 1;
      this.bbFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbExit)});
      this.bbFile.Name = "bbFile";
      // 
      // bbSave
      // 
      this.bbSave.Caption = "Save";
      this.bbSave.Id = 2;
      this.bbSave.Name = "bbSave";
      this.bbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbSave_ItemClick);
      // 
      // bbLoad
      // 
      this.bbLoad.Caption = "Load";
      this.bbLoad.Id = 3;
      this.bbLoad.Name = "bbLoad";
      this.bbLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbLoad_ItemClick);
      // 
      // bbExit
      // 
      this.bbExit.Caption = "Exit";
      this.bbExit.Id = 5;
      this.bbExit.Name = "bbExit";
      this.bbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbExit_ItemClick);
      // 
      // bbEdit
      // 
      this.bbEdit.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.bbEdit.Appearance.Options.UseBorderColor = true;
      this.bbEdit.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
      this.bbEdit.Caption = "&Edit";
      this.bbEdit.Id = 4;
      this.bbEdit.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbAuthor, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbAddBook, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbEditBook),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbDeleteBook),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbShowBook)});
      this.bbEdit.Name = "bbEdit";
      // 
      // bbAuthor
      // 
      this.bbAuthor.Appearance.Options.UseBorderColor = true;
      this.bbAuthor.Caption = "Author";
      this.bbAuthor.Id = 6;
      this.bbAuthor.Name = "bbAuthor";
      this.bbAuthor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAddAuthor_ItemClick);
      // 
      // bbAddBook
      // 
      this.bbAddBook.Caption = "Add Book";
      this.bbAddBook.Id = 7;
      this.bbAddBook.Name = "bbAddBook";
      this.bbAddBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAddBook_ItemClick);
      // 
      // bbEditBook
      // 
      this.bbEditBook.Caption = "Edit Book";
      this.bbEditBook.Id = 8;
      this.bbEditBook.Name = "bbEditBook";
      this.bbEditBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbEditBook_ItemClick);
      // 
      // bbDeleteBook
      // 
      this.bbDeleteBook.Caption = "Delete Book";
      this.bbDeleteBook.Id = 9;
      this.bbDeleteBook.Name = "bbDeleteBook";
      this.bbDeleteBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbDeleteBooks_ItemClick);
      // 
      // bbShowBook
      // 
      this.bbShowBook.Caption = "Show Book";
      this.bbShowBook.Id = 10;
      this.bbShowBook.Name = "bbShowBook";
      this.bbShowBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbShowBook_ItemClick);
      // 
      // bbReport
      // 
      this.bbReport.Caption = "Report";
      this.bbReport.Id = 12;
      this.bbReport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbLastBooks),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbAuthorResume),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbBookTimeline)});
      this.bbReport.Name = "bbReport";
      // 
      // bbLastBooks
      // 
      this.bbLastBooks.Caption = "Last Books";
      this.bbLastBooks.Id = 13;
      this.bbLastBooks.Name = "bbLastBooks";
      this.bbLastBooks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbLastBooks_ItemClick);
      // 
      // bbAuthorResume
      // 
      this.bbAuthorResume.Caption = "Author Resume";
      this.bbAuthorResume.Id = 14;
      this.bbAuthorResume.Name = "bbAuthorResume";
      this.bbAuthorResume.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAuthorResume_ItemClick);
      // 
      // bbBookTimeline
      // 
      this.bbBookTimeline.Caption = "Book Timeline";
      this.bbBookTimeline.Id = 15;
      this.bbBookTimeline.Name = "bbBookTimeline";
      this.bbBookTimeline.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbBookTimeline_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Size = new System.Drawing.Size(648, 23);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 381);
      this.barDockControlBottom.Size = new System.Drawing.Size(648, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 23);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 358);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(648, 23);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 358);
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "fILE";
      this.barSubItem1.Id = 0;
      this.barSubItem1.Name = "barSubItem1";
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "barButtonItem1";
      this.barButtonItem1.Id = 11;
      this.barButtonItem1.Name = "barButtonItem1";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(648, 381);
      this.Controls.Add(this.gridBooks);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "FrmMain";
      this.Text = "Library App";
      ((System.ComponentModel.ISupportInitialize)(this.viewChapters)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewBooks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarSubItem bbFile;
        private DevExpress.XtraBars.BarButtonItem bbSave;
        private DevExpress.XtraBars.BarButtonItem bbLoad;
        private DevExpress.XtraBars.BarSubItem bbEdit;
        private DevExpress.XtraBars.BarButtonItem bbAuthor;
        private DevExpress.XtraBars.BarButtonItem bbAddBook;
        private DevExpress.XtraBars.BarButtonItem bbEditBook;
        private DevExpress.XtraBars.BarButtonItem bbDeleteBook;
        private DevExpress.XtraBars.BarButtonItem bbExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private Model.LibraryDataSet libraryDS;
        private DevExpress.XtraBars.BarButtonItem bbShowBook;
        private DevExpress.XtraGrid.GridControl gridBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView viewChapters;
        private DevExpress.XtraGrid.Views.Grid.GridView viewBooks;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle1;
        private DevExpress.XtraGrid.Columns.GridColumn colStartPage;
        private DevExpress.XtraGrid.Columns.GridColumn colEndPage;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBook;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colPublisher;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
        private DevExpress.XtraBars.BarSubItem bbReport;
        private DevExpress.XtraBars.BarButtonItem bbLastBooks;
        private DevExpress.XtraBars.BarButtonItem bbAuthorResume;
        private DevExpress.XtraBars.BarButtonItem bbBookTimeline;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

