using Library.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cruder
{
    public static class Book
    {
        public static Library.BizO.Book GetById(string id)
        {
            DbModel db = new();
            Library.Entity.Book tmp = db.Books.FirstOrDefault(x => x.BookId == id);

            Library.BizO.Book rec = BuildMap.Mapper.Map<Library.Entity.Book,
                Library.BizO.Book>(tmp);

            return rec;

        }

        public static Library.BizO.Book GetByTitle(string title)
        {
            DbModel db = new();
            Library.Entity.Book tmp = db.Books.FirstOrDefault(x => x.Title.Contains(title));


            Library.BizO.Book rec = BuildMap.Mapper.Map<Library.Entity.Book,
                                           Library.BizO.Book>(tmp);

            return rec;

        }

        public static Library.BizO.Book GetByISBN(string isbn)
        {
            DbModel db = new();
            Library.Entity.Book tmp = db.Books.FirstOrDefault(x => x.ISBN == isbn);


            Library.BizO.Book rec = BuildMap.Mapper.Map<Library.Entity.Book,
                                           Library.BizO.Book>(tmp);

            return rec;

        }

        public static void Save(Library.BizO.Book rec)
        {
            DbModel db = new();
            Library.Entity.Book row = db.Books
                                        .AsTracking()
                                        .FirstOrDefault(x => x.BookId == rec.BookId);
            if (row == null)
            {
                //new
                row = BuildMap.Mapper.Map<Library.BizO.Book, Library.Entity.Book>(rec);
                db.Books.Add(row);
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
            Library.Entity.Book row = db.Books
                                        .AsTracking()
                                        .FirstOrDefault(x => x.BookId == id);
            if (row != null)
            {
                db.Books.Remove(row);
            }
            db.SaveChanges();
        }
    }
}
