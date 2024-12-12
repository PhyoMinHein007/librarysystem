using AutoMapper.QueryableExtensions;
using Library.Entity;
using Library.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cruder
{
    public class Rental
    {
        public static Library.BizO.Rental GetById(string id)
        {
            DbModel db = new();
            Library.BizO.Rental rec = (db.Rentals
                .Where(x => x.RentalId == id)
                .Include(x => x.RentalDetails)
                .ProjectTo<Library.BizO.Rental>(BuildMap.Mapper.ConfigurationProvider))
                .FirstOrDefault();        

            return rec;

        }

        public static Boolean Save(Library.BizO.Rental rec)
        {
            DbModel db = new();
            Library.Entity.Rental row = (db.Rentals
                .Where(x => x.RentalId == rec.RentalId)
                .Include(x => x.RentalDetails)
                ).FirstOrDefault();

            if (row == null)
            {
                row = BuildMap.Mapper.Map<Library.BizO.Rental, Library.Entity.Rental>(rec);
                db.Rentals.Add(row);
            }
            else
            {
                row.RentalId = rec.RentalId;
                row.MemberId = rec.MemberId;
                row.UserId = rec.UserId;
                row.RentalDate = rec.RentalDate;
                row.DateToReturn = rec.DateToReturn;
                row.RentalDetails = BuildMap.Mapper.Map<List<BizO.RentalDetail>, List<Entity.RentalDetail>>(rec.RentalDetails);
                db.Rentals.Update(row);
            }
            db.SaveChanges();
            return true;
        }

        public static void Delete(string id)
        {
            DbModel db = new();
            Library.Entity.Rental row = db.Rentals
                                        .AsTracking()
                                        .FirstOrDefault(x => x.RentalId == id);
            if (row != null)
            {
                db.Rentals.Remove(row);
            }
            db.SaveChanges();
        }

        

    }
}
