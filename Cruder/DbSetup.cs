using Library.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Cruder
{
    public static class DbSetup
    {
        public static void CreateDb()
        {
            DbModel db = new DbModel();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
        
    }
}
