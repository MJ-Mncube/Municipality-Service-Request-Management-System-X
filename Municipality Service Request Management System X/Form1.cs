//LOGIN PAGE
using static System.Windows.Forms.LinkLabel;
using System.IO;

namespace Municipality_Service_Request_Management_System_X
{
    public partial class frmLoginPage : Form
    {
        //Global Declaration of Class
        private clsVerify objVerify = new clsVerify();
        //Path to textfile
        string filepath = Path.Combine(Application.StartupPath, "Residents.txt");
        public frmLoginPage()
        {
            InitializeComponent();
            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);

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
        {//"Name|Surname|Age|Gender|Race|Email|ID|Phone|Password"

            Highlight();//Highlights empty or invalid fiels

            //Reading textfile to check if they match login details
            if (!File.Exists(filepath))
            {
                MessageBox.Show("File not found");
                return;
            }
            string line = "";
            string[] lineArray = new string[10];
            string email = "";
            string Password = "";

            string inputEmail = tbxEmail.Text;
            string inputPassword = tbxPassword.Text;

            bool emailFound = false;
            bool loginCorrect = false;

            if (string.IsNullOrEmpty(inputPassword))
            {
                lblWpassword.Text = "Please enter a password";
                return;
            }
            if(string.IsNullOrEmpty(inputEmail))
            {
                lblEmailVerify.Text = "Please enter an email";
                return;
            }

            StreamReader reader = new StreamReader(filepath);
            using (reader)
            {
                line = reader.ReadLine();

                while (line != null)
                {
                    lineArray = line.Split('|');
                    if (lineArray.Length < 10)
                    {
                        line = reader.ReadLine();
                        continue;
                    }
                    email = lineArray[6];
                    Password = lineArray[9];

                    if (email.Equals(inputEmail))
                    {
                        emailFound = true;
                       // pnlSignalEmail.BackColor = Color.Red;

                        if (Password.Equals(inputPassword))
                        {
                            loginCorrect = true;
                          //  pnlPass.BackColor = Color.Green;
                        }
                        else
                        {


                           // pnlPass.BackColor = Color.Red;
                            lblWpassword.Text = "Incorrect Password and/or Email";

                        }

                        break;
                    }

                    line = reader.ReadLine();
                }
            }
            if (!emailFound)
            {
                lblWpassword.Text = "Incorrect Password and/or Email";
               // pnlSignalEmail.BackColor = Color.Red;
            }
            // Login successful
            if (loginCorrect)
            {
                MainPage_1_ MainPage = new MainPage_1_(inputEmail);
                MainPage.Show();
                this.Hide();
            }
            tbxEmail.Clear();
            tbxPassword.Clear();

            
        }//end of btnPassword_Click

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

        private void label2_Click(object sender, EventArgs e)
        {
            //Navigate from login to sign up
      
        }
        private void Highlight()
        {
            //////Using clsVerify class to verify email
            string sEmail;
            sEmail = tbxEmail.Text;
            string sResult = objVerify.VerifyEmail(sEmail);
            lblEmailVerify.Text = sResult;

            //////Color indicator for email verification
            if (sResult.Contains("Email") || (objVerify.emptyCheck(tbxPassword.Text) != "") )
            {
                pnlSignalEmail.BackColor = Color.Red;
                pnlPass.BackColor = Color.Red;
            }
            else if ((objVerify.emptyCheck(tbxEmail.Text) == "")|| sResult == "")
            {
                pnlSignalEmail.BackColor = Color.Green;
                pnlPass.BackColor = Color.Green;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Updating the textfile for the forgotten password
            /*Show new button
             * Search for account through email
             * send an email for OTP
             * if found user must enter a new password
             * ask user to confirm if they want to change password 
             * after confirmation it must go back to regular login procedure
             */


            //clear text
            tbxPassword.Clear();
            tbxEmail.Clear();

            string email = tbxEmail.Text;
            string newPassword = tbxPassword.Text;

            //Change instruction
            lblEmail.Text = "Enter Email";

            //Verify email and Check if email exists
            if ((objVerify.VerifyEmail(email) != "") || objVerify.emptyCheck(email) != "")
            {
                return;
            }


            bool bfound = false;
            string[] line = File.ReadAllLines(filepath);

            string searchEmail = "";



            for (int i = 0; i < line.Length; i++)
            {
                string[] lineArray = line[i].Split('|');
                if (lineArray.Length < 10)
                {
                    continue;
                }
                searchEmail = lineArray[6];
                if (email != searchEmail)
                {
                    lblEmailVerify.Text = "Email not found!";
                    return;
                }
                else
                {
                    //change instruction
                    lblPass.Text = "Enter new Password";


                    lineArray[6] = newPassword;
                    line[i] = string.Join("|", lineArray);
                    bfound = true;
                    break;

                }



            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            formUsers users = new formUsers();
            users.Show();
            this.Hide();
        }
    }
}
