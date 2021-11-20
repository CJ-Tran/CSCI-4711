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
        public EventArgs tempUName, tempPWord; 

        //AvailController availCtrl;

        //public LoginForm(AvailController availCtrl)
        //{
        //    this.availCtrl = availCtrl;
        //}

        //public LoginForm(LogoutControl logoutCtrl) : base(logoutCtrl) { }

        public LoginForm():base() 
        {

        }

        public void Open()
        {
            // opens login form
            RAD_v4.Login loginform1 = new RAD_v4.Login();
            loginform1.Visible = true;
            //this.Activate();
            //this.Show();
        }

        public void Submit()
        {
            //string n = "", p = ""; // example
            AvailController.Verify(tempUName, tempPWord);
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
