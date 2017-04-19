using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW2.MyClasses
{
    public class Account
    {
        private string _type;
        private string _nickname;
        private double _balance;


        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public String Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }

        }
        public Double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }


        public Boolean hasLoanOffer()
        {
            if (Balance < 15000)
            {
                return false;
            }
            else
            {
                return true;
            }
    }

    }

    
}