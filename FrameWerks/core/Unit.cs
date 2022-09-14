
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;



namespace FrameWorks
{
   [Serializable]
   public class Unit : AssemblyBase 
   {
 
      public Unit()
      {
        
      }
      public Unit(ProductDto productDto)
      {
            this.ProductID = productDto.ProductID;
            this.UnitName = productDto.UnitName;
            this.UnitDepth = productDto.D.GetValueOrDefault();
            this.UnitHeight = productDto.H.GetValueOrDefault();
            this.UnitWidth = productDto.W.GetValueOrDefault();
            this.UnitID = productDto.UnitID;
            this.ProjectInstanceName = productDto.ArchDescription;
      }

        public override void Build()
      {
            foreach (SubAssemblyBase sub in this.m_subAssemblies)
            {
               sub.Parent = this;
               sub.Build();
            }
        }
    
   }
}
