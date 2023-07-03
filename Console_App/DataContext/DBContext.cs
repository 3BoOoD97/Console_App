using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_App.Model;

namespace Console_App.DataContext
{
     class DBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FRE0R4E\SQLEXPRESS01;Initial Catalog=args;Integrated Security=True; TrustServerCertificate=True");
        }

        public DbSet<argClass> argTable { get; set; }
    }
}
