using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityObjects
{
    class Reservation
    {
        /* Properties */
        private string UName { get; set; }

        public int KeyID { get; set; }

        public Reservation(string n, int k)
        {
            UName = n;
            KeyID = k;
        }

        
    }
}
