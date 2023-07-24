using special_invitation.special_invitationDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace special_invitation
{
    public partial class goods : Form
    {
        public goods()
        {
            InitializeComponent();
        }

        private void goods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "special_invitationDataSet.goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.special_invitationDataSet.goods);

        }

        private void back_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void account_Click(object sender, EventArgs e)
        {
            authorisation authorisation = new authorisation();
            authorisation.Show();
            this.Hide();
        }

        private void close_application_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите \nудалить данный товар?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    goodsBindingSource.RemoveCurrent();
                    goodsTableAdapter.Update(special_invitationDataSet);
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
            goodsTableAdapter.Update(special_invitationDataSet);
            MessageBox.Show("Данные успешно сохранены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Операция не была проведена, проверьте правильность введённых данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
