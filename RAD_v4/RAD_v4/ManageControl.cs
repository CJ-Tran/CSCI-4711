using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ManageControl
    {
        public static Entity.KeyStatus GetStatus(int s)
        {
            return Controller.DBConnector.GetStatus(s);
        }
        public static void Update(Entity.KeyStatus k)
        {
            Controller.DBConnector.Save(k);
        }
    }
}
