using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;

namespace Controller
{
    static class StartupController
    {
        public static void Initiate()
        {
            //AvailController ac = new AvailController();
            LoginForm lf = new LoginForm();
            lf.Open();

            DBConnector.Initialize();
            //DBConnector db = new DBConnector();
            //db.Initialize();
        }

    }

}
