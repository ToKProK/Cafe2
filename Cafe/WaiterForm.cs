﻿using System;
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
    public partial class WaiterForm : Form
    {
        public WaiterForm()
        {
            InitializeComponent();
        }

        private void WaiterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Добро пожаловать {Authorization.Surname} {Authorization.Name} {Authorization.Patronymic}";
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorizate_Form form = new Authorizate_Form();
            form.Show();
        }
    }
}
