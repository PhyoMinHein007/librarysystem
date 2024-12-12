using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public static class UserRole
    {
        public static Library.BizO.UserRole GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("UserRole id parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.UserRole rec = Library.Cruder.UserRole.GetById(id);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Library.BizO.UserRole GetByRoleDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Role description parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.UserRole rec = Library.Cruder.UserRole.GetByRoleDescription(description);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Boolean Save(Library.BizO.UserRole rec)
        {
            if (string.IsNullOrEmpty(rec.UserRoleId))
            {
                MessageBox.Show("UserRole id parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.RoleDescription))
            {
                MessageBox.Show("Role description parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.UserRole.Save(rec);
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
                MessageBox.Show("UserRole id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.UserRole.Delete(id);
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
