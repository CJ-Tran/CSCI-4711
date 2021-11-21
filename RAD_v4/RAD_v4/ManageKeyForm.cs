using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Entity;

namespace Boundary
{
    class ManageKeyForm : Form
    {
        //ManageControl mc;

        public ManageKeyForm()
        {
            //mc = new ManageControl();
        }

        public void Submit()
        {
            int k = 0;
            Display(ManageControl.GetStatus(k));
        }

        public void Save()
        {
            int temp = 0;
            KeyStatus k = new KeyStatus(temp);
            ManageControl.Update(k);
            Display(k);
        }

        //public void Close() { }

        public void Display(KeyStatus k)
        {

        }
    }
}
