using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorks.Makes.System3090
{
    public class XXPS_SLIDING_DOOR : SubAssemblyBase
    {
        public XXPS_SLIDING_DOOR() 
        {
           
        }

        public override void Build()
        {
            // Frame --
            ComponentPart m_p = new ComponentPart(1244, "Stile", this, 1, SubAssemblyWidth + 12.0m);
            m_p.ComponentGroupType = "Frame";
            m_componentParts.Add(m_p);
            
        }
    }
}
