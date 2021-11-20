using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Windows.Forms;

namespace Boundary
{
    class LoginForm : Form
    {
        public object tempUName, tempPWord;

        public void Open()
        {
            //opens login form
            RAD_v4.Login loginform1 = new RAD_v4.Login();
            loginform1.TopMost = true; // Make top-most before making visible
            loginform1.Visible = true;
        }

        public void Submit()
        {
            if (LoginControl.Verify(tempUName, tempPWord))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
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
