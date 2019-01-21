namespace LibraryFinalProject.Forms
{
    partial class FrmShowBook
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
      this.txtYear = new DevExpress.XtraEditors.TextEdit();
      this.txtTitle = new DevExpress.XtraEditors.TextEdit();
      this.gridShowChapter = new DevExpress.XtraGrid.GridControl();
      this.showChapterView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.ChapterTitle = new DevExpress.XtraGrid.Columns.GridColumn();
      this.StartPage = new DevExpress.XtraGrid.Columns.GridColumn();
      this.EndPage = new DevExpress.XtraGrid.Columns.GridColumn();
      this.txtPublisher = new DevExpress.XtraEditors.TextEdit();
      this.txtAuthor = new DevExpress.XtraEditors.TextEdit();
      this.Title = new DevExpress.XtraEditors.LabelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.groupBookShow = new DevExpress.XtraEditors.GroupControl();
      this.Cancel = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridShowChapter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.showChapterView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPublisher.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAuthor.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupBookShow)).BeginInit();
      this.groupBookShow.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtYear
      // 
      this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.txtYear.Enabled = false;
      this.txtYear.Location = new System.Drawing.Point(77, 31);
      this.txtYear.Name = "txtYear";
      this.txtYear.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtYear.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtYear.Properties.Appearance.Options.UseBackColor = true;
      this.txtYear.Properties.Appearance.Options.UseForeColor = true;
      this.txtYear.Size = new System.Drawing.Size(154, 20);
      this.txtYear.TabIndex = 5;
      // 
      // txtTitle
      // 
      this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.txtTitle.Enabled = false;
      this.txtTitle.Location = new System.Drawing.Point(77, 5);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtTitle.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtTitle.Properties.Appearance.Options.UseBackColor = true;
      this.txtTitle.Properties.Appearance.Options.UseForeColor = true;
      this.txtTitle.Size = new System.Drawing.Size(154, 20);
      this.txtTitle.TabIndex = 1;
      // 
      // gridShowChapter
      // 
      this.gridShowChapter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridShowChapter.Location = new System.Drawing.Point(8, 66);
      this.gridShowChapter.MainView = this.showChapterView;
      this.gridShowChapter.Name = "gridShowChapter";
      this.gridShowChapter.Size = new System.Drawing.Size(505, 208);
      this.gridShowChapter.TabIndex = 1;
      this.gridShowChapter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.showChapterView});
      this.gridShowChapter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gridShowChapter_PreviewKeyDown);
      // 
      // showChapterView
      // 
      this.showChapterView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ChapterTitle,
            this.StartPage,
            this.EndPage});
      this.showChapterView.GridControl = this.gridShowChapter;
      this.showChapterView.Name = "showChapterView";
      this.showChapterView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.showChapterView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.showChapterView.OptionsBehavior.AllowIncrementalSearch = true;
      this.showChapterView.OptionsBehavior.Editable = false;
      this.showChapterView.OptionsMenu.EnableColumnMenu = false;
      this.showChapterView.OptionsMenu.ShowGroupSortSummaryItems = false;
      this.showChapterView.OptionsView.ShowGroupPanel = false;
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
      // txtPublisher
      // 
      this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPublisher.Enabled = false;
      this.txtPublisher.Location = new System.Drawing.Point(332, 5);
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtPublisher.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtPublisher.Properties.Appearance.Options.UseBackColor = true;
      this.txtPublisher.Properties.Appearance.Options.UseForeColor = true;
      this.txtPublisher.Size = new System.Drawing.Size(154, 20);
      this.txtPublisher.TabIndex = 7;
      // 
      // txtAuthor
      // 
      this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAuthor.Enabled = false;
      this.txtAuthor.Location = new System.Drawing.Point(332, 31);
      this.txtAuthor.Name = "txtAuthor";
      this.txtAuthor.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.txtAuthor.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.txtAuthor.Properties.Appearance.Options.UseBackColor = true;
      this.txtAuthor.Properties.Appearance.Options.UseForeColor = true;
      this.txtAuthor.Size = new System.Drawing.Size(154, 20);
      this.txtAuthor.TabIndex = 3;
      // 
      // Title
      // 
      this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.Title.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.Title.Location = new System.Drawing.Point(5, 5);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(55, 17);
      this.Title.TabIndex = 0;
      this.Title.Text = "&Book Title";
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 15F);
      this.labelControl1.Location = new System.Drawing.Point(16, 27);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(0, 28);
      this.labelControl1.TabIndex = 4;
      // 
      // labelControl2
      // 
      this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.labelControl2.Location = new System.Drawing.Point(5, 34);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(25, 17);
      this.labelControl2.TabIndex = 8;
      this.labelControl2.Text = "&Year";
      // 
      // labelControl3
      // 
      this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.labelControl3.Location = new System.Drawing.Point(266, 5);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(50, 17);
      this.labelControl3.TabIndex = 2;
      this.labelControl3.Text = "&Publisher";
      // 
      // labelControl4
      // 
      this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Nirmala UI Semilight", 10F);
      this.labelControl4.Location = new System.Drawing.Point(266, 31);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(37, 17);
      this.labelControl4.TabIndex = 6;
      this.labelControl4.Text = "&Author";
      // 
      // groupBookShow
      // 
      this.groupBookShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBookShow.Controls.Add(this.labelControl4);
      this.groupBookShow.Controls.Add(this.labelControl3);
      this.groupBookShow.Controls.Add(this.labelControl2);
      this.groupBookShow.Controls.Add(this.Title);
      this.groupBookShow.Controls.Add(this.labelControl1);
      this.groupBookShow.Controls.Add(this.txtAuthor);
      this.groupBookShow.Controls.Add(this.txtPublisher);
      this.groupBookShow.Controls.Add(this.txtYear);
      this.groupBookShow.Controls.Add(this.txtTitle);
      this.groupBookShow.Location = new System.Drawing.Point(8, 4);
      this.groupBookShow.Name = "groupBookShow";
      this.groupBookShow.ShowCaption = false;
      this.groupBookShow.Size = new System.Drawing.Size(505, 56);
      this.groupBookShow.TabIndex = 0;
      this.groupBookShow.Text = "groupControl1";
      // 
      // Cancel
      // 
      this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Cancel.Location = new System.Drawing.Point(435, 280);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(75, 23);
      this.Cancel.TabIndex = 2;
      this.Cancel.Text = "&Cancel";
      this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
      // 
      // FrmShowBook
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(519, 318);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.groupBookShow);
      this.Controls.Add(this.gridShowChapter);
      this.Name = "FrmShowBook";
      this.Text = "Show";
      ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridShowChapter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.showChapterView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPublisher.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAuthor.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupBookShow)).EndInit();
      this.groupBookShow.ResumeLayout(false);
      this.groupBookShow.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridShowChapter;
        private DevExpress.XtraGrid.Views.Grid.GridView showChapterView;
        private DevExpress.XtraGrid.Columns.GridColumn ChapterTitle;
        private DevExpress.XtraGrid.Columns.GridColumn StartPage;
        private DevExpress.XtraGrid.Columns.GridColumn EndPage;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.TextEdit txtYear;
        private DevExpress.XtraEditors.TextEdit txtPublisher;
        private DevExpress.XtraEditors.TextEdit txtAuthor;
        private DevExpress.XtraEditors.LabelControl Title;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupBookShow;
        private DevExpress.XtraEditors.SimpleButton Cancel;

    }
}