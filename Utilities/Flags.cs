using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public class Flags
    {
        public enum AvailabilityStatus
        {
            Available = 0,
            RentOut = 1,
            Compensated = 2,
            NotForRentOut = 3,
            NotReturned = 4,
            Damaged = 5,
            None = 6
        }

        public enum ReturnStatus
        {
            Good = 0,
            NotReturnedYet = 1,      
            Lost = 2,         
            Overdue = 3,
            Damaged = 4,
            None = 5
        }

    }
}
