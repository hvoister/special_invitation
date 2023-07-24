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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace special_invitation
{
    public partial class sells : Form
    {
        dataBase dataBase = new dataBase();
        public sells()
        {
            InitializeComponent();
        }

        private void sells_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "special_invitationDataSet.goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.special_invitationDataSet.goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "special_invitationDataSet.sells". При необходимости она может быть перемещена или удалена.
            this.sellsTableAdapter.Fill(this.special_invitationDataSet.sells);

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

        private void addbutton_Click(object sender, EventArgs e)
        {
            addpanel.Visible = true;
            back.Visible = false;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите \nудалить данную запись?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    sellsBindingSource.RemoveCurrent();
                    sellsTableAdapter.Update(special_invitationDataSet);
                    MessageBox.Show("Данные успешно удалены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Операция не была проведена! Нечего удалять.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (fambox.Text == "" || namebox.Text == "" || patbox.Text == "" || numbox.Text == "" || numgoodbox.Text == "")
                {
                    MessageBox.Show("Введите данные во все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string fam = fambox.Text;
                    string name = namebox.Text;
                    string pat = patbox.Text;
                    string num = numbox.Text;
                    int good = Convert.ToInt16(goodbox.SelectedValue);
                    int numgood = Convert.ToInt32(numgoodbox.Text);

                    dataBase.openConnection();
                    SqlCommand cus = new SqlCommand($"select cost from goods where id_good = {good}", dataBase.getConnection());
                    int cost = Convert.ToInt32(cus.ExecuteScalar());

                    int sellsum = cost * numgood;

                    string querystring = $"insert into sells (cus_fam, cus_name, cus_pat, cus_phone, good_type, good_num, sell_sum) values (N'{fam}', N'{name}', N'{pat}', N'{num}', {good}, {numgood}, {sellsum})";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                    command.ExecuteNonQuery();

                    dataBase.closeConnection();
                    MessageBox.Show("Данные успешно добавлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.sellsTableAdapter.Fill(this.special_invitationDataSet.sells);
                    addpanel.Visible = false;
                    back.Visible = true;

                    fambox.Clear();
                    namebox.Clear();
                    patbox.Clear();
                    numbox.Clear();
                    numgoodbox.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
