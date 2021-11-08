using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class ManageControl : Controller
    {

        public ManageControl()
        {
            
        }

        public EntityObjects.KeyStatus GetStatus(int s)
        {
            return DBConnector.GetStatus(s);
        }
        public void Update(EntityObjects.KeyStatus k)
        {
            DBConnector.Save(k);
        }
    }
}
