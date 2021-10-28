using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boundary
{
    class ManageKeyForm
    {
        public static void Submit()
        {
            int k = 0;
            Display(Controller.ManageControl.GetStatus(k));
        }

        public static void Save()
        {
            int temp = 0;
            Entity.KeyStatus k = new Entity.KeyStatus(temp);
            Controller.ManageControl.Update(k);
            Display(k);
        }

        public static void Display(Entity.KeyStatus k)
        {

        }
    }
}
