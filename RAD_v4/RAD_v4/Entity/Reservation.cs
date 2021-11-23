namespace Entity
{
    class Reservation
    {
        /* Properties */
        public string UName { get; set; } // made public so DBConnector could access

        public int KeyID { get; set; }

        /* Constructor */
        public Reservation(string name, int keyId)
        {
            this.UName = name;
            this.KeyID = keyId;
        }
    }
}
