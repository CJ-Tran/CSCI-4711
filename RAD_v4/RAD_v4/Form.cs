using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    public class Form
    {
        ControllerObjects.LogoutControl _lc;

        public Form(ControllerObjects.LogoutControl lc)
        {
            _lc = lc;
        }

        public void Logout()
        {
            string n = "";
            _lc.Logout(n);
            Close();
        }

        public void Close()
        {

        }
    }
}
