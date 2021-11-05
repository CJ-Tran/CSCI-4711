using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class ManageControl : Controller
    {
        DBConnector db;

        public ManageControl()
        {
            db = new DBConnector();
        }

        public EntityObjects.KeyStatus GetStatus(int s)
        {
            return db.GetStatus(s);
        }
        public void Update(EntityObjects.KeyStatus k)
        {
            db.Save(k);
        }
    }
}
