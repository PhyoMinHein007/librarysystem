using AutoMapper.QueryableExtensions;
using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;

namespace Library.Cruder
{
    public static class UserRole
    {
        public static Library.BizO.UserRole GetById(string id)
        {
            DbModel db = new();
            Library.Entity.UserRole tmp = db.UserRoles
                .AsNoTracking()
                .FirstOrDefault(x => x.UserRoleId == id);

            Library.BizO.UserRole rec = BuildMap.Mapper.Map<Library.Entity.UserRole,
                Library.BizO.UserRole>(tmp);

            return rec;

        }

        public static Library.BizO.UserRole GetByRoleDescription(string description)
        {
            DbModel db = new();
            Library.Entity.UserRole tmp = db.UserRoles
                                                 .AsNoTracking()
                                                 .FirstOrDefault(x => x.RoleDescription.Contains(description));
                                                 

            Library.BizO.UserRole rec = BuildMap.Mapper.Map<Library.Entity.UserRole,
                                            Library.BizO.UserRole>(tmp);

            return rec;

        }

        public static List<Library.BizO.UserRole> GetAllUserRoleId()
        {
            DbModel db = new();
            List<Library.BizO.UserRole> reclist = (db.UserRoles
                                                        .OrderBy(x => x.UserRoleId)
                                                        .ProjectTo<Library.BizO.UserRole>(BuildMap.Mapper.ConfigurationProvider))
                                                        .ToList();

            return reclist;
        }

        public static void Save(Library.BizO.UserRole rec)
        {
            DbModel db = new();
            Library.Entity.UserRole row = db.UserRoles
                                        .AsTracking()
                                        .FirstOrDefault(x => x.UserRoleId == rec.UserRoleId);
            if (row == null)
            {
                //new
                row = BuildMap.Mapper.Map<Library.BizO.UserRole, Library.Entity.UserRole>(rec);
                db.UserRoles.Add(row);
            }
            else
            {
                row.UserRoleId = rec.UserRoleId;
                row.RoleDescription = rec.RoleDescription;
                db.UserRoles.Update(row);
            }
            db.SaveChanges();
        }

        public static void Delete(string id)
        {
            DbModel db = new();
            Library.Entity.UserRole row = db.UserRoles
                                        .AsTracking()
                                        .FirstOrDefault(x => x.UserRoleId == id);
            if (row != null)
            {
                db.UserRoles.Remove(row);
            }
            db.SaveChanges();
        }

        internal static List<BizO.UserRole> GetAllUserRoles()
        {
            throw new NotImplementedException();
        }
    }
}
