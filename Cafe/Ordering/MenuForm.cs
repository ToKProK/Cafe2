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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        public static int id_dish_add;
        public static string name_dish_add;
        public static int price_add;
        public static int count;
        public static int sum;
        bool add_button = false;
        private void MenuForm_Load(object sender, EventArgs e)
        {
            OrderingClass.GetMenu();
            dataGridView1.DataSource = OrderingClass.dtMenu;

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            id_dish_add = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            name_dish_add = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            price_add = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            count = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            sum = count * price_add;
            add_button = true;
            this.Close();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(add_button == false)
            {
                name_dish_add = null;
            }
            
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
