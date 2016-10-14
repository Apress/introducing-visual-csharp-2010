using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataApp {
    public partial class Form1 : Form {

        // define the Northwind Entity context field
        private NorthwindEntities northwindContext;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // create the context object
            northwindContext = new NorthwindEntities();
            // set the data source in the binding source
            employeeBindingSource.DataSource = northwindContext.Employees;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            // persist any changes in the context
            northwindContext.SaveChanges();
        }
    }
}
