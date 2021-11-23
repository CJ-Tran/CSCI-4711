using System.Collections.Generic;

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
