using System;
using System.Collections.Generic;


namespace Library.Entity;

public partial class Member: Library.Base.Member
{
    public virtual Entity.MemberType MemberType { get; set; }

    public virtual List<Entity.Rental> Rentals { get; set; }

}
