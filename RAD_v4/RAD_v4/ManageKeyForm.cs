using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerObjects;
using EntityObjects;

namespace BoundaryObjects
{
    class ManageKeyForm : Form
    {
        ManageControl mc;

        public ManageKeyForm()
        {
            mc = new ManageControl();
        }

        public void Submit()
        {
            int k = 0;
            Display(mc.GetStatus(k));
        }

        public void Save()
        {
            int temp = 0;
            KeyStatus k = new KeyStatus(temp);
            mc.Update(k);
            Display(k);
        }

        public void Display(KeyStatus k)
        {

        }
    }
}
