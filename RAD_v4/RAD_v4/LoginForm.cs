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
        //public string tempUName, tempPWord;
        public object tempUName, tempPWord;

        public LoginForm() : base() { }

        public void Open()
        {
            // opens login form
            RAD_v4.Login loginform1 = new RAD_v4.Login();
            loginform1.Visible = true;
            loginform1.TopMost = true;
        }

        public void Submit()
        {
            //AvailController.Verify(tempUName, tempPWord);
            //Close();

            //bool valid = AvailController.Verify(tempUName.Trim(), tempPWord.Trim());
            bool valid = AvailController.Verify(tempUName, tempPWord);

            if (valid)
            {
                Application.Exit();
                Close(); // Use parent class (Form) CLose method
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
