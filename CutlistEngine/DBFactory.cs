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
        public async static Task<CutlistDBContext> GetDbContext(String filepath)
        {
            CutlistDBContext db = new CutlistDBContext(filepath);
            await db.Database.EnsureCreatedAsync();
            return db;
        }

    }
}
