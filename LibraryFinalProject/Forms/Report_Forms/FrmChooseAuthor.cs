using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryFinalProject.Model;
using DevExpress.XtraEditors.Controls;
using LibraryFinalProject.Reports;

namespace LibraryFinalProject.Forms.Report_Forms
{
  public partial class FrmChooseAuthor : Form
  {
    LibraryDataSet libraryDS;

    public FrmChooseAuthor(LibraryDataSet libraryDataSet)
    {
      InitializeComponent();
      libraryDS = libraryDataSet;
      lookUpAuthor.Properties.DataSource = libraryDS.Author;
    }

    private void lookUpAuthor_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
    {
      if (e.Value == null)
      {
        return;
      }
      LibraryDataSet.AuthorRow authorRow = libraryDS.Author.FindById((int)e.Value);
      if (authorRow == null)
      {
        return;
      }
      e.DisplayText = authorRow.FirstName + " " + authorRow.LastName;
    }

    private void btnAuthor_Click(object sender, EventArgs e)
    {
      if (lookUpAuthor.EditValue == null)
      {
        MessageBox.Show("Select an author");
        return;
      }
      else if(CheckData.checkAuthor(lookUpAuthor.EditValue.ToString())){
        using (Report_Author aui = new Report_Author(libraryDS, (int)lookUpAuthor.EditValue))
        {
          aui.ShowPreviewDialog();
        }
      }
    }
  }
}
