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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        

        public void DataUpdate()
        {
            AccountClass.GetAccount();
            dataGridView1.DataSource = AccountClass.dtAccount;
        }


        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            DataUpdate();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.Show();
            
        }

        private void button_addAccount_Click(object sender, EventArgs e)
        {
            AccountAddModalForm form = new AccountAddModalForm();
            form.ShowDialog();
            DataUpdate();

        }

        private void button_EditAccount_Click(object sender, EventArgs e)
        {
            string id_0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int id = int.Parse(id_0);
            string login = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string password = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string surname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string patronymic = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string id_role_0 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            int id_role = int.Parse(id_role_0);
            string id_status_0 = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            int id_status = int.Parse(id_status_0);
            AccountEditModalForm form = new AccountEditModalForm(id, login, password, surname, name, patronymic, id_role,id_status);
            form.ShowDialog();
            DataUpdate();
        }

        private void button_DeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string id_0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int id = int.Parse(id_0);
                string surname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string name = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string patronymic = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                DialogResult question = MessageBox.Show($"Вы действительно хотите удалить сотрудника {surname} {name} {patronymic} из базы данных? Данные о нёс нельзя будет потом восстановить.", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    AccountClass.DeleteAccount(id);
                    DataUpdate();
                    MessageBox.Show("Информация о сотруднике была успешно удалениа из базы данных", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch 
            {
                MessageBox.Show("Не удалось удолить");
            }
        }
    }
}
