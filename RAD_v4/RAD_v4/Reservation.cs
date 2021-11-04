using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityObjects
{
    class Reservation
    {
        private string uName;
        private int keyID;

        public Reservation(string n, int k)
        {
            uName = n;
            keyID = k;
        }

        /* Getters & Setters */
        public string GetUName()
        {
            return uName;
        }
        public void SetUName(string name)
        {
            uName = name;
        }

        public int GetKeyID()
        {
            return keyID;
        }
        public void SetUName(int k)
        {
            keyID = k;
        }
    }
}
