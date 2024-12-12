using System;
using System.Collections.Generic;


namespace Library.Base;

public partial class Rental
{
    public string RentalId { get; set; } 

    public DateTime RentalDate { get; set; } 

    public string MemberId { get; set; }    //FK

    public DateTime DateToReturn { get; set; } 

    public string UserId { get; set; }  //FK
}
