using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public enum StatusType
    {
        Available, //0
        Pending, //1
        Assigned //2
    }//StatusType Enum

    class KeyStatus
    {
        /* Properties */
        public int KeyID { get; }

        public StatusType Status { get; set; }


        // Key's status set to "Available" by default
        public KeyStatus(int keyNum, StatusType status = StatusType.Available)
        {
            this.KeyID = keyNum;
            this.Status = status;
        }//KeyStatus()
    }//KeyStatus class
}//namespace
