using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class DistanceCalclator : Form
    {
        public DistanceCalclator()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double miles, gallons, mpg, ppg;
            string gallonsUsed, totalCost, stopForGas;
            // Reading user input and converting them into doubles
            miles = Convert.ToDouble(milesTB.Text);
            gallons = Convert.ToDouble(gallonsTB.Text);
            mpg = Convert.ToDouble(AverageMpgTB.Text);
            ppg = Convert.ToDouble(ppgTB.Text);

            // Calculating the amount of gas used during the trip and displaying it to a label with two decimal places
            gallonsUsed = Convert.ToString(miles / mpg);
            lblTotalGas.Text = Convert.ToString(Math.Round(Convert.ToDecimal(gallonsUsed),2)) + " Gallons of gas used";

            // Calculating the number of times you will need to stop to fill up your gas tank
            stopForGas = Convert.ToString(Math.Floor(Convert.ToDecimal(Convert.ToDecimal(gallonsUsed) / Convert.ToDecimal(gallons))));
            if (Convert.ToDouble(stopForGas) == 1)
            {
                lblGasStops.Text = "You will need to stop " + stopForGas + " time for gas";
            }
            else
            {
                lblGasStops.Text = "You will need to stop " + stopForGas + " times for gas";
            }

            // Calculate the total amount of money spent for gas
            totalCost = Convert.ToString(Convert.ToDouble(gallonsUsed) * ppg);
            lblTotalCost.Text = Convert.ToString(Convert.ToDecimal(totalCost).ToString("C2"));
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DistanceCalclator_Load(object sender, EventArgs e)
        {
            lblTotalGas.Text = "";
            lblGasStops.Text = "";
            lblTotalCost.Text = "";
        }           
    }
}
