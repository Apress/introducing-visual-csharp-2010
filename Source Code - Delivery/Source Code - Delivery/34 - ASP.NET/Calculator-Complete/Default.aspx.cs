using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Calculator_Complete {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void convertButton_Click(object sender, EventArgs e) {

            // only proceed if all of the validators are happy
            if (IsValid) {
                // get the values from the controls
                int minutesCompleted = int.Parse(minutesTextBox.Text);
                int lapsCompleted = int.Parse(lapsTextBox.Text);
                int lapLength = int.Parse(lengthTextBox.Text);
                int caloriesPerHour = int.Parse(caloriesTextBox.Text);

                // perform the calculations we need for the results
                float distance = (lapsCompleted * lapLength) * 0.00062137119223733f;
                float caloriesBurned = (minutesCompleted / 60f) * caloriesPerHour;
                float pace = (minutesCompleted * 60) / lapsCompleted;

                StringBuilder resultBuilder = new StringBuilder();
                resultBuilder.AppendFormat("Distance completed: {0:F2} miles\n", distance);
                resultBuilder.AppendFormat("Calories burned: {0:F0} calories\n", caloriesBurned);
                resultBuilder.AppendFormat("Average pace: {0:F0} seconds/lap", pace);

                // compose and set the results
                resultsTextBox.Text = resultBuilder.ToString();
            }
        }
    }
}