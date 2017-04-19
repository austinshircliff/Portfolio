//Austin Shircliff
//CIS200-01
//Program 2
//Due : 3/12/16
//This adds functionality in the form of GUI's. The user can add a book or a patron, get a list of patrons, items, and checkedout items, checkout a book and return a book.

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
    public partial class LibraryForm : Form
    {
        private Library lib;//Library

        public LibraryForm()
        {
            InitializeComponent();

            lib = new Library();//create new library
            //library item info
            lib.AddLibraryBook("Adventures of Batman", "Penguin Publishing", 1990, 7, "nananana", "Bruce Wayne");
            lib.AddLibraryBook("Joker AutoBiography", "Serious", 2000, 9, "HAHAHAHA", "The Joker");
            lib.AddLibraryBook("Attack on Titan", "Anime", 2010, 5, "823746", "John Doe");
            lib.AddLibraryMovie("Dragonball Z:Battle of the Gods", "Funimation", 2015, 5, "DBZ123", 122.5, "Akira Toriama", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.PG13);
            lib.AddLibraryMovie("Suicide Squad", "Universal", 2016, 2, "159846", 200.6, "That Guy", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.R);
            lib.AddLibraryMusic("Mezmerize", "Universal", 2005, 15, "BYOB456", 45, "System of A Down", LibraryMediaItem.MediaType.CD, 11);
            lib.AddLibraryJournal("Why UK is Better than UL", "Science", 2016, 100, "123456", 5, 6, "Truth", "Kendra");
            lib.AddLibraryMagazine("ESPN", "Sports", 2005, 16, "965896", 1, 6);
            //library patron info
            lib.AddPatron("Austin Shircliff", "1A");
            lib.AddPatron("James Shircliff", "2B");
            lib.AddPatron("Edward Nygma", "????");
            lib.AddPatron("Les Vegetables", "STEAK");
            lib.AddPatron("Ronald Swanson", "WHISKEY");
            lib.AddPatron("Courntey Craig", "10FES0");

        }
        //Precondition:File-About must be clicked
        //Postcondition:A messagebox will appear showing information about the program 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About the Application:" + System.Environment.NewLine + "Name: Austin Shircliff" + System.Environment.NewLine + "Program Number: Program 2" 
                + System.Environment.NewLine + "Due Date: 3/10/16" + System.Environment.NewLine +"Description: This application will allow manipulation of the Library.","About Program 2");
        }
        //Precondition:File-Exit must be clicked
        //Postcondition: The application will be closed
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Precondition:Reports - Patron List must be clicked
        //Postcondition:A list of the patrons will be sent to the text box on the application including a count
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Text = string.Empty;//clears the text box
            int count = lib.GetPatronCount();//gets the count of patrons
            mainText.Text = "Number of Patrons: " + count.ToString()+ System.Environment.NewLine+ "List of Patrons:"+System.Environment.NewLine;//displays the count of patrons
            
                      
            foreach (LibraryPatron patron in lib.GetPatronsList())//display all the patrons
            {
                mainText.AppendText(patron.ToString());//append
                mainText.AppendText(System.Environment.NewLine);
            }
         

        }
        // Precondition:  The item list has been clicked
        // Postcondition: A list of the items will be sent to the text box on the application including a count
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Text = string.Empty;//clears the text box
            int count = lib.GetItemCount();//gets count of items
            mainText.Text = "Number of Items in the Library: " + count.ToString() + System.Environment.NewLine + System.Environment.NewLine;//displays the count of items

            foreach (LibraryItem item in lib.GetItemsList())//displays the library item and their information from their toString 
            {
                
                mainText.AppendText(item.ToString());//append
                mainText.AppendText(System.Environment.NewLine);
                mainText.AppendText(System.Environment.NewLine);
               
            }
        }
        // Precondition:  the checked out list has been clicked
        // Postcondition: a list of the items that are checked out will be sent to the text box on the application including a count
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainText.Text = string.Empty;//clears text box
            int count = lib.GetCheckedOutCount();//gets count of checked out items
            mainText.Text = "Number of Item Checked Out: " + count.ToString() + System.Environment.NewLine + System.Environment.NewLine;//displays count of checked out items

          
                    
            foreach (LibraryItem item in lib.GetItemsList())
            {
               if(item.IsCheckedOut())
               {
                   mainText.AppendText(item.ToString());
                   mainText.AppendText(System.Environment.NewLine);
                   mainText.AppendText(System.Environment.NewLine);
               }
               

            }

        }
        // Precondition:  Add patron must be clicked
        // Postcondition: A new patron will be added to the list of patrons available
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatron addpatron = new AddPatron();//form
            DialogResult result;
            string name;//holds name
            string id;//holds id


            result = addpatron.ShowDialog();//calls form

            if (result == DialogResult.OK)//checks the result of the form
            {
                name = addpatron.Patronname;//sets the name
                id = addpatron.Patronnumber;//sets the id

                lib.AddPatron(name, id);//adds a new patron based on the input
            }
        }
        // Precondition:  Add Book must be clicked
        // Postcondition: A new book will be added to the list of libray items
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbook newbook = new addbook();//creates form
            DialogResult result;
            string title;//holds title
            string publisher;//holds publisher
            int copyrightyear;//holds copyright year
            int loanperiod;//holds loanperiod
            string callnumber;//holds call number
            string author;//holds author

            result = newbook.ShowDialog();//calls the form

            if (result == DialogResult.OK)//checks the result of the form
            {
                title = newbook.Title;//sets the title
                publisher = newbook.Publisher;//sets the publisher
                copyrightyear = int.Parse(newbook.Copyrightyear);//parses the copyright year and sets it
                loanperiod = int.Parse(newbook.Loanperiod);//parses the loanperiod and sets it
                callnumber = newbook.Callnumber;//sets the callnumber
                author = newbook.Callnumber;//sets the author

                lib.AddLibraryBook(title, publisher, copyrightyear, loanperiod, callnumber, author);//adds a new item based on the input
            }
        }
        // Precondition:  The checkout item will be clicked
        // Postcondition: A dialog box will pop up and allow the user to checkout an item and specify the patron that checked it out
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkout checkoutitem = new checkout(lib._items,lib._patrons);
            DialogResult result;
            result = checkoutitem.ShowDialog();
            int item;
            int patron;


            if (result == DialogResult.OK)
            {
                item = checkoutitem.Itembeingcheckedout;
                patron = checkoutitem.Patroncheckingout;

                lib.CheckOut(item, patron);
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            @return returnitem = new @return(lib._items);
            DialogResult result;
            result = returnitem.ShowDialog();
            int returneditem;

            if (result == DialogResult.OK)
            {
                returneditem = returnitem.Returningitem;

                lib.ReturnToShelf(returneditem);
            }
        }
    }
}
