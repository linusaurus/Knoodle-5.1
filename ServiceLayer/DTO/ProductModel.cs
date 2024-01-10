using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ServiceLayer
{
    public class ProductModel 
    {
       
        public ProductModel(){}
        
        // ProductID
        public int ProductID;
        // JobID
        public int JobID;
        // JobName
        public string JobName;
        // JobID
        public string UnitName;
        // UnitID
        public int UnitID;
        // ArchDescription
        public string ArchDescription;
        // Width
        public decimal W;
        // Depth
        public decimal D;
        // Height
        public decimal H;
        // Delivered
        public bool Delivered;
        // DeliveryDate
        public DateTime DeliveryDate;
        // ProductionDate
        public string ProductionDate;
   
    }
}
