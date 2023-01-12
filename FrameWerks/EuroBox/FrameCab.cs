using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.EuroBox
{
    [Serializable]
    public class FrameCab : FrameWorks.SubAssemblyBase
    {
        public FrameCab() { }

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
            this.ComponentParts.Add(Component);

            // Right Side
            Component = new ComponentPart(2878, "RSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);

            // Bottom
            Component = new ComponentPart(2878, "Bottom ", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);
            //Top
            Component = new ComponentPart(2878, "Top", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);
            // Back
            Component = new ComponentPart(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            Component.ComponentWidth = this.SubAssemblyWidth - 1.0m;
            Component.ComponentThick = 0.25m;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);

   
            this.ComponentParts.Add(new ComponentPart(2893, "21-Runner", this, 1, 22.0m));

            #endregion

            #region Labor

          
            this.ComponentParts.Add(Component);
            #endregion

            foreach (FrameWorks.ComponentPart p in this.ComponentParts)
            {
                // needed to tickle the cost forcing calculation
                decimal d = p.Area;
                m_calculatedCost += p.CalculatedCost;
            }

        }
    }
    [Serializable]
    public class EuroCab : FrameWorks.SubAssemblyBase
    {
        public EuroCab() { }

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
            this.ComponentParts.Add(Component);

            // Right Side
            Component = new ComponentPart(2878, "RSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);

            // Bottom
            Component = new ComponentPart(2878, "Bottom ", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);
            //Top
            Component = new ComponentPart(2878, "Top", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);
            // Back
            Component = new ComponentPart(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            Component.ComponentWidth = this.SubAssemblyWidth - 1.0m;
            Component.ComponentThick = 0.25m;
            Component.ComponentGroupType = "Case";
            this.ComponentParts.Add(Component);


            this.ComponentParts.Add(new ComponentPart(2893, "21-Runner", this, 1, 22.0m));

            #endregion

            #region Labor

           
            
            #endregion

            foreach (FrameWorks.ComponentPart p in this.ComponentParts)
            {
                // needed to tickle the cost forcing calculation
                decimal d = p.Area;
                m_calculatedCost += p.CalculatedCost;
            }

        }
    }



}