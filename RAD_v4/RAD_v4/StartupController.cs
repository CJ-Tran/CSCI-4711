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
            AvailController ac = new AvailController();
            BoundaryObjects.LoginForm lf = new BoundaryObjects.LoginForm(ac);
            lf.Open();

            DBConnector.Initialize();
        }

    }

}
