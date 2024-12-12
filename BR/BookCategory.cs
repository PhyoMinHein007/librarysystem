using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public static class BookCategory
    {
        public static Library.BizO.BookCategory GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Book Category id parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.BookCategory rec = Library.Cruder.BookCategory.GetById(id);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Library.BizO.BookCategory GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Category name parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.BookCategory rec = Library.Cruder.BookCategory.GetByName(name);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Boolean Save(Library.BizO.BookCategory rec)
        {
            if (string.IsNullOrEmpty(rec.CatId))
            {
                MessageBox.Show("Category id parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.CatName))
            {
                MessageBox.Show("Category name parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.BookCategory.Save(rec);
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
                MessageBox.Show("Category id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.BookCategory.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }


}
