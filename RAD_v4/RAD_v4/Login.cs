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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignInButton_click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello, {UsernameTextbox}, your password is {PasswordTextbox}?");
        }

    }
}
