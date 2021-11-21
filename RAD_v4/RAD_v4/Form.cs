using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Windows.Forms;

namespace Boundary
{
    public class Form : System.Windows.Forms.Form
    {
        public void Logout(string name)
        {
            LogoutControl.Logout(name);
            Close();
        }
    }
}
