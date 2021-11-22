using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KeyList
    {
        public Key[] Keys { get; set; } //private auto-implemented property for keys array
        //public to help add

        public KeyList(List<Key> aKeyList)
        {
            Keys = aKeyList.ToArray();
        }
        // Will need constructor that instantiates keys in the future?


    }
}
