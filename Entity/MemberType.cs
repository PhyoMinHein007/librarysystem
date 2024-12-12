using System;
using System.Collections.Generic;



namespace Library.Entity;

public partial class MemberType : Library.Base.MemberType
{
    public virtual List<Entity.Member> Members { get; set; }
}
