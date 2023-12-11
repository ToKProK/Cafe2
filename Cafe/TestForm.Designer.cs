namespace Cafe
{
    partial class TestForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_TestStart = new System.Windows.Forms.Button();
            this.checkBox_Connection = new System.Windows.Forms.CheckBox();
            this.checkBox_AddUser = new System.Windows.Forms.CheckBox();
            this.checkBox_EditUser = new System.Windows.Forms.CheckBox();
            this.checkBox_DeleteUser = new System.Windows.Forms.CheckBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(55, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(435, 53);
            this.progressBar1.TabIndex = 0;
            // 
            // button_TestStart
            // 
            this.button_TestStart.Location = new System.Drawing.Point(173, 380);
            this.button_TestStart.Name = "button_TestStart";
            this.button_TestStart.Size = new System.Drawing.Size(208, 69);
            this.button_TestStart.TabIndex = 1;
            this.button_TestStart.Text = "Начало тестирования";
            this.button_TestStart.UseVisualStyleBackColor = true;
            this.button_TestStart.Click += new System.EventHandler(this.button_TestStart_Click);
            // 
            // checkBox_Connection
            // 
            this.checkBox_Connection.AutoSize = true;
            this.checkBox_Connection.Location = new System.Drawing.Point(55, 38);
            this.checkBox_Connection.Name = "checkBox_Connection";
            this.checkBox_Connection.Size = new System.Drawing.Size(256, 20);
            this.checkBox_Connection.TabIndex = 2;
            this.checkBox_Connection.Text = "Проверка подключению к серверу";
            this.checkBox_Connection.UseVisualStyleBackColor = true;
            // 
            // checkBox_AddUser
            // 
            this.checkBox_AddUser.AutoSize = true;
            this.checkBox_AddUser.Location = new System.Drawing.Point(55, 64);
            this.checkBox_AddUser.Name = "checkBox_AddUser";
            this.checkBox_AddUser.Size = new System.Drawing.Size(272, 20);
            this.checkBox_AddUser.TabIndex = 3;
            this.checkBox_AddUser.Text = "Проверка добавления пользователя";
            this.checkBox_AddUser.UseVisualStyleBackColor = true;
            // 
            // checkBox_EditUser
            // 
            this.checkBox_EditUser.AutoSize = true;
            this.checkBox_EditUser.Location = new System.Drawing.Point(55, 90);
            this.checkBox_EditUser.Name = "checkBox_EditUser";
            this.checkBox_EditUser.Size = new System.Drawing.Size(302, 20);
            this.checkBox_EditUser.TabIndex = 4;
            this.checkBox_EditUser.Text = "Проверка редактирования пользователя";
            this.checkBox_EditUser.UseVisualStyleBackColor = true;
            // 
            // checkBox_DeleteUser
            // 
            this.checkBox_DeleteUser.AutoSize = true;
            this.checkBox_DeleteUser.Location = new System.Drawing.Point(55, 116);
            this.checkBox_DeleteUser.Name = "checkBox_DeleteUser";
            this.checkBox_DeleteUser.Size = new System.Drawing.Size(256, 20);
            this.checkBox_DeleteUser.TabIndex = 5;
            this.checkBox_DeleteUser.Text = "Проверка удаления пользователя";
            this.checkBox_DeleteUser.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(437, 389);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(100, 60);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 478);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.checkBox_DeleteUser);
            this.Controls.Add(this.checkBox_EditUser);
            this.Controls.Add(this.checkBox_AddUser);
            this.Controls.Add(this.checkBox_Connection);
            this.Controls.Add(this.button_TestStart);
            this.Controls.Add(this.progressBar1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_TestStart;
        private System.Windows.Forms.CheckBox checkBox_Connection;
        private System.Windows.Forms.CheckBox checkBox_AddUser;
        private System.Windows.Forms.CheckBox checkBox_EditUser;
        private System.Windows.Forms.CheckBox checkBox_DeleteUser;
        private System.Windows.Forms.Button button_Exit;
    }
}