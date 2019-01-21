using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryFinalProject.Model;
using LibraryFinalProject.Controller;
using LibraryFinalProject.Forms;
using LibraryFinalProject.Reports;
using LibraryFinalProject.Forms.Report_Forms;

namespace LibraryFinalProject
{
  public partial class FrmMain : Form
  {
    LibraryDataAccess _libraryDataAccess { set; get; }

    public FrmMain()
    {
      InitializeComponent();
    }

    private void InitializeData()
    {
      _libraryDataAccess = new LibraryDataAccess();
      libraryDS = _libraryDataAccess.ReadLibraryData();
      gridBooks.DataSource = libraryDS.Book;
    }

    private void bbLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      InitializeData();
    }

    private void bbAddAuthor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        LibraryDataSet libraryDSCopy = libraryDS.Copy() as LibraryDataSet;
        using (FrmAuthor authorForm = new FrmAuthor(libraryDSCopy))
        {
          authorForm.ShowInTaskbar = false;
          DialogResult result = authorForm.ShowDialog();
          if (result == DialogResult.OK)
          {
            libraryDS.Merge(libraryDSCopy);
          }
        }
      }
    }

    private void mainViewBooks_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        LibraryDataSet.BookRow bookRow = viewBooks.GetDataRow(e.RowHandle) as LibraryDataSet.BookRow;
        if (bookRow == null)
        {
          return;
        }
        e.Value = bookRow.AuthorRow.FirstName + " " + bookRow.AuthorRow.LastName;
      }
    }

    private void bbShowBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        LibraryDataSet.BookRow bookRow = viewBooks.GetFocusedDataRow() as LibraryDataSet.BookRow;
        using (FrmShowBook show = new FrmShowBook(libraryDS, bookRow))
        {
          show.ShowInTaskbar = false;
          show.ShowDialog();
        }
      }
    }

    private void bbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      Application.Exit();
    }

    private void bbAddBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        LibraryDataSet libraryDSCopy = libraryDS.Copy() as LibraryDataSet;
        using (FrmAddBook show = new FrmAddBook(libraryDSCopy))
        {
          show.ShowInTaskbar = false;
          DialogResult result = show.ShowDialog();
          if (result == DialogResult.OK)
          {
            libraryDS.Merge(libraryDSCopy);
          }
        }
      }
    }

    private void bbDeleteBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        viewBooks.DeleteSelectedRows();
      }
    }

    private void gridBooks_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      if (e.KeyData == Keys.Delete)
      {
        viewBooks.DeleteSelectedRows();
      }
    }

    private void bbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        _libraryDataAccess.WriteData(libraryDS);
      }
    }

    private void bbEditBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        LibraryDataSet.BookRow bookRow = viewBooks.GetFocusedDataRow() as LibraryDataSet.BookRow;
        if (bookRow == null)
        {
          return;
        }

        LibraryDataSet libraryDSCopy = libraryDS.Copy() as LibraryDataSet;
        bookRow = libraryDSCopy.Book.FindById(bookRow.Id);

        if (bookRow == null)
        {
          return;
        }

        using (FrmEditBook showEdit = new FrmEditBook(libraryDSCopy, bookRow))
        {
          showEdit.ShowInTaskbar = false;
          DialogResult result = showEdit.ShowDialog();
          if (result == DialogResult.OK)
          {
            libraryDS.Merge(libraryDSCopy);
          }
        }
      }
    }

    private void bbLastBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        using (FrmChooseNumber fcn = new FrmChooseNumber())
        {
          fcn.ShowInTaskbar = false;
          fcn.ShowDialog();
        }
      }
    }

    private void bbAuthorResume_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        LibraryDataSet libraryDSCopy = libraryDS.Copy() as LibraryDataSet;
        using (FrmChooseAuthor fca = new FrmChooseAuthor(libraryDSCopy))
        {
          fca.ShowInTaskbar = false;
          fca.ShowDialog();
        }
      }
    }

    private void bbBookTimeline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (_libraryDataAccess == null)
      {
        MessageBox.Show("Load data first");
      }
      else
      {
        LibraryDataSet libraryDSCopy = libraryDS.Copy() as LibraryDataSet;
        using (FrmChooseYear fcy = new FrmChooseYear(libraryDSCopy))
        {
          fcy.ShowInTaskbar = false;
          fcy.ShowDialog();
        }
      }
    }
  }
}
