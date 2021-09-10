﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class Claim
    {
        public int ClaimID { get; set; }
        public int? SupplierID { get; set; }
        public int? OrderNum { get; set; }
        public string SupplierOrder { get; set; }
        public DateTime? ClaimDate { get; set; }
        public int? EmployeeID { get; set; }
    }
}