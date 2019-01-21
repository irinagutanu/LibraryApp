using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LibraryFinalProject.Model
{
    class Author
    {
        public Int32    Id          { set; get; }
        public String   FirstName   { set; get; }
        public String   LastName    { set; get; }
        public DateTime BirthDate   { set; get; }
        public Image   Picture     { set; get; }
    }
}
