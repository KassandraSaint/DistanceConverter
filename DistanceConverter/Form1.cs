using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        // Initializing constants
        const double YARD_TO_FOOT = 3;
        const double FOOT_TO_INCH = 12;

        // Initializing mesurment variables to keep a selections from the List Boxes
        private string fromMeasurment;
        private string toMeasurment;
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            // Initializing variable for user's input
            double distanceToConvert;

            // Checking if user entered value correctly and storing it in a variable
            if (double.TryParse(distanceBox.Text, out distanceToConvert))
            {
                // Getting fromMeasurment selection
                if (fromListBox.SelectedIndex != -1)
                {
                    // Assigning result of the selection to fromMeasurment variable
                    fromMeasurment = fromListBox.SelectedItem.ToString();
                }
                else
                {
                    // Showing a message that there was no selection made
                    MessageBox.Show("Select a distance you want to convert from!");
                }

                // Getting toMeasurment selection
                if (toListBox.SelectedIndex != -1)
                {
                    // Assigning result of the selection to toMeasurment variable
                    toMeasurment = toListBox.SelectedItem.ToString();
                }
                else
                {
                    // Showing a message that there was no selection made
                    MessageBox.Show("Select a distance you want to convert to!");
                }

                // Checking all possible cases, calculating the distance and showing calculated text in a Label
                switch (fromMeasurment)
                {
                    case "Inches":
                        if (toMeasurment == "Feet")
                        {
                            distanceToConvert /= FOOT_TO_INCH;
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        else if (toMeasurment == "Yards")
                        {
                            distanceToConvert /= (FOOT_TO_INCH * YARD_TO_FOOT);
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        else {
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        break;
                    case "Feet":
                        if (toMeasurment == "Inches")
                        {
                            distanceToConvert *= FOOT_TO_INCH;
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        else if (toMeasurment == "Yards")
                        {
                            distanceToConvert /= YARD_TO_FOOT;
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        else
                        {
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        break;
                    case "Yards":
                        if (toMeasurment == "Inches")
                        {
                            distanceToConvert *= (FOOT_TO_INCH * YARD_TO_FOOT);
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        else if (toMeasurment == "Feet")
                        {
                            distanceToConvert *= YARD_TO_FOOT;
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        else
                        {
                            convertedLabel.Text = distanceToConvert.ToString();
                        }
                        break;
                }
            }
            else
            {
                // Showing a message that input in the distance box was wrong
                MessageBox.Show("Input was wrong. Enter a number!");
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
