using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Windows.Forms;

namespace Boundary
{
    class MainMenu
    {
        public void Open(User u, KeyList kList)
        {
            // opens main menu
            RAD_v4.MMenu mm = new RAD_v4.MMenu();
            mm.AddKeys(u, kList);
            mm.Refresh();
            mm.TopMost = true;
            mm.Visible = true;
        }
    }
}
