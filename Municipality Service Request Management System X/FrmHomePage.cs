using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipality_Service_Request_Management_System_X
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //navigate to user page
            formUsers users = new formUsers();
            users.Show();
            this.Hide();
        }
    }
}
