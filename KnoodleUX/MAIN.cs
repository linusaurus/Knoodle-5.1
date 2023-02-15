using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnoodleUX.UXControls;

namespace KnoodleUX
{
    public partial class MAIN : Form
    {

        public MAIN()
        {
            InitializeComponent();
            PurchaseOrderControl purchaseOrderControl = new PurchaseOrderControl();
            purchaseOrderControl.Dock= DockStyle.Fill;
            this.Controls.Add(purchaseOrderControl);
        }
    }
}
