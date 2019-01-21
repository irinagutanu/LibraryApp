using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using LibraryFinalProject.Model;
using LibraryFinalProject.Controller;

namespace LibraryFinalProject.Reports
{
  public partial class Report_Recent : DevExpress.XtraReports.UI.XtraReport
  {
    LibraryDataAccess ldas = new LibraryDataAccess();
    public Report_Recent(int nb)
    {
      InitializeComponent();
      this.DataSource = ldas.SelectLastBooks(nb) as ReportRecentDS;
    }
  }
}
