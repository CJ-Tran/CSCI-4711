using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boundary
{
    class RequestKeyForm
    {
        public void Submit()
        {
            string n = "";
            int k = 0;
            Controller.RequestControl.Reserve(n, k); // no need return bool
            Close();
        }

        public void Close()
        {
            //close request key form
        }
    }
}
