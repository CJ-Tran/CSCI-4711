using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    class RequestKeyForm
    {
        public void Submit()
        {
            string n = "";
            int k = 0;
            ControllerObjects.RequestControl.Reserve(n, k); // no need return bool (Sequence Diagram)
            Close();
        }

        public void Close()
        {
            //close request key form
        }
    }
}
