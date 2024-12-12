using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public static class Member
    {
        public static Library.BizO.Member GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Member id parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.Member rec = Library.Cruder.Member.GetById(id);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Library.BizO.Member GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Member name parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.Member rec = Library.Cruder.Member.GetByName(name);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Boolean Save(Library.BizO.Member rec)
        {
            if (string.IsNullOrEmpty(rec.MemberId))
            {
                MessageBox.Show("Member id parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.Name))
            {
                MessageBox.Show("Member name parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.Member.Save(rec);
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
                MessageBox.Show("Member id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.Member.Delete(id);
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
