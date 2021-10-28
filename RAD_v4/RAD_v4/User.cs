using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class User
    {
        private string uName;
        private string pWord;
        private char type;

        public User(string n, string p, char t = 'C')
        {
            uName = n;
            pWord = p;
            type = t;
        }

        public string GetUName()
        {
            return uName;
        }
        public void SetUName(string name)
        {
            uName = name;
        }

        public string GetPWord()
        {
            return pWord;
        }
        public void SetPWord(string p)
        {
            pWord = p;
        }

        public char GetType()
        {
            return type;
        }
        public void SetType(char t)
        {
            type = t;
        }
    }
}
