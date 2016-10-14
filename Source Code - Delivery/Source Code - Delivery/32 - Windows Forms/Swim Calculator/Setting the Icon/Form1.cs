using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace Creating_the_Project {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ValidateKeyPress(object sender, KeyEventArgs e) {
            // we want to allow numbers, the left and right cursor keys and the delete key
            bool isNumberKey = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9;
            bool isNumberPadKey = e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9;
            bool isDeleteKey = e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back;

            if (isNumberKey || isNumberPadKey || isDeleteKey) {
                // this is a key we want to support
                statusLabel.Text = "Ready";
            } else {
                // this is not a key we want to support
                // - suppress the key event
                e.SuppressKeyPress = true;
                // send a message to the status bar 
                statusLabel.Text = string.Format("Ignored: {0}", e.KeyCode);
                // play an alert sound
                SystemSounds.Beep.Play();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void convertButton_Click(object sender, EventArgs e) {
            // define the variables that will hold the control values
            int minutesCompleted, lapsCompleted, lapLength, caloriesPerHour;

            // parse the control contents into the variables
            try {
                // extract the values entered by the user from the form controls
                minutesCompleted = int.Parse(minutesTextBox.Text);
                lapsCompleted = int.Parse(lapsTextBox.Text);
                lapLength = (int)poolLength.Value;
                caloriesPerHour = (int)calsPerHour.Value;

            } catch (Exception) {
                statusLabel.Text = "Cannot parse values";
                SystemSounds.Beep.Play();
                // return from this method
                return;
            }

            // ensure that we have values which are greater than zero
            if (minutesCompleted <= 0 || lapsCompleted <= 0 || lapLength <= 0 || caloriesPerHour <= 0) {
                // we cannot proceed - we have one or more bad values
                statusLabel.Text = "Cannot calculate - use values greater than zero";
                // alert the user to the erro
                SystemSounds.Beep.Play();
                return;
            }

            // perform the calculations we need for the results
            float distance = (lapsCompleted * lapLength) * 0.00062137119223733f;
            float caloriesBurned = (minutesCompleted / 60f) * caloriesPerHour;
            float pace = (minutesCompleted * 60) / lapsCompleted;

            // compose and set the results
            resultsTextBox.Lines = new string[] {
                string.Format("Distance completed: {0:F2} miles", distance),
                string.Format("Calories burned: {0:F0} calories", caloriesBurned),
                string.Format("Average pace: {0:F0} seconds/lap", pace),
            };
        }
    }
}
