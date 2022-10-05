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
       
        private string DBFolderPath = @"Data Source=C:\DB\";
        private string path;
        private string con;
        public DbSet<CutListProduct>? CutListProducts { get; set; }

 
        public CutlistDBContext(string? filePath)
        {
           path = Path.Combine(DBFolderPath, filePath);
           con = $"{path}.db";

        }

        public CutlistDBContext(DbContextOptions<CutlistDBContext> options)
            : base(options)
        {
            
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(con);
                SQLitePCL.Batteries.Init();
            }
        }

        
    }
}
