using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Controller
{
    static class ManageControl 
    {
        public static KeyStatus GetStatus(int keyId)
        {
            return DBConnector.GetStatus(keyId);
        }
        public static void Update(KeyStatus kStat)
        {
            DBConnector.Save(kStat); //need to pass keyId to DBConnector since connector is static
        }
    }
}
