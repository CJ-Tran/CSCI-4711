using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    class ManageKeyForm
    {
        ControllerObjects.ManageControl mc;

        public ManageKeyForm()
        {
            mc = new ControllerObjects.ManageControl();
        }

        public void Submit()
        {
            int k = 0;
            Display(mc.GetStatus(k));
        }

        public void Save()
        {
            int temp = 0;
            EntityObjects.KeyStatus k = new EntityObjects.KeyStatus(temp);
            mc.Update(k);
            Display(k);
        }

        public void Display(EntityObjects.KeyStatus k)
        {

        }
    }
}
