using System;
using System.Collections.Generic;


namespace Library.Entity;

public partial class UserRole : Library.Base.UserRole
{
    public virtual List<User> Users { get; set; }
}
