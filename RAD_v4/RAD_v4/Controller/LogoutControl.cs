namespace Controller
{
    public static class LogoutControl
    {
        public static void Logout(string name)
        {
            DBConnector.SaveLogout(name);
            DBConnector.Initialize(); //reinitialize db to open a new connection

            /* Opens login form */
            RAD_v4.LoginForm loginform1 = new RAD_v4.LoginForm()
            {
                TopMost = true,
                Visible = true
            };
        }
    }
}
