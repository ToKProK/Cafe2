namespace Cafe
{
    partial class OrderingForm
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.id_ordering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_ordering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_of_guests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_dish_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_dish_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ordering,
            this.name_ordering,
            this.summa,
            this.waiter,
            this.table,
            this.count_of_guests,
            this.name_dish_status,
            this.id_dish_status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(647, 389);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(141, 49);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // id_ordering
            // 
            this.id_ordering.DataPropertyName = "id_ordering";
            this.id_ordering.HeaderText = "id_ordering";
            this.id_ordering.Name = "id_ordering";
            this.id_ordering.Visible = false;
            // 
            // name_ordering
            // 
            this.name_ordering.DataPropertyName = "name_ordering";
            this.name_ordering.HeaderText = "Название заказа";
            this.name_ordering.Name = "name_ordering";
            // 
            // summa
            // 
            this.summa.DataPropertyName = "summa";
            this.summa.HeaderText = "Сумма";
            this.summa.Name = "summa";
            // 
            // waiter
            // 
            this.waiter.DataPropertyName = "waiter";
            this.waiter.HeaderText = "Официант";
            this.waiter.Name = "waiter";
            // 
            // table
            // 
            this.table.DataPropertyName = "table";
            this.table.HeaderText = "Стол";
            this.table.Name = "table";
            // 
            // count_of_guests
            // 
            this.count_of_guests.DataPropertyName = "count_of_guests";
            this.count_of_guests.HeaderText = "Количесво гостей";
            this.count_of_guests.Name = "count_of_guests";
            // 
            // name_dish_status
            // 
            this.name_dish_status.DataPropertyName = "name_dish_status";
            this.name_dish_status.HeaderText = "Статус заказа";
            this.name_dish_status.Name = "name_dish_status";
            // 
            // id_dish_status
            // 
            this.id_dish_status.DataPropertyName = "id_dish_status";
            this.id_dish_status.HeaderText = "id_dish_status";
            this.id_dish_status.Name = "id_dish_status";
            this.id_dish_status.Visible = false;
            // 
            // OrderingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderingForm";
            this.Text = "Заказы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderingForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ordering;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_ordering;
        private System.Windows.Forms.DataGridViewTextBoxColumn summa;
        private System.Windows.Forms.DataGridViewTextBoxColumn waiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn table;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_of_guests;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_dish_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dish_status;
    }
}