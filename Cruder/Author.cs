using AutoMapper.QueryableExtensions;
using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cruder
{
    public static class Author
    {
        public static Library.BizO.Author GetById(string id)
        {
            DbModel db = new();
            Library.Entity.Author tmp = db.Authors
                .AsNoTracking()
                .FirstOrDefault(x => x.AuthorId == id);

            Library.BizO.Author rec = BuildMap.Mapper.Map<Library.Entity.Author, 
                Library.BizO.Author>(tmp);

            return rec;
               
        }

        public static List<Library.BizO.Author> GetByName(string name)
        {
            DbModel db = new();
            List<Library.Entity.Author> tmp = db.Authors
                                                 .AsNoTracking()
                                                 .Where(x => x.AuthorName.Contains(name))
                                                 .ToList();

            List<Library.BizO.Author> rec = BuildMap.Mapper.Map<List<Library.Entity.Author>,
                                            List<Library.BizO.Author>>(tmp);

            return rec;

            //return (db.Authors
            //         .Where(x => x.AuthorName.Contains(name))
            //         .ProjectTo<Library.BizO.Author>(BuildMap.Mapper.ConfigurationProvider))
            //         .ToList();

        }

        public static List<Library.BizO.Author> GetAllAuthors()
        {
            DbModel db = new();
            List<Library.BizO.Author> reclist = (db.Authors
                                                        .OrderBy(x => x.AuthorId)
                                                        .ProjectTo<Library.BizO.Author>(BuildMap.Mapper.ConfigurationProvider))
                                                        .ToList();


            return reclist;

        }

        public static void Save(Library.BizO.Author rec)
        {
            DbModel db = new();
            Library.Entity.Author row = db.Authors
                                        .AsTracking()
                                        .FirstOrDefault(x => x.AuthorId == rec.AuthorId);
            if(row == null)
            {
                //new
                row = BuildMap.Mapper.Map<Library.BizO.Author, Library.Entity.Author>(rec);
                db.Authors.Add(row);        
            }
            else
            {
                //update
                //db.Entry(row).CurrentValues.SetValues(rec);
                row.AuthorName = rec.AuthorName;
                row.EMail = rec.EMail;
                db.Authors.Update(row);
            }
            db.SaveChanges();           
        }

        public static void Delete(string id)
        {
            DbModel db = new();
            Library.Entity.Author row = db.Authors
                                        .AsTracking()
                                        .FirstOrDefault(x => x.AuthorId == id);
            if (row != null)
            {
                db.Authors.Remove(row);
            }
            db.SaveChanges();
        }
    }
}
