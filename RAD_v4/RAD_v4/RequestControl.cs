using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boundary;
using Entity;

namespace Controller
{
    static class RequestControl
    {
        public static void Reserve(string n, int k)
        {
            RequestProcessedWin rpw = new RequestProcessedWin();

            DBConnector.Save(new Reservation(n, k));
            rpw.Open(n);

            //return true; // no need?
        }
    }
}
