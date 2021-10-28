using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class RequestControl
    {
        public static bool Reserve(string n, int k)
        {
            Controller.DBConnector.Save(new Entity.Reservation(n, k));
            Boundary.RequestProcessedWin.Open(n);

            return true; // no need?
        }
    }
}
