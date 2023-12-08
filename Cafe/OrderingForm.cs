using MySqlX.XDevAPI.Relational;
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
        public static int id_last_ordering;
        public OrderingForm()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (Authorization.Role == "Администратор")
            {
                this.Hide();
                AdminForm form = new AdminForm();
                form.Show();
            }
            if (Authorization.Role == "Официант")
            {
                this.Hide();
                WaiterForm form = new WaiterForm();
                form.Show();
            }
            if (Authorization.Role == "Повар")
            {
                this.Hide();
                CookForm form = new CookForm();
                form.Show();

            }
        }

        private void OrderingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderingForm_Load(object sender, EventArgs e)
        {
            OrderingClass.GetOrfering();
            dataGridView1.DataSource = OrderingClass.dtOrdering;

            if (Authorization.Role == "Администратор")
            {
                button_AddShift.Visible = false;
            }
            if (Authorization.Role == "Официант")
            {
                button_AddShift.Visible = true;
            }
            if (Authorization.Role == "Повар")
            {
                button_AddShift.Visible = true;
            }
            Int32 index = dataGridView1.RowCount - 1;
            id_last_ordering = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
        }
        public static int id_ordering_select;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //int id_ordering, string name_ordering, int summa, string waiter, string table, int count_of_guests, int id_dish_status, string name_dish_status
            int id_ordering = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string name_ordering = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int summa = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string id_waiter = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string name_waiter = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string table = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            int count_of_guests = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            int id_dish_status = int.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            string name_dish_status = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            OrderingFullForm form = new OrderingFullForm(id_ordering, name_ordering, summa, name_waiter, table, count_of_guests,id_dish_status,name_dish_status);
            form.ShowDialog();
        }

        private void button_AddShift_Click(object sender, EventArgs e)
        {
            OrderingFullAddForm form = new OrderingFullAddForm();
            form.ShowDialog();
            OrderingClass.GetOrfering();
            dataGridView1.DataSource = OrderingClass.dtOrdering;
        }
    }
}
