using System;
using System.Collections.Generic;
using static Library.Utilities.Flags;

namespace Library.Base;

public partial class Book
{
    public string BookId { get; set; }

    public string? Title { get; set; } 

    public string? ISBN { get; set; }

    public string? Publisher { get; set; } 

    public string? YearPublished { get; set; } 

    public string? CatId { get; set; }  //FK

    public AvailabilityStatus AvailabilityStatus { get; set; }

}
