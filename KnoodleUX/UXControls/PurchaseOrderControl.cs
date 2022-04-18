using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Data;

namespace KnoodleUX.UXControls
{
    internal class PurchaseOrderControl : Control
    {
        private readonly MosaicContext _ctx;

        public PurchaseOrderControl(MosaicContext context)
        {
            _ctx = context;
        }
    }
}
