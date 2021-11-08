using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class RequestControl : Controller
    {
        public bool Reserve(string n, int k)
        {
            BoundaryObjects.RequestProcessedWin rpw = new BoundaryObjects.RequestProcessedWin();

            DBConnector.Save(new EntityObjects.Reservation(n, k));
            rpw.Open(n);

            return true; // no need?
        }
    }
}
