using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityObjects
{
    class KeyStatus
    {
        private int keyID;
        private char status;

        // Key's status set to "Available" by default
        public KeyStatus(int k, char s = 'A')
        {
            keyID = k;
        }

        /* Getters & Setters */
        public int GetKeyID()
        {
            return keyID;
        }
        public void SetUName(int k)
        {
            keyID = k;
        }

        public int GetStatus()
        {
            return status;
        }
        public void SetStatus(char s)
        {
            status = s;
        }
    }
}
