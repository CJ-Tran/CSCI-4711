using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class KeyStatus
    {
        private int keyID;
        private char status;

        public KeyStatus(int k, char s = 'A')
        {
            keyID = k;
        }

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
