namespace LibraryFinalProject.Reports
{
  partial class Report_Order
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

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
      this.reportOrderDS1 = new LibraryFinalProject.Model.ReportOrderDS();
      this.beforeYearLabel = new DevExpress.XtraReports.UI.XRLabel();
      this.afterYearLabel = new DevExpress.XtraReports.UI.XRLabel();
      this.bookTable = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
      this.Title = new DevExpress.XtraReports.UI.XRTableCell();
      this.Author = new DevExpress.XtraReports.UI.XRTableCell();
      this.Publisher = new DevExpress.XtraReports.UI.XRTableCell();
      this.Year = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
      this.txtTitle = new DevExpress.XtraReports.UI.XRTableCell();
      this.txtAuthor = new DevExpress.XtraReports.UI.XRTableCell();
      this.txtPublisher = new DevExpress.XtraReports.UI.XRTableCell();
      this.txtYear = new DevExpress.XtraReports.UI.XRTableCell();
      this.txtInfo = new DevExpress.XtraReports.UI.XRLabel();
      ((System.ComponentModel.ISupportInitialize)(this.reportOrderDS1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bookTable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.bookTable});
      this.Detail.HeightF = 25F;
      this.Detail.Name = "Detail";
      this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // TopMargin
      // 
      this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
      this.TopMargin.HeightF = 78.125F;
      this.TopMargin.Name = "TopMargin";
      this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // xrLabel1
      // 
      this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
      this.xrLabel1.ForeColor = System.Drawing.Color.DarkRed;
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.88F);
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(272F, 45F);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseForeColor = false;
      this.xrLabel1.Text = "Books by Year Report";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
      this.BottomMargin.HeightF = 41.66667F;
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // xrPageInfo2
      // 
      this.xrPageInfo2.ForeColor = System.Drawing.Color.DarkRed;
      this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 8.666675F);
      this.xrPageInfo2.Name = "xrPageInfo2";
      this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.xrPageInfo2.SizeF = new System.Drawing.SizeF(160.4167F, 23F);
      this.xrPageInfo2.StylePriority.UseForeColor = false;
      // 
      // xrPageInfo1
      // 
      this.xrPageInfo1.ForeColor = System.Drawing.Color.DarkRed;
      this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(604.1667F, 10.00001F);
      this.xrPageInfo1.Name = "xrPageInfo1";
      this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrPageInfo1.SizeF = new System.Drawing.SizeF(45.83331F, 23F);
      this.xrPageInfo1.StylePriority.UseForeColor = false;
      // 
      // GroupHeader1
      // 
      this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtInfo,
            this.xrTable1,
            this.afterYearLabel,
            this.beforeYearLabel});
      this.GroupHeader1.HeightF = 98.95834F;
      this.GroupHeader1.Name = "GroupHeader1";
      // 
      // reportOrderDS1
      // 
      this.reportOrderDS1.DataSetName = "ReportOrder";
      this.reportOrderDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // beforeYearLabel
      // 
      this.beforeYearLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.beforeYearLabel.ForeColor = System.Drawing.Color.DarkRed;
      this.beforeYearLabel.LocationFloat = new DevExpress.Utils.PointFloat(29.16667F, 7.166672F);
      this.beforeYearLabel.Name = "beforeYearLabel";
      this.beforeYearLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.beforeYearLabel.SizeF = new System.Drawing.SizeF(242.8333F, 23F);
      this.beforeYearLabel.StylePriority.UseFont = false;
      this.beforeYearLabel.StylePriority.UseForeColor = false;
      this.beforeYearLabel.Text = "beforeYearLabel";
      // 
      // afterYearLabel
      // 
      this.afterYearLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.afterYearLabel.ForeColor = System.Drawing.Color.DarkRed;
      this.afterYearLabel.LocationFloat = new DevExpress.Utils.PointFloat(29.16667F, 42.66666F);
      this.afterYearLabel.Name = "afterYearLabel";
      this.afterYearLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.afterYearLabel.SizeF = new System.Drawing.SizeF(326.0418F, 24.04167F);
      this.afterYearLabel.StylePriority.UseFont = false;
      this.afterYearLabel.StylePriority.UseForeColor = false;
      this.afterYearLabel.Text = "afterYearLabel";
      // 
      // bookTable
      // 
      this.bookTable.LocationFloat = new DevExpress.Utils.PointFloat(29.16667F, 0F);
      this.bookTable.Name = "bookTable";
      this.bookTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
      this.bookTable.SizeF = new System.Drawing.SizeF(610.8333F, 25F);
      // 
      // xrTableRow1
      // 
      this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.Title,
            this.Author,
            this.Publisher,
            this.Year});
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1D;
      // 
      // Title
      // 
      this.Title.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.Title.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order.Title")});
      this.Title.ForeColor = System.Drawing.Color.DarkRed;
      this.Title.Name = "Title";
      this.Title.StylePriority.UseBorders = false;
      this.Title.StylePriority.UseForeColor = false;
      this.Title.Text = "Title";
      this.Title.Weight = 0.99488401304850083D;
      // 
      // Author
      // 
      this.Author.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.Author.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order.Author")});
      this.Author.ForeColor = System.Drawing.Color.DarkRed;
      this.Author.Name = "Author";
      this.Author.StylePriority.UseBorders = false;
      this.Author.StylePriority.UseForeColor = false;
      this.Author.Text = "Author";
      this.Author.Weight = 0.94884020542585734D;
      // 
      // Publisher
      // 
      this.Publisher.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.Publisher.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order.Publisher")});
      this.Publisher.ForeColor = System.Drawing.Color.DarkRed;
      this.Publisher.Name = "Publisher";
      this.Publisher.StylePriority.UseBorders = false;
      this.Publisher.StylePriority.UseForeColor = false;
      this.Publisher.Text = "Publisher";
      this.Publisher.Weight = 0.776262358620341D;
      // 
      // Year
      // 
      this.Year.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.Year.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order.Year")});
      this.Year.ForeColor = System.Drawing.Color.DarkRed;
      this.Year.Name = "Year";
      this.Year.StylePriority.UseBorders = false;
      this.Year.StylePriority.UseForeColor = false;
      this.Year.Text = "Year";
      this.Year.Weight = 0.28001342290530085D;
      // 
      // xrTable1
      // 
      this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(29.16667F, 73.95834F);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
      this.xrTable1.SizeF = new System.Drawing.SizeF(610.8334F, 25F);
      // 
      // xrTableRow2
      // 
      this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.txtTitle,
            this.txtAuthor,
            this.txtPublisher,
            this.txtYear});
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1D;
      // 
      // txtTitle
      // 
      this.txtTitle.BackColor = System.Drawing.Color.WhiteSmoke;
      this.txtTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTitle.ForeColor = System.Drawing.Color.DarkRed;
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.StylePriority.UseBackColor = false;
      this.txtTitle.StylePriority.UseBorders = false;
      this.txtTitle.StylePriority.UseFont = false;
      this.txtTitle.StylePriority.UseForeColor = false;
      this.txtTitle.Text = "Title";
      this.txtTitle.Weight = 2.0256942236580819D;
      // 
      // txtAuthor
      // 
      this.txtAuthor.BackColor = System.Drawing.Color.WhiteSmoke;
      this.txtAuthor.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAuthor.ForeColor = System.Drawing.Color.DarkRed;
      this.txtAuthor.Name = "txtAuthor";
      this.txtAuthor.StylePriority.UseBackColor = false;
      this.txtAuthor.StylePriority.UseBorders = false;
      this.txtAuthor.StylePriority.UseFont = false;
      this.txtAuthor.StylePriority.UseForeColor = false;
      this.txtAuthor.Text = "Author";
      this.txtAuthor.Weight = 1.9319436179903529D;
      // 
      // txtPublisher
      // 
      this.txtPublisher.BackColor = System.Drawing.Color.WhiteSmoke;
      this.txtPublisher.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPublisher.ForeColor = System.Drawing.Color.DarkRed;
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.StylePriority.UseBackColor = false;
      this.txtPublisher.StylePriority.UseBorders = false;
      this.txtPublisher.StylePriority.UseFont = false;
      this.txtPublisher.StylePriority.UseForeColor = false;
      this.txtPublisher.Text = "Publisher";
      this.txtPublisher.Weight = 1.5805571969913159D;
      // 
      // txtYear
      // 
      this.txtYear.BackColor = System.Drawing.Color.WhiteSmoke;
      this.txtYear.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtYear.ForeColor = System.Drawing.Color.DarkRed;
      this.txtYear.Name = "txtYear";
      this.txtYear.StylePriority.UseBackColor = false;
      this.txtYear.StylePriority.UseBorders = false;
      this.txtYear.StylePriority.UseFont = false;
      this.txtYear.StylePriority.UseForeColor = false;
      this.txtYear.Text = "Year";
      this.txtYear.Weight = 0.57013839641884267D;
      // 
      // txtInfo
      // 
      this.txtInfo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Order.Info")});
      this.txtInfo.LocationFloat = new DevExpress.Utils.PointFloat(272F, 7.166672F);
      this.txtInfo.Name = "txtInfo";
      this.txtInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.txtInfo.SizeF = new System.Drawing.SizeF(165.625F, 23F);
      this.txtInfo.Text = "txtInfo";
      // 
      // Report_Order
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
      this.DataMember = "Order";
      this.DataSource = this.reportOrderDS1;
      this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.DarkRed;
      this.Margins = new System.Drawing.Printing.Margins(100, 100, 78, 42);
      this.Version = "10.2";
      ((System.ComponentModel.ISupportInitialize)(this.reportOrderDS1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bookTable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
    private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
    private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    private Model.ReportOrderDS reportOrderDS1;
    private DevExpress.XtraReports.UI.XRLabel beforeYearLabel;
    private DevExpress.XtraReports.UI.XRLabel afterYearLabel;
    private DevExpress.XtraReports.UI.XRTable bookTable;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
    private DevExpress.XtraReports.UI.XRTableCell Title;
    private DevExpress.XtraReports.UI.XRTableCell Author;
    private DevExpress.XtraReports.UI.XRTableCell Publisher;
    private DevExpress.XtraReports.UI.XRTableCell Year;
    private DevExpress.XtraReports.UI.XRTable xrTable1;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
    private DevExpress.XtraReports.UI.XRTableCell txtTitle;
    private DevExpress.XtraReports.UI.XRTableCell txtAuthor;
    private DevExpress.XtraReports.UI.XRTableCell txtPublisher;
    private DevExpress.XtraReports.UI.XRTableCell txtYear;
    private DevExpress.XtraReports.UI.XRLabel txtInfo;
  }
}
