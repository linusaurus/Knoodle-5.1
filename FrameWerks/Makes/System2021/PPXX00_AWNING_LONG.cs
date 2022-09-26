using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorks.Makes.System2021
{
    public class PPXX00_AWNING_LONG : SubAssemblyBase
    {
        
        public PPXX00_AWNING_LONG() : base()
        {
            
        }

        // Main contructor Method
        public override void Build()
        {
           
           m_componentParts.Add(new ComponentPart(4266,$"Frame Strut", this, 2, m_subAssemblyWidth - 2.23m));
           m_componentParts.Add(new ComponentPart(4266, $"Lock Set", this, 2, m_subAssemblyWidth - 2.23m));
           m_componentParts.Add(new ComponentPart(4266, $"Dumb Suck", this, 2, m_subAssemblyWidth - 2.23m));

        }

    }
}
