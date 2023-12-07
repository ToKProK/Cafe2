using System;
using System.Collections;
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
    public partial class ShiftAddForm : Form
    {
        public ShiftAddForm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            LoadCombobox();

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCombobox()
        {
            //Можно сделать автоматический выбор в зависимости от времени.
            ShiftClass.GetView_shift();
            comboBox1.DataSource = ShiftClass.dtVShift;
            comboBox1.DisplayMember = "name_vshift";
            comboBox1.ValueMember = "id_vshift";
            //Выбираю нужную роль через Value
            //comboBox1.SelectedValue = id_role;
        }

        private void ShiftAddForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShiftAddPersonalForm form = new ShiftAddPersonalForm();
            form.ShowDialog();
            //Добавляем выбранного сторудника.
            if (ShiftClass.surname_add_user != null && ShiftClass.name_add_user != null)
            {
                var index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = ShiftClass.id_add_user;
                this.dataGridView1.Rows[index].Cells[1].Value = ShiftClass.surname_add_user;
                this.dataGridView1.Rows[index].Cells[2].Value = ShiftClass.name_add_user;
                this.dataGridView1.Rows[index].Cells[3].Value = ShiftClass.patronymic_add_user;
                this.dataGridView1.Rows[index].Cells[4].Value = ShiftClass.name_role_add_user;
                this.dataGridView1.Rows[index].Cells[5].Value = ShiftClass.id_role_add_user;
            }

        }

        private void button_ShiftSave_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList id_account = new ArrayList();
                ArrayList role = new ArrayList();

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value == null)
                    {
                        break;
                    }
                    id_account.Add(dr.Cells[0].Value);
                    role.Add(dr.Cells[5].Value);
                }
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;

                string VariantShift = comboBox1.SelectedValue.ToString();
                int v1 = Convert.ToInt32(VariantShift);
                ShiftForm.id_last_shift = ShiftForm.id_last_shift + 1;
                ShiftClass.AddShift(dt1.ToString("yyyy-MM-dd HH:mm:ss.fff"), dt2.ToString("yyyy-MM-dd HH:mm:ss.fff"), v1, id_account, ShiftForm.id_last_shift);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении смены \n" + ex);
            }
            
        }
    }
}
