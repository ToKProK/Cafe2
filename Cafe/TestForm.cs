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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        static int id_new_user;
        string login = "erqnv;jkn[evbdsiuvbug";
        string password = "erqnv;jkn[evbdsiuvbug";
        string surname = "efevevevevwe";
        string name = "fewfwqvrevqvev23";
        string otchestv = "wovnqivn;nvqenv";
        int id_role = 1;
        int id_status = 1;
        private void button_TestStart_Click(object sender, EventArgs e)
        {
            if (DBConnection.ConnectorDB())
            {
                checkBox_Connection.Checked = true;
                progressBar1.Value = progressBar1.Value + 25;
            }
            else { checkBox_Connection.Checked = false; ErrorBox(checkBox_Connection.Text); }
            if (AccountClass.AddAccount(login, password, surname, name, otchestv, id_role, id_status))
            {
                checkBox_AddUser.Checked = true;
                progressBar1.Value = progressBar1.Value + 25;
            }
            else { checkBox_AddUser.Checked = false; ErrorBox(checkBox_AddUser.Text); }
            GetIdNewAccount(login);
            if (AccountClass.EditAccount(id_new_user, login + "123", password + "123", surname + "312", name + "213", otchestv + "31", 2, 2))
            {
                checkBox_EditUser.Checked = true;
                progressBar1.Value = progressBar1.Value + 25;
            }
            else { checkBox_EditUser.Checked = false; ErrorBox(checkBox_EditUser.Text); }
            if (AccountClass.DeleteAccount(id_new_user))
            {
                checkBox_DeleteUser.Checked = true;
                progressBar1.Value = progressBar1.Value + 25;
            }
            else { checkBox_DeleteUser.Checked = false; ErrorBox(checkBox_DeleteUser.Text); } 
        }
        private void ErrorBox(string error)
        {
            MessageBox.Show($"Ошибка при {error}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public static void GetIdNewAccount(string login)
        {
            DBConnection.MsCommand.CommandText = $"SELECT id FROM accounts WHERE accounts.login = '{login}' ";
            Object result = DBConnection.MsCommand.ExecuteScalar();
            if (result != null)
            {
                string id = result.ToString();
                id_new_user = int.Parse(id);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.Show();
        }
    }
}
