using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    class LoginForm
    {
        public static void Open()
        {
            // opens login form
        }

        public static void Submit()
        {
            string n = "", p = ""; // example
            ControllerObjects.AvailController.Verify(n, p);
            Close();
        }

        public static void Close()
        {
            // close login form
        }

        public static void Display(string s)
        {
            Console.WriteLine(s);
        }

        public static void Display()
        {
            // displays login form on screen
        }
    }
}
