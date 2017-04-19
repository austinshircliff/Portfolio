using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HW2.MyClasses;

namespace HW2
{
    public partial class LoanApplicationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = (Customer)Session["customer"];
            NameLabel.Text = customer.FullName;

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            Account selectedAccount = (Account)Session["selectedAccount"];

            if(Double.Parse(AgeTextBox.Text) > 18)
            {
                if(Double.Parse(LoanTextBox.Text) < selectedAccount.Balance && Double.Parse(LoanTextBox.Text) < (Double.Parse(SalaryTextBox.Text)  ) * 0.5)
                {
                    LoanApprovalLabel.Text = "Congrats, your loan is approved!";

                    LoanApprovalLabel.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    LoanApprovalLabel.Text = "Sorry, you were denied";

                    LoanApprovalLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                LoanApprovalLabel.Text = "Sorry, you were denied";
                LoanApprovalLabel.ForeColor = System.Drawing.Color.Red;

            }




        }
    }
}