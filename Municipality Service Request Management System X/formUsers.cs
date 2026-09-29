using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Municipality_Service_Request_Management_System_X
{
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoginPage loginPage = new frmLoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the 'Login as...' button under the user of your choice to procceed to the login page");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newpass = Interaction.InputBox("Enter your Password", "Welcome back administrator!!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHomePage homePage = new FrmHomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
