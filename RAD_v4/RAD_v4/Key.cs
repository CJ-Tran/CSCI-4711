using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Key // public to help add
    {
        /* Properties */
        public int ID { get; set; }

        public StatusType Status { get; set; }

        public string CurrentUser { get; set; }

        public string PreviousUser { get; set; }

        public int RoomNum { get; set; }

        // Previous user default to blank because new keys wouldn't have a previous user
        public Key(int idP, StatusType statusP, int rNum, string cUser, string pUser = "")
        {
            ID = idP;
            Status = statusP;
            RoomNum = rNum;
            CurrentUser = cUser;
            PreviousUser = pUser;
        }

        
    }
}
