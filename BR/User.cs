using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public static class User
    {
        public static Library.BizO.User GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("User id parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.User rec = Library.Cruder.User.GetById(id);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Library.BizO.User GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("User name parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.User rec = Library.Cruder.User.GetByName(name);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Boolean Save(Library.BizO.User rec)
        {
            if (string.IsNullOrEmpty(rec.UserId))
            {
                MessageBox.Show("User id parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.UserName))
            {
                MessageBox.Show("User name parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.User.Save(rec);
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
                MessageBox.Show("User id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.User.Delete(id);
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
