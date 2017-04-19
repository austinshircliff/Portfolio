using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HW2.MyClasses;

namespace HW2
{
    public partial class AccountSummary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GenerateSessionObjects session = new GenerateSessionObjects();
            List<Account> accounts = (List<Account>)Session["accounts"];
            Customer customer = (Customer)Session["customer"];
            if (!IsPostBack)
            {


                FirstNameLabel.Text = customer.FullName;
                foreach (Account a in accounts)
                {
                    AccountListBox.Items.Add(a.Nickname);
                }
            }
        }
    }
}