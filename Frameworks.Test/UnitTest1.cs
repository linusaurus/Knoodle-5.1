using CutlistEngine;
using SQLitePCL;

namespace Frameworks.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CutlistDBContext ctx = new CutlistDBContext("1225");
           
            ctx.Database.EnsureCreated();
            for (int i = 0; i < 400; i++)
            {

            CutListProduct prod = new CutListProduct();
            prod.ProductID = i;
            prod.JobId = 1407;
            prod.Tax = 0.023m;
            prod.Markup = 0.5m;
            prod.ProductName = "Something long winded and creepy";
            prod.CutlistID = new Guid();
            prod.FunctionName = "RHWindow Handle";
            prod.PartID = 1;
            ctx.CutListProducts.Add(prod);

            }

            ctx.SaveChanges();
        }

        [TestMethod]
        public void TextShouldCreateDB_With_FilePath()
        {
            var db = DBFactory.GetDbContext("1216");
            Assert.IsTrue(db.Database.CanConnect());
        }
    }
}