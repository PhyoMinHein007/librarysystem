using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BizO
{
    public class Rental: Base.Rental
    {
        public List<BizO.RentalDetail> RentalDetails { get; set; }
    }
}
