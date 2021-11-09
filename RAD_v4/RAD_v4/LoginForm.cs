using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerObjects;

namespace BoundaryObjects
{
    class LoginForm : Form
    {
        AvailController availCtrl;

        public LoginForm(AvailController availCtrl)
        {
            this.availCtrl = availCtrl;
        }

        public LoginForm(LogoutControl logoutCtrl) : base(logoutCtrl) { }

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

        //public void Close()
        //{
        //    // close login form
        //}

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
