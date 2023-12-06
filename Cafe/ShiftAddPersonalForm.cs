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
    public partial class ShiftAddPersonalForm : Form
    {
        public ShiftAddPersonalForm()
        {
            InitializeComponent();
        }

        private void ShiftAddPersonalForm_Load(object sender, EventArgs e)
        {
            ShiftClass.GetPeople_ForAddForm();
            dataGridView1.DataSource = ShiftClass.dt_add_user;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //Передаём значения выбранного пользователя проррамме
            string id_0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ShiftClass.id_add_user = int.Parse(id_0);
            ShiftClass.surname_add_user = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ShiftClass.name_add_user = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ShiftClass.patronymic_add_user = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ShiftClass.name_role_add_user = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ShiftClass.id_role_add_user = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.Close();
        }
    }
}
