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
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(350, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(290, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Κατάσταση Λεωφορείου";
            // 
            // lblBatteryTitle
            // 
            lblBatteryTitle.AutoSize = true;
            lblBatteryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBatteryTitle.ForeColor = Color.DarkSlateGray;
            lblBatteryTitle.Location = new Point(100, 130);
            lblBatteryTitle.Name = "lblBatteryTitle";
            lblBatteryTitle.Size = new Size(215, 25);
            lblBatteryTitle.TabIndex = 1;
            lblBatteryTitle.Text = "Φόρτιση Μπαταρίας:";
            // 
            // lblBatteryVal
            // 
            lblBatteryVal.AutoSize = true;
            lblBatteryVal.Font = new Font("Segoe UI", 14F);
            lblBatteryVal.ForeColor = Color.ForestGreen;
            lblBatteryVal.Location = new Point(430, 130);
            lblBatteryVal.Name = "lblBatteryVal";
            lblBatteryVal.Size = new Size(55, 25);
            lblBatteryVal.TabIndex = 2;
            lblBatteryVal.Text = "85%";
            // 
            // lblSolarTitle
            // 
            lblSolarTitle.AutoSize = true;
            lblSolarTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSolarTitle.ForeColor = Color.DarkSlateGray;
            lblSolarTitle.Location = new Point(100, 190);
            lblSolarTitle.Name = "lblSolarTitle";
            lblSolarTitle.Size = new Size(220, 25);
            lblSolarTitle.TabIndex = 3;
            lblSolarTitle.Text = "Ηλιοφάνεια Πάνελ:";
            // 
            // lblSolarVal
            // 
            lblSolarVal.AutoSize = true;
            lblSolarVal.Font = new Font("Segoe UI", 14F);
            lblSolarVal.ForeColor = Color.Goldenrod;
            lblSolarVal.Location = new Point(430, 190);
            lblSolarVal.Name = "lblSolarVal";
            lblSolarVal.Size = new Size(55, 25);
            lblSolarVal.TabIndex = 4;
            lblSolarVal.Text = "82%";
            // 
            // lblDustTitle
            // 
            lblDustTitle.AutoSize = true;
            lblDustTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDustTitle.ForeColor = Color.DarkSlateGray;
            lblDustTitle.Location = new Point(100, 250);
            lblDustTitle.Name = "lblDustTitle";
            lblDustTitle.Size = new Size(240, 25);
            lblDustTitle.TabIndex = 5;
            lblDustTitle.Text = "Ρύπανση Φωτοβολταϊκών:";
            // 
            // lblDustVal
            // 
            lblDustVal.AutoSize = true;
            lblDustVal.Font = new Font("Segoe UI", 14F);
            lblDustVal.ForeColor = Color.Firebrick;
            lblDustVal.Location = new Point(430, 250);
            lblDustVal.Name = "lblDustVal";
            lblDustVal.Size = new Size(115, 25);
            lblDustVal.TabIndex = 6;
            lblDustVal.Text = "Χαμηλός (5%)";
            // 
            // lblCheckDateTitle
            // 
            lblCheckDateTitle.AutoSize = true;
            lblCheckDateTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCheckDateTitle.ForeColor = Color.DarkSlateGray;
            lblCheckDateTitle.Location = new Point(100, 310);
            lblCheckDateTitle.Name = "lblCheckDateTitle";
            lblCheckDateTitle.Size = new Size(230, 25);
            lblCheckDateTitle.TabIndex = 7;
            lblCheckDateTitle.Text = "Επόμενος Έλεγχος:";
            // 
            // lblCheckDateVal
            // 
            lblCheckDateVal.AutoSize = true;
            lblCheckDateVal.Font = new Font("Segoe UI", 14F);
            lblCheckDateVal.ForeColor = Color.MidnightBlue;
            lblCheckDateVal.Location = new Point(430, 310);
            lblCheckDateVal.Name = "lblCheckDateVal";
            lblCheckDateVal.Size = new Size(115, 25);
            lblCheckDateVal.TabIndex = 8;
            lblCheckDateVal.Text = "15/11/2026";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.MidnightBlue;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(100, 380);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(220, 45);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Ανανέωση Δεδομένων";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(12, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 45);
            btnBack.TabIndex = 10;
            btnBack.Text = "Επιστροφή στον πίνακα";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // BusStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
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
            Text = "Κατάσταση Λεωφορείου - MagicBus";
            Load += BusStatus_Load;
            ResumeLayout(false);
            PerformLayout();
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