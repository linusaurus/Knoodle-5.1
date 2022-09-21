using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorks.Makes.System2021
{
    public class PPXX00_AWNING_LONG : SubAssemblyBase
    {
        int _counter = 1;
        public PPXX00_AWNING_LONG() : base()
        {
            
        }

        // Main contructor Method
        public override void Build()
        {
          
           m_componentParts.Add(new ComponentPart(4266,$"Frame Strut", this, 2, m_subAssemblyWidth - 2.23m));
           
          

        }

    }
}
