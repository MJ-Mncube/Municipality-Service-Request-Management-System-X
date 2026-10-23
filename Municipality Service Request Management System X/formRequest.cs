using Municipality_Service_Request_Management_System_X.clsRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Municipality_Service_Request_Management_System_X
{
    public partial class formRequest : Form
    {
        private string _loggedInEmail;
        private UserDetails _currentUser;
        private MunicipalServiceRequest _currentRequest;

        private void AutoFillUserDetails()
        {
            MessageBox.Show("Searching for email: [" + UserSession.LoggedInEmail + "]");
            // Use the global email
            var user = FileHelper.GetUserByEmail(UserSession.LoggedInEmail);

            // 2. Check if the search failed
            if (user == null)
            {
                // Show an error message
                MessageBox.Show("Your account could not be found in the system. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Close this request page
                this.Hide();

                // Send them back to the login page
                frmLoginPage loginPage = new frmLoginPage();
                loginPage.Show();

                // Stop running the rest of this method
                return;

            }
            _currentUser = user;
        }
        public string IssueType1 { get; set; } = "";
        // 2. Constructor accepts the email
        public formRequest(string emailFromLogin)
        {
            InitializeComponent();

            _loggedInEmail = emailFromLogin;


            // 3. Automatically fetch and fill the user details when the form opens
            AutoFillUserDetails();
        }
        public formRequest()
        {
            InitializeComponent();
            _currentRequest = new MunicipalServiceRequest();
            AutoFillUserDetails();

        }

        private void formRequest_Load(object sender, EventArgs e)
        {
            showButton();
            count();
            progress();
            // 2. Recursively find and hook up ALL checkboxes and textboxes, even if nested
            HookUpEvents(pnlContainer);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pnlContainer.Visible = false;
            pnlSampleReport.Visible = false;
            pnlContainer2.Visible = true;
            btnPrevious.Visible = true;
            lblInstruct.Text = "Enter details on the provided fields.The options that are written 'optional' are not compulsory.";
            btnContinue.Visible = false;
            btnSubmit.Visible = true;

        }

        private void lblSouth_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void showButton()//Code for dynamic continue button
        {
            int count = 0;
            if (cbxByLawInfrengments.Checked
                || cbxCableTheft.Checked
                || cbxClinicServiceComplaint.Checked
                || cbxContaminatedWater.Checked
                || cbxDamagedManholeCover.Checked
                || cbxDeadAnimalRemoval.Checked
                || cbxDisasterReliefRequest.Checked
                || cbxDisorderlyConduct.Checked
                || cbxEnviromentalhealthhazard.Checked
                || cbxExposedorDamagedCables.Checked
                || cbxGangActivityHotspot.Checked
                || cbxIllegaldumping.Checked
                || cbxIllegalElectricityConnection.Checked
                || cbxIllegalLandInvasion.Checked
                || cbxIllegalStreetTrading.Checked
                || cbxLowWaterPressure.Checked
                || cbxMeterFault.Checked
                || cbxMissedRefuseCollection.Checked
                || cbxNowatersupply.Checked
                || cbxOvergrownGrassorVerges.Checked
                || cbxPestInfestation.Checked
                || cbxPollution.Checked
                || cbxPowerOutage.Checked
                || cbxPowerSurges.Checked
                || cbxPublicToiletMaintance.Checked
                || cbxSewerblockage.Checked
                || cbxTankerAccessibilityIssue.Checked
                || cbxTransformerFault.Checked
                || cbxTreeMaintainance.Checked
                || cbxUnsafeFood.Checked
                || cbxVandalismofPublicProperty.Checked
                || cbxWaterLeak.Checked
                || tbxElectricity.Text != ""
                || tbxWater.Text != ""
                || tbxSanitationWaste.Text != ""
                || tbxPublicSafety.Text != ""
                || tbxHealth.Text != ""
                || tbxEnvironment.Text != ""
                )
            {
                btnContinue.Visible = true;
                progressBar.Value = 33;

            }
            else
            {
                btnContinue.Visible = false;
                progressBar.Value = 0;
            }
        }
        private void HookUpEvents(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is CheckBox cb)
                {
                    cb.CheckedChanged -= OnInputChanged; // Prevents duplicate wiring if loaded twice
                    cb.CheckedChanged += OnInputChanged;
                }
                else if (c is System.Windows.Forms.TextBox tb)
                {
                    tb.TextChanged -= OnInputChanged;
                    tb.TextChanged += OnInputChanged;
                }

                // If this control has children of its own (like a GroupBox or nested Panel), search inside it too!
                if (c.HasChildren)
                {
                    HookUpEvents(c);
                }
            }
        }
        private void OnInputChanged(object sender, EventArgs e)
        {
            showButton();
            count();
            progress();
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = true;
            pnlContainer2.Visible = false;
            btnPrevious.Visible = false;
            btnContinue.Visible = true;
            lblInstruct.Text = "Select or enter complaint.You may select more than 1 complaint for your request.";
            progressBar.Value = 33;
            btnSubmit.Visible = false;
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
        private void count()
        {

            int points = 0;

            // Add 1 point for every checked box or filled textbox
            if (cbxByLawInfrengments.Checked) points++;
            if (cbxCableTheft.Checked) points++;
            if (cbxClinicServiceComplaint.Checked) points++;
            if (cbxContaminatedWater.Checked) points++;
            if (cbxDamagedManholeCover.Checked) points++;
            if (cbxDeadAnimalRemoval.Checked) points++;
            if (cbxDisasterReliefRequest.Checked) points++;
            if (cbxDisorderlyConduct.Checked) points++;
            if (cbxEnviromentalhealthhazard.Checked) points++;
            if (cbxExposedorDamagedCables.Checked) points++;
            if (cbxGangActivityHotspot.Checked) points++;
            if (cbxIllegaldumping.Checked) points++;
            if (cbxIllegalElectricityConnection.Checked) points++;
            if (cbxIllegalLandInvasion.Checked) points++;
            if (cbxIllegalStreetTrading.Checked) points++;
            if (cbxLowWaterPressure.Checked) points++;
            if (cbxMeterFault.Checked) points++;
            if (cbxMissedRefuseCollection.Checked) points++;
            if (cbxNowatersupply.Checked) points++;
            if (cbxOvergrownGrassorVerges.Checked) points++;
            if (cbxPestInfestation.Checked) points++;
            if (cbxPollution.Checked) points++;
            if (cbxPowerOutage.Checked) points++;
            if (cbxPowerSurges.Checked) points++;
            if (cbxPublicToiletMaintance.Checked) points++;
            if (cbxSewerblockage.Checked) points++;
            if (cbxTankerAccessibilityIssue.Checked) points++;
            if (cbxTransformerFault.Checked) points++;
            if (cbxTreeMaintainance.Checked) points++;
            if (cbxUnsafeFood.Checked) points++;
            if (cbxVandalismofPublicProperty.Checked) points++;
            if (cbxWaterLeak.Checked) points++;
            if (tbxElectricity.Text != "") points++;
            if (tbxWater.Text != "") points++;
            if (tbxSanitationWaste.Text != "") points++;
            if (tbxPublicSafety.Text != "") points++;
            if (tbxHealth.Text != "") points++;
            if (tbxEnvironment.Text != "") points++;

            lblcount.Text = points.ToString();


        }

        private void cbxDisasterReliefRequest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Cannot submit: User details are missing. Please log in again.", "Error");
                return; // Stops the code from crashing
            }

            string filepath = @"C:\Users\User\Documents\Lagash ltd\Residents.txt";
            // 1. Create the data object (populated from your UI textboxes)
            //code for priority(1-10)
            double priorityScore;

            int count = int.Parse(lblcount.Text);
            int score = 0;
            switch (count)
            {
                case int n when (n >= 1 & n <= 12):
                    score = 18;
                    break;
                case int n when (n >= 13 & n <= 24):
                    score = 28;
                    break;
                case int n when (n > 24):
                    score = 38;
                    break;
                default:
                    score = 0;
                    break;
            }
            if (rbtReoccuring1.Checked)
            {
                // Handle reoccuring request logic
                score += 5;
            }
            else if (rbtReoccuring2.Checked)
            {
                // Handle reoccuring request logic
                score += 10;
            }
            else if (rbtReoccuring3.Checked)
            {
                score += 15;
            }
            if (rbtEmergency1.Checked)
            {
                score += 25;
            }
            if (cbxElderly.Checked)
            {
                score += 5;
            }
            else if ((cbxElderly.Checked && cbxDisabilities.Checked) || (cbxElderly.Checked && cbxChildren.Checked)
                || (cbxDisabilities.Checked && cbxChildren.Checked))
            { score += 10; }
            else if (cbxElderly.Checked && cbxDisabilities.Checked && cbxChildren.Checked)
            {
                score += 15;
            }
            priorityScore = score / 10.0;
            string Priority = "";

            if (priorityScore > 1.0 && priorityScore <= 2.5)
            {
                Priority = "Low Priority";
            }
            else if (priorityScore > 2.5 && priorityScore <= 6.5)
            {
                Priority = "Medium Priority";
            }
            else if (priorityScore > 6.5 && priorityScore <= 10.0)
            {
                Priority = "High Priority";

            }




            IssueType1 = issueType();
            string selectedCategories = GetCategories();
            _currentRequest = new MunicipalServiceRequest
            {
                ReferenceNumber = $"MSRMS-2026-{new Random().Next(1000, 9999)}",
                DateLogged = DateTime.Now,
                CurrentStatus = "Assigned Request",
                Priority = Priority,
                ResidentName = _currentUser.Name + " " + _currentUser.Surname,
                ContactNumber = _currentUser.Phonenumber,
                StreetAddress = tbxStreetAddress.Text,
                Suburb = tbxTownName.Text,
                NearestLandmark = tbxNearestLandmark.Text,
                Category = selectedCategories,
                IssueType = IssueType1,


                // Add some dummy timeline data for the text file
                Timeline =
              {
                        new TimelineEvent { Time = DateTime.Now.ToString("HH:mm"), Title = "Request Logged", Status = "COMPLETE" },
                      new TimelineEvent { Time = DateTime.Now.AddDays(2).ToString("dd MMM, HH:mm"), Title = "Estimated Completion", Status = "PENDING" },
                        new TimelineEvent { Time = "Pending", Title = "Resolved", Status = "PENDING" }
              }
            };
            Details();
            progress();
            DisplayRequestReport(_currentRequest);


        }


        private void cbxElderly_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string issueType()
        {

            string points = "";

            // Add 1 point for every checked box or filled textbox
            if (cbxByLawInfrengments.Checked) points += "By Law Infrengments";
            if (cbxCableTheft.Checked) points += "Cable Theft";
            if (cbxClinicServiceComplaint.Checked) points += "Clinic Service Complaint";
            if (cbxContaminatedWater.Checked) points += "Contaminated Water";
            if (cbxDamagedManholeCover.Checked) points += "Damaged Manhole Cover";
            if (cbxDeadAnimalRemoval.Checked) points += "Dead Animal Removal";
            if (cbxDisasterReliefRequest.Checked) points += "Disaster Relief Request";
            if (cbxDisorderlyConduct.Checked) points += "Disorderly Conduct";
            if (cbxEnviromentalhealthhazard.Checked) points += "Environmental Health Hazard";
            if (cbxExposedorDamagedCables.Checked) points += "Exposed or Damaged Cables";
            if (cbxGangActivityHotspot.Checked) points += "Gang Activity Hotspot";
            if (cbxIllegaldumping.Checked) points += "Illegal Dumping";
            if (cbxIllegalElectricityConnection.Checked) points += "Illegal Electricity Connection";
            if (cbxIllegalLandInvasion.Checked) points += "Illegal Land Invasion";
            if (cbxIllegalStreetTrading.Checked) points += "Illegal Street Trading";
            if (cbxLowWaterPressure.Checked) points += "Low Water Pressure";
            if (cbxMeterFault.Checked) points += "Meter Fault";
            if (cbxMissedRefuseCollection.Checked) points += "Missed Refuse Collection";
            if (cbxNowatersupply.Checked) points += "No Water Supply";
            if (cbxOvergrownGrassorVerges.Checked) points += "Overgrown Grass or Verges";
            if (cbxPestInfestation.Checked) points += "Pest Infestation";
            if (cbxPollution.Checked) points += "Pollution";
            if (cbxPowerOutage.Checked) points += "Power Outage";
            if (cbxPowerSurges.Checked) points += "Power Surges";
            if (cbxPublicToiletMaintance.Checked) points += "Public Toilet Maintenance";
            if (cbxTankerAccessibilityIssue.Checked) points += "Tanker Accessibility Issue";
            if (cbxTransformerFault.Checked) points += "Transformer Fault";
            if (cbxTreeMaintainance.Checked) points += "Tree Maintenance";
            if (cbxUnsafeFood.Checked) points += "Unsafe Food";
            if (cbxVandalismofPublicProperty.Checked) points += "Vandalism of Public Property";
            if (cbxWaterLeak.Checked) points += "Water Leak";
            if (tbxElectricity.Text != "") points += tbxElectricity.Text + ", ";
            if (tbxWater.Text != "") points += tbxWater.Text + ", ";
            if (tbxSanitationWaste.Text != "") points += tbxSanitationWaste.Text + ", ";
            if (tbxPublicSafety.Text != "") points += tbxPublicSafety.Text + ", ";
            if (tbxHealth.Text != "") points += tbxHealth.Text + ", ";
            if (tbxEnvironment.Text != "") points += tbxEnvironment.Text + ", ";

            if (points.EndsWith(", "))
            {
                points = points.Substring(0, points.Length - 2);
            }
            return points;

        }
        // Make sure to add this at the top of your file

        private string GetCategories()
        {
            // A HashSet automatically prevents duplicate entries
            HashSet<string> categories = new HashSet<string>();

            // 1. WATER
            if (cbxContaminatedWater.Checked || cbxLowWaterPressure.Checked || cbxMeterFault.Checked ||
                cbxNowatersupply.Checked || cbxTankerAccessibilityIssue.Checked || cbxWaterLeak.Checked ||
                tbxWater.Text != "")
            {
                categories.Add("Water");
            }

            // 2. ENVIRONMENT
            if (cbxEnviromentalhealthhazard.Checked || cbxIllegalLandInvasion.Checked ||
                cbxOvergrownGrassorVerges.Checked || cbxPestInfestation.Checked ||
                cbxPollution.Checked || cbxTreeMaintainance.Checked || tbxEnvironment.Text != "")
            {
                categories.Add("Environment");
            }

            // 3. PUBLIC SAFETY
            // Note: Electricity issues (Cable theft, Power outage, exposed cables) are grouped here as there is no "Infrastructure" category in your list.
            if (cbxByLawInfrengments.Checked || cbxCableTheft.Checked || cbxDisorderlyConduct.Checked ||
                cbxExposedorDamagedCables.Checked || cbxGangActivityHotspot.Checked ||
                cbxIllegalElectricityConnection.Checked || cbxIllegalStreetTrading.Checked ||
                cbxPowerOutage.Checked || cbxPowerSurges.Checked || cbxTransformerFault.Checked ||
                cbxVandalismofPublicProperty.Checked || tbxElectricity.Text != "" || tbxPublicSafety.Text != "")
            {
                categories.Add("Public Safety");
            }

            // 4. HEALTH AND SOCIAL SECURITY
            if (cbxClinicServiceComplaint.Checked || cbxDisasterReliefRequest.Checked ||
                cbxUnsafeFood.Checked || tbxHealth.Text != "")
            {
                categories.Add("Health and Social Security");
            }

            // 5. SANITATION AND WASTE
            if (cbxDamagedManholeCover.Checked || cbxDeadAnimalRemoval.Checked ||
                cbxIllegaldumping.Checked || cbxMissedRefuseCollection.Checked ||
                cbxPublicToiletMaintance.Checked || tbxSanitationWaste.Text != "")
            {
                categories.Add("Sanitation and Waste");
            }

            // Combine the unique categories into a single comma-separated string
            return string.Join(", ", categories);
        }
        private void DisplayRequestReport(MunicipalServiceRequest req)
        {
            // 1. Clear existing text
            rtbReport.Clear();

            // Set base font
            Font regularFont = new Font("Consolas", 10, FontStyle.Regular);
            Font boldFont = new Font("Consolas", 10, FontStyle.Bold);
            Font titleFont = new Font("Consolas", 14, FontStyle.Bold);

            // --- HEADER ---
            rtbReport.SelectionFont = titleFont;
            rtbReport.SelectionAlignment = HorizontalAlignment.Center;
            rtbReport.AppendText("MUNICIPAL SERVICE REQUEST\n");

            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText("==========================================================\n\n");

            rtbReport.SelectionAlignment = HorizontalAlignment.Left;

            // --- CORE DETAILS ---
            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("REFERENCE NO:\t");
            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText(req.ReferenceNumber + "\n");

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("DATE LOGGED:\t");
            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText(req.DateLogged.ToString("dd MMM yyyy, HH:mm") + "\n");

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("STATUS:\t\t");
            // Make Status Green if resolved, else default
            rtbReport.SelectionColor = req.CurrentStatus == "Resolved" ? Color.Green : Color.Black;
            rtbReport.AppendText(req.CurrentStatus + "\n");
            rtbReport.SelectionColor = Color.Black;

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("PRIORITY:\t");
            // Color code the priority
            if (req.Priority.Contains("High")) rtbReport.SelectionColor = Color.Red;
            else if (req.Priority.Contains("Medium")) rtbReport.SelectionColor = Color.DarkOrange;
            else rtbReport.SelectionColor = Color.Green;
            rtbReport.AppendText(req.Priority + "\n\n");
            rtbReport.SelectionColor = Color.Black;

            // --- REQUESTER DETAILS ---
            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("----------------------------------------------------------\n");
            rtbReport.AppendText("1. REQUESTER DETAILS\n");
            rtbReport.AppendText("----------------------------------------------------------\n");

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("NAME:\t\t");
            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText(req.ResidentName + "\n");

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("CONTACT NO:\t");
            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText(req.ContactNumber + "\n\n");

            // --- LOCATION DETAILS ---
            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("----------------------------------------------------------\n");
            rtbReport.AppendText("2. LOCATION DETAILS\n");
            rtbReport.AppendText("----------------------------------------------------------\n");

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("STREET:\t\t");
            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText(req.StreetAddress + "\n");

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("SUBURB:\t\t");
            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText(req.Suburb + "\n\n");

            // --- ISSUE DETAILS ---
            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("----------------------------------------------------------\n");
            rtbReport.AppendText("3. ISSUE DETAILS\n");
            rtbReport.AppendText("----------------------------------------------------------\n");

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("CATEGORY:\t");
            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText(req.Category + "\n");

            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("ISSUE TYPE:\t");
            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText(req.IssueType + "\n\n");

            // --- TIMELINE ---
            rtbReport.SelectionFont = boldFont;
            rtbReport.AppendText("----------------------------------------------------------\n");
            rtbReport.AppendText("4. PROGRESS TIMELINE\n");
            rtbReport.AppendText("----------------------------------------------------------\n");

            foreach (var ev in req.Timeline)
            {
                rtbReport.SelectionFont = regularFont;

                // Format the time and title
                rtbReport.AppendText($"[{ev.Time}]  \t");

                if (ev.Status == "COMPLETE") rtbReport.SelectionColor = Color.Green;
                else if (ev.Status == "PENDING") rtbReport.SelectionColor = Color.Gray;

                rtbReport.SelectionFont = boldFont;
                rtbReport.AppendText($"{ev.Title.PadRight(22)}");

                rtbReport.SelectionFont = regularFont;
                rtbReport.AppendText($" | {ev.Status}\n");
                rtbReport.SelectionColor = Color.Black; // Reset color
            }

            rtbReport.SelectionFont = regularFont;
            rtbReport.AppendText("\n==========================================================\n");
        }

        private void btnMakeChanges_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnSubmit.Visible = true;
            btnMakeChanges.Visible = false;
            pnlSampleReport.Visible = false;
            pnlContainer.Visible = false;
            pnlContainer2.Visible = true;
            btnContinue.Visible = false;
            btnPrevious.Visible = true;
            lblInstruct.Text = "Enter details on the provided fields.The options that are written 'optional' are not compulsory.";
            progressBar.Value = 65;
        }
        private void Details()
        {

            if (!string.IsNullOrEmpty(tbxStreetAddress.Text)
                && !string.IsNullOrEmpty(tbxNearestLandmark.Text)
                && !string.IsNullOrEmpty(tbxTownName.Text)
                && (rbtEmergency1.Checked || rbtEmergency2.Checked)
                && (rbtReoccuring1.Checked || rbtReoccuring2.Checked || rbtReoccuring3.Checked)
                && (rbtNoAccess.Checked || rbtYesAccess.Checked))
            {
                lblInstruct.Text = "If you are satisfied with the details of your request, press Confirm.";
                pnlSampleReport.Visible = true;
                pnlContainer.Visible = false;
                pnlContainer2.Visible = false;
                btnMakeChanges.Visible = true;
                btnConfirm.Visible = true;
                btnSubmit.Visible = false;
                btnMakeChanges.Visible = true;
                btnPrevious.Visible = false;
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
        }
        private void progress()
        {

            // 1. Start with the base 33 points from the first page (Issue Selection)
            // If you have a variable tracking this, use that. Otherwise, hardcode 33.
            int progress = 33;

            // 2. Add points based on the current state of the form
            if (!string.IsNullOrEmpty(tbxStreetAddress.Text)) { progress += 10; }
            if (!string.IsNullOrEmpty(tbxNearestLandmark.Text)) { progress += 10; }
            if (!string.IsNullOrEmpty(tbxTownName.Text)) { progress += 10; }
            if (rbtEmergency1.Checked || rbtEmergency2.Checked) { progress += 10; }
            if (rbtReoccuring1.Checked || rbtReoccuring2.Checked || rbtReoccuring3.Checked) { progress += 10; }
            if (rbtNoAccess.Checked || rbtYesAccess.Checked) { progress += 17; }

            // 3. Safety check: Make sure it never goes over 100
            if (progress > 100)
            {
                progress = 100;
            }

            // 4. Assign the final calculated number to the ProgressBar
            progressBar.Value = progress;



        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // 2. Define where to save the text files (e.g., a folder on the C: drive)
            string saveFolder = @"C:\Users\User\Desktop\Photon Developers\Municipality Service Request Management System X\Requests";

            // 3. Create the generator and save the file
            try
            {
                RequestFileGenerator generator = new RequestFileGenerator(saveFolder);
                generator.SaveRequestToFile(_currentRequest);

                MessageBox.Show($"Request saved successfully!\n\nOpen this folder to view it:\n{saveFolder}", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Saving");
            }
            btnMakeChanges.Visible = false;
            pnlDone.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Images|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _currentRequest.PhotoFilePath = ofd.FileName;
                    pbxQuery.ImageLocation = _currentRequest.PhotoFilePath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

 

