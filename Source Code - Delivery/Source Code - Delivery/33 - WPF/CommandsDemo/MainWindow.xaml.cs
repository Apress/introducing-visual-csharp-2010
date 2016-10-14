using System.Windows;
using System.Windows.Input;

namespace CommandsDemo {
   
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            // create a command binding
            CommandBinding myBinding = new CommandBinding(ApplicationCommands.New);

            myBinding.Executed += (source, eventArgs) => {
                MessageBox.Show("New command has been executed");
            };

            myBinding.CanExecute += (source, eventArgs) => {
                eventArgs.CanExecute = checkBox1.IsChecked ?? false;
            };

            // add the binding to the set for this program
            CommandBindings.Add(myBinding);

            // set the Content property for the Button controls
            button1.Content = ApplicationCommands.New.Text;
            button2.Content = ApplicationCommands.New.Text;
        }
    }
}
