using Entity;
using RAD_v4;
//using System.Windows.Forms;

namespace Boundary
{
    /* Picks which form to open */
    class MainMenu : Form
    {
        public void Open(User u, KeyList kList)
        {
            if (u.Type == User.AcctType.Customer)
            {
                RequestKeyForm rkf = new RequestKeyForm(u, kList);
            }
            else
            {
                ManageKeyForm mkf = new ManageKeyForm(u, kList)
                {
                    TopMost = true,
                    Visible = true
                };
            }
            Close();
        }
    }
}
