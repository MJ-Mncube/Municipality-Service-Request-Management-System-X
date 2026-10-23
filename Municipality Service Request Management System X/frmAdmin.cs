using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace Municipality_Service_Request_Management_System_X
{
    public partial class frmAdmin : Form
    {
        private string filepath = @"C:\Users\User\Documents\Lagash ltd\Residents.txt";
        private DataTable residentTable = new DataTable();
        public frmAdmin()
        {
            InitializeComponent();
            //tpUsers.Click += tpUsers_Click;
            SetupDataTable();
            ShowHelpDetails();

        }
        // --- SETUP DATATABLE ---
        private void SetupDataTable()
        {
            residentTable.Columns.Add("UserID");
            residentTable.Columns.Add("Name");
            residentTable.Columns.Add("Surname");
            residentTable.Columns.Add("Age", typeof(int));
            residentTable.Columns.Add("Gender");
            residentTable.Columns.Add("Race");
            residentTable.Columns.Add("Email");
            residentTable.Columns.Add("ID");
            residentTable.Columns.Add("Phone");
            residentTable.Columns.Add("Password");

            // Link the table to the grid
            dataGridView1.DataSource = residentTable;
        }

        // --- 1. READ: LOAD FILE INTO GRID ---
        private void btnLoad_Click(object sender, EventArgs e)
        {
            residentTable.Rows.Clear(); // Clear existing data before loading

            if (!File.Exists(filepath))
            {
                MessageBox.Show("File not found!");
                return;
            }

            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split('|');
                if (parts.Length == 10) // Ensure the line is valid
                {
                    residentTable.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4],
                                           parts[5], parts[6], parts[7], parts[8], parts[9]);
                }
            }
        }

        // --- SAVE HELPER (Writes DataTable back to Text File) ---
        private void SaveToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    foreach (DataRow row in residentTable.Rows)
                    {
                        // Join all columns with the pipe symbol
                        string line = string.Join("|", row.ItemArray);
                        sw.WriteLine(line);
                    }
                }
                MessageBox.Show("File updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
        }

        // --- 2. ADD: CREATE A NEW RESIDENT ---
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Add a new row to the DataTable using the textboxes
            residentTable.Rows.Add(
                txtUserID.Text, txtName.Text, txtSurname.Text, txtAge.Text,
                txtGender.Text, txtRace.Text, txtEmail.Text, txtID.Text,
                txtPhone.Text, txtPassword.Text
            );

            SaveToFile(); // Save the updated table to the text file
            ClearTextBoxes();
        }

        // --- 3. DELETE: REMOVE A RESIDENT ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this resident?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove the selected row from the DataTable
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    SaveToFile(); // Save changes to text file
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Please select a full row to delete.");
            }
        }

        // --- 4. UPDATE: EDIT AN EXISTING RESIDENT ---
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Update the DataTable directly
                DataRow rowToUpdate = residentTable.Rows[selectedIndex];
                rowToUpdate["UserID"] = txtUserID.Text;
                rowToUpdate["Name"] = txtName.Text;
                rowToUpdate["Surname"] = txtSurname.Text;
                rowToUpdate["Age"] = txtAge.Text;
                rowToUpdate["Gender"] = txtGender.Text;
                rowToUpdate["Race"] = txtRace.Text;
                rowToUpdate["Email"] = txtEmail.Text;
                rowToUpdate["ID"] = txtID.Text;
                rowToUpdate["Phone"] = txtPhone.Text;
                rowToUpdate["Password"] = txtPassword.Text;

                SaveToFile(); // Save changes to text file
                MessageBox.Show("Updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        // --- UI HELPER: Click on Grid to Fill TextBoxes ---
        // Double click your DataGridView in the designer to create this event
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate textboxes with the row's data
                txtUserID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtSurname.Text = row.Cells[2].Value.ToString();
                txtAge.Text = row.Cells[3].Value.ToString();
                txtGender.Text = row.Cells[4].Value.ToString();
                txtRace.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtID.Text = row.Cells[7].Value.ToString();
                txtPhone.Text = row.Cells[8].Value.ToString();
                txtPassword.Text = row.Cells[9].Value.ToString();
            }
        }

        // --- UI HELPER: Clear TextBoxes ---
        private void ClearTextBoxes()
        {
            txtUserID.Clear(); txtName.Clear(); txtSurname.Clear();
            txtAge.Clear(); txtGender.Clear(); txtRace.Clear();
            txtEmail.Clear(); txtID.Clear(); txtPhone.Clear();
            txtPassword.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 2. Get the first selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // 3. Extract the data from the row and put it in the textboxes
                // We use '?.ToString()' to prevent crashes if a cell is empty (null)
                txtUserID.Text = selectedRow.Cells[0].Value?.ToString();
                txtName.Text = selectedRow.Cells[1].Value?.ToString();
                txtSurname.Text = selectedRow.Cells[2].Value?.ToString();
                txtAge.Text = selectedRow.Cells[3].Value?.ToString();
                txtGender.Text = selectedRow.Cells[4].Value?.ToString();
                txtRace.Text = selectedRow.Cells[5].Value?.ToString();
                txtEmail.Text = selectedRow.Cells[6].Value?.ToString();
                txtID.Text = selectedRow.Cells[7].Value?.ToString();
                txtPhone.Text = selectedRow.Cells[8].Value?.ToString();
                txtPassword.Text = selectedRow.Cells[9].Value?.ToString();
            }
            else
            {
                // If they click the button without selecting a row, show a warning
                MessageBox.Show("Please click on a row in the grid first, then click Read Line.", "No Row Selected");
            }
        }

        private void btnSORT_Click(object sender, EventArgs e)
        {
            DataView view = residentTable.DefaultView;

            // 2. Check which radio button is selected and apply the sort
            if (rbtAge.Checked)
            {
                // Sorts Age from smallest to largest
                view.Sort = "Age ASC";
            }
            else if (rbtGender.Checked)
            {
                // Sorts Gender alphabetically (e.g., Female before Male)
                view.Sort = "Gender ASC";
            }
            else if (rbtRace.Checked)
            {
                // Sorts Race alphabetically
                view.Sort = "Race ASC";
            }
            else
            {
                MessageBox.Show("Please select an option to sort by (Age, Gender, or Race).", "No Option Selected");
                return;
            }

            // 3. Rebind the sorted view back to the DataGridView
            dataGridView1.DataSource = view;
        }

        private void tbcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtdetails_TextChanged(object sender, EventArgs e)
        {

        }
        private void ShowHelpDetails()
        {
            rbtDetails.ReadOnly = true;
            rbtDetails.Text = "This Admin Management page allows you to view, organize, and update all resident accounts stored in the system. " +
                              "The Data Grid View displays all registered residents and allows you to click on any row to highlight a specific person. " +
                              "The text boxes above are used to display and edit resident details including User ID, Name, Surname, Age, Gender, Race, Email, ID, Phone, and Password. " +
                              "You can use the Read Line button to automatically copy the details of the selected grid row into these text boxes. " +
                              "To create a new resident, fill in the text boxes and click the Add button. " +
                              "To modify an existing resident, select their row, make your changes in the text boxes, and click Update. " +
                              "If a resident needs to be removed from the system, select their row and click Delete. " +
                              "The Load button refreshes the grid with the latest data from the text file. " +
                              "Finally, to organize the list, select the Age, Gender, or Race option and click the Sort button to instantly rearrange the grid.";
        }

       
    }
}

