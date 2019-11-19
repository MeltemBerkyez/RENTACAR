using RENTACAR.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RENTACAR.ORM.Context
{
    class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-QAORR5D;Database=RENTACAR;uid=sa;pwd=123456;";
        }
        public DbSet<Arabalar> Cars { get; set; }
        public DbSet<Musteriler> Customers { get; set; }
        public DbSet<Kİralama> Rents { get; set; }
    }
}
