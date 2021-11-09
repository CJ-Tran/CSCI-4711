using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerObjects;

namespace BoundaryObjects
{
    class RequestKeyForm : Form
    {
        RequestControl RequestCtrl;

        public RequestKeyForm()
        {
            RequestCtrl = new RequestControl();
        }

        public void Submit()
        {
            string n = "";
            int k = 0;
            RequestControl rc = new RequestControl();
            rc.Reserve(n, k); // no need return bool (Sequence Diagram)
            Close();
        }

        //public void Close()
        //{
        //    //close request key form
        //}
    }
}
