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
    public partial class AddPatron : Form
    {
        public AddPatron()
        {
            InitializeComponent();
        }
        internal string Patronname
        {   // Precondition:  none
            // Postcondition: user input in nametxtbox is retrieved
            get { return nametxtbox.Text; }
        }
        internal string Patronnumber
        {   // Precondition:  none
            // Postcondition: user input in idnumtxtbox is retrieved
            get { return idnumtxtbox.Text; }
        }


        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void nametxtbox_Validating(object sender, CancelEventArgs e)
        {

            if (nametxtbox.Text == "")//ensure they have entered text
            {

                errorProvider1.SetError(nametxtbox, "Please Enter A Name");//display error
                e.Cancel = true;//prevent furthur action
            }
            
          
           
        }
        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void idnumtxtbox_Validating(object sender, CancelEventArgs e)
        {

            if (idnumtxtbox.Text == "")//ensure they have entered text
            {

                errorProvider2.SetError(idnumtxtbox, "Please Enter An ID Number");//display error
                e.Cancel = true;//prevent furthur action
            }

            // Precondition:  the validating cancelevent must be done
            // Postcondition: the error message will be changed to nothing
        }
        private void nametxtbox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nametxtbox, "");//clear error
           

        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void idnumtxtbox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(idnumtxtbox, "");//clear error
            
        }
        // Precondition:  User has initiated click on addpatronbutton
        // Postcondition: If all controls on form validate, InputBox is dismissed with OK result
        private void addpatronbutton_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        
    }
}
