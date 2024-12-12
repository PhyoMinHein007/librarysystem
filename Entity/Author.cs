using Library.Base;
using System;
using System.Collections.Generic;

namespace Library.Entity;

public partial class Author: Library.Base.Author
{
    public virtual List<Entity.BookAuthor> BookAuthors { get; set; }

}
