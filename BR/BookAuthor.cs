using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public class BookAuthor
    {
        public static void Save(Library.BizO.BookAuthor rec)
        {
            try
            {
                Library.Cruder.BookAuthor.Save(rec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public static void Delete(string bookId, string authorId)
        {
            try
            {
                Library.Cruder.BookAuthor.Delete(bookId, authorId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
