using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Key
    {
        private int id;
        private char status;
        private string currentUser;
        private string previousUser;
        private byte roomNum;

        public int ID
        {
            get;
            set;
        }
        public char Status
        {
            get; set;
        }

        public string CurrentUser
        {
            get; set;
        }

        public string PreviousUser
        {
            get; set;
        }

        public byte RoomNum
        {
            get; set;
        }
    }
}
