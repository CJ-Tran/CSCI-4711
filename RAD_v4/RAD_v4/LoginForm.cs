using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    class LoginForm
    {
        ControllerObjects.AvailController availCtrl;
        ControllerObjects.LogoutControl logoutCtrl; //Not sure if we need a logoutCtrl on the LoginForm

        public LoginForm(ControllerObjects.AvailController availCtrl)
        {
            this.availCtrl = availCtrl;
        }
        public LoginForm(ControllerObjects.LogoutControl logoutCtrl)
        {
            this.logoutCtrl = logoutCtrl;
        }

        public void Open()
        {
            // opens login form
        }

        public void Submit()
        {
            string n = "", p = ""; // example
            availCtrl.Verify(n, p);
            Close();
        }

        public void Close()
        {
            // close login form
        }

        public void Display(string s)
        {
            Console.WriteLine(s);
        }

        public void Display()
        {
            // displays login form on screen
        }
    }
}
