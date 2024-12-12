using System;
using System.Collections.Generic;


namespace Library.Entity;

public partial class User : Library.Base.User
{
    public virtual List<Entity.Rental> Rentals { get; set; }


    public virtual Entity.UserRole UserRole {  get; set; }    

}
