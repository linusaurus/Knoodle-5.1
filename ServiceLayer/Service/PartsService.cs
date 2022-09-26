using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer;
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Numerics;


namespace ServiceLayer
{


    public class PartsService 
    {
        private readonly MosaicContext ctx;
       

        public PartsService(MosaicContext context)
        {
            ctx = context;
        }

        //private int partCount;

        //private Dictionary<int, Part> _parts = new Dictionary<int, Part>();
        //public Dictionary<int, Part> Parts { get => _parts; }
      
        //public void LoadParts()
        //{

        //    _parts = ctx.Part.ToDictionary(p => p.PartID);
        //    partCount = _parts.Count();
        //}

        //public Part GetPart(int partID)
        //{
        //    return _parts[partID];
        //}

        //public int PartCount
        //{
        //    get { return partCount; }
        //    set { partCount = value; }
        //}

        public class PartItem
        {
            public int PartID { get; set; }
            public string MaterialName { get; set; }
            public string MaterialDescription { get; set; }
            public decimal MarkUp { get; set; }
            public decimal Weight { get; set; }
            public decimal Waste { get; set; }
            public decimal UnitCost { get; set; }
            public decimal Width { get; set; }
            public decimal Height { get; set; }
            public string UnitName { get; set; }
            public int UoM { get; set; }


            public static Expression<Func<Part, PartItem>> Projection
            {
                get
                {
                    return x => new PartItem()
                    {
                        PartID = x.PartID,
                        MaterialName = x.ItemName,
                        MaterialDescription = x.ItemDescription,
                        MarkUp = x.MarkUp.GetValueOrDefault(),
                        Weight = x.Weight.GetValueOrDefault(),
                        Waste = x.Waste.GetValueOrDefault(),
                        Width = decimal.Zero,
                        Height = decimal.Zero,
                        UnitCost = x.Cost.GetValueOrDefault(),
                        UoM = x.UnitOfMeasureID.GetValueOrDefault(),
                        UnitName = x.UnitOfMeasure.UnitName
                        
                    };
                }
            }
        }

        public Dictionary<int,PartItem> PartItems()
        {
            return ctx.Part.Include(u => u.UnitOfMeasure).Select(PartItem.Projection).ToDictionary(p => p.PartID);
        }

    }
}
