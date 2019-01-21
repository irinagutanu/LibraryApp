using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LibraryFinalProject.Model;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using LibraryFinalProject.Reports;

namespace LibraryFinalProject.Controller
{
  class LibraryDataAccess
  {
    private SqlDataAdapter authorDA;
    private SqlDataAdapter bookDA;
    private SqlDataAdapter chapterDA;
    private String connection_string = "Data Source=IRINAG\\SQLEXPRESS;Initial Catalog=BookDB;Integrated Security=True";

    public LibraryDataAccess()
    {
      InitializeAdapters();
    }

    public LibraryDataSet ReadLibraryData()
    {
      LibraryDataSet libraryDS = new LibraryDataSet();

      using (SqlConnection connection = new SqlConnection(connection_string))
      {
          connection.Open();
          InitializeAdapters();
          UpdateAdapters(connection);

          authorDA.Fill(libraryDS.Author);
          bookDA.Fill(libraryDS.Book);
          chapterDA.Fill(libraryDS.Chapter);
      }

      return libraryDS;
    }

    public void WriteData(LibraryDataSet ds)
    {
      using (SqlConnection connection = new SqlConnection(connection_string))
      {
          connection.Open();
          InitializeAdapters();
          UpdateAdapters(connection);

          WriteLibraryInsertAuthor(ds);
          WriteLibraryInsertBook(ds);
          WriteLibraryInsertChapter(ds);
          WriteLibraryEditAuthor(ds);
          WriteLibraryEditBook(ds);
          WriteLibraryEditChapter(ds);
          WriteLibraryDeleteBook(ds);
          WriteLibraryDeleteAuthor(ds);
      }
    }

    public void WriteLibraryInsertAuthor(LibraryDataSet libraryDS)
    {
      libraryDS.EnforceConstraints = false;
      using (authorDA.InsertCommand.Connection = new SqlConnection(connection_string))
      {
        authorDA.InsertCommand.Connection.Open();
        try
        {
            authorDA.Update(libraryDS.Author.Select(null, null, DataViewRowState.Added));
        }
        catch (SqlException)
        {
            MessageBox.Show("Error: Could not modify database. Try again!");
        }
        finally
        {
            libraryDS.EnforceConstraints = true;
        }
      }
    }

    public ReportRecentDS SelectLastBooks(int nb)
    {
      ReportRecentDS reportRecentDS = new ReportRecentDS();
      using (SqlConnection conn = new SqlConnection(connection_string))
      {
        using (SqlCommand command = new SqlCommand("Last_Books", conn))
        {
          command.Parameters.Add("@Number", SqlDbType.Int);
          using(SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters["@Number"].Value = nb;
            conn.Open();
            sqlDataAdapter.Fill(reportRecentDS.Book);
          }
        }
      }
      return reportRecentDS;
    }

    public ReportOrderDS SelectBooksOrder(int year)
    {
      ReportOrderDS reportOrderDS = new ReportOrderDS();
      using (SqlConnection conn = new SqlConnection(connection_string))
      {
        using (SqlCommand command = new SqlCommand("Book_Order", conn))
        {
          command.Parameters.Add("@Year", SqlDbType.Int);
          using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters["@Year"].Value = year;
            conn.Open();
            sqlDataAdapter.Fill(reportOrderDS.Order);
          }
        }
      }
      return reportOrderDS;
    }

