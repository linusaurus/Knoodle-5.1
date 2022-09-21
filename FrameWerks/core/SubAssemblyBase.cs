#region Copyright (c) 2021 WeaselWare Software
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
' Portions Copyright 2008 WeaselWare Software
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
using FrameWorks;
using ServiceLayer;

namespace FrameWorks 
{
  
    public abstract class SubAssemblyBase 
   {

        #region Fields

        protected int m_productID;
        protected int m_subAssemblyID;
    
        protected AssemblyBase m_parent;
        protected List<ComponentPart> m_componentParts = new List<ComponentPart>();
        protected string m_makeFileName;
        protected string m_subAssemblyName;
        protected decimal m_subAssemblyWidth;
        protected decimal m_subAssemblyHieght;
        protected decimal m_subAssemblyDepth;
        protected decimal m_calculatedCost;
        protected static int m_counter;
        protected decimal m_area;
        protected decimal m_perimeter;
        protected decimal m_weight;

        protected List<SubAssemblyBase> m_childSubAssembly = new List<SubAssemblyBase> ();

        protected FrameWorks.Workorder m_workorder;

   
        #endregion

        public static SubAssemblyBase FactoryNew(SubAssemblyDTO Criteria)
        {
           
           SubAssemblyBase newAssembly = null;          
           Type t = Type.GetType(Criteria.MakeFile.ToString());
        
           try
           {
               if (t != null)
               {
                    newAssembly = (SubAssemblyBase)Activator.CreateInstance(t, true);

                    if (newAssembly != null)// Makefile not found 
                    {                
                    newAssembly.ProductID = Criteria.ProductID;
                    newAssembly.SubAssemblyID = Criteria.SubAssemblyID;
                    newAssembly.m_subAssemblyName = Criteria.SubAssemblyName;
                    newAssembly.SubAssemblyWidth = Criteria.W.GetValueOrDefault();
                    newAssembly.m_subAssemblyHieght = Criteria.H.GetValueOrDefault();
                    newAssembly.SubAssemblyDepth = Criteria.D.GetValueOrDefault();
                    newAssembly.ModelID = Criteria.MakeFile.ToString();
                    }
                    else
                    {
                        // log to the console window
                        Console.Write($"{t} not found or mispelled");
                    }


                }

           }
           catch (Exception e)
           {
                string msg =  String.Format("Makefile {0} no match found",Criteria.ToString() );              
                throw;
           }
           return newAssembly;            
       }

       public override string ToString()
       {
           return m_subAssemblyID.ToString();
       }


      #region Constructor

      public SubAssemblyBase()
      {
   
        
      }

     
      public List<SubAssemblyBase> ChildSubAssemblies
      {
          get { return m_childSubAssembly; }
          set { m_childSubAssembly = value; }
      }
      
      #endregion

      public FrameWorks.Workorder WorkOrder
      { get { return m_workorder; } set { m_workorder = value ; } }

           
      public int CreateID
      {
         get{return m_counter;}
      }

      public decimal SquareFootPrice
      {
          get
          {
                return Math.Round( Decimal.Divide(CalculatedCost, this.m_area), 2);
          }
      }
      
      public  decimal CalculatedCost
      {
          get
          {
              decimal _cost = decimal.Zero;
              foreach (ComponentPart component in this.m_componentParts)
              {
                  decimal per = component.CalculatedCost;
                  _cost += component.CalculatedCost;

              }
              m_calculatedCost = _cost;
              return m_calculatedCost;
          }
      }

        /// <summary>
        /// TODO replace with reference to a selfcalculationg WORKORDER object
        /// </summary>
   
      public decimal Weight
      {
         get 
         {
            decimal w = decimal.Zero;

             //foreach (FrameWorks.ComponentPart p in this.Components)
             //{
             //    w += p.Weight;
             //}
             return Math.Round(w,2);
         }
         set { m_weight = value; }
      }

      public decimal Area
      {
         get {
                decimal result = decimal.Zero;
                result = Math.Round(((m_subAssemblyWidth * m_subAssemblyHieght)/144),2);
                m_area = result;
                return m_area;
          }
         
      }

      public decimal Perimeter
      {
         get
         {
            m_perimeter = decimal.Zero;
            m_perimeter = (m_subAssemblyWidth * 2.0m) + (m_subAssemblyHieght * 2.0m) + (m_subAssemblyDepth * 2.0m);
            return Math.Round(m_perimeter,2);
         }
      }

      
      #region SubAssemblyBase Members
      
      public int SubAssemblyID
      {
         get{return m_subAssemblyID;}
         set{m_subAssemblyID = value;}
      }

      public AssemblyBase Parent
      {
         get{return m_parent ;}
         set{ m_parent = value;}
      }

        public int ProductID
        {
            get{return m_productID;}
            set{m_productID = value;}
        }
        /// <summary>
        /// Refactored Parts Name
        /// </summary>
      public List<ComponentPart> ComponentParts
      {
         get { return m_componentParts; }
      } 

      public string ModelID
      {
          get {return this.GetType().ToString() ;}
          //get {return makeFileName; }
         set{m_makeFileName = value;}
      }
      public string Name
      {
         get { return m_subAssemblyName ; }
         set { m_subAssemblyName = value;}
      }
      public decimal SubAssemblyWidth
      {
         get { return m_subAssemblyWidth; }
         set { m_subAssemblyWidth = value; }
      }
      public decimal SubAssemblyHieght
      {
         get { return m_subAssemblyHieght; }
         set { m_subAssemblyHieght = value; }
      }
      public decimal SubAssemblyDepth
      {
         get { return m_subAssemblyDepth; }
         set { m_subAssemblyDepth = value; }
      }

      
       // public ProductDto ParentAssembly { get => parentAssembly; set => parentAssembly = value; }

        #endregion

        #region Methods

        // This is overidden with each Makefile Instance Class
        public virtual void Build(){}
         
      #endregion

   }
}
