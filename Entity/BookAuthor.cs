using Library.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity
{
    public partial class BookAuthor: Library.Base.BookAuthor
    {
        public virtual Entity.Book Book { get; set; }

        public virtual Entity.Author Author { get; set; }
    }
}
