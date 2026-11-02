namespace MagicBus
{
    partial class ClimateControl
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
            lblTempTitle = new Label();
            lblTemperature = new Label();
            btnTempUp = new Button();
            btnTempDown = new Button();
            btnAcOn = new Button();
            btnAcOff = new Button();
            lblStatus = new Label();
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
            lblTitle.Text = "Έλεγχος Κλιματισμού";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblTempTitle
            lblTempTitle.AutoSize = false;
            lblTempTitle.Font = new Font("Segoe UI", 14F);
            lblTempTitle.Location = new Point(241, 155);
            lblTempTitle.Name = "lblTempTitle";
            lblTempTitle.Size = new Size(500, 45);
            lblTempTitle.TabIndex = 1;
            lblTempTitle.Text = "Θερμοκρασία Καμπίνας";
            lblTempTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblTemperature
            lblTemperature.AutoSize = false;
            lblTemperature.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTemperature.ForeColor = Color.MidnightBlue;
            lblTemperature.Location = new Point(411, 215);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(160, 65);
            lblTemperature.TabIndex = 2;
            lblTemperature.Text = "22°C";
            lblTemperature.TextAlign = ContentAlignment.MiddleCenter;

            // btnTempUp
            btnTempUp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTempUp.Location = new Point(591, 215);
            btnTempUp.Name = "btnTempUp";
            btnTempUp.Size = new Size(60, 65);
            btnTempUp.TabIndex = 1;
            btnTempUp.Text = "+";
            btnTempUp.UseVisualStyleBackColor = true;
            btnTempUp.Click += btnTempUp_Click;

            // btnTempDown
            btnTempDown.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTempDown.Location = new Point(331, 215);
            btnTempDown.Name = "btnTempDown";
            btnTempDown.Size = new Size(60, 65);
            btnTempDown.TabIndex = 0;
            btnTempDown.Text = "-";
            btnTempDown.UseVisualStyleBackColor = true;
            btnTempDown.Click += btnTempDown_Click;

            // btnAcOn
            btnAcOn.BackColor = Color.ForestGreen;
            btnAcOn.FlatStyle = FlatStyle.Flat;
            btnAcOn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAcOn.ForeColor = Color.White;
            btnAcOn.Location = new Point(291, 325);
            btnAcOn.Name = "btnAcOn";
            btnAcOn.Size = new Size(180, 65);
            btnAcOn.TabIndex = 2;
            btnAcOn.Text = "A/C ON";
            btnAcOn.UseVisualStyleBackColor = false;
            btnAcOn.Click += btnAcOn_Click;

            // btnAcOff
            btnAcOff.BackColor = Color.Firebrick;
            btnAcOff.FlatStyle = FlatStyle.Flat;
            btnAcOff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAcOff.ForeColor = Color.White;
            btnAcOff.Location = new Point(511, 325);
            btnAcOff.Name = "btnAcOff";
            btnAcOff.Size = new Size(180, 65);
            btnAcOff.TabIndex = 3;
            btnAcOff.Text = "A/C OFF";
            btnAcOff.UseVisualStyleBackColor = false;
            btnAcOff.Click += btnAcOff_Click;

            // lblStatus
            lblStatus.AutoSize = false;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(191, 420);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(600, 55);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Κατάσταση: Ενεργό (ON)";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            // btnBack
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 50);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή στον πίνακα οδηγού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // ClimateControl
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(lblStatus);
            Controls.Add(btnBack);
            Controls.Add(btnAcOff);
            Controls.Add(btnAcOn);
            Controls.Add(btnTempDown);
            Controls.Add(btnTempUp);
            Controls.Add(lblTemperature);
            Controls.Add(lblTempTitle);
            Controls.Add(lblTitle);
            Name = "ClimateControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Έλεγχος Κλιματισμού - MagicBus";
            Load += ClimateControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblTempTitle;
        private Label lblTemperature;
        private Button btnTempUp;
        private Button btnTempDown;
        private Button btnAcOn;
        private Button btnAcOff;
        private Label lblStatus;
        private Button btnBack;
    }
}