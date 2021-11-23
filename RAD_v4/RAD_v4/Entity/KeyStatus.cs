namespace Entity
{
    public enum StatusType
    {
        Available, //0
        Pending,   //1
        Assigned   //2
    }//StatusType Enum

    class KeyStatus
    {
        /* Properties */
        public int KeyID { get; }

        public StatusType Status { get; set; }

        /* Constructor */
        public KeyStatus(int keyNum, StatusType status = StatusType.Available)// Key's status set to "Available" by default
        {
            this.KeyID = keyNum;
            this.Status = status;
        }//KeyStatus()
    }//KeyStatus class
}//namespace
