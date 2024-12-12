using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public static class Book
    {
        public static Library.BizO.Book GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Book id parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.Book rec = Library.Cruder.Book.GetById(id);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Library.BizO.Book GetByTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Book title parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.Book rec = Library.Cruder.Book.GetByTitle(title);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Library.BizO.Book GetByISBN(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Book ISBN parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.Book rec = Library.Cruder.Book.GetByISBN(isbn);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Boolean Save(Library.BizO.Book rec)
        {
            if (string.IsNullOrEmpty(rec.BookId))
            {
                MessageBox.Show("Book id parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.Title))
            {
                MessageBox.Show("Book Title parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.ISBN))
            {
                MessageBox.Show("Book ISBN parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.Book.Save(rec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public static Boolean Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Book id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.Book.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public static bool isAvailable(string bookId)
        {
            BizO.Book book = Cruder.Book.GetById(bookId);
            if (book.AvailabilityStatus == Flags.AvailabilityStatus.Available)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
