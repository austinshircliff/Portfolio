using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW2.MyClasses
{
    public class Customer
    {
        private string _fullname;
        private string _fulladdress;

        public Customer(string name, string address)
        {
            _fullname = name;
            _fulladdress = address;

        }


        public string FullName
        {
            get { return _fullname; }
        }
        public string FullAddress
        {
            get { return _fulladdress; }
        }
    }
}