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
        private static bool _created = false;
        private string DBFolderPath = @"Data Source=C:\DB\";
        public DbSet<CutListProduct>? CutListProducts { get; set; }
        public CutlistDBContext()
        {
            if (!_created)
            {
                
                _created = true;
               //Database.EnsureDeleted();
               // Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(DBFolderPath, "CLJOB1427.db");
         
            optionsBuilder.UseSqlite(path);
            SQLitePCL.Batteries.Init();


        }
    }
}
