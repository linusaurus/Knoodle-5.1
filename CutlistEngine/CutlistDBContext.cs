using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CutlistEngine
{
    public class CutlistDBContext : DbContext
    {
        public DbSet<CutListProduct> CutListProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(@"Data Source=C:\DB\", "CL1479.db");
         
            optionsBuilder.UseSqlite(path);
            SQLitePCL.Batteries.Init();


        }
    }
}
