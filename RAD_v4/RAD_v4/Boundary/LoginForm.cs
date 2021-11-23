using Controller;
using System;
using System.Windows.Forms;

namespace RAD_v4
{
    public partial class LoginForm : Form // UserControl -> Form
    {
        public object tempUName, tempPWord;

        public void Submit()
        {
            if (LoginControl.Verify(tempUName, tempPWord))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");

                //reopens login form
                this.TopMost = true;
                this.Visible = true;
            }
        }

        /*
         * Got rid of Display(string s), Display(), Open() methods
         */

        /* UI Elements */
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click_1(object sender, EventArgs e)
        {
            Submit();
            Close();
        }

        private void UNameInput_TextChanged(object sender, EventArgs e)
        {
            tempUName = sender;
        }

        private void PWordInput_TextChanged(object sender, EventArgs e)
        {
            tempPWord = sender;
        }

        private void UNameLabel_Click(object sender, EventArgs e) { }

        private void PasswordLabel_Click(object sender, EventArgs e) { }

        private void Login_Load(object sender, EventArgs e) { }
    }
}
