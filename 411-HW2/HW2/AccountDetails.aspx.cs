using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HW2.MyClasses;

namespace HW2
{
    public partial class AccountDetails : System.Web.UI.Page
    {
    

        protected void Page_Load(object sender, EventArgs e)
        {
            
                List<Account> accounts = (List<Account>)Session["accounts"];
                Customer customer = (Customer)Session["customer"];


            if (HttpContext.Current.Request.UrlReferrer.AbsolutePath == "/AccountSummary.aspx")
            {
                int selectedIndex = ((ListBox)PreviousPage.FindControl("AccountListBox")).SelectedIndex;

                Account selectedAccount = accounts[selectedIndex];
                HttpContext.Current.Session["selectedAccount"] = selectedAccount;


                AccountNameLabel.Text = selectedAccount.Nickname;
                AccountTypelabel.Text = selectedAccount.Type;
                AccountBalanceLabel.Text = selectedAccount.Balance.ToString("C");
                LoanLabel.Text = selectedAccount.hasLoanOffer().ToString();
                AddressLabel.Text = customer.FullAddress;

            }
            else
            {
                Account selectedAccount = (Account)Session["selectedAccount"];

                AccountNameLabel.Text = selectedAccount.Nickname;
                AccountTypelabel.Text = selectedAccount.Type;
                AccountBalanceLabel.Text = selectedAccount.Balance.ToString("C");
                LoanLabel.Text = selectedAccount.hasLoanOffer().ToString();
                AddressLabel.Text = customer.FullAddress;
            }
            
        }

        protected void WithdrawlButton_Click(object sender, EventArgs e)
        {
            List<Account> accounts = (List<Account>)Session["accounts"];
            Account selectedAccount = (Account)Session["selectedAccount"];


            if (selectedAccount.Balance > Double.Parse(withdrawlTextBox.Text))
            {
                
                selectedAccount.Balance = selectedAccount.Balance - Double.Parse(withdrawlTextBox.Text);
                AccountBalanceLabel.Text = selectedAccount.Balance.ToString("C");
                HttpContext.Current.Session["accounts"] = accounts;
                
            }
            else
            {
                WithdrawlErrorLabel.Text = "Withdrawl Amount is greater than the balance";
            }
        }
    }
}
