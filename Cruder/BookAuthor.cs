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
    public static class BookAuthor
    {
        public static List<Library.BizO.BookAuthor> GetByBookId(string id)
        {
            DbModel db = new();
            var tmpList = db.BookAuthors.Where(x => x.BookId == id).ToList();

            List<Library.BizO.BookAuthor> recList = tmpList
                .Select(tmp => BuildMap.Mapper.Map<Library.Entity.BookAuthor, Library.BizO.BookAuthor>(tmp))
                .ToList();

            return recList;
        }


        public static void Save(Library.BizO.BookAuthor rec)
        {
            DbModel db = new();

            
            var row = db.BookAuthors
                        .AsTracking()
                        .FirstOrDefault(x => x.BookId == rec.BookId && x.AuthorId == rec.AuthorId);

            if (row == null)
            {
                // New record
                row = BuildMap.Mapper.Map<Library.BizO.BookAuthor, Library.Entity.BookAuthor>(rec);
                db.BookAuthors.Add(row);
                
            }
            else
            {
                // Update existing record
                row.AuthorId = rec.AuthorId; // Update AuthorId if it can change
                row.BookId = rec.BookId;     // Update BookId if it can change
                db.BookAuthors.Update(row);                
            }

            db.SaveChanges();
        }

        public static void Delete(string bookId, string authorId)
        {
            DbModel db = new();

            var row = db.BookAuthors
                        .FirstOrDefault(x => x.BookId == bookId && x.AuthorId == authorId);

            if (row != null)
            {
                db.BookAuthors.Remove(row);
                db.SaveChanges();
            }
            
        }


    }
}
