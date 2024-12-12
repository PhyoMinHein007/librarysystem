using Library.Entity;
using System;
using System.Collections.Generic;

namespace Library.Entity;

public partial class Book: Library.Base.Book
{

    public virtual List<Entity.BookAuthor> BookAuthors { get; set; }
    public virtual Entity.BookCategory BookCategory { get; set; }

    public virtual List<Entity.RentalDetail> RentalDetails { get; set; }
}
