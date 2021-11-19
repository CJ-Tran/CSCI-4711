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
            //AvailController ac = new AvailController();
            Application.Run(new LoginForm());
            


            // Was testing static/non-static
            DBConnector.Initialize();
            //DBConnector db = new DBConnector();
            //db.Initialize();
        }

    }

}
