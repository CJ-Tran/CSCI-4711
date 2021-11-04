using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    class DBConnector
    {
        public static void Initialize()
        {
            // start DB
        }

        public static EntityObjects.User GetUser(string n, string p)
        {
            return new EntityObjects.User(n, p);
        }

        public static EntityObjects.KeyList GetKeys()
        {
            return new EntityObjects.KeyList();
        }

        public static bool Save(EntityObjects.Reservation r)
        {
            return true;
        }

        public static EntityObjects.KeyStatus GetStatus(int n)
        {
            return new EntityObjects.KeyStatus(n);
        }

        public static void Save(EntityObjects.KeyStatus k)
        {
            // save to DB
        }

        public static void SaveLogout(string n)
        {
            // save to DB
        }
    }
}
