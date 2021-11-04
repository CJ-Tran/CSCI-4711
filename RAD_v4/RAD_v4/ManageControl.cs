using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class ManageControl
    {
        public static EntityObjects.KeyStatus GetStatus(int s)
        {
            return ControllerObjects.DBConnector.GetStatus(s);
        }
        public static void Update(EntityObjects.KeyStatus k)
        {
            ControllerObjects.DBConnector.Save(k);
        }
    }
}
