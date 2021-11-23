using System;
using System.Windows.Forms;

namespace RAD_v4
{
    public partial class RequestProcessedWin : Form
    {
        string name;

        public RequestProcessedWin(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Controller.LogoutControl.Logout(name);
            Close();
        }
    }
}
