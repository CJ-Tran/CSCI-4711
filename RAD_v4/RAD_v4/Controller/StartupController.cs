using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Controller
{
    static class StartupController
    {
        public static void Initiate()
        {
            //Had to Initialize DB first to save values
            DBConnector.Initialize();

            /* Opens login form */
            RAD_v4.LoginForm loginform1 = new RAD_v4.LoginForm()
            {
                TopMost = true,
                Visible = true
            };

            Application.Run(); //leave .Run() empty to loop
        }

    }

}
