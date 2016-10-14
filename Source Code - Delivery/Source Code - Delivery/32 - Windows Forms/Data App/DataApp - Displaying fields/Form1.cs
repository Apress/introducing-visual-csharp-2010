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

        NorthwindEntities entityContext = new NorthwindEntities();

        public Form1() {
            InitializeComponent();

            employeeBindingSource.DataSource = entityContext.Employees;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            entityContext.SaveChanges();
        }
    }
}
