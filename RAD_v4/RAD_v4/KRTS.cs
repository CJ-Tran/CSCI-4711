using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerObjects;

namespace RAD_v4
{
    class KRTS
    {
        public static void Run()
        {
            StartupController sc = new StartupController();
            sc.Initiate();
        }
    }
}
