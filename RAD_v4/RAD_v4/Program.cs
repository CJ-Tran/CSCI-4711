namespace RAD_v4
{
    /*
     * How I changed program from Console to Windows Application:
     * https://forum.openframeworks.cc/t/how-to-hide-a-console-window-when-launching-exe-file/28616
     * 
     * Deleted KRTS class and just put the StartupController.Initiate() in Program.Main()
     */
    class Program
    {
        static void Main(string[] args)
        {
            Controller.StartupController.Initiate();
        }
    }
}
