namespace MagicBus
{
    partial class RobotCleaner
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
            lblStatus = new Label();
            lblFloor = new Label();
            cmbFloor = new ComboBox();
            btnBack = new Button();
            btnStop = new Button();
            btnStart = new Button();
            progressCleaning = new ProgressBar();
            lblProgress = new Label();
            timerCleaning = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(354, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ρομπότ καθαρισμού";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblStatus.ForeColor = Color.MidnightBlue;
            lblStatus.Location = new Point(30, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(260, 31);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Κατάσταση: Σε αναμονή";
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblFloor.ForeColor = Color.MidnightBlue;
            lblFloor.Location = new Point(30, 160);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(302, 31);
            lblFloor.TabIndex = 2;
            lblFloor.Text = "Επιλέξτε όροφο καθαρισμού";
            // 
            // cmbFloor
            // 
            cmbFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFloor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbFloor.FormattingEnabled = true;
            cmbFloor.Items.AddRange(new object[] { "Κάτω όροφος", "Επάνω όροφος" });
            cmbFloor.Location = new Point(30, 200);
            cmbFloor.Name = "cmbFloor";
            cmbFloor.Size = new Size(350, 39);
            cmbFloor.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(220, 50);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnStop.Location = new Point(340, 280);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(280, 60);
            btnStop.TabIndex = 5;
            btnStop.Text = "Διακοπή καθαρισμού";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnStart.Location = new Point(30, 280);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(280, 60);
            btnStart.TabIndex = 6;
            btnStart.Text = "Έναρξη καθαρισμού";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressCleaning
            // 
            progressCleaning.Location = new Point(30, 380);
            progressCleaning.Name = "progressCleaning";
            progressCleaning.Size = new Size(590, 35);
            progressCleaning.TabIndex = 7;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblProgress.Location = new Point(30, 430);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(148, 31);
            lblProgress.TabIndex = 8;
            lblProgress.Text = "Πρόοδος: 0%";
            // 
            // timerCleaning
            // 
            timerCleaning.Interval = 2000;
            timerCleaning.Tick += timerCleaning_Tick;
            // 
            // RobotCleaner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(lblProgress);
            Controls.Add(progressCleaning);
            Controls.Add(btnStart);
            Controls.Add(btnStop);
            Controls.Add(btnBack);
            Controls.Add(cmbFloor);
            Controls.Add(lblFloor);
            Controls.Add(lblStatus);
            Controls.Add(lblTitle);
            Name = "RobotCleaner";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Ρομπότ καθαρισμού";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStatus;
        private Label lblFloor;
        private ComboBox cmbFloor;
        private Button btnBack;
        private Button btnStop;
        private Button btnStart;
        private ProgressBar progressCleaning;
        private Label lblProgress;
        private System.Windows.Forms.Timer timerCleaning;
    }
}