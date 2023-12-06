namespace Cafe
{
    partial class ShiftForm
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
            this.id_shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_vshift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Exit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_AddShift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_shift,
            this.data_start,
            this.data_end,
            this.name_vshift});
            this.dataGridView1.Location = new System.Drawing.Point(20, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(843, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // id_shift
            // 
            this.id_shift.DataPropertyName = "id_shift";
            this.id_shift.HeaderText = "Номер смены";
            this.id_shift.MinimumWidth = 6;
            this.id_shift.Name = "id_shift";
            this.id_shift.ReadOnly = true;
            this.id_shift.Width = 200;
            // 
            // data_start
            // 
            this.data_start.DataPropertyName = "data_start";
            this.data_start.HeaderText = "Начало смены";
            this.data_start.MinimumWidth = 6;
            this.data_start.Name = "data_start";
            this.data_start.ReadOnly = true;
            this.data_start.Width = 200;
            // 
            // data_end
            // 
            this.data_end.DataPropertyName = "data_end";
            this.data_end.HeaderText = "Окончание смены";
            this.data_end.MinimumWidth = 6;
            this.data_end.Name = "data_end";
            this.data_end.ReadOnly = true;
            this.data_end.Width = 200;
            // 
            // name_vshift
            // 
            this.name_vshift.DataPropertyName = "name_vshift";
            this.name_vshift.HeaderText = "Вид смены";
            this.name_vshift.MinimumWidth = 6;
            this.name_vshift.Name = "name_vshift";
            this.name_vshift.ReadOnly = true;
            this.name_vshift.Width = 200;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(1053, 684);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(141, 49);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.surname,
            this.name,
            this.patronymic,
            this.name_role});
            this.dataGridView2.Location = new System.Drawing.Point(20, 366);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(843, 356);
            this.dataGridView2.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Фамилия";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 200;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // patronymic
            // 
            this.patronymic.DataPropertyName = "patronymic";
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.MinimumWidth = 6;
            this.patronymic.Name = "patronymic";
            this.patronymic.ReadOnly = true;
            this.patronymic.Width = 200;
            // 
            // name_role
            // 
            this.name_role.DataPropertyName = "name_role";
            this.name_role.HeaderText = "Должность";
            this.name_role.MinimumWidth = 6;
            this.name_role.Name = "name_role";
            this.name_role.ReadOnly = true;
            this.name_role.Width = 200;
            // 
            // button_AddShift
            // 
            this.button_AddShift.Location = new System.Drawing.Point(936, 33);
            this.button_AddShift.Name = "button_AddShift";
            this.button_AddShift.Size = new System.Drawing.Size(205, 86);
            this.button_AddShift.TabIndex = 5;
            this.button_AddShift.Text = "Добавить новую смену";
            this.button_AddShift.UseVisualStyleBackColor = true;
            this.button_AddShift.Click += new System.EventHandler(this.button_AddShift_Click);
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 738);
            this.Controls.Add(this.button_AddShift);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShiftForm";
            this.Text = "Смены";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShiftForm_FormClosing);
            this.Load += new System.EventHandler(this.ShiftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_vshift;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_role;
        private System.Windows.Forms.Button button_AddShift;
    }
}