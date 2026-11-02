namespace MagicBus
{
    partial class RobotCleaner
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

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Font = new Font(
                "Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(922, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ρομπότ καθαρισμού";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblStatus
            lblStatus.AutoSize = false;
            lblStatus.Font = new Font("Segoe UI", 13.8F);
            lblStatus.ForeColor = Color.MidnightBlue;
            lblStatus.Location = new Point(130, 130);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(722, 70);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Κατάσταση: Σε αναμονή";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            // lblFloor
            lblFloor.AutoSize = false;
            lblFloor.Font = new Font("Segoe UI", 13.8F);
            lblFloor.ForeColor = Color.MidnightBlue;
            lblFloor.Location = new Point(130, 210);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(722, 40);
            lblFloor.TabIndex = 2;
            lblFloor.Text = "Επιλέξτε όροφο καθαρισμού";
            lblFloor.TextAlign = ContentAlignment.MiddleCenter;

            // cmbFloor
            cmbFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFloor.Font = new Font("Segoe UI", 13.8F);
            cmbFloor.FormattingEnabled = true;
            cmbFloor.Items.AddRange(new object[]
            {
                "Κάτω όροφος",
                "Επάνω όροφος"
            });
            cmbFloor.Location = new Point(291, 260);
            cmbFloor.Margin = new Padding(3, 2, 3, 2);
            cmbFloor.Name = "cmbFloor";
            cmbFloor.Size = new Size(400, 39);
            cmbFloor.TabIndex = 3;

            // btnBack
            btnBack.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(30, 525);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(340, 50);
            btnBack.TabIndex = 6;
            btnBack.Text = "Επιστροφή στον πίνακα προσωπικού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // btnStop
            btnStop.BackColor = Color.MidnightBlue;
            btnStop.Enabled = false;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(532, 325);
            btnStop.Margin = new Padding(3, 2, 3, 2);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(320, 65);
            btnStop.TabIndex = 5;
            btnStop.Text = "Διακοπή καθαρισμού";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;

            // btnStart
            btnStart.BackColor = Color.MidnightBlue;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(130, 325);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(320, 65);
            btnStart.TabIndex = 4;
            btnStart.Text = "Έναρξη καθαρισμού";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;

            // progressCleaning
            progressCleaning.Location = new Point(130, 420);
            progressCleaning.Margin = new Padding(3, 2, 3, 2);
            progressCleaning.Name = "progressCleaning";
            progressCleaning.Size = new Size(722, 30);
            progressCleaning.TabIndex = 7;

            // lblProgress
            lblProgress.AutoSize = false;
            lblProgress.Font = new Font("Segoe UI", 13.8F);
            lblProgress.Location = new Point(130, 460);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(722, 40);
            lblProgress.TabIndex = 8;
            lblProgress.Text = "Πρόοδος: 0%";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;

            // timerCleaning
            timerCleaning.Interval = 2000;
            timerCleaning.Tick += timerCleaning_Tick;

            // RobotCleaner
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "RobotCleaner";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Ρομπότ καθαρισμού";
            ResumeLayout(false);
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