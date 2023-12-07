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
    public partial class OrderingFullForm : Form
    {
        string name_ordering;
        int count_of_guests;
        string waiter;
        string table;
        int summa;
        int id_dish_status;
        string name_dish_status;
        public OrderingFullForm(int id_ordering0, string name_ordering0, int summa0, string waiter0, string table0, int count_of_guests0, int id_dish_status0, string name_dish_status0)
        {
            InitializeComponent();
            name_ordering = name_ordering0;
            count_of_guests = count_of_guests0;
            waiter = waiter0;
            table = table0;
            id_dish_status = id_dish_status0;
            name_dish_status = name_dish_status0;
            summa = summa0;
        }
        private void DataUpdate()
        {
            OrderingClass.GetOrferingFull();
            dataGridView1.DataSource = OrderingClass.dtOrderingFull;
        }

        private void OrderingFullForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = name_ordering;
            textBox2.Text = count_of_guests.ToString();
            textBox3.Text = waiter;
            textBox4.Text = table;
            textBox5.Text = summa.ToString();
            textBox6.Text = name_dish_status;
            DataUpdate();
        }
    }
}
