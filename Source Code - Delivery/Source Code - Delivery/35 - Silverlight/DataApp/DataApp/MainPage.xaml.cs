using System.Windows.Controls;

namespace DataApp {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void employeeDomainDataSource_LoadedData(object sender, System.Windows.Controls.LoadedDataEventArgs e) {

            if (e.HasError) {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            if (comboBox1 != null) {
                // get the selected city from the ComboBox
                string selectedCity = ((ComboBoxItem)comboBox1.SelectedItem).Content.ToString();

                // remove any filters that are in place
                employeeDomainDataSource.FilterDescriptors.Clear();

                // add a new filter if the user has selected a specific city
                if (selectedCity != "All") {
                    employeeDomainDataSource.FilterDescriptors.Add(
                        new FilterDescriptor("City", FilterOperator.IsEqualTo, selectedCity));
                }
            }
        }
    }
}
