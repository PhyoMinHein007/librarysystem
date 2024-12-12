using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;


namespace Library.Cruder
{
    public static class MemberType
    {
        public static Library.BizO.MemberType GetById(string id)
        {
            DbModel db = new();
            Library.Entity.MemberType tmp = db.MemberTypes.FirstOrDefault(x => x.MemberTypeId == id);

            Library.BizO.MemberType rec = BuildMap.Mapper.Map<Library.Entity.MemberType,
                Library.BizO.MemberType>(tmp);

            return rec;

        }

        public static List<BizO.MemberType> GetAllMemberTypeId()
        {

            DbModel db = new();

            List<BizO.MemberType> recList = (db.MemberTypes
                .OrderBy(x => x.MemberTypeId)
                .ProjectTo<Library.BizO.MemberType>(BuildMap.Mapper.ConfigurationProvider))
                .ToList();

            return recList;
        }


        public static void Save(Library.BizO.MemberType rec)
        {
            DbModel db = new();
            Library.Entity.MemberType row = db.MemberTypes
                                        .AsTracking()
                                        .FirstOrDefault(x => x.MemberTypeId == rec.MemberTypeId);
            if (row == null)
            {
                //new
                row = BuildMap.Mapper.Map<Library.BizO.MemberType, Library.Entity.MemberType>(rec);
                db.MemberTypes.Add(row);
            }
            else
            {
                //update
                //db.Entry(row).CurrentValues.SetValues(rec);
                row.MemberTypeId = rec.MemberTypeId;
                row.MaxBookAllowed = rec.MaxBookAllowed;
                row.DaysAllowed = rec.DaysAllowed;
                db.MemberTypes.Update(row);
            }
            db.SaveChanges();
        }

        public static void Delete(string id)
        {
            DbModel db = new();
            Library.Entity.MemberType row = db.MemberTypes
                                        .AsTracking()
                                        .FirstOrDefault(x => x.MemberTypeId == id);
            if (row != null)
            {
                db.MemberTypes.Remove(row);
            }
            db.SaveChanges();
        }
    }
}
