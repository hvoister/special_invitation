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
    public partial class staffs : Form
    {
        dataBase dataBase = new dataBase();

        public staffs()
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

        private void staffs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "special_invitationDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.special_invitationDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "special_invitationDataSet.staffs". При необходимости она может быть перемещена или удалена.
            this.staffsTableAdapter.Fill(this.special_invitationDataSet.staffs);

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Операция не была проведена, проверьте правильность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите \nудалить данного сотрудника?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    staffsBindingSource.RemoveCurrent();
                    staffsTableAdapter.Update(special_invitationDataSet);
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
                if (fambox.Text == "" || namebox.Text == "" || patbox.Text == "" || numbox.Text == "" || postbox.Text == "")
                {
                    MessageBox.Show("Введите данные во все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string fam = fambox.Text;
                    string name = namebox.Text;
                    string pat = patbox.Text;
                    string num = numbox.Text;
                    string post = postbox.Text;
                    int acc = Convert.ToInt16(accbox.SelectedValue);

                    dataBase.openConnection();
                    string querystring = $"insert into staffs (fam, name, pat, phone, post, account) values (N'{fam}', N'{name}', N'{pat}', N'{num}', N'{post}', {acc})";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                    command.ExecuteNonQuery();

                    dataBase.closeConnection();
                    MessageBox.Show("Данные успешно добавлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.staffsTableAdapter.Fill(this.special_invitationDataSet.staffs);
                    addpanel.Visible = false;
                    back.Visible = true;

                    fambox.Clear();
                    namebox.Clear();
                    patbox.Clear();
                    numbox.Clear();
                    postbox.Clear(); 
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
