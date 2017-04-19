using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW2.MyClasses
{
    public class GenerateSessionObjects
    {
        List<Account> accounts = new List<Account>();


        public GenerateSessionObjects()
        {
            Account act1 = new Account();
            act1.Balance = 10000;
            act1.Nickname = "Primary Checking";
            act1.Type = "Checking";

            Account act2 = new Account();
            act2.Balance = 150000;
            act2.Nickname = "Vacation Fund";
            act2.Type = "Checking";

            Account act3 = new Account();
            act3.Balance = 2000;
            act3.Nickname = "Primary Savings";
            act3.Type = "Savings";

            Customer customer = new Customer("Austin","123 Gotham Ln.");

            accounts.Add(act1);
            accounts.Add(act2);
            accounts.Add(act3);

            HttpContext.Current.Session["customer"] = customer;
            HttpContext.Current.Session["accounts"] = accounts;







        }

    }
}