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
    public partial class frmSignUp : Form
    {   //Global decleration of class
        private clsVerify objVerify = new clsVerify();

        //Path to textfile
        string filepath = @"C:\Users\User\Documents\Lagash ltd\Residents.txt";
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {



            HighlightFunction();//Function that highlights fields that are empty or invalid


            string IDDigits = tbxID.Text;
            //Age
            int age = objVerify.AgeID((IDDigits));
            //gender
            string gender = objVerify.GenderID((IDDigits));
            //Race
            string race = objVerify.raceID((IDDigits));



            //Checking if the number, email and ID are already save to the textfile

            //"Name|Surname|Age|Gender|Race|Email|ID|Phone|Password"

            if (!File.Exists(filepath))
            {
                MessageBox.Show("File not found");
                return;
            }
            string line = "";
            string[] lineArray = new string[10];
            string email = "";
            string ID = "";
            string Number = "";

            string inputEmail = tbxEmail.Text;
            string inputNumber = tbxPhone.Text;
            string inputID = tbxID.Text;

            bool bfound = false;


            StreamReader reader = new StreamReader(filepath);
            using (reader)
            {
                line = reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    lineArray = line.Split('|');
                    if (lineArray.Length < 10)
                    {
                        line = reader.ReadLine();
                        continue;
                    }
                    email = lineArray[6];
                    ID = lineArray[7];
                    Number = lineArray[8];


                    if (ID.Equals(inputID) || Number.Equals(inputNumber) || email.Equals(inputEmail))
                    {
                        MessageBox.Show("Email, ID or Phone number already exists. Please use different credentials.");
                        bfound = true;
                        return;
                    }
                    else { bfound = false; }

                }

            }
            ///////Writing account to texftile
            if (tbxPass1.Text != tbxPassword.Text)
            {
                lblWpassword.Text = "Passwords do not match";
                return;
            }
            //1.Checking if all fields are filled
            if (objVerify.emptyCheck(tbxname.Text) == ""
                && objVerify.emptyCheck(tbxSurname.Text) == ""
                && objVerify.VerifyEmail(tbxEmail.Text) == ""
                && objVerify.VerifyID(tbxID.Text) == ""
                && objVerify.VerifyPhone(tbxPhone.Text) == ""
                && objVerify.emptyCheck(tbxPassword.Text) == ""
                && objVerify.emptyCheck(tbxPass1.Text) == ""
                && cmbxGender.SelectedIndex != -1)
            {
                //2.Writing to textfiles

                if (!File.Exists(filepath))
                {
                    MessageBox.Show("File does not exist.");
                    return;
                }
                //generating user ID
                string userID = tbxname.Text.Substring(0, 1) +
                    tbxSurname.Text.Substring(0, 1) +
                    tbxID.Text.Substring(0, 4);
                //Line with "|" split to separate details

                string ResidentDetails = userID + "|" +
                    tbxname.Text + "|" +
                    tbxSurname.Text + "|" +
                     age.ToString() + "|" +
                     gender + "|" +
                     race + "|" +
                    tbxEmail.Text + "|" +
                    tbxID.Text + "|" +
                    tbxPhone.Text + "|" +
                    tbxPassword.Text;
                //The sample output shoulf be like "Name|Surname|Age|Gender|Race|Email|ID|Phone|Password"
                using (StreamWriter sw = new StreamWriter(filepath, true))
                {
                    sw.WriteLine(ResidentDetails);
                }
                MessageBox.Show("Account created successfully!");

                //Writing user initials
                MainPage_1_ mainpage = new MainPage_1_();

                // mainpage.lblIdentify.Text = tbxname.Text.Substring(0, 1).ToUpper() + tbxSurname.Text.Substring(0, 1).ToUpper();

                //clear textbox
                tbxEmail.Clear();
                tbxID.Clear();
                tbxname.Clear();
                tbxSurname.Clear();
                tbxPassword.Clear();
                tbxPhone.Clear();

                //Navigate back to login
                frmLoginPage frmLoginPage = new frmLoginPage();
                frmLoginPage.Show();
                this.Hide();
            }
        }
        private void HighlightFunction()
        {
            string sEmail;
            sEmail = tbxEmail.Text;
            string sResult = objVerify.VerifyEmail(sEmail);
            lblWarning.Text = sResult;

            //////Color indicator for verification
            if (sResult.Contains("Email"))//Email
            {
                pnlSignalEmail.BackColor = Color.Red;
                sEmail = "";
            }
            else
            {
                pnlSignalEmail.BackColor = Color.Green;
            }
            //Using clsVerify to veriFy ID
            string ID;
            ID = (tbxID.Text);
            string sresultID = objVerify.VerifyID(ID);
            lblWarningID.Text = sresultID;
            if (sresultID.Contains("ID"))//ID
            {
                pnlIDsignal.BackColor = Color.Red;
                ID = "";
            }
            else
            {
                pnlIDsignal.BackColor = Color.Green;
            }

            if (objVerify.emptyCheck(tbxname.Text) == "")//Name
            {
                pnlName.BackColor = Color.Green;
                lblWname.Text = "";
            }
            else
            {
                pnlName.BackColor = Color.Red;
                lblWname.Text = "Enter Name";
            }
            if (objVerify.emptyCheck(tbxSurname.Text) == "")//Surname
            {
                pnlSurname.BackColor = Color.Green;
                lblWsurname.Text = "";
            }
            else
            {
                pnlSurname.BackColor = Color.Red;
                lblWsurname.Text = "Enter Surname";
            }
            string phone = tbxPhone.Text;
            string sresultPhone = objVerify.VerifyPhone(phone);
            lblWPhoneNumber.Text = sresultPhone;
            if (lblWPhoneNumber.Text == "")//
            {
                pnlPhoneNumber.BackColor = Color.Green;

            }
            else
            {
                pnlPhoneNumber.BackColor = Color.Red;

            }
            if (objVerify.emptyCheck(tbxPassword.Text) == "")//
            {
                pnlPassword.BackColor = Color.Green;
                lblWpassword.Text = "";
            }
            else
            {
                pnlPassword.BackColor = Color.Red;
                lblWpassword.Text = "Enter Password";
            }
            if (objVerify.emptyCheck(tbxPass1.Text) == "")//
            {
                pnlPass1.BackColor = Color.Green;
                lblwarnPass1.Text = "";
            }
            else
            {
                pnlPass1.BackColor = Color.Red;
                lblwarnPass1.Text = "Enter Password";
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLoginPage = new frmLoginPage();
            frmLoginPage.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string IDDigits = tbxID.Text;
            //Age
            int age = objVerify.AgeID((IDDigits));
            //gender
            string gender = objVerify.GenderID((IDDigits));
            //Race
            string race = objVerify.raceID((IDDigits));
            MessageBox.Show("Age:" + age + "\nGender:" + gender + "\nRace:" + race);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
    }
}
