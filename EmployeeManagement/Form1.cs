using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Getts called on initialization of the form
            InitializeComponent();
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            //show form
            MessageBox.Show("Sangmesh1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi welcome to git EmployeeManagement");
        }
    }
}
