using special_invitation.special_invitationDataSetTableAdapters;
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
    public partial class accounts : Form
    {
        dataBase dataBase = new dataBase();

        public accounts()
        {
            InitializeComponent();
        }

        private void close_application_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void account_Click(object sender, EventArgs e)
        {
            authorisation authorisation = new authorisation();
            authorisation.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void accounts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "special_invitationDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.special_invitationDataSet.users);

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите \nудалить данного пользователя?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    usersBindingSource.RemoveCurrent();
                    usersTableAdapter.Update(special_invitationDataSet);
                    MessageBox.Show("Данные успешно удалены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Операция не была проведена! Нечего удалять.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            addpanel.Visible = true;
            back.Visible = false;
        }

        private void panelback_Click(object sender, EventArgs e)
        {
            addpanel.Visible = false;
            back.Visible = true;
        }

        private void agree_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginbox.Text == "" || passwordbox.Text == "")
                {
                    MessageBox.Show("Введите данные во все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string login = loginbox.Text;
                    string password = passwordbox.Text;
                    int level = 2;
                    switch (Convert.ToInt64(levelbox.Text))
                    {
                        case 1:
                            level = 1;
                            break;
                        case 2:
                            level = 2;
                            break;
                        default:
                            level = 2;
                            MessageBox.Show("Вы ввели неверный уровень доступа! Автоматически аккаунту присвоен уровень доступа Сотрудник.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    DateTime now = DateTime.Now;

                    dataBase.openConnection();
                    string querystring = $"insert into users (login, password, level, enter_time) values (N'{login}', N'{password}', {level}, '{now}')";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                    command.ExecuteNonQuery();

                    dataBase.closeConnection();
                    MessageBox.Show("Данные успешно добавлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.usersTableAdapter.Fill(this.special_invitationDataSet.users);
                    addpanel.Visible = false;
                    back.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void levelsinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Существующие уровни доступа:\n  - Директор: 1;\n  - Сотрудник: 2.", "Уровни доступа!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
