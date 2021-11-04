using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityObjects
{
    class KeyList
    {
        private static Key[] keys;

        // Will need constructor that instantiates keys in the future?

        public static Key[] GetKeys()
        {
            return keys;
        }
    }
}
