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

        private decimal materialThickness = 0.73m;
        private decimal backThickness = 0.5m;
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
            Component.ComponentThick = materialThickness;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);

            // Right Side
            Component = new ComponentPart(2878, "RSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = materialThickness;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);

            // Bottom
            Component = new ComponentPart(2878, "Bottom ", this, 1, this.SubAssemblyWidth - (materialThickness * 2), SubAssemblyDepth);
            Component.ComponentThick = materialThickness;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);
            //Top
            Component = new ComponentPart(2878, "Top", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = materialThickness;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);

            Component = new ComponentPart(2878, "Nailers", this, 2, 4.0m, this.SubAssemblyWidth - 1.5m);
            Component.ComponentThick = materialThickness;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);
            // Back
            Component = new ComponentPart(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            Component.ComponentWidth = this.SubAssemblyWidth - 1.0m;
            Component.ComponentThick = backThickness;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);

            // Pounds test
            Component = new ComponentPart(3049, "Nailer", this,2, 2.0m, this.SubAssemblyWidth - 1.5m);
            Component.ComponentThick = materialThickness;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);

            this.ComponentParts.Add(new ComponentPart(2893, "21-Runner", this, 1, 0.0m));
            // Drawers 3
            Component = new ComponentPart(34, "Maple Drawer Box", this, 1, 22.0m);
            Component.ComponentThick = 6.0m;
            Component.ComponentWidth = this.SubAssemblyWidth - 0.625m;
            this.ComponentParts.Add(Component);

            #endregion

            #region Labor

           
            Component.UOM = 11;
            this.ComponentParts.Add(Component);

            #endregion

            //refresh internals
            foreach (FrameWorks.ComponentPart p in this.ComponentParts)
            {
                // needed to tickle the cost forcing calculation
                decimal d = p.Area;
                m_calculatedCost += p.CalculatedCost;
            }

        }
    }

   


}