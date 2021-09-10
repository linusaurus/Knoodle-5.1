using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace DataLayer.Entity
{
    public partial class JobSite
    {
        public int JobSiteID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Geometry Location { get; set; }
        public int? JobID { get; set; }
    }
}
