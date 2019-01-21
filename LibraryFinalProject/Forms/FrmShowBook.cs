using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LibraryFinalProject.Model;
using LibraryFinalProject.Controller;

namespace LibraryFinalProject.Forms
{
  public partial class FrmShowBook : DevExpress.XtraEditors.XtraForm
  {
    public FrmShowBook(LibraryDataSet bookSet, LibraryDataSet.BookRow bookRow)
    {
      InitializeComponent();

      if (bookRow != null)
      {
        txtTitle.EditValue = bookRow.Title;
        txtYear.EditValue = bookRow.Year.ToString();
        txtPublisher.EditValue = bookRow.Publisher;
        String author = "none";
        foreach (LibraryDataSet.AuthorRow authrow in bookSet.Author)
        {
          if (authrow.Id == bookRow.IdAuthor)
          {
            author = authrow.FirstName + " " + authrow.LastName;
          }
        }
        txtAuthor.EditValue = author;
        int bookId = bookRow.Id;

        gridShowChapter.DataSource = bookSet.Chapter.Where(row => row.IdBook == bookId).AsDataView(); 
      }
    }

    private void gridShowChapter_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      if (e.KeyData == Keys.Delete)
      {
        showChapterView.DeleteSelectedRows();
      }
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}