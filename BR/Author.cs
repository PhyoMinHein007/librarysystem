using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public static class Author
    {
        public static Library.BizO.Author GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Author id parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.Author rec = Library.Cruder.Author.GetById(id);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }          
        }

        public static List<Library.BizO.Author> GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Author name parameter must not be empty");
                return null;
            }
            try
            {
                List<Library.BizO.Author> rec = Library.Cruder.Author.GetByName(name);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Boolean Save(Library.BizO.Author rec)
        {
            if (string.IsNullOrEmpty(rec.AuthorId))
            {
                MessageBox.Show("Author id parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.AuthorName))
            {
                MessageBox.Show("Author name parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.Author.Save(rec);                
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
                MessageBox.Show("Author id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.Author.Delete(id);
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
