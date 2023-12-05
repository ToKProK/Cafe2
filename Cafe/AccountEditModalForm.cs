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
    public partial class AccountEditModalForm : Form
    {
        //Делаю переменные глобальными.
        int id_role;
        int id_status;
        int id;
        string login;

        public AccountEditModalForm(int id_1, string login_1,string password_1, string surname_1, string name_1, string patronymic_1, int id_role_1, int id_status_1)
        {
            InitializeComponent();
            
            //Присваиваю глобальным переменным значения.
            id = id_1;
            id_role = id_role_1;
            id_status = id_status_1;
            textBox_login.Text = login_1;
            login = login_1;
            textBox_password.Text = password_1;
            textBox_surname.Text = surname_1;
            textBox_name.Text = name_1;
            textBox_patronymic.Text = patronymic_1;
            id_role = id_role_1;
            //
            LoadCombobox_Role();
            LoadCombobox_Status();
        }


        private void LoadCombobox_Role()
        {
            //Загружаю все роли
            AccountClass.GetRole();
            comboBox_Role.DataSource = AccountClass.dtRole;
            comboBox_Role.DisplayMember = "name_role";
            comboBox_Role.ValueMember = "id_role";
            //Выбираю нужную роль через Value
            comboBox_Role.SelectedValue = id_role;
        }
        private void LoadCombobox_Status()
        {
            //Загружаю все роли
            AccountClass.GetStatus();
            comboBox_Status.DataSource = AccountClass.dtStatus;
            comboBox_Status.DisplayMember = "name_status";
            comboBox_Status.ValueMember = "id_status";
            //Выбираю нужную роль через Value, по id
            comboBox_Status.SelectedValue = id_status;
        }
        private void Edit()
        {
            string Q1 = comboBox_Role.SelectedValue.ToString();
            string Q2 = comboBox_Status.SelectedValue.ToString();
            int id_role = int.Parse(Q1);
            int id_status = int.Parse(Q2);
            AccountClass.EditAccount(id, textBox_login.Text, textBox_password.Text, textBox_surname.Text, textBox_name.Text, textBox_patronymic.Text, id_role, id_status);
            MessageBox.Show("Редактирование прошло успешно");
            this.Close();

        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == login)
            {
                Edit();
            }
            else
            {
                string sql = $"SELECT login FROM accounts " +
                             $"WHERE login = '{textBox_login.Text}'";
                DBConnection.MsCommand.CommandText = sql;
                Object result = DBConnection.MsCommand.ExecuteScalar();
                if (result == null)
                {
                    Edit();
                }
                else
                {
                    MessageBox.Show("Пользователь с такми логином уже существет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
