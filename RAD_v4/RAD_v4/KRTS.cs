using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_v4
{
    class KRTS
    {
        public static void Run()
        {
            ControllerObjects.StartupController sc = new ControllerObjects.StartupController();
            sc.Initiate();
        }
    }
}
