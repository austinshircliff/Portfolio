//Austin Shircliff
//Program 1
//CIS 199-01
//February 16, 2016
//This is a program that is designed for a painting company. This program allows the user to input the square feet of the area being painted, the coats of paint, and the price of each gallon of paint. 
//The program then delivers the total square feet being painted, the gallons of paint required, hours of labor, cost of paint, cost of labor, and the total cost of the job at hand.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void calculatebutton_Click(object sender, EventArgs e)//setting the button to activate the program when clicked
        {
            try
            {

                const int SquareFeetPerGallon = 325;//a constant for the square feet a gallon of paint will cover
                const int laborPerGallon = 8;//a constant for the hours it takes for each gallon of paint
                const double workerWage = 10.50;//a constant for how much the workers make an hour

                double squarefeet;//a variable for the squarefeet entered 
                int numberofcoats;// a variable for the number of coats being put on 
                double pricepergallon;// a variale for the price of gallons that will be entered
                double totalsquarefeet;//a variable for the total square feet being covered
                double totalgallons;// a variable for the total number of gallons being used
                double hoursoflabor;// a variable for the hours of labor that will be required
                double costofpaint;// a variable for the cost of a gallon of paint
                double costoflabor;// a variable for the total cost of labor
                double totalcost;// a variable for the cost of paint + the cost of labor

                squarefeet = double.Parse(squarefeettext.Text);//changing squarefeet to a double
                numberofcoats = int.Parse(paintcoattext.Text);// changing numberofcoats to an int
                pricepergallon = double.Parse(priceofgallontext.Text);//changing pricepergallon to a double


                totalsquarefeet = squarefeet * numberofcoats;//giving totalsquarefeet a number and calculating for it
                totalsquarefeettext.Text = totalsquarefeet.ToString("n1");//setting the display and specifying to allow one decimal place

                totalgallons = Math.Ceiling(totalsquarefeet / SquareFeetPerGallon);// setting the math to calculate total gallons with math ceiling to round up
                gallonsofpainttext.Text = totalgallons.ToString("");//setting the display 

                hoursoflabor = (totalsquarefeet / SquareFeetPerGallon) * laborPerGallon;// setting the math to calculate the hours of labor
                hoursoflabortext.Text = hoursoflabor.ToString("n1");// setting the display and specifying to show one decimal place

                costofpaint = totalgallons * pricepergallon;// setting the math to calculate the cost of paint
                costofpainttext.Text = costofpaint.ToString("c");// setting the display and specifying to make it currency

                costoflabor = workerWage * hoursoflabor;//setting the math to calculate total cost of labor
                costoflabortext.Text = costoflabor.ToString("c");// setting the display and specifying to make it currency

                totalcost = costoflabor + costofpaint;// setting the math to calculate the total cost of the job
                totalcosttext.Text = totalcost.ToString("c");// setting the display and specifying to make it currency




            }
            catch (Exception) //used to ensure that data entered is correct
            {
            }


            }
         
        }
    }
 




