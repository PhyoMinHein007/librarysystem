using System;
using System.Collections.Generic;


namespace Library.Entity;

public partial class Rental : Library.Base.Rental
{
    public virtual Entity.Member Member { get; set; } 
    public virtual List<Entity.RentalDetail> RentalDetails { get; set;}

    public virtual Entity.User User { get; set; }
}
