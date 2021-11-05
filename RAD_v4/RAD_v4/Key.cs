using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityObjects
{
    class Key
    {
        /*
        private int id;
        private char status;
        private byte roomNum;
        private string currentUser;
        private string previousUser;
        */
        // Previous user default to blank because new keys wouldn't have a previous user
        public Key(int idP, char statusP, byte rNum, string cUser, string pUser = "")
        {
            ID = idP;
            Status = statusP;
            RoomNum = rNum;
            CurrentUser = cUser;
            PreviousUser = pUser;
        }

        /* Properties */
        // Used properties instead of getters/setters
        //Changed to auto-implemented properties (works as long as we don't need any input validation)
        public int ID { get; set; }
        public char Status { get; set; }
        public string CurrentUser { get; set; }

        public string PreviousUser { get; set; }

        public byte RoomNum { get; set; }
    }
}
