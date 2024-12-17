using AutoMapper.QueryableExtensions;
using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cruder
{
    public static class Member
    {
        public static Library.BizO.Member GetById(string id)
        {
            DbModel db = new();
            Library.Entity.Member tmp = db.Members.FirstOrDefault(x => x.MemberId == id);

            Library.BizO.Member rec = BuildMap.Mapper.Map<Library.Entity.Member,
                Library.BizO.Member>(tmp);

            return rec;

        }

        public static List<Library.BizO.Member> GetByName(string name)
        {
            DbModel db = new();
            List<Library.Entity.Member> tmp = db.Members
                                    .AsNoTracking()
                                    .Where(x => x.Name.Contains(name))
                                    .ToList();


            List<Library.BizO.Member> rec = BuildMap.Mapper.Map<List<Library.Entity.Member>,
                                           List<Library.BizO.Member>>(tmp);

            return rec;

        }

        public static void Save(Library.BizO.Member rec)
        {
            DbModel db = new();
            Library.Entity.Member row = db.Members
                                        .AsTracking()
                                        .FirstOrDefault(x => x.MemberId == rec.MemberId);
            if (row == null)
            {
                //new
                row = BuildMap.Mapper.Map<Library.BizO.Member, Library.Entity.Member>(rec);
                db.Members.Add(row);
            }
            else
            {
                //update
                db.Entry(row).CurrentValues.SetValues(rec);
            }
            db.SaveChanges();
        }

        public static void Delete(string id)
        {
            DbModel db = new();
            Library.Entity.Member row = db.Members
                                        .AsTracking()
                                        .FirstOrDefault(x => x.MemberId == id);
            if (row != null)
            {
                db.Members.Remove(row);
            }
            db.SaveChanges();
        }
    }
}
