using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Reservation
    {
        /* Properties */
        public string UName { get; set; } // made public so DBConnector could access

        public int KeyID { get; set; }

        public Reservation(string uName, int keyId)
        {
            this.UName = uName;
           this.KeyID = keyId;
        }

        
    }
}
