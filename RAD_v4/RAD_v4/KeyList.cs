using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityObjects
{
    class KeyList
    {
        
        public KeyList(List<Key> aKeyList)
        {
            Keys = aKeyList.ToArray();
        }
        // Will need constructor that instantiates keys in the future?
        private Key[] Keys { get; set; } //private auto-implemented property for keys array
        public Key[] GetKeys()
        {
            return Keys;
        }
    }
}
