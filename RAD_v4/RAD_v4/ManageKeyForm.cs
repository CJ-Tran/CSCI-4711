using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryObjects
{
    class ManageKeyForm
    {
        public static void Submit()
        {
            int k = 0;
            Display(ControllerObjects.ManageControl.GetStatus(k));
        }

        public static void Save()
        {
            int temp = 0;
            EntityObjects.KeyStatus k = new EntityObjects.KeyStatus(temp);
            ControllerObjects.ManageControl.Update(k);
            Display(k);
        }

        public static void Display(EntityObjects.KeyStatus k)
        {

        }
    }
}
