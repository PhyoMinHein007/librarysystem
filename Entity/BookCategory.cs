using System;
using System.Collections.Generic;

namespace Library.Entity;

public partial class BookCategory: Library.Base.BookCategory
{
    public virtual List<Entity.Book> Books { get; set; }
}
