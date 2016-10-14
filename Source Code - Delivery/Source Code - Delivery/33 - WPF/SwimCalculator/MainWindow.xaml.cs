using System.Windows;
using System.Windows.Input;
using System.Media;
using System.Text;
using System.Windows.Controls;

namespace SwimCalculator {
    
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void ValidateKeyPress(object sender, KeyEventArgs e) {

            // we want to allow numbers, the left and right cursor keys and the delete key
            bool isNumberKey = e.Key >= Key.D0 && e.Key <= Key.D9;
            bool isNumberPadKey = e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9;
            bool isDeleteKey = e.Key == Key.Delete || e.Key == Key.Back;
            bool isTab = e.Key == Key.Tab;

            if (isNumberKey || isNumberPadKey || isDeleteKey || isTab) {
                // this is a key we want to support
                statusLabel.Content = "Ready";
            } else {
                // this is not a key we want to support
                // - suppress the key event
                e.Handled = true;
                // send a message to the status bar 
                statusLabel.Content = string.Format("Ignored: {0}", e.Key);
                // play an alert sound
                SystemSounds.Beep.Play();
            }
        }

        private void convertButton_Click(object sender, RoutedEventArgs e) {
            // extract the values from the controls
            int minutesCompleted = int.Parse(minutesTextBox.Text);
            int lapsCompleted = int.Parse(lapsTextBox.Text);
            int lapLength = int.Parse(lengthTextBox.Text);
            int caloriesPerHour = int.Parse(caloriesTextBox.Text);

            // ensure that we have values that are greater than zero
            if (minutesCompleted <= 0 || lapsCompleted <= 0 || lapLength <= 0 || caloriesPerHour <= 0) {
                // we cannot proceed - we have one or more bad values
                statusLabel.Content = "Cannot calculate - use values greater than zero";
                // alert the user to the erro
                SystemSounds.Beep.Play();
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

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            minutesTextBox.Focus();
        }

        private void TextBoxGotFocus(object sender, RoutedEventArgs e) {
            if (e.Source is TextBox) {
                ((TextBox)e.Source).SelectAll();
            }
        }
    }
}
