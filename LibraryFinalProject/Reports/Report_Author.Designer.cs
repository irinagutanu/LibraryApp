namespace LibraryFinalProject.Reports
{
  partial class Report_Author
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
      this.AuthorInfoPanel = new DevExpress.XtraReports.UI.XRPanel();
      this.txtBirthDate = new DevExpress.XtraReports.UI.XRLabel();
      this.txtLastName = new DevExpress.XtraReports.UI.XRLabel();
      this.txtFirstName = new DevExpress.XtraReports.UI.XRLabel();
      this.pictureBox = new DevExpress.XtraReports.UI.XRPictureBox();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.txtReport = new DevExpress.XtraReports.UI.XRLabel();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.reportAuthor1 = new LibraryFinalProject.Model.AuthorInfo();
      this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
      this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
      this.BookInfoTable = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
      this.txtTitle = new DevExpress.XtraReports.UI.XRTableCell();
      this.txtPublisher = new DevExpress.XtraReports.UI.XRTableCell();
      this.txtYear = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
      this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
      this.txtTitleName = new DevExpress.XtraReports.UI.XRTableCell();
      this.txtPublisherName = new DevExpress.XtraReports.UI.XRTableCell();
      this.txtYearName = new DevExpress.XtraReports.UI.XRTableCell();
      ((System.ComponentModel.ISupportInitialize)(this.reportAuthor1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BookInfoTable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.BookInfoTable});
      this.Detail.HeightF = 25F;
      this.Detail.Name = "Detail";
      this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // AuthorInfoPanel
      // 
      this.AuthorInfoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
      this.AuthorInfoPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.pictureBox});
      this.AuthorInfoPanel.LocationFloat = new DevExpress.Utils.PointFloat(2.249845F, 10.00001F);
      this.AuthorInfoPanel.Name = "AuthorInfoPanel";
      this.AuthorInfoPanel.SizeF = new System.Drawing.SizeF(668.7501F, 227.2917F);
      this.AuthorInfoPanel.StylePriority.UseBackColor = false;
      // 
      // txtBirthDate
      // 
      this.txtBirthDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AuthorInfo.BirthDate")});
      this.txtBirthDate.ForeColor = System.Drawing.Color.DarkRed;
      this.txtBirthDate.LocationFloat = new DevExpress.Utils.PointFloat(117.2916F, 50.33334F);
      this.txtBirthDate.Name = "txtBirthDate";
      this.txtBirthDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.txtBirthDate.SizeF = new System.Drawing.SizeF(100F, 23F);
      this.txtBirthDate.StylePriority.UseForeColor = false;
      this.txtBirthDate.Text = "txtBirthDate";
      // 
      // txtLastName
      // 
      this.txtLastName.BorderColor = System.Drawing.Color.DarkRed;
      this.txtLastName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AuthorInfo.LastName")});
      this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLastName.ForeColor = System.Drawing.Color.DarkRed;
      this.txtLastName.LocationFloat = new DevExpress.Utils.PointFloat(164.8333F, 10.00001F);
      this.txtLastName.LockedInUserDesigner = true;
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.txtLastName.SizeF = new System.Drawing.SizeF(91.04181F, 23F);
      this.txtLastName.StylePriority.UseBorderColor = false;
      this.txtLastName.StylePriority.UseFont = false;
      this.txtLastName.StylePriority.UseForeColor = false;
      this.txtLastName.Text = "txtLastName";
      // 
      // txtFirstName
      // 
      this.txtFirstName.BorderColor = System.Drawing.Color.DarkRed;
      this.txtFirstName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
      this.txtFirstName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AuthorInfo.FirstName")});
      this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFirstName.ForeColor = System.Drawing.Color.DarkRed;
      this.txtFirstName.LocationFloat = new DevExpress.Utils.PointFloat(63.04162F, 10.00001F);
      this.txtFirstName.LockedInUserDesigner = true;
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.txtFirstName.SizeF = new System.Drawing.SizeF(101.7917F, 23F);
      this.txtFirstName.StylePriority.UseBorderColor = false;
      this.txtFirstName.StylePriority.UseBorderDashStyle = false;
      this.txtFirstName.StylePriority.UseFont = false;
      this.txtFirstName.StylePriority.UseForeColor = false;
      this.txtFirstName.Text = "[FirstName]";
      // 
      // pictureBox
      // 
      this.pictureBox.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
      this.pictureBox.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "AuthorInfo.Picture")});
      this.pictureBox.ImageUrl = "C:\\Users\\irina.gutanu\\Desktop\\Images\\download.png";
      this.pictureBox.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.SizeF = new System.Drawing.SizeF(302.0833F, 207.2917F);
      this.pictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
      this.pictureBox.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictureBox1_BeforePrint);
      // 
      // TopMargin
      // 
      this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtReport});
      this.TopMargin.HeightF = 56.20832F;
      this.TopMargin.Name = "TopMargin";
      this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // txtReport
      // 
      this.txtReport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtReport.ForeColor = System.Drawing.Color.DarkRed;
      this.txtReport.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
      this.txtReport.Name = "txtReport";
      this.txtReport.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.txtReport.SizeF = new System.Drawing.SizeF(273F, 45F);
      this.txtReport.StylePriority.UseFont = false;
      this.txtReport.StylePriority.UseForeColor = false;
      this.txtReport.Text = "Report Author";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
      this.BottomMargin.HeightF = 42.29164F;
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // xrPageInfo2
      // 
      this.xrPageInfo2.ForeColor = System.Drawing.Color.DarkRed;
      this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 9.999974F);
      this.xrPageInfo2.Name = "xrPageInfo2";
      this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.xrPageInfo2.SizeF = new System.Drawing.SizeF(197.9167F, 23F);
      this.xrPageInfo2.StylePriority.UseForeColor = false;
      // 
      // xrPageInfo1
      // 
      this.xrPageInfo1.ForeColor = System.Drawing.Color.DarkRed;
      this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(626.2083F, 9.291649F);
      this.xrPageInfo1.Name = "xrPageInfo1";
      this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrPageInfo1.SizeF = new System.Drawing.SizeF(44.79163F, 23F);
      this.xrPageInfo1.StylePriority.UseForeColor = false;
      // 
      // reportAuthor1
      // 
      this.reportAuthor1.DataSetName = "AuthorInfo";
      this.reportAuthor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // formattingRule1
      // 
      this.formattingRule1.Name = "formattingRule1";
      // 
      // GroupHeader1
      // 
      this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.AuthorInfoPanel});
      this.GroupHeader1.HeightF = 282.7084F;
      this.GroupHeader1.Name = "GroupHeader1";
      // 
      // BookInfoTable
      // 
      this.BookInfoTable.LocationFloat = new DevExpress.Utils.PointFloat(17.66678F, 0F);
      this.BookInfoTable.Name = "BookInfoTable";
      this.BookInfoTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
      this.BookInfoTable.SizeF = new System.Drawing.SizeF(643.3333F, 25F);
      // 
      // xrTableRow1
      // 
      this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.txtTitle,
            this.txtPublisher,
            this.txtYear});
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1D;
      // 
      // txtTitle
      // 
      this.txtTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtTitle.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AuthorInfo.Title")});
      this.txtTitle.ForeColor = System.Drawing.Color.DarkRed;
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.StylePriority.UseBorders = false;
      this.txtTitle.StylePriority.UseForeColor = false;
      this.txtTitle.Text = "txtTitle";
      this.txtTitle.Weight = 3.1833314786273341D;
      // 
      // txtPublisher
      // 
      this.txtPublisher.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtPublisher.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AuthorInfo.Publisher")});
      this.txtPublisher.ForeColor = System.Drawing.Color.DarkRed;
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.StylePriority.UseBorders = false;
      this.txtPublisher.StylePriority.UseForeColor = false;
      this.txtPublisher.Text = "[Publisher]";
      this.txtPublisher.Weight = 2.0933342303698517D;
      // 
      // txtYear
      // 
      this.txtYear.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtYear.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AuthorInfo.Year")});
      this.txtYear.ForeColor = System.Drawing.Color.DarkRed;
      this.txtYear.Name = "txtYear";
      this.txtYear.StylePriority.UseBorders = false;
      this.txtYear.StylePriority.UseForeColor = false;
      this.txtYear.Text = "txtYear";
      this.txtYear.Weight = 1.1566661350704328D;
      // 
      // xrPanel1
      // 
      this.xrPanel1.BackColor = System.Drawing.Color.Transparent;
      this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtFirstName,
            this.txtLastName,
            this.txtBirthDate});
      this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(333.7501F, 47.29166F);
      this.xrPanel1.Name = "xrPanel1";
      this.xrPanel1.SizeF = new System.Drawing.SizeF(325.0001F, 83.33333F);
      this.xrPanel1.StylePriority.UseBackColor = false;
      // 
      // xrTable1
      // 
      this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(17.66678F, 257.7084F);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
      this.xrTable1.SizeF = new System.Drawing.SizeF(643.3333F, 25F);
      // 
      // xrTableRow2
      // 
      this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.txtTitleName,
            this.txtPublisherName,
            this.txtYearName});
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1D;
      // 
      // txtTitleName
      // 
      this.txtTitleName.BackColor = System.Drawing.Color.WhiteSmoke;
      this.txtTitleName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtTitleName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTitleName.ForeColor = System.Drawing.Color.DarkRed;
      this.txtTitleName.Name = "txtTitleName";
      this.txtTitleName.StylePriority.UseBackColor = false;
      this.txtTitleName.StylePriority.UseBorders = false;
      this.txtTitleName.StylePriority.UseFont = false;
      this.txtTitleName.StylePriority.UseForeColor = false;
      this.txtTitleName.Text = "Title";
      this.txtTitleName.Weight = 1.4844552924697534D;
      // 
      // txtPublisherName
      // 
      this.txtPublisherName.BackColor = System.Drawing.Color.WhiteSmoke;
      this.txtPublisherName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtPublisherName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPublisherName.ForeColor = System.Drawing.Color.DarkRed;
      this.txtPublisherName.Name = "txtPublisherName";
      this.txtPublisherName.StylePriority.UseBackColor = false;
      this.txtPublisherName.StylePriority.UseBorders = false;
      this.txtPublisherName.StylePriority.UseFont = false;
      this.txtPublisherName.StylePriority.UseForeColor = false;
      this.txtPublisherName.Text = "Publisher";
      this.txtPublisherName.Weight = 0.97616642467647252D;
      // 
      // txtYearName
      // 
      this.txtYearName.BackColor = System.Drawing.Color.WhiteSmoke;
      this.txtYearName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
      this.txtYearName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtYearName.ForeColor = System.Drawing.Color.DarkRed;
      this.txtYearName.Name = "txtYearName";
      this.txtYearName.StylePriority.UseBackColor = false;
      this.txtYearName.StylePriority.UseBorders = false;
      this.txtYearName.StylePriority.UseFont = false;
      this.txtYearName.StylePriority.UseForeColor = false;
      this.txtYearName.Text = "Year";
      this.txtYearName.Weight = 0.53937828285377409D;
      // 
      // Report_Author
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
      this.DataMember = "AuthorInfo";
      this.DataSource = this.reportAuthor1;
      this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
      this.Margins = new System.Drawing.Printing.Margins(100, 69, 56, 42);
      this.Version = "10.2";
      ((System.ComponentModel.ISupportInitialize)(this.reportAuthor1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BookInfoTable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.XRLabel txtReport;
    private DevExpress.XtraReports.UI.XRPictureBox pictureBox;
    private DevExpress.XtraReports.UI.XRPanel AuthorInfoPanel;
    private DevExpress.XtraReports.UI.XRLabel txtBirthDate;
    private DevExpress.XtraReports.UI.XRLabel txtLastName;
    private DevExpress.XtraReports.UI.XRLabel txtFirstName;
    private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
    private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    private Model.AuthorInfo reportAuthor1;
    private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
    private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
    private DevExpress.XtraReports.UI.XRPanel xrPanel1;
    private DevExpress.XtraReports.UI.XRTable BookInfoTable;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
    private DevExpress.XtraReports.UI.XRTableCell txtTitle;
    private DevExpress.XtraReports.UI.XRTableCell txtPublisher;
    private DevExpress.XtraReports.UI.XRTableCell txtYear;
    private DevExpress.XtraReports.UI.XRTable xrTable1;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
    private DevExpress.XtraReports.UI.XRTableCell txtTitleName;
    private DevExpress.XtraReports.UI.XRTableCell txtPublisherName;
    private DevExpress.XtraReports.UI.XRTableCell txtYearName;
  }
}
