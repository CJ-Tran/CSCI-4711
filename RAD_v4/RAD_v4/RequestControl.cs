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
        public static void Reserve(string uName, int key)
        {
            RequestProcessedWin rpw = new RequestProcessedWin();

            DBConnector.Save(new Reservation(uName, key));
            rpw.Open(uName);
        }
    }
}
