#region Copyright (c) 2022 WeaselWare Software
/************************************************************************************
'
' Copyright  2022 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2022 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Diagnostics.Metrics;
using FrameWorks.Core;

namespace FrameWorks
{
    public class ComponentNotFoundException : System.Exception
    {
        public ComponentNotFoundException()
        {
            // Add implementation.
        }
        public ComponentNotFoundException(string message) 
            : base(message)
        {
            // Add implementation.
        }
        public ComponentNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }

    
 
    public class ComponentPart
   {

      #region Fields

      protected decimal unitPrice;
      protected string componentName;
      protected decimal unitSpecificAmount;
        //this requires the lookup and a Component number
      protected ServiceLayer.PartsService.PartItem m_source;
      protected decimal componentWidth = 0.0m;
      protected decimal componentThick = 0.0m;
      protected decimal componentLength = 0.0m;
      protected string functionalName;
      protected string componentGroupType;
      protected decimal sourceWaste = 0.0m;
      protected decimal sourceMarkup = 0.0m;
      //----------------------------------------------
      protected SubAssemblyBase parentAssembly;
      protected decimal area;
      protected string componentLabel = string.Empty;
      protected string componentIdentifier = string.Empty;
      protected int unitOfMeasureID = 0;
      protected string unitOfMeasureName = string.Empty;
      protected decimal weight;
      protected decimal waste = 0.0m;
      protected decimal markup = 0.0m;
      protected int supplierID;
      protected int partID;
      

      #endregion

      #region Contructors

 

      public ComponentPart()
      {

      }

      public ComponentPart(int sourceID)
      {
         if(sourceID == -1)
         {
            m_source = new ServiceLayer.PartsService.PartItem();
           
         } 
         else
         {      
                this.m_source = FrameWorks.PartDictionary.PartLookup[sourceID];         
                unitOfMeasureID = m_source.UoM;
                unitOfMeasureName = m_source.UnitName;
                partID = m_source.PartID;
                waste = m_source.Waste ;
                markup = m_source.MarkUp;
                unitPrice = m_source.UnitCost;
 
          }

        }


        public ComponentPart(int sourceID, string functionalName, SubAssemblyBase parent,int Quantity, decimal calculatedLength)
      {
         if (sourceID == -1)
         {
            m_source = new ServiceLayer.PartsService.PartItem();
         }
         else
         {
             try
             {
                this.m_source = FrameWorks.PartDictionary.PartLookup[sourceID];
                    unitOfMeasureID = m_source.UoM;
                    unitOfMeasureName = m_source.UnitName;
                    partID = m_source.PartID;
                    waste = m_source.Waste;
                    markup = m_source.MarkUp;
                    unitPrice = m_source.UnitCost;
                
                    //this.ComponentLabel = $"{parent.ProductID.ToString()}-{parent.SubAssemblyID}-{Globals.counter++}";
                }
             catch 
             {
                 ComponentNotFoundException ex = new ComponentNotFoundException(String.Format("Source Part {0} does not exist",sourceID.ToString()));
                 throw ex;
             }
             
         }

         
         this.functionalName = functionalName;
         //this.parent = parentAssembly;
         this.componentLength = calculatedLength;
         this.Qnty = Quantity ;

      }

        public ComponentPart(int sourceID, string functionalName, SubAssemblyBase parent, int Quantity, decimal calculatedLength, string PartGroupType)
        {
            
            if (sourceID == -1)
            {
                m_source = new ServiceLayer.PartsService.PartItem();
            }
            else
            {
                try
                {
                    this.m_source = FrameWorks.PartDictionary.PartLookup[sourceID];                  
                    unitOfMeasureID = m_source.UoM;
                    unitOfMeasureName = m_source.UnitName;
                    partID = m_source.PartID;
                    waste = m_source.Waste;
                    markup = m_source.MarkUp;
                    unitPrice = m_source.UnitCost;
                    this.ComponentLabel = $"{parent.ProductID.ToString()}-{parent.SubAssemblyID}-{Globals.counter++}";
                }
                catch
                {
                    ComponentNotFoundException ex = new ComponentNotFoundException(String.Format("Source Part {0} does not exist", sourceID.ToString()));
                    throw ex;
                }

            }


            this.functionalName = functionalName;
            //this.parent = parentAssembly;
            this.componentLength = calculatedLength;
            this.Qnty = Quantity;
            this.componentGroupType = PartGroupType;

        }

        public ComponentPart(int sourceID, string functionalName, SubAssemblyBase parent, int Quantity, decimal calculatedLength,decimal width)
      {
          if (sourceID == -1)
          {
              m_source = new ServiceLayer.PartsService.PartItem();

          }
          else
          {
              try
              {
                  this.m_source = FrameWorks.PartDictionary.PartLookup[sourceID];
                    unitOfMeasureID = m_source.UoM;
                    unitOfMeasureName = m_source.UnitName;
                    partID = m_source.PartID;
                    waste = m_source.Waste;
                    markup = m_source.MarkUp;
                    unitPrice = m_source.UnitCost;
                    this.ComponentLabel = $"{parent.ProductID.ToString()}-{parent.SubAssemblyID}-{Globals.counter++}";
                }
              catch
              {
                  ComponentNotFoundException ex = new ComponentNotFoundException("Component ID = does not exist");
                  throw ex;
              }

          }


          this.functionalName = functionalName;
          this.parentAssembly = parent;
          this.componentLength = calculatedLength;
          this.m_Qnty = Quantity;
          this.ComponentWidth = width;

      }
      
      #endregion
      [Category("Component Specification")]
      public string ComponentType
     { get { return componentGroupType; } set { componentGroupType = value; } }
     
      
      [Category("Material")]
      public decimal UnitPrice
      { 
          get 
          {
             unitPrice = m_source.UnitCost;          
             return unitPrice; 
          } 
          set 
          { 
              unitPrice = value; 
          } 
      }
      
      #region Properties

      [Category("Material")]
      public int SupplierID
      {
          get { return supplierID; }
          set { supplierID = value; }
      }
      [Category("Material")]
      public decimal Waste
      {
          get 
          {
              if (m_source.Waste != decimal.Zero)
              {
                  decimal qty = decimal.Parse(m_Qnty.ToString());
                  switch (m_source.UoM)
                  {

                      //--- Each-------------------------------------------------------------------
                      case 1:
                          {
                              this.waste = qty * m_source.Waste;
                              break;
                          }
                      //--- Foot
                      case 2:
                          {
                              this.waste = Math.Round((decimal)((this.componentLength / 12) * Qnty) * m_source.Waste,2);
                              break;
                          }
                      //--- lbs
                      case 3:
                          {
                              this.waste = (decimal)((this.componentLength / 12) * Qnty) * m_source.Waste;
                              break;
                          }
                      //--- Qts
                      case 4:
                          {
                              this.waste = (decimal)((this.componentLength / 12) * Qnty) * m_source.Waste;
                              break;
                          }
                      //--- Inch
                      case 6:
                          {
                              this.waste = (this.componentLength * Qnty) * m_source.Waste;
                              break;
                          }
                      //--- Pair
                      case 7:
                          {
                              this.waste = (this.componentLength * Qnty) * m_source.Waste;
                              break;
                          }
                      // Sqft
                      case 8:
                          {
                              this.waste = Math.Round((((this.componentLength * this.ComponentWidth) / 144) * qty) * m_source.Waste,2);
                              break;
                          }

                      //--- Sq Inch
                      case 9:
                          {

                              this.waste = (this.Area * qty) * m_source.Waste;
                              break;
                          }
                      //--- Bdft
                      case 10:
                          {

                              this.waste = (this.Area * qty) * m_source.Waste;
                              break;
                          }

                  }
                 
              }
              else
              {
                    waste = decimal.Zero;
              }
              return Math.Round(waste, 2);
          }
          set 
          {
                waste = value ;
          }
      }
      [Category("Material")]
      public decimal MarkUp
      {
          get 
          {
              if (this.GetType().ToString() == "FrameWorks.LComponent")
              {
                 return 0.0m;
              }
              return m_source.MarkUp; 
          }
          set { markup = value; }
      }
      [Category("Component Specification")]
      public decimal Area
      {
         get
         {
             decimal m_area = decimal.Zero;
             switch (this.UOM)
                 {
                 case 8:
                     {
                      if (componentWidth > 0.0m && componentLength > 0.0m)
                        {
                            m_area = (componentLength * componentWidth);
                            m_area = m_area / 144;
                            m_area = Math.Round(m_area, 4);
                        }
                        break;
                     }
                 case 9:
                     {
                         if (componentWidth > 0.0m)
                         {
                             m_area = (componentLength * componentWidth);
                             m_area = Math.Round(m_area, 4);
                         }
                        break;
                     }
                 }

             return m_area;
         } 
        
       }
    
      public decimal Weight
      {
          get 
          {
              switch(m_source.UoM ) 
             {
            
                //--- Each
                case 1 :
                {
                this.weight   = (this.m_Qnty  * m_source.Weight);
                break;
                }
                //--- Foot
                case 2:
                {
                    this.weight =((this.componentLength / 12)* Qnty) * m_source.Weight;
                    break;
                }
                //--- Inch
                case 6:
                {
                    this.weight =((this.componentLength)* Qnty) * m_source.Weight;
                    break;
                }
                //--- Pair
                case 7:
                {
                    
                    this.weight = Math.Round(Qnty * m_source.Weight, 4);
                    break;
                }
                //--- Sqft
                case 8:
                {
                    decimal area = (decimal)this.Area;
                    if (this.Area  > 0.0m)
                    {
                        this.weight = Math.Round(((area) * Qnty) * m_source.Weight,4);
                        
                    }

                    break;
                }
                //--- Sq Inch
                case 9:
                {

                    this.weight = (this.Area * Qnty) * m_source.Weight;
                    break;
            }
       
                }
            return this.weight; 
         }
          
          set { weight = value ;}
      }
      [Category("Material")]
      public int UOM 
      { 
        get 
        {
            if ( this.Source !=null )
            {
              unitOfMeasureID = this.Source.UoM ;
            }
            return unitOfMeasureID; 
        }
      
        set 
        {
                unitOfMeasureID = value;
        } 
       }

        [Category("Material")]
        public string UnitOfMeasureName
        {
            get { return unitOfMeasureName; }
            set { unitOfMeasureName = value; }
        }
      
       public string ComponentLabel
       {
         get{
             
             return componentLabel;
         }
         set{componentLabel = value;}
       
       }


 
      [Category("Component Specification")]
      private int m_Qnty;
      [Category("Component Specification")]
      private decimal m_calculatedCost = decimal.Zero ;
      [Category("Component Specification")]
      public virtual decimal CalculatedCost
      {
        get {
        
        switch(m_source.UoM ) 
        {
            
            //--- Each
            case 1:
            {
                    this.m_calculatedCost = Math.Round((decimal)(m_Qnty * m_source.UnitCost),2);
                    break;
             }
            //--- Foot
            case 2:
            {
                    decimal cs = (decimal)(this.componentLength / 12) *  Convert.ToDecimal(Qnty) * m_source.UnitCost;
                    this.m_calculatedCost = Math.Round(cs, 2);
                    break;
            }
            //--- Inch
            case 6:
            {
                    this.m_calculatedCost =(decimal) (this.componentLength  *  Convert.ToDecimal(Qnty)  *  m_source.UnitCost);
                    break;
            }
            //--- Pair
            case 7:
            {
                    this.m_calculatedCost = Math.Round((decimal)(m_Qnty * m_source.UnitCost),2);
                    break;
            }
            //--- Square Foot
            case 8:
            {
                decimal cs = (decimal)((this.Area  * m_source.UnitCost));
                this.m_calculatedCost = Math.Round(cs,2);
                break;
            }
            //--- Sq Inch
            case 9:
            {
             
                this.m_calculatedCost = (decimal)((this.Area  * Qnty) * m_source.UnitCost) ;
                break;
            }
            //--- Bdft
            case 10:
            {

                this.m_calculatedCost = (decimal)((this.Area * Qnty) * m_source.UnitCost);
                break;
            }
       
        }
            return Math.Round(m_calculatedCost,2); 
         }
         
      }
      [Category("Component Specification")]
      public int Qnty
      {
         get { return m_Qnty; }
         set { m_Qnty = value; }
      }
      [Category("Material")]
      public string ComponentName
      {
         get { return componentName; }
         set { componentName = value; }
      }

      public void LoadComponent()
      {

      }

      [Category("Component Specification")]
      public SubAssemblyBase ContainerAssembly
      {
         get { return parentAssembly; }
         set {parentAssembly = value; }
      }

      [Category("Material")]
      public virtual ServiceLayer.PartsService.PartItem Source
      {
         get { return m_source; }
         set { m_source = value; }

      }
      [Category("Component Specification")]
      public virtual string FunctionalName
      {
         get { return functionalName; }
         set { functionalName =value; }
      }
      [Category("Component Specification")]
      public string ComponentGroupType
      {
         get { return componentGroupType; }
         set { componentGroupType = value; }

      }
      [Category("Dimension")]
      public decimal ComponentWidth
      {
         get { return componentWidth; }
         set { componentWidth = value; }
      }
      [Category("Dimension")]
      public decimal ComponentLength
      {
         get { return componentLength; }
         set { componentLength  = value; }

      }
      [Category("Dimension")]
      public decimal ComponentThick
      {
         get { return componentThick; }
         set { componentThick = value; }
      }

      #endregion

      #region Methods

      public virtual object Clone()
      {
         Component newComponent =(Component)this.MemberwiseClone();
         return newComponent;
      }

      private decimal ConvertToUomAmount(int UoM, FrameWorks.ComponentPart Component)
      {
          decimal result = decimal.Zero;
          switch (this.UOM)
          {
              case 1:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              case 2:
                  {
                      result = Convert.ToDecimal(this.ComponentLength / 12);
                      break;
                  }
              case 3:
                  {
                      result = Convert.ToDecimal(this.Weight);
                      break;
                  }
              case 4:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              case 5:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              case 6:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              case 7:
                  {
                      result = Convert.ToDecimal(this.Qnty / 2);
                      break;
                  }
              case 8:
                  {
                      result = Convert.ToDecimal(this.Qnty * this.Area);
                      break;
                  }
              case 9:
                  {
                      result = Convert.ToDecimal(this.Qnty * this.Area);
                      break;
                  }
              case 10:
                  {
                      if (this.ComponentThick != decimal.Zero)
                      {
                        result = Convert.ToDecimal(this.Qnty * this.Area * this.ComponentThick);
                      }
                      else
                      {
                          result = Convert.ToDecimal(this.Qnty * this.Area);
                      }
                      
                      break;
                  }
              case 11:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              default:
                  break;
          }

          return result;
      }

      #endregion

     
   }
}
