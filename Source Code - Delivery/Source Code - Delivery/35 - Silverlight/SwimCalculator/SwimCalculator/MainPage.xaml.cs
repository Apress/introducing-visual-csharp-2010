using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SwimCalculator {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e) {
            // extract the values from the controls
            int minutesCompleted = int.Parse(minutesTextBox.Text);
            int lapsCompleted = int.Parse(lapsTextBox.Text);
            int lapLength = int.Parse(lengthTextBox.Text);
            int caloriesPerHour = int.Parse(caloriesTextBox.Text);

            // ensure that we have values that are greater than zero
            if (minutesCompleted <= 0 || lapsCompleted <= 0 ||
                lapLength <= 0 || caloriesPerHour <= 0) {

                // we cannot proceed - we have one or more bad values
                ErrorWindow myErrorWindow = new ErrorWindow();
                myErrorWindow.errorMessageTextBlock.Text = "Cannot calculate - use values greater than zero";
                myErrorWindow.Show();
                return;
            }

            // perform the calculations we need for the results
            float distance = (lapsCompleted * lapLength) * 0.00062137119223733f;
            float caloriesBurned = (minutesCompleted / 60f) * caloriesPerHour;
            float pace = (minutesCompleted * 60) / lapsCompleted;

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendFormat("Distance completed: {0:F2} miles\n", distance);
            resultBuilder.AppendFormat("Calories burned: {0:F0} calories\n", caloriesBurned);
            resultBuilder.AppendFormat("Average pace: {0:F0} seconds/lap", pace);

            // compose and set the results
            resultsTextBlock.Text = resultBuilder.ToString();
        }
    }
}
