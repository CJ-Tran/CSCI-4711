using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    class LoginForm
    {
        ControllerObjects.AvailController _ac;
        ControllerObjects.LogoutControl _lc;

        public LoginForm(ControllerObjects.AvailController ac)
        {
            _ac = ac;
        }
        public LoginForm(ControllerObjects.LogoutControl lc)
        {
            _lc = lc;
        }

        public void Open()
        {
            // opens login form
        }

        public void Submit()
        {
            string n = "", p = ""; // example
            _ac.Verify(n, p);
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
