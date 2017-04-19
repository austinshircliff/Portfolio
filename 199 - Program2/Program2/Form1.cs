//Austin Shircliff
//Program 2
//March 9th, 2015
//CIS 199-01
//This program allow the user to type in their last name and click a radio button for the specific year and it will return the time and date that they will be able to register for the next years classes.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }
        private void calculatebutton_Click(object sender, EventArgs e)
        {
            
            
            string name = nameentry.Text;//allowing the text entered to be set as a string
            char entry;//declaring entry as a char
            entry = 'X';//setting x equal to entry
            entry = name[0];// saying that it will only look at the first letter in the text
            entry = char.ToUpper(entry);//setting the entry to always be uppercase
            //bellow is naming and giving a value to each char
          
            char Tletter;
            Tletter = 'T';
            char Zletter;
            Zletter = 'Z';
            char Aletter;
            Aletter = 'A';
            char Dletter;
            Dletter = 'D';
            char Eletter;
            Eletter = 'E';
            char Iletter;
            Iletter = 'I';
            char Jletter;
            Jletter = 'J';
            char Oletter;
            Oletter = 'O';
            char Pletter;
            Pletter = 'P';
            char Sletter;
            Sletter = 'S';
            char Vletter;
            Vletter = 'V';
            char Wletter;
            Wletter = 'W';
            char Bletter;
            Bletter = 'B';
            char Cletter;
            Cletter = 'C';
            char Fletter;
            Fletter = 'F';
            char Gletter;
            Gletter = 'G';
            char Lletter;
            Lletter = 'L';
            char Mletter;
            Mletter = 'M';
            char Qletter;
            Qletter = 'Q';
            char Rletter;
            Rletter = 'R';
            
           
                if (char.IsLetter(entry))//ensuring that it is a letter that is entered
                {
                    if (seniorbutton.Checked)//if statement for what will happen is senior is checked
                    {
                        //Set the entry greater and equal than the specific requirements, same for all the way down
                        if (entry >= Tletter && entry <= Zletter)
                        {
                            MessageBox.Show("8:30 AM - Wednesday, April 1 2015");//give the appropriate time and date in a messagebox, same for all the way down
                        }
                        else if (entry >= Aletter && entry <= Dletter)
                        {
                            MessageBox.Show("10:00 AM - Wednesday, April 1 2015");
                        }
                        else if (entry >= Eletter && entry <= Iletter)
                        {
                            MessageBox.Show("11:30 AM - Wednesday, April 1 2015");
                        }
                        else if (entry >= Jletter && entry <= Oletter)
                        {
                            MessageBox.Show("2:00 PM - Wednesday, April 1 2015");
                        }
                        else if (entry >= Pletter && entry <= Sletter)
                        {
                            MessageBox.Show("4:00 PN - Wednesday, April 1 2015");
                        }
                    }

                    if (juniorbutton.Checked)
                    {

                        if (entry >= Tletter && entry <= Zletter)//Set the entry greater and equal than the specific requirements, same for all the way down
                        {
                            MessageBox.Show("8:30 AM - Thursday, April 2 2015");//give the appropriate time and date in a messagebox, same for all the way down
                        }
                        else if (entry >= Aletter && entry <= Dletter)
                        {
                            MessageBox.Show("10:00 AM - Thursday, April 2 2015");
                        }
                        else if (entry >= Eletter && entry <= Iletter)
                        {
                            MessageBox.Show("11:30 AM - Thursday, April 2 2015");
                        }
                        else if (entry >= Jletter && entry <= Oletter)
                        {
                            MessageBox.Show("2:00 PM - Thursday, April 2 2015");
                        }
                        else if (entry >= Pletter && entry <= Sletter)
                        {
                            MessageBox.Show("4:00 PN - Thursday, April 2 2015");
                        }
                    }
                    if (sophomorebutton.Checked)
                    {

                        if (entry >= Tletter && entry <= Vletter)//Set the entry greater and equal than the specific requirements, same for all the way down
                        {
                            MessageBox.Show("8:30 AM - Friday, April 3 2015");//give the appropriate time and date in a messagebox, same for all the way down
                        }
                        else if (entry >= Wletter && entry <= Zletter)
                        {
                            MessageBox.Show("10:00 AM - Friday, April 3  2015");
                        }
                        else if (entry >= Aletter && entry <= Bletter)
                        {
                            MessageBox.Show("11:30 AM - Friday, April 3 2015");
                        }
                        else if (entry >= Cletter && entry <= Dletter)
                        {
                            MessageBox.Show("2:00 PM - Friday, April 3 2015");
                        }
                        else if (entry >= Eletter && entry <= Fletter)
                        {
                            MessageBox.Show("4:00 PM - Friday, April 3 2015");
                        }
                        else if (entry >= Gletter && entry <= Iletter)
                        {
                            MessageBox.Show("8:30 AM - Monday, April 6 2015");
                        }
                        else if (entry >= Jletter && entry <= Lletter)
                        {
                            MessageBox.Show("10:00 AM - Monday, April 6 2015");
                        }
                        else if (entry >= Mletter && entry <= Oletter)
                        {
                            MessageBox.Show("11:30 AM - Monday, April 6 2015");
                        }
                        else if (entry >= Pletter && entry <= Qletter)
                        {
                            MessageBox.Show("2:00 PM - Monday, April 6 2015");
                        }
                        else if (entry >= Rletter && entry <= Sletter)
                        {
                            MessageBox.Show("4:00 PM - Monday, April 6 2015");
                        }
                    }

                    if (freshmanbutton.Checked)
                    {

                        if (entry >= Tletter && entry <= Vletter)//Set the entry greater and equal than the specific requirements, same for all the way down
                        {
                            MessageBox.Show("8:30 AM - Tuesday, April 77 2015");//give the appropriate time and date in a messagebox, same for all the way down
                        }
                        else if (entry >= Wletter && entry <= Zletter)
                        {
                            MessageBox.Show("10:00 AM - Tuesday, April 7  2015");
                        }
                        else if (entry >= Aletter && entry <= Bletter)
                        {
                            MessageBox.Show("11:30 AM - Tuesday, April 7 2015");
                        }
                        else if (entry >= Cletter && entry <= Dletter)
                        {
                            MessageBox.Show("2:00 PM - Tuesday, April 7 2015");
                        }
                        else if (entry >= Eletter && entry <= Fletter)
                        {
                            MessageBox.Show("4:00 PM - Tuesday, April 7 2015");
                        }
                        else if (entry >= Gletter && entry <= Iletter)
                        {
                            MessageBox.Show("8:30 AM - Wednesday, April 8 2015");
                        }
                        else if (entry >= Jletter && entry <= Lletter)
                        {
                            MessageBox.Show("10:00 AM - Wednesday, April 8 2015");
                        }
                        else if (entry >= Mletter && entry <= Oletter)
                        {
                            MessageBox.Show("11:30 AM - Wednesday, April 8 2015");
                        }
                        else if (entry >= Pletter && entry <= Qletter)
                        {
                            MessageBox.Show("2:00 PM - Wednesday, April 8 2015");
                        }
                        else if (entry >= Rletter && entry <= Sletter)
                        {
                            MessageBox.Show("4:00 PM - Wednesday, April 8 2015");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Last Name Or The First Letter Of Your Last Name.");
                }
            }


        }
    }

