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
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            ShiftClass.GetPeople();
            dataGridView2.DataSource = ShiftClass.dtShift;
        }
    }
}
