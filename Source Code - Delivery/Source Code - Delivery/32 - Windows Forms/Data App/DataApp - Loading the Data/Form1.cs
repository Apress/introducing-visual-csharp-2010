using System.Windows.Forms;

namespace DataApp {
    public partial class Form1 : Form {

        // define the EntityFramework context field
        NorthwindEntities entityContext = new NorthwindEntities();

        public Form1() {
            InitializeComponent();

            // set the data source for the data binding
            employeeBindingSource.DataSource = entityContext.Employees;
        }
    }
}
