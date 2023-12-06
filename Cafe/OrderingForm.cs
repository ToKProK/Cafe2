using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class OrderingForm : Form
    {
        public OrderingForm()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.Show();
        }

        private void OrderingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderingForm_Load(object sender, EventArgs e)
        {
            OrderingClass.GetOrfering();
            dataGridView1.DataSource = OrderingClass.dtOrdering;
        }
    }
}
