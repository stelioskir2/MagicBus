namespace MagicBus
{
    partial class ClimateControl
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
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(340, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(298, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Έλεγχος Κλιματισμού";
            // 
            // lblTempTitle
            // 
            lblTempTitle.AutoSize = true;
            lblTempTitle.Font = new Font("Segoe UI", 14F);
            lblTempTitle.Location = new Point(380, 130);
            lblTempTitle.Name = "lblTempTitle";
            lblTempTitle.Size = new Size(215, 25);
            lblTempTitle.TabIndex = 1;
            lblTempTitle.Text = "Θερμοκρασία Καμπίνας";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTemperature.ForeColor = Color.MidnightBlue;
            lblTemperature.Location = new Point(430, 170);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(88, 45);
            lblTemperature.TabIndex = 2;
            lblTemperature.Text = "22°C";
            // 
            // btnTempUp
            // 
            btnTempUp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTempUp.Location = new Point(530, 170);
            btnTempUp.Name = "btnTempUp";
            btnTempUp.Size = new Size(50, 45);
            btnTempUp.TabIndex = 3;
            btnTempUp.Text = "+";
            btnTempUp.UseVisualStyleBackColor = true;
            btnTempUp.Click += btnTempUp_Click;
            // 
            // btnTempDown
            // 
            btnTempDown.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTempDown.Location = new Point(360, 170);
            btnTempDown.Name = "btnTempDown";
            btnTempDown.Size = new Size(50, 45);
            btnTempDown.TabIndex = 4;
            btnTempDown.Text = "-";
            btnTempDown.UseVisualStyleBackColor = true;
            btnTempDown.Click += btnTempDown_Click;
            // 
            // btnAcOn
            // 
            btnAcOn.BackColor = Color.ForestGreen;
            btnAcOn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAcOn.ForeColor = Color.White;
            btnAcOn.Location = new Point(330, 260);
            btnAcOn.Name = "btnAcOn";
            btnAcOn.Size = new Size(140, 50);
            btnAcOn.TabIndex = 5;
            btnAcOn.Text = "A/C ON";
            btnAcOn.UseVisualStyleBackColor = false;
            btnAcOn.Click += btnAcOn_Click;
            // 
            // btnAcOff
            // 
            btnAcOff.BackColor = Color.Firebrick;
            btnAcOff.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAcOff.ForeColor = Color.White;
            btnAcOff.Location = new Point(490, 260);
            btnAcOff.Name = "btnAcOff";
            btnAcOff.Size = new Size(140, 50);
            btnAcOff.TabIndex = 6;
            btnAcOff.Text = "A/C OFF";
            btnAcOff.UseVisualStyleBackColor = false;
            btnAcOff.Click += btnAcOff_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(390, 330);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(201, 21);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Κατάσταση: Ενεργό (ON)";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(12, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 48);
            btnBack.TabIndex = 7;
            btnBack.Text = "Επιστροφή στον 'Ελεγχο Οδηγού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ClimateControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
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
            Text = "Έλεγχος Κλιματισμού - MagicBus";
            Load += ClimateControl_Load;
            ResumeLayout(false);
            PerformLayout();
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