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
        public static void Reserve(string name, int key) //bool -> void
        {
            try
            {
                DBConnector.Save(new Reservation(name, key));
                RequestProcessedWin rpw = new RequestProcessedWin();
                rpw.Open(name);
            }
            catch (Exception)
            {
                //return false;
                throw new Exception("Error at RequestControl.Reserve");
            }
        }
    }
}
