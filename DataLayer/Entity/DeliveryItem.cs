﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class DeliveryItem
    {
        public int DeliveryItemID { get; set; }
        public int? DeliveryID { get; set; }
        public string Description { get; set; }
        public int? ProductID { get; set; }
        public int? SubAssemblyID { get; set; }
        public int? PartID { get; set; }
        public decimal? Qnty { get; set; }
        public bool? Onboard { get; set; }
        public bool? Delivered { get; set; }
        public string ItemReferenceType { get; set; }
        public int? ItemReference { get; set; }
    }
}