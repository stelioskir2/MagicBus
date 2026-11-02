namespace MagicBus
{
    partial class BusStatus
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblBatteryTitle = new Label();
            lblBatteryVal = new Label();
            lblSolarTitle = new Label();
            lblSolarVal = new Label();
            lblDustTitle = new Label();
            lblDustVal = new Label();
            lblCheckDateTitle = new Label();
            lblCheckDateVal = new Label();
            btnRefresh = new Button();
            btnBack = new Button();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(922, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Κατάσταση Λεωφορείου";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblBatteryTitle
            lblBatteryTitle.AutoSize = false;
            lblBatteryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBatteryTitle.ForeColor = Color.DarkSlateGray;
            lblBatteryTitle.Location = new Point(70, 150);
            lblBatteryTitle.Name = "lblBatteryTitle";
            lblBatteryTitle.Size = new Size(360, 45);
            lblBatteryTitle.TabIndex = 1;
            lblBatteryTitle.Text = "Φόρτιση Μπαταρίας:";
            lblBatteryTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblBatteryVal
            lblBatteryVal.AutoSize = false;
            lblBatteryVal.Font = new Font("Segoe UI", 14F);
            lblBatteryVal.ForeColor = Color.ForestGreen;
            lblBatteryVal.Location = new Point(470, 150);
            lblBatteryVal.Name = "lblBatteryVal";
            lblBatteryVal.Size = new Size(440, 45);
            lblBatteryVal.TabIndex = 2;
            lblBatteryVal.Text = "85%";
            lblBatteryVal.TextAlign = ContentAlignment.MiddleLeft;

            // lblSolarTitle
            lblSolarTitle.AutoSize = false;
            lblSolarTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSolarTitle.ForeColor = Color.DarkSlateGray;
            lblSolarTitle.Location = new Point(70, 215);
            lblSolarTitle.Name = "lblSolarTitle";
            lblSolarTitle.Size = new Size(360, 45);
            lblSolarTitle.TabIndex = 3;
            lblSolarTitle.Text = "Ηλιοφάνεια Πάνελ:";
            lblSolarTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblSolarVal
            lblSolarVal.AutoSize = false;
            lblSolarVal.Font = new Font("Segoe UI", 14F);
            lblSolarVal.ForeColor = Color.Goldenrod;
            lblSolarVal.Location = new Point(470, 215);
            lblSolarVal.Name = "lblSolarVal";
            lblSolarVal.Size = new Size(440, 45);
            lblSolarVal.TabIndex = 4;
            lblSolarVal.Text = "82%";
            lblSolarVal.TextAlign = ContentAlignment.MiddleLeft;

            // lblDustTitle
            lblDustTitle.AutoSize = false;
            lblDustTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDustTitle.ForeColor = Color.DarkSlateGray;
            lblDustTitle.Location = new Point(70, 280);
            lblDustTitle.Name = "lblDustTitle";
            lblDustTitle.Size = new Size(360, 45);
            lblDustTitle.TabIndex = 5;
            lblDustTitle.Text = "Ρύπανση Φωτοβολταϊκών:";
            lblDustTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblDustVal
            lblDustVal.AutoSize = false;
            lblDustVal.Font = new Font("Segoe UI", 14F);
            lblDustVal.ForeColor = Color.Firebrick;
            lblDustVal.Location = new Point(470, 280);
            lblDustVal.Name = "lblDustVal";
            lblDustVal.Size = new Size(440, 80);
            lblDustVal.TabIndex = 6;
            lblDustVal.Text = "Χαμηλή (4%)";
            lblDustVal.TextAlign = ContentAlignment.TopLeft;

            // lblCheckDateTitle
            lblCheckDateTitle.AutoSize = false;
            lblCheckDateTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCheckDateTitle.ForeColor = Color.DarkSlateGray;
            lblCheckDateTitle.Location = new Point(70, 370);
            lblCheckDateTitle.Name = "lblCheckDateTitle";
            lblCheckDateTitle.Size = new Size(360, 45);
            lblCheckDateTitle.TabIndex = 7;
            lblCheckDateTitle.Text = "Επόμενος Έλεγχος:";
            lblCheckDateTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblCheckDateVal
            lblCheckDateVal.AutoSize = false;
            lblCheckDateVal.Font = new Font("Segoe UI", 14F);
            lblCheckDateVal.ForeColor = Color.MidnightBlue;
            lblCheckDateVal.Location = new Point(470, 370);
            lblCheckDateVal.Name = "lblCheckDateVal";
            lblCheckDateVal.Size = new Size(440, 45);
            lblCheckDateVal.TabIndex = 8;
            lblCheckDateVal.Text = "15/11/2026";
            lblCheckDateVal.TextAlign = ContentAlignment.MiddleLeft;

            // btnRefresh
            btnRefresh.BackColor = Color.MidnightBlue;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(331, 440);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(320, 60);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Ανανέωση Δεδομένων";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;

            // btnBack
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(340, 50);
            btnBack.TabIndex = 10;
            btnBack.Text = "Επιστροφή στον πίνακα προσωπικού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // BusStatus
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(lblCheckDateVal);
            Controls.Add(lblCheckDateTitle);
            Controls.Add(lblDustVal);
            Controls.Add(lblDustTitle);
            Controls.Add(lblSolarVal);
            Controls.Add(lblSolarTitle);
            Controls.Add(lblBatteryVal);
            Controls.Add(lblBatteryTitle);
            Controls.Add(lblTitle);
            Name = "BusStatus";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Κατάσταση Λεωφορείου - MagicBus";
            Load += BusStatus_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblBatteryTitle;
        private Label lblBatteryVal;
        private Label lblSolarTitle;
        private Label lblSolarVal;
        private Label lblDustTitle;
        private Label lblDustVal;
        private Label lblCheckDateTitle;
        private Label lblCheckDateVal;
        private Button btnRefresh;
        private Button btnBack;
    }
}