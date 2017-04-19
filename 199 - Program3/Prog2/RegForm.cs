// Program 3
// CIS 199-01
// Due: 4/5/15
// By: Austin Shircliff
// This program is a tweak of Dr. Wright's Program 2 and it takes 
//out a very long if-else statement and repleaces is with arrays. It still allows the user to input their
//name and check their year and it will tell them the day and time they are allowed to register for classes.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void findRegTimeBtn_Click(object sender, EventArgs e)
            //preconditions: the programmer must know the day and times various students are meant to register.
            //postcondition: the program tells the user what date that he or she will be able to register based on their name. 
        {
            const string DAY1 = "April 1";  // 1st day of registration
            const string DAY2 = "April 2"; // 2nd day of registration
            const string DAY3 = "April 3"; // 3rd day of registration
            const string DAY4 = "April 6"; // 4th day of registration
            const string DAY5 = "April 7"; // 5th day of registration
            const string DAY6 = "April 8"; // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration

            lastNameStr = lastNameTxt.Text;

            if (lastNameStr == "") // Empty text box
                MessageBox.Show("Please enter last name!");
            else
            {
                lastNameLetterCh = lastNameStr[0]; // As in text, p. 466-467

                if (!char.IsLetter(lastNameLetterCh)) // Is it a letter or not?
                    MessageBox.Show("Please ensure a letter is in first position of last name!");
                else
                {
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    // Juniors and Seniors share same schedule but different days
                    if (juniorBtn.Checked || seniorBtn.Checked)
                    {
                        if (seniorBtn.Checked)
                            dateStr = DAY1;
                        else // Must be juniors
                            dateStr = DAY2;

                      
                        char[] seniorjuniorLetter = { 'A', 'E', 'J', 'P', 'T', };//array setting the chars that it will be looking for
                        string[] seniorjuniorTime = { TIME2, TIME3, TIME4, TIME5, TIME1 };//array setting the corresponding times
                        int i = seniorjuniorLetter.Length - 1;//setting an int to the last one in the array
                        while (i >= 0 && lastNameLetterCh <= seniorjuniorLetter[i])//a while loop that goes through the array
                            --i;
                        timeStr = seniorjuniorTime[i];//setting the spot in the array the loop stops to the output label timeStr
                    }
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                        if (sophBtn.Checked)
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY4;
                            else // All other letters on previous day
                                dateStr = DAY3;
                        }
                        else // must be freshman
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY6;
                            else // All other letters on previous day
                                dateStr = DAY5;
                        }

                 
                        char[] freshsophLetter = { 'A','C', 'E','G', 'J','M', 'P','R' ,'T','W' };//Setting an array of char with the various letters you will be testing
                        string[] freshsophTime = { TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2 };//setting an array with all the times that will be associated with the top array
                        int v = freshsophLetter.Length - 1;//setting another variable to the length of the array
                        while (v >= 0 && lastNameLetterCh <= freshsophLetter[v])//a while loop that moves through the top array and finds the proper spot where it matches the char
                            --v;//it is decending 
                        timeStr = freshsophTime[v];//setting the spot it stops in the time array to the output label timeStr
                    }

                    dateTimeLbl.Text = dateStr + " at " + timeStr;
                }
            }
        }
    }
}
