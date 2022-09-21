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
            m_componentParts.Add(new ComponentPart(1, "Reclusive Hinge PlateLH", this, 2, this.m_subAssemblyWidth - 6.25m));
            m_componentParts.Add(new ComponentPart(1, "Reclusive Hinge PlateRH", this, 4, this.m_subAssemblyWidth - 6.25m));
        }
    }
}
