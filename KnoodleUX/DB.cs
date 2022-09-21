using DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameWorks;
using System.Windows.Forms;

namespace KnoodleUX
{
    public class DB
    {

        public static void FillBuildTree(TreeView buildTree, List<FrameWorks.AssemblyBase> units)
        {
           buildTree.Nodes.Clear();
            
            if (units != null && units.Count > 0)
            {
                foreach (FrameWorks.Unit un in units)
                {
                    TreeNode node = new TreeNode(un.UnitName);
                    node.Tag = un;
                    buildTree.Nodes.Add(node);
                    foreach (FrameWorks.SubAssemblyBase sub in un.SubAssemblies)
                    {
                        TreeNode subNode = new TreeNode(sub.Name);
                        subNode.Tag = sub;
                        node.Nodes.Add(subNode);
                        foreach (ComponentPart part in sub.ComponentParts)
                        {
                            TreeNode partNode = new TreeNode();
                            partNode.Text = part.FunctionalName;
                            if (part.GetType().Name.ToString() == "LPart") partNode.BackColor = System.Drawing.Color.Goldenrod;
                            partNode.Tag = part;
                            subNode.Nodes.Add(partNode);
                        }
                    }
                }
            }


        }
    }
}
