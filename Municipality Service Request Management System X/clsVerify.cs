using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Municipality_Service_Request_Management_System_X
{
    public class clsVerify///Class we will use to verify details
    {
        

        public string VerifyEmail(string Email)//verifying email
        {
            if (string.IsNullOrEmpty(Email))
            {
                return "Enter Email";
            }
            else if (!Regex.IsMatch(
                Email,
                @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))//using regex because contains is breachable
            {
                return "Invalid Email";
            }
            return "";
        }
      
        public string VerifyID(string ID)//verifying ID
        {
            //reading from user ID
           
           
            if (string.IsNullOrEmpty(ID))
            {
                return "Enter your ID number";
            }
            int month = Convert.ToInt32(ID.Substring(2, 2));
            int day = Convert.ToInt32(ID.Substring(4, 2));
            if (!Regex.IsMatch(ID, @"^\d{13}$")
                ||(day>31)
                ||(month>12))
            {
                return "Invalid ID number";
            }
            return "";
        }//After verfiying extract details
          /*Details that can be obtained from ID
         * Date of birth(Age)1-6th Digit(DONE)
         * Gender 7-10th Digit(0000-4999 FeMale)(5000-9999 male)
         * Race 11-12th Digit(00-09 Black)(10-19 White)(20-29 Coloured)(30-39 Indian)(40-49 Asian)(50-59 Other)
         * Last digit is to verify validity(Missing the Luhn method)
         */
        public int AgeID(string ID)///////////////Capture Age
        {
            
            int yearOfBirth = 0;
            int currentYear = DateTime.Now.Year % 100;//lAST 2 digits for year
            if (ID.Length != 13)
            {
                return 0;
            }
            else
            {
                string year = ID.Substring(0, 2);
                int years = Convert.ToInt32(year);
                if (years <= currentYear)
                {
                    yearOfBirth = 2000 + years;
                }
                else
                {
                    yearOfBirth = 1900 + years;
                }
                //Checking if birth DAY and month has arrived or not to add a year or keep the same
                //Month
                string month = ID.ToString().Substring(2, 2);
                int monthOfBirth = Convert.ToInt32(month);
                //Day
                string day = ID.ToString().Substring(4, 2);
                int dayOfBirth = Convert.ToInt32(day);
                int Age = 0;
                if ((monthOfBirth < DateTime.Now.Month) || (monthOfBirth == DateTime.Now.Month && dayOfBirth <= DateTime.Now.Day))
                {
                    Age = DateTime.Now.Year - yearOfBirth;
                }
                else
                {
                    Age = DateTime.Now.Year - yearOfBirth - 1;
                }

                return Age;
            }
        }
        
        public string GenderID(string ID)/////////////Checking the Gender
        {    //4 digits that determine gender
            string options = "";
            if (ID.Length != 13)
            {
                return "Invalid ID";
            }
            else
            {
                string genderDigits = ID.Substring(6, 4);
                int Gender = Convert.ToInt32(genderDigits);
                if (Gender >= 0000 && Gender <= 4999)
                {
                    options = "Female";
                }
                else if (Gender >= 5000 && Gender <= 9999)
                {
                    options = "Male";
                }
                else
                {
                    options = "Invalid ID";
                }
            }
            return options;

        }
        public string raceID(string ID)////////////Checking Race
        {
            if (ID.Length != 13)
            {
                return "Invalid ID";
            }
            else
            {
                string raceDigits = ID.Substring(10, 2);
                int race = Convert.ToInt32(raceDigits);

                //Race 11 - 12th Digit(00 - 09 Black)(10 - 19 White)(20 - 29 Coloured)(30 - 39 Indian)(40 - 49 Asian)(50 - 59 Other)

                switch (race)
                {
                    case int r when r >= 0 && r < 10:
                        return "Black";
                    case int r when r >= 10 && r < 20:
                        return "White";
                    case int r when r >= 20 && r < 30:
                        return "Coloured";
                    case int r when r >= 30 && r < 40:
                        return "Indian";
                    case int r when r >= 40 && r < 50:
                        return "Asian";
                    default:
                        return "Other";
                }
            }



        }
        public string VerifyPhone(string Phone)//Verifying Phone number
        {
            if (string.IsNullOrEmpty(Phone))
            {
                return "Enter Phone Number";
            }

            // Clean up THE spaxes in between
            string cleaned = Phone.Replace(" ", "");
               

            // Convert formT so user can write starting with 0 or +27
            if (cleaned.StartsWith("0"))
            {
                cleaned = "+27" + cleaned.Substring(1);
            }

            if (!Regex.IsMatch(cleaned, @"^\+27[0-9]{9}$"))
            {
                return "Invalid Phone Number";
            }

            return "";
        }//Changed entry of ID into string because the ID number is too long to be stored as an integer

        //Checking if a field is empty
        public string emptyCheck(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Field cannot be empty";
            }
            return "";
        }



    }//End of clsVerfiy
   
}
/*AI chatbot that will be given a prompt explaining the app, the code and navigation
 * Use TabOrder for Admin and Use dynamic UI for user
 * User - ChatBot, DashBoard, Request(Survey)/Request Status(Check Progress), Rating, Logout, About
 * Admin- DashBoard, Reuest Mangement,User Managment, Admin Managment, Feasability assesmnet, Load Ratings(Comments)
 * Generate User ID
 */
