namespace special_invitation
{
    partial class accounts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accounts));
            this.back = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.PictureBox();
            this.close_application = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.special_invitationDataSet = new special_invitation.special_invitationDataSet();
            this.usersTableAdapter = new special_invitation.special_invitationDataSetTableAdapters.usersTableAdapter();
            this.deletebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.addpanel = new System.Windows.Forms.Panel();
            this.levelbox = new System.Windows.Forms.TextBox();
            this.levelsinfo = new System.Windows.Forms.PictureBox();
            this.agree = new System.Windows.Forms.PictureBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_application)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_invitationDataSet)).BeginInit();
            this.addpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelsinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelback)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(133)))), ((int)(((byte)(171)))));
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(839, 20);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 50);
            this.back.TabIndex = 20;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(133)))), ((int)(((byte)(171)))));
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 49);
            this.label1.TabIndex = 19;
            this.label1.Text = "Особое приглашение - Аккаунты";
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(133)))), ((int)(((byte)(171)))));
            this.account.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("account.BackgroundImage")));
            this.account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.account.Location = new System.Drawing.Point(902, 19);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(57, 50);
            this.account.TabIndex = 17;
            this.account.TabStop = false;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // close_application
            // 
            this.close_application.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(133)))), ((int)(((byte)(171)))));
            this.close_application.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_application.BackgroundImage")));
            this.close_application.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_application.Location = new System.Drawing.Point(963, 19);
            this.close_application.Name = "close_application";
            this.close_application.Size = new System.Drawing.Size(57, 50);
            this.close_application.TabIndex = 16;
            this.close_application.TabStop = false;
            this.close_application.Click += new System.EventHandler(this.close_application_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(133)))), ((int)(((byte)(171)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1188, 66);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(133)))), ((int)(((byte)(171)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduserDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.entertimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 235);
            this.dataGridView1.TabIndex = 21;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.iduserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iduserDataGridViewTextBoxColumn.Width = 60;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Уровень доступа";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelDataGridViewTextBoxColumn.Width = 125;
            // 
            // entertimeDataGridViewTextBoxColumn
            // 
            this.entertimeDataGridViewTextBoxColumn.DataPropertyName = "enter_time";
            this.entertimeDataGridViewTextBoxColumn.HeaderText = "Последнее время входа в аккаунт";
            this.entertimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entertimeDataGridViewTextBoxColumn.Name = "entertimeDataGridViewTextBoxColumn";
            this.entertimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.entertimeDataGridViewTextBoxColumn.Width = 250;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.special_invitationDataSet;
            // 
            // special_invitationDataSet
            // 
            this.special_invitationDataSet.DataSetName = "special_invitationDataSet";
            this.special_invitationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebutton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F);
            this.deletebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deletebutton.Location = new System.Drawing.Point(521, 337);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(499, 53);
            this.deletebutton.TabIndex = 23;
            this.deletebutton.Text = "Удалить аккаунт";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addbutton.Location = new System.Drawing.Point(12, 337);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(499, 53);
            this.addbutton.TabIndex = 22;
            this.addbutton.Text = "Добавить аккаунт";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // addpanel
            // 
            this.addpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addpanel.BackgroundImage")));
            this.addpanel.Controls.Add(this.levelbox);
            this.addpanel.Controls.Add(this.levelsinfo);
            this.addpanel.Controls.Add(this.agree);
            this.addpanel.Controls.Add(this.passwordbox);
            this.addpanel.Controls.Add(this.loginbox);
            this.addpanel.Controls.Add(this.label7);
            this.addpanel.Controls.Add(this.label3);
            this.addpanel.Controls.Add(this.label2);
            this.addpanel.Controls.Add(this.panelback);
            this.addpanel.Location = new System.Drawing.Point(12, 84);
            this.addpanel.Name = "addpanel";
            this.addpanel.Size = new System.Drawing.Size(1008, 306);
            this.addpanel.TabIndex = 24;
            this.addpanel.Visible = false;
            // 
            // levelbox
            // 
            this.levelbox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F);
            this.levelbox.Location = new System.Drawing.Point(433, 168);
            this.levelbox.Name = "levelbox";
            this.levelbox.Size = new System.Drawing.Size(376, 43);
            this.levelbox.TabIndex = 32;
            // 
            // levelsinfo
            // 
            this.levelsinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.levelsinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("levelsinfo.BackgroundImage")));
            this.levelsinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.levelsinfo.Location = new System.Drawing.Point(827, 160);
            this.levelsinfo.Name = "levelsinfo";
            this.levelsinfo.Size = new System.Drawing.Size(57, 50);
            this.levelsinfo.TabIndex = 31;
            this.levelsinfo.TabStop = false;
            this.levelsinfo.Click += new System.EventHandler(this.levelsinfo_Click);
            // 
            // agree
            // 
            this.agree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.agree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agree.BackgroundImage")));
            this.agree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agree.Location = new System.Drawing.Point(890, 160);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(57, 50);
            this.agree.TabIndex = 30;
            this.agree.TabStop = false;
            this.agree.Click += new System.EventHandler(this.agree_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F);
            this.passwordbox.Location = new System.Drawing.Point(303, 119);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(506, 43);
            this.passwordbox.TabIndex = 28;
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F);
            this.loginbox.Location = new System.Drawing.Point(303, 70);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(506, 43);
            this.loginbox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F);
            this.label7.Location = new System.Drawing.Point(170, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 34);
            this.label7.TabIndex = 26;
            this.label7.Text = "Уровень доступа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F);
            this.label3.Location = new System.Drawing.Point(170, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F);
            this.label2.Location = new System.Drawing.Point(170, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Логин:";
            // 
            // panelback
            // 
            this.panelback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.panelback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelback.BackgroundImage")));
            this.panelback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelback.Location = new System.Drawing.Point(951, 0);
            this.panelback.Name = "panelback";
            this.panelback.Size = new System.Drawing.Size(57, 50);
            this.panelback.TabIndex = 12;
            this.panelback.TabStop = false;
            this.panelback.Click += new System.EventHandler(this.panelback_Click);
            // 
            // accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1032, 403);
            this.Controls.Add(this.addpanel);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.account);
            this.Controls.Add(this.close_application);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accounts";
            this.Load += new System.EventHandler(this.accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_application)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_invitationDataSet)).EndInit();
            this.addpanel.ResumeLayout(false);
            this.addpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelsinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox account;
        private System.Windows.Forms.PictureBox close_application;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private special_invitationDataSet special_invitationDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private special_invitationDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Panel addpanel;
        private System.Windows.Forms.PictureBox panelback;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox agree;
        private System.Windows.Forms.PictureBox levelsinfo;
        private System.Windows.Forms.TextBox levelbox;
    }
}