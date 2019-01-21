using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LibraryFinalProject.Controller;
using LibraryFinalProject.Model;
using DevExpress.XtraEditors.Repository;
using System.IO;

namespace LibraryFinalProject.Forms
{
  public partial class FrmAuthor : DevExpress.XtraEditors.XtraForm
  {
    LibraryDataSet libraryDaS;

    public FrmAuthor(LibraryDataSet libraryDS)
    {
      InitializeComponent();
      libraryDaS = libraryDS;
      gridAuthor.DataSource = libraryDaS.Author;
    }

    private void OK_Click(object sender, EventArgs e)
    {
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Close();
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void gridAuthor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      if (e.KeyData == Keys.Delete)
      {
        viewAuthor.DeleteSelectedRows();
      }
    }
  }
}