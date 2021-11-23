using Controller;

namespace Boundary
{
    public class Form : System.Windows.Forms.Form
    {
        public void Logout(string name)
        {
            LogoutControl.Logout(name);
            Close();
        }
    }
}
