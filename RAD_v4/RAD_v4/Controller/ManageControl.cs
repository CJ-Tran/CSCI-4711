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
