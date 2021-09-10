using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Delivery
    {
        public int DeliveryID { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? JobID { get; set; }
        public int? EmployeeID { get; set; }
        public int? ItemCount { get; set; }
        public int? JobSiteID { get; set; }
    }
}
