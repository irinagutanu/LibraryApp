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
using DevExpress.XtraEditors.Controls;

namespace LibraryFinalProject.Forms
{
  public partial class FrmAddBook : DevExpress.XtraEditors.XtraForm
  {
    LibraryDataSet ds, lds;

    public FrmAddBook(LibraryDataSet libraryDS)
    {
      InitializeComponent();
      ds = libraryDS.Clone() as LibraryDataSet;
      lds = libraryDS;
      lookUpAuthor.Properties.DataSource = lds.Author;
      gridChapter.DataSource = ds.Chapter;
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Close();
    }

    private void Ok_Click_1(object sender, EventArgs e)
    {
      if (!CheckData.checkBookData(txtTitle.Text, txtPublisher.Text, txtYear.Text, lookUpAuthor.Text))
      {
        return;
      }
      else
      {
        LibraryDataSet.BookRow bookRow = AddBookRow();

        foreach (LibraryDataSet.ChapterRow chr in ds.Chapter.Rows)
        {
          if (CheckData.checkChapterData(chr))
          {
            LibraryDataSet.ChapterRow nchr = MakeChapterRow(chr, bookRow.Id);
            lds.Chapter.AddChapterRow(nchr);
          }
        }
      }
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Close();
    }

    private LibraryDataSet.ChapterRow MakeChapterRow(LibraryDataSet.ChapterRow chr, int bkId)
    {
      LibraryDataSet.ChapterRow nchr = lds.Chapter.NewChapterRow();
      nchr.Title = chr.Title;
      nchr.StartPage = chr.StartPage;
      nchr.EndPage = chr.EndPage;
      nchr.BookRow = lds.Book.FindById(bkId) as LibraryDataSet.BookRow;
      nchr.IdBook = bkId;
      return nchr;
    }

    private LibraryDataSet.BookRow AddBookRow()
    {
      LibraryDataSet.BookRow bookRow = lds.Book.NewBookRow();
      bookRow.Title = txtTitle.Text;
      bookRow.Publisher = txtPublisher.Text;
      bookRow.Year = Int32.Parse(txtYear.EditValue.ToString());
      bookRow.IdAuthor = (int)lookUpAuthor.EditValue;
      lds.Book.AddBookRow(bookRow);
      return bookRow;
    }

    private void FrmAddBook_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      if (e.KeyData == Keys.Delete)
      {
        viewChapter.DeleteSelectedRows();
      }
    }

    private void lookUpAuthor_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
    {
      if (e.Value == null)
      {
        return;
      }
      LibraryDataSet.AuthorRow authorRow = lds.Author.FindById((int)e.Value);
      if (authorRow == null)
      {
        return;
      }
      e.DisplayText = authorRow.FirstName + " " + authorRow.LastName;
    }
  }
}