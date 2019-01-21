using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace LibraryFinalProject.Model
{
  public static class CheckData
  {
    private static Boolean checkTitle(string txtTitle)
    {
      if (String.IsNullOrEmpty(txtTitle))
      {
        MessageBox.Show("Add a title!");
        return false;
      }
      return true;
    }

    private static Boolean checkPublisher(string txtPublisher)
    {
      if (String.IsNullOrEmpty(txtPublisher))
      {
        MessageBox.Show("Add a publisher!");
        return false;
      }
      return true;
    }

    public static Boolean checkAuthor(string txtAuthor)
    {
      if (String.IsNullOrEmpty(txtAuthor))
      {
        MessageBox.Show("Choose an author!");
        return false;
      }
      return true;
    }

    public static Boolean checkYear(string txtYear)
    {
      if (String.IsNullOrEmpty(txtYear))
      {
        MessageBox.Show("Add a year!");
        return false;
      }
      else if (!isNumeric(txtYear) || NumericValue(txtYear) < 0 || NumericValue(txtYear) > DateTime.Now.Year)
      {
        MessageBox.Show("Invalid Year");
        return false;
      }
      return true;
    }

    public static Boolean checkBookData(string txtTitle, string txtPublisher, string txtYear, string txtAuthor)
    {
      if (!checkTitle(txtTitle))
      {
        return false;
      }
      else if (!checkPublisher(txtPublisher))
      {
        return false;
      }
      else if (!checkYear(txtYear))
      {
        return false;
      }
      else if (!checkAuthor(txtAuthor))
      {
        return false;
      }
      return true;
    }

    private static Boolean checkChapterTitle(string txtTitle)
    {
      if (String.IsNullOrEmpty(txtTitle))
      {
        //should show something depending on how the application should manage chapters
        return false;
      }
      return true;
    }

    private static Boolean checkChapterPages(string startPage, string endPage)
    {
      if (!isNumeric(startPage) || !isNumeric(endPage) || NumericValue(startPage) < 0 || NumericValue(startPage) > NumericValue(endPage))
      {
        return false;
      }
      return true;
    }

    public static Boolean checkChapterData(LibraryDataSet.ChapterRow chapter)
    {
      try
      {
        if (!checkChapterTitle(chapter.Title) || !checkChapterPages(chapter.StartPage.ToString(), chapter.EndPage.ToString()))
        {
          MessageBox.Show("Chapter " + chapter.Title + " is not valid");
          return false;
        }
      }
      catch (StrongTypingException)
      {
        MessageBox.Show("Chapter is not valid");
        return false;
      }
      return true;
    }

    public static Boolean isNumeric(string str)
    {
      int nb;
      return int.TryParse(str, out nb);
    }

    public static int NumericValue(string str)
    {
      int nb;
      var isnum = int.TryParse(str, out nb);
      return nb;
    }
  }
}
