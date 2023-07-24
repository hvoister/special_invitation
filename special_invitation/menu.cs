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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            if (current_user.level == 1)
            {
                directorpanel.Visible = true;
                manager_panel.Visible = false;
            }
            if (current_user.level == 2)
            {
                manager_panel.Visible = true;
                directorpanel.Visible = false;
            }

        }

        private void close_application_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void account_Click_1(object sender, EventArgs e)
        {
            directorpanel.Visible = false;
            this.Hide();
            authorisation authorisation = new authorisation(); ;
            authorisation.Show();
        }

        private void contacts_Click(object sender, EventArgs e)
        {
            contactspanel.Visible = true;
            closepanels.Visible = true;

        }

        private void closepanels_Click(object sender, EventArgs e)
        {
            contactspanel.Visible = false;
            price.Visible = false;
            closepanels.Visible = false;
        }

        private void goods_Click(object sender, EventArgs e)
        {
            price.Visible = true;
            closepanels.Visible = true;
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            staffs staffs = new staffs();
            staffs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goods goods = new goods(); 
            goods.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accounts accounts = new accounts();
            accounts.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sells sells = new sells();
            sells.Show();
            this.Hide();
        }

        private void goods_manager_Click(object sender, EventArgs e)
        {
            goods goods = new goods();
            goods.Show();
            this.Hide();
        }

        private void sells_manager_Click(object sender, EventArgs e)
        {
            sells sells = new sells();
            sells.Show();
            this.Hide();
        }

        private void goods_manager_Click_1(object sender, EventArgs e)
        {
            goods goods = new goods();
            goods.Show();
            this.Hide();
        }

        private void sells_manager_Click_1(object sender, EventArgs e)
        {
            sells sells = new sells();
            sells.Show();
            this.Hide();
        }
    }
}
