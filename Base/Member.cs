using System;
using System.Collections.Generic;



namespace Library.Base;

public partial class Member
{
    public string MemberId { get; set; }

    public string? Name { get; set; } 
    public string? PhoneNo { get; set; } 

    public string? EMail { get; set; } 

    public string? MemberTypeId { get; set; }       //FK

    public int? CurrentRentOutCount { get; set; } = 0;

}
