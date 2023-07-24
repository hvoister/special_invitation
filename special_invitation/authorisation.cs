using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace special_invitation
{
    public partial class authorisation : Form
    {
        public current_user user;

        dataBase dataBase = new dataBase();

        public authorisation()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            current_user.login = loginbox.Text;
            current_user.password = passwordbox.Text;
            DateTime now = DateTime.Now;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user from users where login = N'{current_user.login}' and password = N'{current_user.password}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли в свой аккаунт!", "Успех входа в аккаунт!", MessageBoxButtons.OK);
                SqlCommand cmd_ID = new SqlCommand($"Select id_user from users where login = N'{current_user.login}' and password = N'{current_user.password}'", dataBase.getConnection());
                dataBase.openConnection();
                int input_ID = Convert.ToInt32(cmd_ID.ExecuteScalar());
                current_user.id = input_ID;
                SqlCommand level = new SqlCommand($"Select level from users where login = N'{current_user.login}' and password = N'{current_user.password}'", dataBase.getConnection());
                current_user.level = Convert.ToInt32(level.ExecuteScalar());
                SqlCommand date = new SqlCommand($"update users set enter_time = '{now}' where id_user = {current_user.id};", dataBase.getConnection());
                date.ExecuteNonQuery();
                dataBase.closeConnection();
                menu menu = new menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует! \nПроверьте корректность данных или обратитесь к администратору для создания нового аккаунта!", "Ошибка входа в аккаунт!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void clientbutton_Click(object sender, EventArgs e)
        {
            current_user.level = 3;
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            startpanel.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            startpanel.Visible = true;
        }

        private void close_password_Click(object sender, EventArgs e)
        {
            passwordbox.UseSystemPasswordChar = true;
            close_password.Visible = false;
            open_password.Visible = true;
        }

        private void open_password_Click(object sender, EventArgs e)
        {
            passwordbox.UseSystemPasswordChar = false;
            close_password.Visible = true;
            open_password.Visible = false;
        }
    }
}
