namespace Municipality_Service_Request_Management_System_X
{
    partial class formDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDashboard = new Label();
            SuspendLayout();
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(282, 181);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(161, 33);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDashboard";
            Text = "formDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboard;
    }
}