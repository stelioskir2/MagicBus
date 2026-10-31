namespace MagicBus
{
    partial class DriverSafety
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblSpeedTitle = new Label();
            lblSpeed = new Label();
            lblLimit = new Label();
            trkSpeed = new TrackBar();
            btnLane = new Button();
            btnFatigue = new Button();
            pnlAlert = new Panel();
            lblAlert = new Label();
            lblHistory = new Label();
            lstAlerts = new ListBox();
            btnBack = new Button();
            timerAlert = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trkSpeed).BeginInit();
            pnlAlert.SuspendLayout();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(375, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ειδοποιήσεις οδήγησης";
            //
            // lblSpeedTitle
            //
            lblSpeedTitle.AutoSize = true;
            lblSpeedTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblSpeedTitle.Location = new Point(30, 90);
            lblSpeedTitle.Name = "lblSpeedTitle";
            lblSpeedTitle.Size = new Size(200, 28);
            lblSpeedTitle.TabIndex = 1;
            lblSpeedTitle.Text = "Ταχύτητα λεωφορείου";
            //
            // lblSpeed
            //
            lblSpeed.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblSpeed.ForeColor = Color.MidnightBlue;
            lblSpeed.Location = new Point(30, 120);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(250, 65);
            lblSpeed.TabIndex = 2;
            lblSpeed.Text = "0 km/h";
            //
            // lblLimit
            //
            lblLimit.AutoSize = true;
            lblLimit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblLimit.Location = new Point(300, 145);
            lblLimit.Name = "lblLimit";
            lblLimit.Size = new Size(133, 28);
            lblLimit.TabIndex = 3;
            lblLimit.Text = "Όριο: 50 km/h";
            //
            // trkSpeed
            //
            trkSpeed.LargeChange = 10;
            trkSpeed.Location = new Point(30, 195);
            trkSpeed.Maximum = 100;
            trkSpeed.Name = "trkSpeed";
            trkSpeed.Size = new Size(420, 56);
            trkSpeed.SmallChange = 5;
            trkSpeed.TabIndex = 4;
            trkSpeed.TickFrequency = 10;
            trkSpeed.ValueChanged += trkSpeed_ValueChanged;
            //
            // btnLane
            //
            btnLane.BackColor = Color.MidnightBlue;
            btnLane.FlatStyle = FlatStyle.Flat;
            btnLane.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnLane.ForeColor = Color.White;
            btnLane.Location = new Point(30, 280);
            btnLane.Name = "btnLane";
            btnLane.Size = new Size(420, 55);
            btnLane.TabIndex = 5;
            btnLane.Text = "Προσομοίωση εξόδου από λωρίδα";
            btnLane.UseVisualStyleBackColor = false;
            btnLane.Click += btnLane_Click;
            //
            // btnFatigue
            //
            btnFatigue.BackColor = Color.MidnightBlue;
            btnFatigue.FlatStyle = FlatStyle.Flat;
            btnFatigue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnFatigue.ForeColor = Color.White;
            btnFatigue.Location = new Point(30, 350);
            btnFatigue.Name = "btnFatigue";
            btnFatigue.Size = new Size(420, 55);
            btnFatigue.TabIndex = 6;
            btnFatigue.Text = "Προσομοίωση κόπωσης οδηγού";
            btnFatigue.UseVisualStyleBackColor = false;
            btnFatigue.Click += btnFatigue_Click;
            //
            // pnlAlert
            //
            pnlAlert.BackColor = Color.SeaGreen;
            pnlAlert.Controls.Add(lblAlert);
            pnlAlert.Location = new Point(490, 90);
            pnlAlert.Name = "pnlAlert";
            pnlAlert.Size = new Size(460, 200);
            pnlAlert.TabIndex = 7;
            //
            // lblAlert
            //
            lblAlert.Dock = DockStyle.Fill;
            lblAlert.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblAlert.ForeColor = Color.White;
            lblAlert.Location = new Point(0, 0);
            lblAlert.Name = "lblAlert";
            lblAlert.Size = new Size(460, 200);
            lblAlert.TabIndex = 0;
            lblAlert.Text = "Όλα κανονικά";
            lblAlert.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblHistory
            //
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblHistory.Location = new Point(490, 305);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(221, 28);
            lblHistory.TabIndex = 8;
            lblHistory.Text = "Ιστορικό ειδοποιήσεων";
            //
            // lstAlerts
            //
            lstAlerts.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstAlerts.FormattingEnabled = true;
            lstAlerts.Location = new Point(490, 340);
            lstAlerts.Name = "lstAlerts";
            lstAlerts.Size = new Size(460, 154);
            lstAlerts.TabIndex = 9;
            //
            // btnBack
            //
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(300, 50);
            btnBack.TabIndex = 10;
            btnBack.Text = "Επιστροφή στον πίνακα οδηγού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // timerAlert
            //
            timerAlert.Interval = 5000;
            timerAlert.Tick += timerAlert_Tick;
            //
            // DriverSafety
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(lstAlerts);
            Controls.Add(lblHistory);
            Controls.Add(pnlAlert);
            Controls.Add(btnFatigue);
            Controls.Add(btnLane);
            Controls.Add(trkSpeed);
            Controls.Add(lblLimit);
            Controls.Add(lblSpeed);
            Controls.Add(lblSpeedTitle);
            Controls.Add(lblTitle);
            Name = "DriverSafety";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Ειδοποιήσεις οδήγησης";
            ((System.ComponentModel.ISupportInitialize)trkSpeed).EndInit();
            pnlAlert.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSpeedTitle;
        private Label lblSpeed;
        private Label lblLimit;
        private TrackBar trkSpeed;
        private Button btnLane;
        private Button btnFatigue;
        private Panel pnlAlert;
        private Label lblAlert;
        private Label lblHistory;
        private ListBox lstAlerts;
        private Button btnBack;
        private System.Windows.Forms.Timer timerAlert;
    }
}
