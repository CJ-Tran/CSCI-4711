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

            LoginForm lf = new LoginForm();
            lf.Open();
            Application.Run(); //leave .Run() empty to loop
        }

    }

}
