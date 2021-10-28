using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boundary
{
    class Form
    {
        public static void Logout()
        {
            string n = "";
            Controller.LogoutControl.Logout(n);
            Close();
        }

        public static void Close()
        {

        }
    }
}
