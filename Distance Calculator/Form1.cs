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
        public static double breaks, miles, gallons, mpg, ppg, averageSpeed;
        public static string stopForGas, gallonsUsed, totalCost;

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Reading user input and converting them into doubles
            miles = Convert.ToDouble(milesTB.Text);
            gallons = Convert.ToDouble(gallonsTB.Text);
            mpg = Convert.ToDouble(AverageMpgTB.Text);
            ppg = Convert.ToDouble(ppgTB.Text);
            breaks = Convert.ToInt32(txtBreaks.Text);
            averageSpeed = Convert.ToDouble(txtAverageSpeed.Text);

            // Creating error messages if any of the text boxes have negative numbers
            if (miles <= 0)
            {
                errorMiles.Text = "Type a number greater than 0";
            }
            else
            {
                if (gallons <= 0)
                {
                    errorGallons.Text = "Type a number greater than 0";
                }
            }      
            if (mpg <= 0)
            {
                    errorMPG.Text = "Type a number greater than 0";
            }        
            
            if (ppg <= 0)
            {
                errorPPG.Text = "Type a number greater than 0";
            }
            if (breaks < 0)
            {
                lblBreaksError.Text = "Type a number equal to or greater than 0";
            }
            if (averageSpeed < 0)
            {
                lblSpeedError.Text = "Enter a speed in miles per hour";
            }
            else
            {
                errorMiles.Text = "";
                errorMPG.Text = "";
                errorPPG.Text = "";
                errorGallons.Text = "";
                lblBreaksError.Text = "";
                lblSpeedError.Text = "";

                // Calculating the amount of gas used during the trip and displaying it to a label with two decimal places
                gallonsUsed = Convert.ToString(miles / mpg);
                lblTotalGas.Text = Convert.ToString(Math.Round(Convert.ToDecimal(gallonsUsed), 2)) + " Gallons of gas used";

                // Calculating the number of times you will need to stop to fill up your gas tank
                stopForGas = Convert.ToString(Math.Round(Convert.ToDecimal(Convert.ToDecimal(gallonsUsed) / Convert.ToDecimal(gallons))));
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
                Time();
            }            
        }

        // Exits the form
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load method that clears data from boxes and labels
        private void DistanceCalclator_Load(object sender, EventArgs e)
        {
            clearData();
        }

        // Clears all of the text boxes while form loads
        private void clearData()
        {
            lblTotalGas.Text = "";
            lblGasStops.Text = "";
            lblTotalCost.Text = "";
            errorMiles.Text = "";
            errorMPG.Text = "";
            errorPPG.Text = "";
            errorGallons.Text = "";
            lblTime.Text = "";
            lblBreaksError.Text = "";
            lblSpeedError.Text = "";            
        }
        private void clearBoxes()
        {            
            txtAverageSpeed.Text = "";
            txtBreaks.Text = "";
            milesTB.Text = "";
            AverageMpgTB.Text = "";
            ppgTB.Text = "";
            gallonsTB.Text = "";
            milesTB.Focus();
        }
        // Used to caluclate the amount of time needed for the trip
        private void Time()
        {
            double minutesForGasBreaks, timePerStop = 10, longBreakTime = 60, driveTime, totalDriveTimeInMinutes;
            string hours, minutes;

            // Calculating the total time for the trip
            longBreakTime *= breaks;
            driveTime = (miles / averageSpeed) * 60;
            minutesForGasBreaks = timePerStop * Convert.ToDouble(stopForGas);
            totalDriveTimeInMinutes = driveTime + minutesForGasBreaks + longBreakTime;           
            hours = Convert.ToString(Math.Floor((totalDriveTimeInMinutes) / 60));            
            minutes = Convert.ToString(Math.Round((totalDriveTimeInMinutes) % 60));

            // Formatting the output of time taken for the trip
            lblTime.Text = hours + " hours and " + minutes + " minutes";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
            clearBoxes();
        }
    }
}
