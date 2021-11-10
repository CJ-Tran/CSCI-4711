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
        private string UName { get; set; }

        public int KeyID { get; set; }

        public Reservation(string uName, int keyId)
        {
            this.UName = uName;
           this.KeyID = keyId;
        }

        
    }
}
