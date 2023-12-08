namespace Cafe
{
    partial class ShiftAddPersonalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.surname,
            this.name,
            this.patronymic,
            this.name_role,
            this.id_role});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 410);
            this.dataGridView1.TabIndex = 10;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Фамилия";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // patronymic
            // 
            this.patronymic.DataPropertyName = "patronymic";
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.MinimumWidth = 6;
            this.patronymic.Name = "patronymic";
            this.patronymic.Width = 150;
            // 
            // name_role
            // 
            this.name_role.DataPropertyName = "name_role";
            this.name_role.HeaderText = "Должность";
            this.name_role.MinimumWidth = 6;
            this.name_role.Name = "name_role";
            this.name_role.Width = 150;
            // 
            // id_role
            // 
            this.id_role.DataPropertyName = "id_role";
            this.id_role.HeaderText = "id_role";
            this.id_role.MinimumWidth = 6;
            this.id_role.Name = "id_role";
            this.id_role.Visible = false;
            this.id_role.Width = 125;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 428);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(185, 57);
            this.button_Add.TabIndex = 11;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(608, 439);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(185, 57);
            this.button_Back.TabIndex = 12;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // ShiftAddPersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShiftAddPersonalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавления сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShiftAddPersonalForm_FormClosing);
            this.Load += new System.EventHandler(this.ShiftAddPersonalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_role;
    }
}