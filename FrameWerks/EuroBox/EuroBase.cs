using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.EuroBox
{
   [Serializable()]
    public class EuroBase : FrameWorks.SubAssemblyBase
    {
       public EuroBase() {}

        public override string ToString()
        {
            return this.Name;
        }

        public override void Build()
        {

            FrameWorks.ComponentPart Component;

            #region Case

            // Left Side
            Component = new ComponentPart(2878, "LSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Right Side
            Component = new ComponentPart(2878, "RSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Bottom
            Component = new ComponentPart(2878, "Bottom ", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);
            //Top
            Component = new ComponentPart(2878, "Top", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            Component = new ComponentPart(2878, "Nailers", this, 2, 4.0m, this.SubAssemblyWidth - 1.5m);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);
            // Back
            Component = new ComponentPart(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            Component.ComponentWidth = this.SubAssemblyWidth - 1.0m;
            Component.ComponentThick = 0.25m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Pounds test
            Component = new ComponentPart(3049, "Nailer", this,2, 2.0m, this.SubAssemblyWidth - 1.5m);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Test
            Component = new ComponentPart(795, "Extrusion", this, 1, this.SubAssemblyHieght - 1.0m);
            Component.ComponentWidth = this.SubAssemblyWidth - 1.0m;
            Component.ComponentThick = 1.25m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);
            // Glass Door
            Component = new ComponentPart(3122, "Glass Door", this, 1, this.SubAssemblyHieght );
            Component.ComponentWidth = this.SubAssemblyWidth ;
            Component.ComponentThick = .625m;
            Component.ComponentGroupType = "Glass";
            this.Components.Add(Component);


            this.Components.Add(new ComponentPart(2893, "21-Runner", this, 1, 0.0m));

            #endregion

            #region Labor

           
            Component.UOM = 11;
            this.Components.Add(Component);

            #endregion

            //refresh internals
            foreach (FrameWorks.ComponentPart p in this.Components)
            {
                // needed to tickle the cost forcing calculation
                decimal d = p.Area;
                m_calculatedCost += p.CalculatedCost;
            }

        }
    }

   


}