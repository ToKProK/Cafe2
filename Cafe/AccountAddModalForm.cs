using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe
{
    public partial class AccountAddModalForm : Form
    {
        public AccountAddModalForm()
        {
            InitializeComponent();

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;   
            string surname = textBox_surname.Text;
            string name = textBox_name.Text;
            string patronymic = textBox_patronymic.Text;
            string A1 = comboBox_Role.SelectedValue.ToString();
            int id_role = int.Parse(A1);
            string A2 = comboBox_Status.SelectedValue.ToString();
            int id_status = int.Parse(A2);

            if (textBox_login.Text != "" && textBox_password.Text != "" && textBox_surname.Text != "" &&
                textBox_name.Text != "" && textBox_patronymic.Text != "")
            {
                string sql = $"SELECT login FROM accounts " +
                             $"WHERE login = '{login}'";
                DBConnection.MsCommand.CommandText = sql;
                Object result = DBConnection.MsCommand.ExecuteScalar();
                if (result == null)
                {
                    if (AccountClass.AddAccount(login, password, surname, name, patronymic, id_role, id_status))
                    {
                        MessageBox.Show("Аккаунт успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                        AccountClass.signal = true;
                    }
                }
                else
                {
                    MessageBox.Show($"Пользователь с логином \"{login}\" уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void LoadCombobox_Role()
        {
            AccountClass.GetRole();
            comboBox_Role.DataSource = AccountClass.dtRole;
            comboBox_Role.DisplayMember = "name_role";
            comboBox_Role.ValueMember = "id_role";
        }
        private void LoadCombobox_Status()
        {
            AccountClass.GetStatus();
            comboBox_Status.DataSource = AccountClass.dtStatus;
            comboBox_Status.DisplayMember = "name_status";
            comboBox_Status.ValueMember = "id_status";
        }
        private void AccountAddModalForm_Load(object sender, EventArgs e)
        {
            LoadCombobox_Role();
            LoadCombobox_Status();
        }

        private void AccountAddModalForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}