    public AuthorInfo SelectAuthorInfo(int id)
    {
      AuthorInfo reportAuthor = new AuthorInfo();
      using (SqlConnection conn = new SqlConnection(connection_string))
      {
        using (SqlCommand command = new SqlCommand("Author_Info", conn))
        {
          command.Parameters.Add("@Id", SqlDbType.Int);
          using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters["@Id"].Value = id;
            conn.Open();
            sqlDataAdapter.Fill(reportAuthor._AuthorInfo);
          }
        }
      }
      return reportAuthor;

    }

    public void WriteLibraryInsertChapter(LibraryDataSet ds)
    {
      using (chapterDA.InsertCommand.Connection = new SqlConnection(connection_string))
      {
        chapterDA.InsertCommand.Connection.Open();
        try
        {
          chapterDA.Update(ds.Chapter.Select(null, null, DataViewRowState.Added));
        }
        catch (SqlException)
        {
          MessageBox.Show("Error: Could not modify database. Try again!");
        }
      }
    }

    public void WriteLibraryInsertBook(LibraryDataSet ds)
    {
      using (bookDA.InsertCommand.Connection = new SqlConnection(connection_string))
      {
        bookDA.InsertCommand.Connection.Open();
        try
        {
          bookDA.Update(ds.Book.Select(null, null, DataViewRowState.Added));
        }
        catch (SqlException)
        {
          MessageBox.Show("Error: Could not modify database. Try again!");
        }
      }
    }

    public void WriteLibraryEditBook(LibraryDataSet ds)
    {
      using (bookDA.UpdateCommand.Connection = new SqlConnection(connection_string))
      {
        bookDA.UpdateCommand.Connection.Open();
        try
        {
          bookDA.Update(ds.Book.Select(null, null, DataViewRowState.ModifiedCurrent));
        }
        catch (SqlException)
        {
          MessageBox.Show("Error: Could not modify database. Try again!");
        }
      }
    }

    public void WriteLibraryEditAuthor(LibraryDataSet ds)
    {
      using (authorDA.UpdateCommand.Connection = new SqlConnection(connection_string))
      {
        authorDA.UpdateCommand.Connection.Open();
        try
        {
          authorDA.Update(ds.Author.Select(null, null, DataViewRowState.ModifiedCurrent));
        }
        catch (SqlException)
        {
          MessageBox.Show("Error: Could not modify database. Try again!");
        }
      }
    }

    public void WriteLibraryEditChapter(LibraryDataSet ds)
    {
      using (chapterDA.UpdateCommand.Connection = new SqlConnection(connection_string))
      {
        chapterDA.UpdateCommand.Connection.Open();
        try
        {
          chapterDA.Update(ds.Chapter.Select(null, null, DataViewRowState.ModifiedCurrent));
        }
        catch (SqlException)
        {
          MessageBox.Show("Error: Could not modify database. Try again!");
        }
      }
    }

    public void WriteLibraryDeleteBook(LibraryDataSet ds)
    {
      using(SqlConnection connection = new SqlConnection(connection_string))
      {
        connection.Open();
        UpdateAdapters(connection);
        try
        {
           bookDA.Update(ds.Book.Select(null, null, DataViewRowState.Deleted));
        }
        catch (SqlException)
        {
           MessageBox.Show("Error: Could not modify database. Try again!");
        }
      }
    }

    public void WriteLibraryDeleteAuthor(LibraryDataSet ds)
    {
      using (SqlConnection connection = new SqlConnection(connection_string))
      {
        connection.Open();
        UpdateAdapters(connection);
        try
        {
           authorDA.Update(ds.Author.Select(null, null, DataViewRowState.Deleted));
        }
        catch (SqlException)
        {
           MessageBox.Show("Error: Could not modify database. Try again!");
        }
      }
    }

    public void WriteLibraryDeleteChapter(LibraryDataSet ds)
    {
      using (SqlConnection connection = new SqlConnection(connection_string))
      {
        connection.Open();
        UpdateAdapters(connection);
        try
        {
          chapterDA.Update(ds.Chapter.Select(null, null, DataViewRowState.Deleted));
        }
        catch (SqlException)
        {
          MessageBox.Show("Error: Could not modify database. Try again!");
        }
      }
    }

    public void InitializeAdapters()
    {
        /*       CHAPTER COMMANDS     */
      chapterDA = new SqlDataAdapter();

      chapterDA.SelectCommand = new SqlCommand("Select_Chapter");
      chapterDA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

      chapterDA.InsertCommand = new SqlCommand("Insert_Chapter");
      chapterDA.InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
      chapterDA.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id").Direction = ParameterDirection.Output;
      chapterDA.InsertCommand.Parameters.Add("@Title", SqlDbType.VarChar, 250, "Title");
      chapterDA.InsertCommand.Parameters.Add("@StartPage", SqlDbType.Int, 0, "StartPage");
      chapterDA.InsertCommand.Parameters.Add("@EndPage", SqlDbType.Int, 0, "EndPage");
      chapterDA.InsertCommand.Parameters.Add("@BookId", SqlDbType.Int, 0, "IdBook");

      chapterDA.UpdateCommand = new SqlCommand("Update_Chapter");
      chapterDA.UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
      chapterDA.UpdateCommand.Parameters.Add("@ChapterId", SqlDbType.Int, 0, "Id");
      chapterDA.UpdateCommand.Parameters.Add("@Title", SqlDbType.VarChar, 50, "Title");
      chapterDA.UpdateCommand.Parameters.Add("@StartPage", SqlDbType.Int, 0, "StartPage");
      chapterDA.UpdateCommand.Parameters.Add("@EndPage", SqlDbType.Int, 0, "EndPage");
      chapterDA.UpdateCommand.Parameters.Add("@BookId", SqlDbType.Int, 0, "IdBook");

      chapterDA.DeleteCommand = new SqlCommand("Delete_Chapter");
      chapterDA.DeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
      chapterDA.DeleteCommand.Parameters.Add("@ChapterId", SqlDbType.Int, 0, "Id");

      /*       AUTHOR COMMANDS     */
      authorDA = new SqlDataAdapter();

      authorDA.SelectCommand = new SqlCommand("Select_Author");
      authorDA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

      authorDA.InsertCommand = new SqlCommand("Insert_Author");
      authorDA.InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
      authorDA.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id").Direction = ParameterDirection.Output;
      authorDA.InsertCommand.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
      authorDA.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
      authorDA.InsertCommand.Parameters.Add("@BirthDate", SqlDbType.DateTime, 30, "BirthDate");
      authorDA.InsertCommand.Parameters.Add("@Picture", SqlDbType.Image, 0, "Picture");


      authorDA.UpdateCommand = new SqlCommand("Update_Author");
      authorDA.UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
      authorDA.UpdateCommand.Parameters.Add("@AuthorId", SqlDbType.Int, 0, "Id");
      authorDA.UpdateCommand.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
      authorDA.UpdateCommand.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
      authorDA.UpdateCommand.Parameters.Add("@BirthDate", SqlDbType.DateTime, 30, "BirthDate");
      authorDA.UpdateCommand.Parameters.Add("@Picture", SqlDbType.Image, 0, "Picture");

      authorDA.DeleteCommand = new SqlCommand("Delete_Author");
      authorDA.DeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
      authorDA.DeleteCommand.Parameters.Add("@AuthorId", SqlDbType.Int, 0, "Id");

      /*       BOOK COMMANDS     */
      bookDA = new SqlDataAdapter();

      bookDA.SelectCommand = new SqlCommand("Select_Book");
      bookDA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

      bookDA.InsertCommand = new SqlCommand("Insert_Book");
      bookDA.InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
      bookDA.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id").Direction = ParameterDirection.Output;
      bookDA.InsertCommand.Parameters.Add("@Title", SqlDbType.VarChar, 50, "Title");
      bookDA.InsertCommand.Parameters.Add("@Year", SqlDbType.Int, 0, "Year");
      bookDA.InsertCommand.Parameters.Add("@Publisher", SqlDbType.VarChar, 50, "Publisher");
      bookDA.InsertCommand.Parameters.Add("@IdAuthor", SqlDbType.Int, 0, "IdAuthor");
      bookDA.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime, 0, "Date");

      bookDA.UpdateCommand = new SqlCommand("Update_Book");
      bookDA.UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
      bookDA.UpdateCommand.Parameters.Add("@BookId", SqlDbType.Int, 0, "Id");
      bookDA.UpdateCommand.Parameters.Add("@Title", SqlDbType.VarChar, 50, "Title");
      bookDA.UpdateCommand.Parameters.Add("@Year", SqlDbType.Int, 0, "Year");
      bookDA.UpdateCommand.Parameters.Add("@Publisher", SqlDbType.VarChar, 50, "Publisher");
      bookDA.UpdateCommand.Parameters.Add("@AuthorId", SqlDbType.Int, 0, "IdAuthor");

      bookDA.DeleteCommand = new SqlCommand("Delete_Book");
      bookDA.DeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
      bookDA.DeleteCommand.Parameters.Add("@BookId", SqlDbType.Int, 0, "Id");
    }

    private void UpdateAdapters(SqlConnection conn)
    {
      bookDA.SelectCommand.Connection = conn;
      bookDA.InsertCommand.Connection = conn;
      bookDA.UpdateCommand.Connection = conn;
      bookDA.DeleteCommand.Connection = conn;

      authorDA.SelectCommand.Connection = conn;
      authorDA.InsertCommand.Connection = conn;
      authorDA.UpdateCommand.Connection = conn;
      authorDA.DeleteCommand.Connection = conn;

      chapterDA.SelectCommand.Connection = conn;
      chapterDA.InsertCommand.Connection = conn;
      chapterDA.UpdateCommand.Connection = conn;
      chapterDA.DeleteCommand.Connection = conn;
    }
  }
}
