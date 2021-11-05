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
            DBConnector db = new DBConnector();
            BoundaryObjects.RequestProcessedWin rpw = new BoundaryObjects.RequestProcessedWin();

            db.Save(new EntityObjects.Reservation(n, k));
            rpw.Open(n);

            return true; // no need?
        }
    }
}
