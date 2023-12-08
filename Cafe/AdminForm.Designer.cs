namespace Cafe
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_account = new System.Windows.Forms.Button();
            this.button_Shift = new System.Windows.Forms.Button();
            this.button_Ordering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(178, 252);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(188, 60);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_account
            // 
            this.button_account.Location = new System.Drawing.Point(8, 38);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(188, 60);
            this.button_account.TabIndex = 2;
            this.button_account.Text = "Пользователи";
            this.button_account.UseVisualStyleBackColor = true;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // button_Shift
            // 
            this.button_Shift.Location = new System.Drawing.Point(8, 104);
            this.button_Shift.Name = "button_Shift";
            this.button_Shift.Size = new System.Drawing.Size(188, 60);
            this.button_Shift.TabIndex = 3;
            this.button_Shift.Text = "Смены";
            this.button_Shift.UseVisualStyleBackColor = true;
            this.button_Shift.Click += new System.EventHandler(this.button_Shift_Click);
            // 
            // button_Ordering
            // 
            this.button_Ordering.Location = new System.Drawing.Point(8, 170);
            this.button_Ordering.Name = "button_Ordering";
            this.button_Ordering.Size = new System.Drawing.Size(188, 60);
            this.button_Ordering.TabIndex = 4;
            this.button_Ordering.Text = "Заказы";
            this.button_Ordering.UseVisualStyleBackColor = true;
            this.button_Ordering.Click += new System.EventHandler(this.button_Ordering_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 324);
            this.Controls.Add(this.button_Ordering);
            this.Controls.Add(this.button_Shift);
            this.Controls.Add(this.button_account);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button button_Shift;
        private System.Windows.Forms.Button button_Ordering;
    }
}