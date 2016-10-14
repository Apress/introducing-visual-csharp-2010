using System.Windows;

namespace DataApp {
    
    public partial class MainWindow : Window {

        NorthwindEntities myContext;

        public MainWindow() {
            InitializeComponent();

            // create the data model context
            myContext = new NorthwindEntities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            System.Windows.Data.CollectionViewSource employeeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // employeeViewSource.Source = [generic data source]
            employeeViewSource.Source = myContext.Employees;
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            myContext.SaveChanges();
        }
    }
}
