namespace special_invitation
{
    partial class authorisation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorisation));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.startpanel = new System.Windows.Forms.Panel();
            this.adminbutton = new System.Windows.Forms.Button();
            this.clientbutton = new System.Windows.Forms.Button();
            this.close_password = new System.Windows.Forms.PictureBox();
            this.open_password = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.startpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_password)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(133)))), ((int)(((byte)(171)))));
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 28.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Особое приглашение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(133)))), ((int)(((byte)(171)))));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            // 
            // loginbox
            // 
            this.loginbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginbox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbox.Location = new System.Drawing.Point(23, 149);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(589, 40);
            this.loginbox.TabIndex = 3;
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordbox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(23, 244);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(589, 40);
            this.passwordbox.TabIndex = 5;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(28, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Font = new System.Drawing.Font("Lucida Sans Typewriter", 19.8F);
            this.enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.enter.Location = new System.Drawing.Point(23, 310);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(290, 52);
            this.enter.TabIndex = 6;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Lucida Sans Typewriter", 19.8F);
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.back.Location = new System.Drawing.Point(322, 310);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(290, 52);
            this.back.TabIndex = 7;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // startpanel
            // 
            this.startpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startpanel.BackgroundImage")));
            this.startpanel.Controls.Add(this.adminbutton);
            this.startpanel.Controls.Add(this.clientbutton);
            this.startpanel.Location = new System.Drawing.Point(12, 103);
            this.startpanel.Name = "startpanel";
            this.startpanel.Size = new System.Drawing.Size(611, 268);
            this.startpanel.TabIndex = 8;
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminbutton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 19.8F);
            this.adminbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.adminbutton.Location = new System.Drawing.Point(11, 147);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(589, 74);
            this.adminbutton.TabIndex = 1;
            this.adminbutton.Text = "Войти в аккаунт";
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // clientbutton
            // 
            this.clientbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientbutton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 19.8F);
            this.clientbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.clientbutton.Location = new System.Drawing.Point(11, 41);
            this.clientbutton.Name = "clientbutton";
            this.clientbutton.Size = new System.Drawing.Size(589, 75);
            this.clientbutton.TabIndex = 0;
            this.clientbutton.Text = "Войти как клиент";
            this.clientbutton.UseVisualStyleBackColor = false;
            this.clientbutton.Click += new System.EventHandler(this.clientbutton_Click);
            // 
            // close_password
            // 
            this.close_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.close_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_password.BackgroundImage")));
            this.close_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_password.Location = new System.Drawing.Point(569, 249);
            this.close_password.Name = "close_password";
            this.close_password.Size = new System.Drawing.Size(33, 33);
            this.close_password.TabIndex = 9;
            this.close_password.TabStop = false;
            this.close_password.Click += new System.EventHandler(this.close_password_Click);
            // 
            // open_password
            // 
            this.open_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.open_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_password.BackgroundImage")));
            this.open_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_password.Location = new System.Drawing.Point(569, 249);
            this.open_password.Name = "open_password";
            this.open_password.Size = new System.Drawing.Size(33, 33);
            this.open_password.TabIndex = 10;
            this.open_password.TabStop = false;
            this.open_password.Click += new System.EventHandler(this.open_password_Click);
            // 
            // authorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 387);
            this.Controls.Add(this.startpanel);
            this.Controls.Add(this.open_password);
            this.Controls.Add(this.close_password);
            this.Controls.Add(this.back);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особое приглашение";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.startpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel startpanel;
        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Button clientbutton;
        private System.Windows.Forms.PictureBox close_password;
        private System.Windows.Forms.PictureBox open_password;
    }
}

