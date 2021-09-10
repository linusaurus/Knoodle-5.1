﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class OrderFee
    {
        public int OrderfeeID { get; set; }
        public string FeeName { get; set; }
        public decimal? Qnty { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Extension { get; set; }
        public int? PurchaseOrderID { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
