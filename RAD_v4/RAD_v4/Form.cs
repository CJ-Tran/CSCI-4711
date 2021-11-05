using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    public class Form
    {
        public static void Logout()
        {
            string n = "";
            ControllerObjects.LogoutControl.Logout(n);
            Close();
        }

        public static void Close()
        {

        }
    }
}
