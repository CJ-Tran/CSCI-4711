﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        /* Properties */
        private string UName { get; set; } //username
        public AcctType Type { get; private set; } //account type (Admin = 1/Customer = 0)
        // public to get the type

        public enum AcctType
        {
            Customer = 0,
            Admin = 1
        }//acct type enumeration (this can be int casted)

        // No type provided, defaults to Customer
        public User(string username, AcctType type = AcctType.Customer)
        {
            this.UName = username;
            this.Type = type;
        }//User()
        public string GetName()
        {
            return this.UName;
        }//GetName()
    }
}
