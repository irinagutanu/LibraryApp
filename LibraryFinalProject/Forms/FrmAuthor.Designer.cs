namespace LibraryFinalProject.Forms
{
    partial class FrmAuthor
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
      this.gridAuthor = new DevExpress.XtraGrid.GridControl();
      this.viewAuthor = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.BirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Picture = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
      this.repImgEdit = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
      this.libraryDS = new LibraryFinalProject.Model.LibraryDataSet();
      this.OK = new DevExpress.XtraEditors.SimpleButton();
      this.Cancel = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewAuthor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repPictureEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repImgEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDS)).BeginInit();
      this.SuspendLayout();
      // 
      // gridAuthor
      // 
      this.gridAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridAuthor.Location = new System.Drawing.Point(8, 4);
      this.gridAuthor.MainView = this.viewAuthor;
      this.gridAuthor.Name = "gridAuthor";
      this.gridAuthor.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repImgEdit,
            this.repPictureEdit});
      this.gridAuthor.Size = new System.Drawing.Size(504, 277);
      this.gridAuthor.TabIndex = 0;
      this.gridAuthor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewAuthor});
      this.gridAuthor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gridAuthor_PreviewKeyDown);
      // 
      // viewAuthor
      // 
      this.viewAuthor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.Picture});
      this.viewAuthor.GridControl = this.gridAuthor;
      this.viewAuthor.Name = "viewAuthor";
      this.viewAuthor.NewItemRowText = "Add...";
      this.viewAuthor.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      this.viewAuthor.OptionsDetail.EnableMasterViewMode = false;
      this.viewAuthor.OptionsFind.AllowFindPanel = false;
      this.viewAuthor.OptionsNavigation.AutoFocusNewRow = true;
      this.viewAuthor.OptionsNavigation.EnterMoveNextColumn = true;
      this.viewAuthor.OptionsView.ColumnAutoWidth = false;
      this.viewAuthor.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
      this.viewAuthor.OptionsView.ShowGroupPanel = false;
      // 
      // FirstName
      // 
      this.FirstName.Caption = "First Name";
      this.FirstName.FieldName = "FirstName";
      this.FirstName.Name = "FirstName";
      this.FirstName.Visible = true;
      this.FirstName.VisibleIndex = 0;
      this.FirstName.Width = 107;
      // 
      // LastName
      // 
      this.LastName.Caption = "Last Name";
      this.LastName.FieldName = "LastName";
      this.LastName.Name = "LastName";
      this.LastName.Visible = true;
      this.LastName.VisibleIndex = 1;
      this.LastName.Width = 105;
      // 
      // BirthDate
      // 
      this.BirthDate.Caption = "Birth Date";
      this.BirthDate.FieldName = "BirthDate";
      this.BirthDate.Name = "BirthDate";
      this.BirthDate.Visible = true;
      this.BirthDate.VisibleIndex = 2;
      this.BirthDate.Width = 124;
      // 
      // Picture
      // 
      this.Picture.Caption = "Picture";
      this.Picture.ColumnEdit = this.repPictureEdit;
      this.Picture.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.Picture.FieldName = "Picture";
      this.Picture.Name = "Picture";
      this.Picture.Visible = true;
      this.Picture.VisibleIndex = 3;
      this.Picture.Width = 158;
      // 
      // repPictureEdit
      // 
      this.repPictureEdit.Name = "repPictureEdit";
      this.repPictureEdit.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
      this.repPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
      // 
      // repImgEdit
      // 
      this.repImgEdit.AutoHeight = false;
      this.repImgEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph),
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.repImgEdit.Name = "repImgEdit";
      this.repImgEdit.ReadOnly = true;
      // 
      // libraryDS
      // 
      this.libraryDS.DataSetName = "Library";
      this.libraryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // OK
      // 
      this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OK.Location = new System.Drawing.Point(356, 287);
      this.OK.Name = "OK";
      this.OK.Size = new System.Drawing.Size(75, 23);
      this.OK.TabIndex = 1;
      this.OK.Text = "OK";
      this.OK.Click += new System.EventHandler(this.OK_Click);
      // 
      // Cancel
      // 
      this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Cancel.Location = new System.Drawing.Point(437, 287);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(75, 23);
      this.Cancel.TabIndex = 2;
      this.Cancel.Text = "Cancel";
      this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
      // 
      // FrmAuthor
      // 
      this.AcceptButton = this.OK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.Cancel;
      this.ClientSize = new System.Drawing.Size(519, 318);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.OK);
      this.Controls.Add(this.gridAuthor);
      this.MaximizeBox = false;
      this.Name = "FrmAuthor";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Authors";
      ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewAuthor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repPictureEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repImgEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.libraryDS)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAuthor;
        private DevExpress.XtraGrid.Views.Grid.GridView viewAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn BirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn Picture;
        private Model.LibraryDataSet libraryDS;
        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.SimpleButton OK;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repImgEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repPictureEdit;
    }
}