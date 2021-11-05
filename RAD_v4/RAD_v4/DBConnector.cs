using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class DBConnector : Controller
    {
        public void Initialize()
        {
            // start DB
        }

        public EntityObjects.User GetUser(string n, string p)
        {
            return new EntityObjects.User(n, p);
        }

        public EntityObjects.KeyList GetKeys()
        {
            return new EntityObjects.KeyList();
        }

        public bool Save(EntityObjects.Reservation r)
        {
            return true;
        }

        public EntityObjects.KeyStatus GetStatus(int n)
        {
            return new EntityObjects.KeyStatus(n);
        }

        public void Save(EntityObjects.KeyStatus k)
        {
            // save to DB
        }

        public void SaveLogout(string n)
        {
            // save to DB
        }
    }
}
