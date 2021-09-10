using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Data;
using DataLayer.Entity;

namespace ServiceLayer
{


    public class PartsService 
    {
        MosaicContext ctx = new MosaicContext();

        private int partCount;
        private Dictionary<int, Part> _parts = new Dictionary<int, Part>();
        public Dictionary<int, Part> Parts { get => _parts; }

        public void LoadParts()
        {
            _parts = ctx.Parts.ToDictionary(p => p.PartID);
            partCount = _parts.Count();
        }


        public Part GetPart(int partID)
        {
            return _parts[partID];
        }


        public int PartCount
        {
            get { return partCount; }
            set { partCount = value; }
        }

    }
}
