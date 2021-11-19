using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;
using System.Data.SQLite;

namespace Controller
{ 
    static class StartupController
    {
        public static void Initiate()
        {
            //AvailController ac = new AvailController();
            LoginForm lf = new LoginForm();
            lf.Open();

            // Was testing static/non-static
            DBConnector.Initialize();
            //DBConnector db = new DBConnector();
            //db.Initialize();
        }

    }

}
