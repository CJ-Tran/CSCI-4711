namespace Entity
{
    public class User
    {
        /* Properties */
        public string UName { get; private set; } //username

        /*
         * Account Type
         *    Admin = 1
         *    Customer = 0
         * Made public to get User type
         */
        public AcctType Type { get; private set; }

        public enum AcctType
        {
            Customer = 0,
            Admin = 1
        }//acct type enumeration (this can be int casted)

        /* Constructor */
        public User(string username, AcctType type = AcctType.Customer) //default user is type customer
        {
            this.UName = username;
            this.Type = type;
        }//User()
    }
}
