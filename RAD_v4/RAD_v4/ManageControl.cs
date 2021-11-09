using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityObjects;

namespace ControllerObjects
{
    class ManageControl : Controller
    {
        public KeyStatus GetStatus(int s)
        {
            return DBConnector.GetStatus(s);
        }
        public void Update(KeyStatus k)
        {
            DBConnector.Save(k);
        }
    }
}
