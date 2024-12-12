using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Mapper
{
    public static class StatusMapper
    {
        public static Flags.AvailabilityStatus MapReturnToAvailability(Flags.ReturnStatus returnStatus)
        {
            return returnStatus switch
            {
                Flags.ReturnStatus.Good => Flags.AvailabilityStatus.Available,
                Flags.ReturnStatus.NotReturnedYet => Flags.AvailabilityStatus.RentOut,
                Flags.ReturnStatus.Lost => Flags.AvailabilityStatus.Compensated,
                Flags.ReturnStatus.Overdue => Flags.AvailabilityStatus.NotReturned,
                Flags.ReturnStatus.Damaged => Flags.AvailabilityStatus.Damaged,
                _ => Flags.AvailabilityStatus.None
            };
        }
    }

}
