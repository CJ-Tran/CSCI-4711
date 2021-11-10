using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    static class DBConnector
    {
        public static void Initialize()
        {
            // start DB
        }

        public static User GetUser(string n, string p)
        {
            return new User(n, p);
            //putting this link for when we begin implementing the hashing algorithm
            //https://stackoverflow.com/questions/4181198/how-to-hash-a-password#10402129
        }

        public static KeyList GetKeys()
        {
            List<Key> kList = new List<Key>(); //keys from database should be placed into this list
            return new KeyList(kList);
        }

        public static bool Save(Reservation res)
        {
            return true;
        }

        public static KeyStatus GetStatus(int key)
        {
            return new KeyStatus(key);
        }

        public static void Save(KeyStatus keyStat)
        {
            // save to DB
        }

        public static void SaveLogout(string n)
        {
            // save to DB
        }
    }
}
