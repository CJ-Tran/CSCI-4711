using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class DBConnector
    {
        public static void Initialize()
        {
            // start DB
        }

        public static Entity.User GetUser(string n, string p)
        {
            return new Entity.User(n, p);
        }

        public static Entity.KeyList GetKeys()
        {
            return new Entity.KeyList();
        }

        public static bool Save(Entity.Reservation r)
        {
            return true;
        }

        public static Entity.KeyStatus GetStatus(int n)
        {
            return new Entity.KeyStatus(n);
        }

        public static void Save(Entity.KeyStatus k)
        {
            // save to DB
        }

        public static void SaveLogout(string n)
        {
            // save to DB
        }
    }
}
