using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryFinalProject.Model
{
    class Book
    {
        public Guid     BookId      { set; get; }
        public Guid     AuthorId    { set; get; } 
        public String   Title       { set; get; }
        public Int32    Year        { set; get; }
        public String   Publisher   { set; get; }
        public DateTime Date        { set; get; }
    }
}
