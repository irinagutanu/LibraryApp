using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryFinalProject.Model;
using LibraryFinalProject.Reports;

namespace LibraryFinalProject.Forms.Report_Forms
{
  public partial class FrmChooseYear : Form
  {
    LibraryDataSet libraryDS;

    public FrmChooseYear(LibraryDataSet libraryDataSet)
    {
      InitializeComponent();
      libraryDS = libraryDataSet;
    }

    private void btnGenerateReport_Click(object sender, EventArgs e)
    {
      if (CheckData.checkYear(txtYear.EditValue.ToString()))
      {
        using (Report_Order lbs = new Report_Order(libraryDS, CheckData.NumericValue(txtYear.EditValue.ToString())))
        {
          lbs.ShowPreviewDialog();
        }
      }
    }
  }
}
