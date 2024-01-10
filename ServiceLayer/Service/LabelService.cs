using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.DTO;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using SQLitePCL;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entity;
using Neodynamic.SDK.Printing;
using System.Data;

namespace ServiceLayer.Service
{
    public class LabelService
    {
       
        public LabelService()
        {
            
        }

        public static string ProductLabelData(int productID)
        {
         
            using (var ctx = new MosaicContext("Data Source=DBSERVER;Initial Catalog=Mosaic;Integrated Security=True"))
            {
                    var nuts = ctx.Product.Where(c => c.ProductID == productID).Include(j => j.Job).AsNoTracking().Select(p => new ProductModel
                    {
                        ProductID = p.ProductID,
                        JobID = p.JobID.GetValueOrDefault(),
                        ArchDescription = p.ArchDescription,
                        ProductionDate = DateTime.Now.ToShortDateString(),
                        D = p.D.GetValueOrDefault(),
                        W = p.W.GetValueOrDefault(),
                        H = p.H.GetValueOrDefault(),
                        JobName = p.Job.jobname,
                        Delivered = false,
                       // DeliveryDate = DateTime.MinValue,
                        UnitID = p.UnitID.GetValueOrDefault(),
                        UnitName = p.UnitName,

                    }).First();

                return SerializeToXml(nuts);
            }
          
        }

        private static string  SerializeToXml(ProductModel input)
        {
            XmlSerializer ser = new XmlSerializer(typeof(ProductModel));
            string result = string.Empty;

            using (MemoryStream memStm = new MemoryStream())
            {
                ser.Serialize(memStm, input);

                memStm.Position = 0;
                result = new StreamReader(memStm).ReadToEnd();
            }

            return result;
        }

        public static ThermalLabel GenerateProductLabel(DataSet ds)
        {

            ThermalLabel tLabel = new ThermalLabel();
            tLabel.LoadXmlTemplate(System.IO.File.ReadAllText("24ProductLabel.tl"));
            tLabel.DataSource = ds;
            return tLabel;
        }


        //MemoryStream stream = new MemoryStream();
        //StreamWriter tr = new StreamWriter(@"C:\temp\out.xml");
        //XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProductModel));
        //xmlSerializer.Serialize(stream, model);
        //return doc;
    }
}
