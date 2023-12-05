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




        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            AccountClass.GetAccount();
            dataGridView1.DataSource = AccountClass.dtAccount;
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
            AccountClass.GetAccount();
            dataGridView1.DataSource = AccountClass.dtAccount;
        }
    }
}
