using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public static class MemberType
    {
        public static Library.BizO.MemberType GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Member Type id parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.MemberType rec = Library.Cruder.MemberType.GetById(id);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static Boolean Save(Library.BizO.MemberType rec)
        {
            if (string.IsNullOrEmpty(rec.MemberTypeId))
            {
                MessageBox.Show("Member Type id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.MemberType.Save(rec);
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
                MessageBox.Show("Member Type id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.MemberType.Delete(id);
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
