using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class StartupController
    {
        public static void Initiate()
        {
            BoundaryObjects.LoginForm.Open();
            ControllerObjects.DBConnector.Initialize();
        }

    }

}
