using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerObjects
{
    static class DBConnector
    {
        public static void Initialize()
        {
            // start DB
        }

        public static EntityObjects.User GetUser(string n, string p)
        {
            return new EntityObjects.User(n, p);
            //putting this link for when we begin implementing the hashing algorithm
            //https://stackoverflow.com/questions/4181198/how-to-hash-a-password#10402129
        }

        public static EntityObjects.KeyList GetKeys()
        {
            List<EntityObjects.Key> kList = new List<EntityObjects.Key>(); //keys from database should be placed into this list
            return new EntityObjects.KeyList(kList);
        }

        public static bool Save(EntityObjects.Reservation res)
        {
            return true;
        }

        public static EntityObjects.KeyStatus GetStatus(int key)
        {
            return new EntityObjects.KeyStatus(key);
        }

        public static void Save(EntityObjects.KeyStatus keyStat)
        {
            // save to DB
        }

        public static void SaveLogout(string n)
        {
            // save to DB
        }
    }
}
