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
    public static class BookCategory
    {
        public static Library.BizO.BookCategory GetById(string id)
        {
            DbModel db = new();
            Library.Entity.BookCategory tmp = db.Categories.FirstOrDefault(x => x.CatId == id);

            Library.BizO.BookCategory rec = BuildMap.Mapper.Map<Library.Entity.BookCategory,
                Library.BizO.BookCategory>(tmp);

            return rec;

        }

        public static Library.BizO.BookCategory GetByName(string name)
        {
            DbModel db = new();
            Library.Entity.BookCategory tmp = db.Categories.FirstOrDefault(x => x.CatName.Contains(name));
                                                

            Library.BizO.BookCategory rec = BuildMap.Mapper.Map<Library.Entity.BookCategory,
                                           Library.BizO.BookCategory>(tmp);

            return rec;

        }

        public static List<Library.BizO.BookCategory> GetAllCategory()
        {
            DbModel db = new();
            List<Library.BizO.BookCategory> reclist = (db.Categories
                                                        .OrderBy(x => x.CatId)
                                                        .ProjectTo<Library.BizO.BookCategory>(BuildMap.Mapper.ConfigurationProvider))
                                                        .ToList();

            return reclist;
        }

        public static void Save(Library.BizO.BookCategory rec)
        {
            DbModel db = new();
            Library.Entity.BookCategory row = db.Categories
                                        .AsTracking()
                                        .FirstOrDefault(x => x.CatId == rec.CatId);
            if (row == null)
            {
                //new
                row = BuildMap.Mapper.Map<Library.BizO.BookCategory, Library.Entity.BookCategory>(rec);
                db.Categories.Add(row);
            }
            else
            {
                //update
                //db.Entry(row).CurrentValues.SetValues(rec);
                row.CatName = rec.CatName;
                db.Categories.Update(row);
            }
            db.SaveChanges();
        }

        public static void Delete(string id)
        {
            DbModel db = new();
            Library.Entity.BookCategory row = db.Categories
                                        .AsTracking()
                                        .FirstOrDefault(x => x.CatId == id);
            if (row != null)
            {
                db.Categories.Remove(row);
            }
            db.SaveChanges();
        }
    }
}
