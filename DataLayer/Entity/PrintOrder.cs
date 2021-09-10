using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entity
{
    public partial class PrintOrder
    {
        public int employeeID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string jobname { get; set; }
        public int LineID { get; set; }
        public int? PartID { get; set; }
        public decimal? Qnty { get; set; }
        public decimal? UnitCost { get; set; }
        public string Description { get; set; }
        public decimal? Extended { get; set; }
        public string FeeName { get; set; }
        public int OrderfeeID { get; set; }
        public decimal? Expr1 { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Extension { get; set; }
        public string SupplierName { get; set; }
        public string Address1 { get; set; }
        public int SupplierID { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Zip { get; set; }
        public string Fax { get; set; }
        public string AccountNumber { get; set; }
        public double? TaxRate { get; set; }
        public int Expr3 { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public string SalesRep { get; set; }
        public int? ShipID { get; set; }
        public decimal? OrderTotal { get; set; }
        public bool? Recieved { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? Tax { get; set; }
    }
}
