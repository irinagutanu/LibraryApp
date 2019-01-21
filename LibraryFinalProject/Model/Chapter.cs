using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryFinalProject.Model
{
    class Chapter
    {
        public Int32    ChapterId   { set; get; }
        public Int32    BookId      { set; get; }
        public String   Title       { set; get; }
        public Int16    StartPage   { set; get; }
        public Int16    EndPage     { set; get; }
    }
}
