using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using LibraryFinalProject.Model;
using LibraryFinalProject.Controller;

namespace LibraryFinalProject.Reports
{
  public partial class Report_Author : DevExpress.XtraReports.UI.XtraReport
  {
    LibraryDataAccess ldas = new LibraryDataAccess();

    public Report_Author(LibraryDataSet lds, int id)
    {
      InitializeComponent();
      this.DataSource = ldas.SelectAuthorInfo(id) as AuthorInfo;
    }

    private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
      if ( IsNullOrEmpty(this.pictureBox) )
      {
        this.pictureBox.ImageUrl = "C:\\Users\\irina.gutanu\\Desktop\\Images\\download.png";
      }
    }

    private bool IsNullOrEmpty(XRPictureBox xRPictureBox)
    {
      if (xRPictureBox.Image == null) return true;
      return false;
    }

  }
}
