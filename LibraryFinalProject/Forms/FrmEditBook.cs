using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryFinalProject.Controller;
using LibraryFinalProject.Model;
using DevExpress.XtraEditors;

namespace LibraryFinalProject.Forms
{
  public partial class FrmEditBook : Form
  {
    LibraryDataSet.BookRow bkr;

    public FrmEditBook(LibraryDataSet _libraryDS, LibraryDataSet.BookRow bookRow)
    {
      InitializeComponent();
      libraryDS = _libraryDS;
      bkr = bookRow;
      if (bookRow != null)
      {
        txtTitle.EditValue = bookRow.Title;
        txtYear.EditValue = bookRow.Year.ToString();
        txtPublisher.EditValue = bookRow.Publisher;
        lookUpAuthor.Properties.DataSource = libraryDS.Author;

        lookUpAuthor.EditValue = bookRow.AuthorRow.Id;

        int bookId = bookRow.Id;
        gridChapters.DataSource = libraryDS.Chapter.Where(row => row.IdBook == bookId).AsDataView();
      }
    }

    private void Ok_Click(object sender, EventArgs e)
    {
      if (UpdateRowInfoValid())
      {
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.Close();
      }
    }

    private Boolean UpdateRowInfoValid()
    {
      if (!CheckData.checkBookData((string)txtTitle.EditValue, (string)txtPublisher.EditValue, (string) txtYear.EditValue, lookUpAuthor.Text))
      {
        return false;
      }
      else{
        bkr.Title = (string)txtTitle.EditValue;
        bkr.Publisher = (string)txtPublisher.EditValue;
        bkr.Year = Int32.Parse(txtYear.EditValue.ToString());
      }
      bkr.AuthorRow = libraryDS.Author.FindById((int)lookUpAuthor.EditValue);

      List<LibraryDataSet.ChapterRow> listchr = libraryDS.Chapter.Where(row => row.IdBook == bkr.Id).ToList();
      foreach (LibraryDataSet.ChapterRow chr in listchr)
      {
        if (!CheckData.checkChapterData(chr))
        {
          return false;
        }
      }
      return true;
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Close();
    }

    private void lookUpAuthor_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
    {
      if(e.Value == null)
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

    private void showChapterView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
    {
      LibraryDataSet.ChapterRow chapterRow = viewChapters.GetFocusedDataRow() as LibraryDataSet.ChapterRow;
      if (chapterRow == null)
      {
        return;
      }
      chapterRow.BookRow = bkr;
    }

    private void FrmEditBook_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      if (e.KeyData == Keys.Delete)
      {
        viewChapters.DeleteSelectedRows();
      }
    }
  }
}
