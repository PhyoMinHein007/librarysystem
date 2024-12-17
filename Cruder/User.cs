using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cruder
{
    public static class User
    {
        public static Library.BizO.User GetById(string id)
        {
            DbModel db = new();
            Library.Entity.User tmp = db.Users.FirstOrDefault(x => x.UserId == id);

            Library.BizO.User rec = BuildMap.Mapper.Map<Library.Entity.User,
                Library.BizO.User>(tmp);

            return rec;

        }

        public static List<Library.BizO.User> GetByName(string name)
        {
            DbModel db = new();
            List<Library.Entity.User> tmp = db.Users
                                            .AsNoTracking()
                                            .Where(x => x.UserName.Contains(name))
                                            .ToList();


            List<Library.BizO.User> rec = BuildMap.Mapper.Map<List<Library.Entity.User>,
                                           List<Library.BizO.User>>(tmp);

            return rec;

        }

        public static void Save(Library.BizO.User rec)
        {
            DbModel db = new();
            Library.Entity.User row = db.Users
                                        .AsTracking()
                                        .FirstOrDefault(x => x.UserId == rec.UserId);
            if (row == null)
            {
                //new
                row = BuildMap.Mapper.Map<Library.BizO.User, Library.Entity.User>(rec);
                db.Users.Add(row);
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
            Library.Entity.User row = db.Users
                                        .AsTracking()
                                        .FirstOrDefault(x => x.UserId == id);
            if (row != null)
            {
                db.Users.Remove(row);
            }
            db.SaveChanges();
        }
    }
}
