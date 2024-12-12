using System;
using System.Collections.Generic;
using static Library.Utilities.Flags;


namespace Library.Base;

public partial class RentalDetail
{
    public string RentalId { get; set; }    //FK

    public string BookId { get; set; }      //FK

    public bool? IsReturned {  get; set; } 

    public DateTime ReturnDate { get; set; }

    public ReturnStatus ReturnStatus { get; set; }   

}
