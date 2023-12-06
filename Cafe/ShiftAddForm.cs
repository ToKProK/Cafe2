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
    }
}
