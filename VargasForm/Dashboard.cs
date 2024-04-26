using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VargasForm
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboardcs_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AccountManage accountManage = new AccountManage();

            panel5.Controls.Clear(); // Clear existing controls from the panel
            panel5.Controls.Add(accountManage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product_form form = new product_form();

            panel5.Controls.Clear(); // Clear existing controls from the panel
            panel5.Controls.Add(form);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashform dashform = new Dashform();

            panel5.Controls.Clear(); // Clear existing controls from the panel
            panel5.Controls.Add(dashform);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            panel5.Controls.Clear(); // Clear existing controls from the panel
            panel5.Controls.Add(product);
        }

        private void product_form1_Load(object sender, EventArgs e)
        {

        }
    }
}
