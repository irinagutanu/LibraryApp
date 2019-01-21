using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using LibraryFinalProject.Model;
using LibraryFinalProject.Controller;

namespace LibraryFinalProject.Reports
{
  public partial class Report_Order : DevExpress.XtraReports.UI.XtraReport
  {
    LibraryDataAccess ldas = new LibraryDataAccess();

    public Report_Order(LibraryDataSet libraryDataSet, int yr)
    {
      InitializeComponent();
      ReportOrderDS rods = ldas.SelectBooksOrder(yr) as ReportOrderDS;
      this.DataSource = rods;
      
      if (rods.Order.Count == 0 )
      {
        this.beforeYearLabel.Text = "All books are before " + yr.ToString() + "." + System.Environment.NewLine;
        this.txtInfo.DataBindings.Clear();
        this.txtInfo.Text = " This means " + ldas.SelectLastBooks(Int32.MaxValue).Book.Count + " books. ";
        this.afterYearLabel.Text = "There are no books in the year " + yr.ToString() + " or after ";
        this.txtTitle.Visible = false;
        this.txtAuthor.Visible = false;
        this.txtPublisher.Visible = false;
        this.txtYear.Visible = false;
        this.bookTable.Visible = false;
      }
      else
      {
        this.beforeYearLabel.Text = "Books before " + yr.ToString() + ":";
        this.afterYearLabel.Text = "Books in " + yr.ToString() + " or after:";
      }
    }

  }
}
