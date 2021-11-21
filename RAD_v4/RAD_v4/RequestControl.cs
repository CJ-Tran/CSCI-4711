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
        public static bool Reserve(string name, int key)
        {
            try
            {
                bool valid = DBConnector.Save(new Reservation(name, key));
                if (valid)
                {
                    RequestProcessedWin rpw = new RequestProcessedWin();
                    rpw.Open(name);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw new Exception("Error at RequestControl.Reserve");
            }



        }
    }
}
