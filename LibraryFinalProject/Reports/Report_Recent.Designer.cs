namespace LibraryFinalProject.Reports
{
  partial class Report_Recent
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
      DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
      DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.TableReport = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
      this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.Title = new DevExpress.XtraReports.UI.XRLabel();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
      this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
      this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
      this.reportRecentDS1 = new LibraryFinalProject.Model.ReportRecentDS();
      ((System.ComponentModel.ISupportInitialize)(this.TableReport)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.reportRecentDS1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TableReport});
      this.Detail.HeightF = 25F;
      this.Detail.Name = "Detail";
      this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // TableReport
      // 
      this.TableReport.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.TableReport.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
      this.TableReport.Name = "TableReport";
      this.TableReport.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
      this.TableReport.SizeF = new System.Drawing.SizeF(649.9999F, 25F);
      this.TableReport.StylePriority.UseBorders = false;
      // 
      // xrTableRow1
      // 
      this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4});
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1D;
      // 
      // xrTableCell5
      // 
      this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Book.Count")});
      this.xrTableCell5.Name = "xrTableCell5";
      xrSummary1.FormatString = "{0:#.00}";
      xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
      this.xrTableCell5.Summary = xrSummary1;
      this.xrTableCell5.Text = "xrTableCell5";
      this.xrTableCell5.Weight = 0.35416667938232421D;
      // 
      // xrTableCell1
      // 
      this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Book.Title")});
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.Text = "xrTableCell1";
      this.xrTableCell1.Weight = 1.7500000381469727D;
      // 
      // xrTableCell2
      // 
      this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Book.Publisher")});
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.Text = "xrTableCell2";
      this.xrTableCell2.Weight = 1.4999998474121095D;
      // 
      // xrTableCell3
      // 
      this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Book.Year")});
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
      this.xrTableCell3.StylePriority.UseBorders = false;
      this.xrTableCell3.StylePriority.UsePadding = false;
      this.xrTableCell3.Text = "xrTableCell3";
      this.xrTableCell3.Weight = 1.3541668701171874D;
      // 
      // xrTableCell4
      // 
      this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Book.AuthorName")});
      this.xrTableCell4.Name = "xrTableCell4";
      xrSummary2.FormatString = "Mr.{0}";
      this.xrTableCell4.Summary = xrSummary2;
      this.xrTableCell4.Text = "xrTableCell4";
      this.xrTableCell4.Weight = 1.5416665649414063D;
      // 
      // TopMargin
      // 
      this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Title});
      this.TopMargin.HeightF = 67.08332F;
      this.TopMargin.Name = "TopMargin";
      this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // Title
      // 
      this.Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Title.ForeColor = System.Drawing.Color.DarkRed;
      this.Title.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.875F);
      this.Title.Name = "Title";
      this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.Title.SizeF = new System.Drawing.SizeF(272.9167F, 45.20832F);
      this.Title.StylePriority.UseFont = false;
      this.Title.StylePriority.UseForeColor = false;
      this.Title.Text = "Report Last Books";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
      this.BottomMargin.HeightF = 35.83336F;
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // xrPageInfo2
      // 
      this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 10.00001F);
      this.xrPageInfo2.Name = "xrPageInfo2";
      this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.xrPageInfo2.SizeF = new System.Drawing.SizeF(179.1667F, 23F);
      // 
      // xrPageInfo1
      // 
      this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(594.7917F, 10.00001F);
      this.xrPageInfo1.Name = "xrPageInfo1";
      this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrPageInfo1.SizeF = new System.Drawing.SizeF(55.20831F, 23F);
      // 
      // GroupHeader1
      // 
      this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
      this.GroupHeader1.HeightF = 53.125F;
      this.GroupHeader1.Name = "GroupHeader1";
      // 
      // xrTable1
      // 
      this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 28.125F);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
      this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 25F);
      // 
      // xrTableRow2
      // 
      this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10});
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1D;
      // 
      // xrTableCell6
      // 
      this.xrTableCell6.BackColor = System.Drawing.Color.WhiteSmoke;
      this.xrTableCell6.BorderColor = System.Drawing.Color.Black;
      this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseBackColor = false;
      this.xrTableCell6.StylePriority.UseBorderColor = false;
      this.xrTableCell6.StylePriority.UseBorders = false;
      this.xrTableCell6.Text = "Nb.";
      this.xrTableCell6.Weight = 0.35416671752929685D;
      // 
      // xrTableCell7
      // 
      this.xrTableCell7.BackColor = System.Drawing.Color.WhiteSmoke;
      this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.StylePriority.UseBackColor = false;
      this.xrTableCell7.StylePriority.UseBorders = false;
      this.xrTableCell7.Text = "Title";
      this.xrTableCell7.Weight = 1.75D;
      // 
      // xrTableCell8
      // 
      this.xrTableCell8.BackColor = System.Drawing.Color.WhiteSmoke;
      this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.StylePriority.UseBackColor = false;
      this.xrTableCell8.StylePriority.UseBorders = false;
      this.xrTableCell8.Text = "Publisher";
      this.xrTableCell8.Weight = 1.4999998474121095D;
      // 
      // xrTableCell9
      // 
      this.xrTableCell9.BackColor = System.Drawing.Color.WhiteSmoke;
      this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.xrTableCell9.Name = "xrTableCell9";
      this.xrTableCell9.StylePriority.UseBackColor = false;
      this.xrTableCell9.StylePriority.UseBorders = false;
      this.xrTableCell9.Text = "Year";
      this.xrTableCell9.Weight = 1.3541670227050779D;
      // 
      // xrTableCell10
      // 
      this.xrTableCell10.BackColor = System.Drawing.Color.WhiteSmoke;
      this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.StylePriority.UseBackColor = false;
      this.xrTableCell10.StylePriority.UseBorders = false;
      this.xrTableCell10.Text = "Author";
      this.xrTableCell10.Weight = 1.5416664123535151D;
      // 
      // reportRecentDS1
      // 
      this.reportRecentDS1.DataSetName = "ReportRecentDS";
      this.reportRecentDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // Report_Recent
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
      this.DataMember = "Book";
      this.DataSource = this.reportRecentDS1;
      this.ForeColor = System.Drawing.Color.DarkRed;
      this.Margins = new System.Drawing.Printing.Margins(100, 100, 67, 36);
      this.Version = "10.2";
      ((System.ComponentModel.ISupportInitialize)(this.TableReport)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.reportRecentDS1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
    private DevExpress.XtraReports.UI.XRLabel Title;
    private DevExpress.XtraReports.UI.XRTable TableReport;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
    private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
    private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    private Model.ReportRecentDS reportRecentDS1;
    private DevExpress.XtraReports.UI.XRTable xrTable1;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
  }
}
