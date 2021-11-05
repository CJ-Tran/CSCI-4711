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
        private StatusType status;

        public enum StatusType
        {
            Available, //0
            Pending, //1
            Assigned //2
        }

        // Key's status set to "Available" by default
        public KeyStatus(int k, StatusType s = StatusType.Available)
        {
            keyID = k;
            status = s;
        }

        /* Properties */
        public int KeyID { get; }

        public StatusType Status { get; set; }
    }
}
