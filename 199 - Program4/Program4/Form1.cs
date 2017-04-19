//Austin Shircliff
//CIS 199-01
//Dr. Wright
//Program 4
//April 26th 2015
//This program allows the user to enter the originzip, destination zip, height, length, width, and weight of a package and then it will calculate the cost of the package and display it in the list box. 
//It also allows the user to click the detail button and it will display the details of the item entered. Then they can click the TOUL button or FROMUL button to change the zip code from what it is to 40292.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Form1 : Form
    {
        private List<GroundPackage> costList = new List<GroundPackage>();//List to hold cost of packages

        public Form1()
        {
            InitializeComponent();
        }

        private void addpackagebutton_Click(object sender, EventArgs e)//add button 
        {
            int originzipcode;//variable for originzip
            int destinationzipcode;//variable for destinationzip
            double length;//variable for length
            double height;//variable for height
            double weight;//variable for weight
            double width;//variable for width

            if (int.TryParse(originziptext.Text, out originzipcode) && int.TryParse(destinationziptext.Text, out destinationzipcode) &&
                double.TryParse(lengthtext.Text, out length) && double.TryParse(widthtext.Text, out width) && double.TryParse(heighttext.Text, out height)
                && double.TryParse(weighttext.Text, out weight))//group of TryParses that will test all of the text entered
            {
                if (originzipcode < 00000 || originzipcode > 99999)//setting that the zip has to be certain numbers
                {
                    MessageBox.Show("Please Enter A Valid Zip Code");//error message 
                    return;//returns nothing if this happens
                }
                if (destinationzipcode < 00000 || destinationzipcode > 99999)//setting that the zip has to be certain numbers
                {
                    MessageBox.Show("Please Enter A Valid Zip Code");//error message
                    return;//returns nothing if this happens

                }
                if (length < 0)// if length is less than 0
                {
                    MessageBox.Show("Please Enter A Valid Length");//show error message
                    return;//return nothing

                }
                if (height < 0)//if height is less than 0
                {
                    MessageBox.Show("Please Enter A Valid Height");//show error message
                    return;//return nothing

                }
                if (width < 0)//if width is less than 0
                {
                    MessageBox.Show("Please Enter A Valid Width");//show error message
                    return;//return noting

                }
                if (weight < 0)//if weight is less than 0
                {
                    MessageBox.Show("Please Enter A Valid Weight");//display error message
                    return;//return nothing
                }
                GroundPackage myPackage = new GroundPackage(originzipcode, destinationzipcode, length, width, height, weight);//creating the object with the 6 parameters
                costList.Add(myPackage);//add that package to the cost listbox
                packagelistbox.Items.Add(myPackage.CalcCost().ToString("c"));//pass the package through ClacCost and set to currency
            }
            else
            {
                MessageBox.Show("Please enter the appropriate values");//display error message
            }
        }
        private void detailsbutton_Click(object sender, EventArgs e)//details button
        {
            int index = packagelistbox.SelectedIndex;//selecting the information from the selected item
            if (index != -1)//not allowing the Details button to not be clicked when an item is not selected
            {
                MessageBox.Show(costList[index].ToString());//toString the info when the button is clicked

            }
            else
            {
                MessageBox.Show("Please select a package");//display error
            }
        }
        private void toULbutton_Click(object sender, EventArgs e)//toUL button
        {
            int index = packagelistbox.SelectedIndex;//selecting the info for the package
            if (index != -1)
            {
                costList[index].DestinationZip = 40292;//change the zip code
                packagelistbox.Items[index] = costList[index].CalcCost().ToString("c");//set new zip and info to CalcCost and currenecy
                MessageBox.Show("Destination Zipcode has been changed ot 40292");//Display Message explaining what happened
            }
            else
            {
                MessageBox.Show("Please select a package");//dislay error
            }
        }
        private void fromULbutton_Click(object sender, EventArgs e)
        {
            int index = packagelistbox.SelectedIndex;//selecting the info for the package
            if (index != -1)
            {
                costList[index].OriginZip = 40292;//change the zip code
                packagelistbox.Items[index] = costList[index].CalcCost().ToString("c");//set the new zip and info to CalcCost and currency
                MessageBox.Show("Origin Zipcode has been changed ot 40292");//display message explaining what happened
            }
            else
            {
                MessageBox.Show("Please select a package");//display error
            }
        }
    }
}

           

        


        

    

