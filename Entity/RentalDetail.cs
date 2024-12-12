using System;
using System.Collections.Generic;


namespace Library.Entity;

public partial class RentalDetail : Library.Base.RentalDetail
{
    public virtual Entity.Rental Rental { get; set; }

    public virtual Entity.Book Book { get; set; }
    
}
