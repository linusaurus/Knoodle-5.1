#region Copyright (c) 2007 WeaselWare Software
/************************************************************************************
'
' Copyright  2007 WeaselWare Software 
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
' Portions Copyright 2007 WeaselWare Software
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
using System.Runtime;

namespace FrameWorks.Makes.System3000
{
   
   public class DividedDoorLayout
   {

      readonly decimal RAIL_WIDTH = 1.3125m;
      readonly decimal STOP_WIDTH = 0.75m;
      readonly decimal MULLION_WIDTH = 1.0m;
      
      private decimal m_h;
      private decimal m_winSpace;
      private decimal m_doubler;
      private decimal m_topStop;
      private decimal m_botStop;
      private decimal m_glassHieght;  

      public DividedDoorLayout(decimal H)
      {
         m_h = H;

      }
      
      public decimal TopStopLength
      {
         get{
            m_topStop = decimal.Zero;
            m_topStop = m_h - ((Doubler - (RAIL_WIDTH * 2.0m)));
            return Math.Round(m_topStop,4);
        }
      }
      public decimal BottomStopLength
      {
         get{
            m_botStop = decimal.Zero ;
            m_botStop = Doubler;
            return Math.Round(m_botStop,4) ;
         }
      } 
      public decimal WindowSpace
      {
      
         get{
         
            decimal result = decimal.Zero;
            result = (RAIL_WIDTH * 2.0m) + (STOP_WIDTH * 2.0m) + (MULLION_WIDTH * 2.0m);
            m_winSpace = decimal.Divide(( m_h - result),3.0m);
            return Math.Round(m_winSpace,4);
         }
      }
      public decimal Doubler
      {
         get
         {
            m_doubler = decimal.Zero;
            m_doubler = WindowSpace + (MULLION_WIDTH);

            return Math.Round(m_doubler, 4);
         }
      }
      public decimal GlassHieght
      {
         get{
            m_glassHieght = decimal.Zero;
            m_glassHieght = m_h - ((RAIL_WIDTH * 2.0m) + (0.125m * 2.0m));
            return Math.Round(m_glassHieght,4);
         
         }
      }





   }
}