using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAD_v4
{
    public partial class Login : Form // changed to Form, from UserControl
    {
        Boundary.LoginForm tempLoginForm = new Boundary.LoginForm(); // Used to pass changed uName and pWord to LoginForm

        public Login()
        {
            InitializeComponent();
        }

        private void SignInButton_Click_1(object sender, EventArgs e)
        {
            tempLoginForm.Submit();
            //MessageBox.Show($"Hello {UNameInput.Text}, your password is {PWordInput.Text}?");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.Visible = true;
            //this.Show();
        }

        private void UNameInput_TextChanged(object sender, EventArgs e)
        {

            tempLoginForm.tempUName = e;

        }

        private void PWordInput_TextChanged(object sender, EventArgs e)
        {

            tempLoginForm.tempPWord = e;

        }

        private void UNameLabel_Click(object sender, EventArgs e) { }

        private void PasswordLabel_Click(object sender, EventArgs e) { }
    }
}
