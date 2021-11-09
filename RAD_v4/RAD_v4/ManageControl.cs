using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityObjects;

namespace ControllerObjects
{
    static class ManageControl 
    {
        public static KeyStatus GetStatus(int s)
        {
            return DBConnector.GetStatus(s);
        }
        public static void Update(KeyStatus k)
        {
            DBConnector.Save(k);
        }
    }
}
