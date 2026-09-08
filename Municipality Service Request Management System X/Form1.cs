//LOGIN PAGE
namespace Municipality_Service_Request_Management_System_X
{
    public partial class frmLoginPage : Form
    {
        //Global Declaration of Class
        private clsVerify objVerify = new clsVerify();
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLoginBackGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {//Simamukele Mncube

            //////Using clsVerify class to verify email
            string sEmail;
            sEmail = tbxEmail.Text;
            string sResult = objVerify.VerifyEmail(sEmail);
            lblEmailVerify.Text = sResult;

            //////Color indicator for email verification
            if (sResult.Contains("Email"))
            {
                pnlSignalEmail.BackColor = Color.Red;
            }
            else
            {
                pnlSignalEmail.BackColor = Color.Green;
            }


        }

        private void pbxLockPassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '\0')
            {
                tbxPassword.PasswordChar = '●';
            }
            else if (tbxPassword.PasswordChar == '●')
            {
                tbxPassword.PasswordChar = '\0';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Navigate from login to sign up
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.Show();
            this.Hide();
        }
    }
}
