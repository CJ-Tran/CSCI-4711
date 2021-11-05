using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class StartupController : Controller
    {
        public void Initiate()
        {
            BoundaryObjects.LoginForm lf = new BoundaryObjects.LoginForm();
            lf.Open();

            DBConnector dc = new DBConnector();
            dc.Initialize();
        }

    }

}
