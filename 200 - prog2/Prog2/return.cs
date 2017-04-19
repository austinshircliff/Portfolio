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
    public partial class @return : Form
    {
        List<LibraryItem> _items;//calls the list
        public @return(List<LibraryItem> l_item)//accepts one parameter
        {
            InitializeComponent();
            _items = l_item;//sets the list
        }
        internal int Returningitem
        {// Precondition:  have to click on the return item tab
            // Postcondition: the index of the item will be retrieved
            get { return returncombobox.SelectedIndex; }
        }

        private void @return_Load(object sender, EventArgs e)
        {

            foreach (LibraryItem l in _items)//steps through the list of items to display them
            {
                
                returncombobox.Items.Add(l.Title + ", " + l.CallNumber);//chooses what to display

            }
        }


        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void returncombobox_Validating(object sender, CancelEventArgs e)
        {
            if (returncombobox.Text == "")//ensure they have entered text
            {

                errorProvider1.SetError(returncombobox, "Please Choose An Item");//display error
                e.Cancel = true;//prevent furthur action
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void returncombobox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(returncombobox, "");//clears error
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())//validates
                this.DialogResult = System.Windows.Forms.DialogResult.OK;//if validation is successful, input is accepted
        }
    }
}
