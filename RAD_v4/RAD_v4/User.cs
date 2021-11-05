using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityObjects
{
    class User
    {
        private string uName;
        private string pWord;
        private char type;

        // No type provided, defaults to Customer
        public User(string n, string p, char t = 'C') 
        {
            uName = n;
            pWord = p;
            type = t;
        }

        /* Getters & Setters */
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

        public new char GetType()
        {
            return type;
        }
        public void SetType(char t)
        {
            type = t;
        }
    }
}
