using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class StartupController
    {
        public static void Initiate()
        {
            Boundary.LoginForm.Open();
            Controller.DBConnector.Initialize();
        }

    }

}
