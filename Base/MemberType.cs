using System;
using System.Collections.Generic;



namespace Library.Base;

public partial class MemberType
{
    public string MemberTypeId { get; set; }

    public int DaysAllowed { get; set; } = 14;

    public int MaxBookAllowed { get; set; } = 3;
}
