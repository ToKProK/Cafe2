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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Добро пожаловать {Authorization.Surname} {Authorization.Name} {Authorization.Patronymic}";
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorizate_Form form = new Authorizate_Form();
            form.Show();
        }

        private void button_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountForm form = new AccountForm();
            form.Show();
        }

        private void button_Shift_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShiftForm form = new ShiftForm();
            form.Show();
        }

        private void button_Ordering_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderingForm form = new OrderingForm();
            form.Show();
        }

        private void button_Test_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TestForm form = new TestForm();
            form.Show();
        }
    }
}
