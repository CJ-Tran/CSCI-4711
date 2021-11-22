using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KeyList
    {
        public Key[] Keys { get; set; } //made public to make adding keys easier

        public KeyList(List<Key> aKeyList)
        {
            Keys = aKeyList.ToArray();
        }
    }
}
