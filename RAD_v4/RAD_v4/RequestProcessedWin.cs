using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Windows.Forms;

namespace Boundary
{
    class RequestProcessedWin // Delete? Pop up window can be implemented in the UI
    {
        public void Open(string name) //pass user to save logout
        {
            //opens window
            RAD_v4.RequestProcessed rp = new RAD_v4.RequestProcessed(name);
            rp.TopMost = true;
            rp.Visible = true;
        }
    }
}
