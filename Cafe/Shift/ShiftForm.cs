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
    public partial class ShiftForm : Form
    {
        //string id;
        //string surname;
        //string name;
        //string patronymic;
        //string name_role;
        static public int id_last_shift;
        public ShiftForm()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
        }
        public void DataUpdate()
        {
            ShiftClass.GetShift();
            dataGridView1.DataSource = ShiftClass.dtShift;
        }

        private void ShiftForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.Show();
        }

        private void ShiftForm_Load(object sender, EventArgs e)
        {
            DataUpdate();
            //Получаю последний номер смены
            Int32 index =dataGridView1.RowCount - 1;
            id_last_shift = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            string id_0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int id_shift = int.Parse(id_0);
            ShiftClass.GetPeople(id_shift);
            dataGridView2.DataSource = ShiftClass.dtPeople;

        }

        private void button_AddShift_Click(object sender, EventArgs e)
        {
            ShiftAddForm form = new ShiftAddForm();
            form.ShowDialog();
            DataUpdate();
        }
    }
}
