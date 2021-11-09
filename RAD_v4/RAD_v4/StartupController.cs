using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoundaryObjects;

namespace ControllerObjects
{
    class StartupController : Controller
    {
        public void Initiate()
        {
            AvailController ac = new AvailController();
            LoginForm lf = new LoginForm(ac);
            lf.Open();

            DBConnector.Initialize();
        }

    }

}
