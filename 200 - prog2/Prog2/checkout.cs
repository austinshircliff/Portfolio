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
    public partial class checkout : Form
    {
        List<LibraryItem> _items;   //call items list  
        List<LibraryPatron> _patrons;//call patrons list
        public checkout(List<LibraryItem> l_item,List<LibraryPatron> l_patron)//parameterized
        {
            InitializeComponent();
            _patrons = l_patron;//sets patron list
            _items = l_item;//sets item list
        }
        internal int Itembeingcheckedout
        {// Precondition:  must choose an item
            // Postcondition: item index will be retrieved
            get { return itemcombobox.SelectedIndex; }
        }
        internal int Patroncheckingout
        {// Precondition:  must choose a patron
            // Postcondition: patron index will be retrieved
            get { return patroncombobox.SelectedIndex; }
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem l in _items)//steps through and gets the list of items
                itemcombobox.Items.Add(l.Title+ ", "+ l.CallNumber);

            foreach (LibraryPatron p in _patrons)//steps through and gets the list of patrons
                patroncombobox.Items.Add(p.PatronName + ", "+ p.PatronID);
        }


        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void itemcombobox_Validating(object sender, CancelEventArgs e)
        {
            if (itemcombobox.Text == "")//ensure they have entered text
            {

                errorProvider1.SetError(itemcombobox, "Please Choose An Item");//display error
                e.Cancel = true;//prevent furthur action
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void itemcombobox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(itemcombobox, "");
        }
        // Precondition:  The dialog box must be run
        // Postcondition: if there is no text in the textbox, there will be an error, if there is text, it will procede to validated
        private void patroncombobox_Validating(object sender, CancelEventArgs e)
        {
            if (patroncombobox.Text == "")//ensure they have entered text
            {

                errorProvider2.SetError(patroncombobox, "Please Choose A Patron");//display error
                e.Cancel = true;//prevent furthur action
            }
        }
        // Precondition:  the validating cancelevent must be done
        // Postcondition: the error message will be changed to nothing
        private void patroncombobox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(patroncombobox, "");//clear error
        }

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())//validates
                this.DialogResult = System.Windows.Forms.DialogResult.OK;//if validation works then the input is accepted and passed to the main form
        }
        
    }
}
