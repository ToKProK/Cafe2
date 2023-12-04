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
    public partial class Authorizate_Form : Form
    {
        public Authorizate_Form()
        {
            InitializeComponent();
        }

        private void Authorizate_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectorDB();
            Clipboard.SetText("admin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Authorization.Authoriz(textBox1.Text, textBox2.Text);
                switch (Authorization.Role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не cуществует");
                            break;
                        }
                    case "Администратор":
                        {
                            this.Hide();
                            AdminForm form = new AdminForm();
                            form.Show();
                            break;
                        }
                    case "Повар":
                        {
                            this.Hide();
                            CookForm form = new CookForm();
                            form.Show(); 
                            break;
                        }
                    case "Официант":
                        {
                            this.Hide();
                            WaiterForm form = new WaiterForm();
                            form.Show();
                            break;
                        }
                }

            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Authorizate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
