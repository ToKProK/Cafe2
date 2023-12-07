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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //int id_ordering, string name_ordering, int summa, string waiter, string table, int count_of_guests, int id_dish_status, string name_dish_status
            int id_ordering = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string name_ordering = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int summa = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string waiter = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string table = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            int count_of_guests = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            int id_dish_status = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            string name_dish_status = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            OrderingFullForm form = new OrderingFullForm(id_ordering, name_ordering, summa, waiter, table, count_of_guests,id_dish_status,name_dish_status);
            form.ShowDialog();
        }
    }
}
