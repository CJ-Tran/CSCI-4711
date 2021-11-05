using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class RequestControl : Controller
    {
        public static bool Reserve(string n, int k)
        {
            ControllerObjects.DBConnector.Save(new EntityObjects.Reservation(n, k));
            BoundaryObjects.RequestProcessedWin.Open(n);

            return true; // no need?
        }
    }
}
