using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class OrderingFullAddForm : Form
    {
        public OrderingFullAddForm()
        {
            InitializeComponent();
            LoadCombobox_Waiter();
            LoadCombobox_ShiftStatus();
        }
        private void LoadCombobox_Waiter()
        {
            //Загружаю все роли
            OrderingClass.GetDataWaiter();
            comboBox2.DataSource = OrderingClass.dtRoleForWaiter;
            comboBox2.DisplayMember = "surname";
            comboBox2.ValueMember = "id";
        }
        private void LoadCombobox_ShiftStatus()
        {
            OrderingClass.GetDataShiftStatus();
            comboBox1.DataSource = OrderingClass.dtShiftStatus;
            comboBox1.DisplayMember = "name_dish_status";
            comboBox1.ValueMember = "id_dish_status";
        }

        private void button_AddMenu_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.ShowDialog();
            if (MenuForm.name_dish_add != null)
            {
                var index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = MenuForm.id_dish_add;
                this.dataGridView1.Rows[index].Cells[1].Value = MenuForm.name_dish_add;
                this.dataGridView1.Rows[index].Cells[2].Value = MenuForm.price_add;
                this.dataGridView1.Rows[index].Cells[3].Value = MenuForm.count;
                this.dataGridView1.Rows[index].Cells[4].Value = MenuForm.sum;
                int sum = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                textBox5.Text = sum.ToString();
            }
            
        }

        private void button_AddOrdering_Click(object sender, EventArgs e)
        {
            //try
            //{
                OrderingForm.id_last_ordering = OrderingForm.id_last_ordering + 1;
                ArrayList id_dish = new ArrayList();
                ArrayList count = new ArrayList();
                ArrayList summa_dish = new ArrayList();

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value == null)
                    {
                        break;
                    }
                    id_dish.Add(dr.Cells[0].Value);
                    count.Add(dr.Cells[3].Value);
                    summa_dish.Add(dr.Cells[4].Value);
                }
                //string name_ordering, int count_of_guests, string id_waiter, string table, int summa, int id_dish_status,int id_ordering,
                //ArrayList id_dish, ArrayList count, ArrayList summa_dish
                string name_ordering = textBox1.Text;
                int count_of_guests = int.Parse(numericUpDown1.Value.ToString());
                int id_waiter = int.Parse(comboBox2.SelectedValue.ToString());
                string table = textBox4.Text;
                int summa = int.Parse(textBox5.Text);
                int id_dish_status = int.Parse(comboBox1.SelectedValue.ToString());
                int id_ordering = OrderingForm.id_last_ordering;

                OrderingClass.AddOrfering(name_ordering, count_of_guests, id_waiter, table, summa, id_dish_status, id_ordering, id_dish, count, summa_dish);
            //}
            //catch 
            //{
            //    MessageBox.Show("Не удалось добавить заказ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
