using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CutlistEngine
{
    public class DBFactory
    {


        public static CutlistDBContext? GetDbContext(String filepath)
        {
            CutlistDBContext db = new CutlistDBContext(filepath);
            db.Database.EnsureCreated();
            return db;
        }

    }
}
