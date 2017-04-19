using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class addbook : Form
    {
        public addbook()
        {
            InitializeComponent();
        }
        public string Title
        {
            // Precondition:  none
            // Postcondition: user input in booktitletxtbox is retrieved
            get { return booktitletxtbox.Text; }
        }
        public string Publisher
        {
            // Precondition:  none
            // Postcondition: user input in publishertxtbox is retrieved
            get { return publishertxtbox.Text; }
        }
        public string Copyrightyear
        {
            // Precondition:  none
            // Postcondition: user input in copytxtbox is retrieved
            get { return copytxtbox.Text; }
        }
        public string Loanperiod
        {
            // Precondition:  none
            // Postcondition: user input in loantxtbox is retrieved
            get { return loantxtbox.Text; }
        }
        public string Callnumber
        {
            // Precondition:  none
            // Postcondition: user input in callnumtxtbox is retrieved
            get { return callnumtxtbox.Text; }
        }
        public string Author
        {
            // Precondition:  none
            // Postcondition: user input in authortxtbox is retrieved
            get { return authortxtbox.Text; }
        }



        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void booktitletxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (booktitletxtbox.Text == "")//ensure they have entered text
            {

                errorProvider1.SetError(booktitletxtbox, "Enter the Book's Title");//display error
                e.Cancel = true;//prevent further action
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void booktitletxtbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(booktitletxtbox, "");//clear error
        }
        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void publishertxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (publishertxtbox.Text == "")//ensure they have entered text
            {

                errorProvider2.SetError(publishertxtbox, "Enter the Book's Publisher");//display error
                e.Cancel = true;//prevent further action
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void publishertxtbox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(publishertxtbox, "");//clear error
        }

        private void copytxtbox_Validating(object sender, CancelEventArgs e)
        {
            int copyright; // Value entered into copytxtbox

            // Will try to parse text as int
            // If fail, it stops
            // If succeeds, TryParse returns true and number stores value in copyright
            if (!int.TryParse(copytxtbox.Text, out copyright))
            {
                e.Cancel = true; // Stops
                // Will NOT proceed to Validated event

                errorProvider3.SetError(copytxtbox, "Enter an integer!"); // Set error message

                copytxtbox.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (copyright < 0 || copyright > 2016)
                {
                    e.Cancel = true; // 
                    // Will NOT proceed to Validated event

                    errorProvider3.SetError(copytxtbox, "Please enter a valid Copyright"); // Set error message

                    copytxtbox.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void copytxtbox_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(copytxtbox, "");//clear error
        }

        private void loantxtbox_Validating(object sender, CancelEventArgs e)
        {
            int loanperiod; // Value entered into copytxtbox

            // Will try to parse text as int
            // If fail, it stops
            // If succeeds, TryParse returns true and number stores value in copyright
            if (!int.TryParse(loantxtbox.Text, out loanperiod))
            {
                e.Cancel = true; // Stops
                // Will NOT proceed to Validated event

                errorProvider4.SetError(loantxtbox, "Enter an integer!"); // Set error message

                copytxtbox.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (loanperiod < 0 || loanperiod > 20)
                {
                    e.Cancel = true; // stops
                    // wont proceed to validated event

                    errorProvider4.SetError(loantxtbox, "Please enter a valid loan period"); // Set error message

                    copytxtbox.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void loantxtbox_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(loantxtbox, "");//clear error
        }
        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void callnumtxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (callnumtxtbox.Text == "")//ensure they have entered text
            {

                errorProvider5.SetError(callnumtxtbox, "Enter the Book's Call Number");//display error
                e.Cancel = true;//prevent further action
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void callnumtxtbox_Validated(object sender, EventArgs e)
        {
            errorProvider5.SetError(callnumtxtbox, "");//clear error
            
        }
        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void authortxtbox_Validating(object sender, CancelEventArgs e)
        {
            if (authortxtbox.Text == "")//ensure they have entered text
            {

                errorProvider6.SetError(authortxtbox, "Enter the Book's Author");//display error
                e.Cancel = true;//prevent further action
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void authortxtbox_Validated(object sender, EventArgs e)
        {
            errorProvider6.SetError(authortxtbox, "");//clear error
        }
        // Precondition:  User has initiated click on addbuttonbutton
        // Postcondition: If all controls on form validate, InputBox is dismissed with OK result
        private void addbookbutton_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())//checked validation
            this.DialogResult = System.Windows.Forms.DialogResult.OK;//if all validates, result is accepted
        }
    }
}
