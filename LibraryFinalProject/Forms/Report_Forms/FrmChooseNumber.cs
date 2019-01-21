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
using LibraryFinalProject.Controller;

namespace LibraryFinalProject.Forms.Report_Forms
{
  public partial class FrmChooseNumber : Form
  {

    public FrmChooseNumber()
    {
      InitializeComponent();
    }

    private void btnNumber_Click(object sender, EventArgs e)
    {
      if (CheckData.isNumeric(txtNumber.EditValue.ToString()))
      {
        int nb = CheckData.NumericValue(txtNumber.EditValue.ToString());
        using (Report_Recent lbs = new Report_Recent(nb))
        {
          lbs.ShowPreviewDialog();
        }
      }
    }
    
  }
}
