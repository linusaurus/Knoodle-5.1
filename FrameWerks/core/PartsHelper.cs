using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWorks
{
   
   public class RectSize
   {
      public decimal W;
      public decimal H;
   }
   
   
   
   public class ComponentsHelper
   {
     
   

      public static List<ComponentPart> TrackMaker(SubAssemblyBase subassembly, int PanelCount,int positions, TrackConfiguration configuration)
       {
            List<ComponentPart> result = new List<ComponentPart>();

            switch (configuration)
	        {
		    case TrackConfiguration.Telescoping:
            
            #region Track Blades
                    
            for (int i = 0; i < PanelCount; i++)
			{
            
            ComponentPart p = new ComponentPart(3345,"Blade-" + i.ToString(),subassembly,1,subassembly.SubAssemblyWidth + 3.0m);
            result.Add(p);
			}
                    
                    
            #endregion

           

            break;

            case TrackConfiguration.BiComponenting:
            break;

            default:
            break;
	        }


            return result;
       }


      
   }
}
