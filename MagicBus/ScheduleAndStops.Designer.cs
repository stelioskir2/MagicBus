namespace MagicBus
{
    partial class ScheduleAndStops
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
            lblSubtitle = new Label();
            dgvStops = new DataGridView();
            lblCurrentStopTitle = new Label();
            lblCurrentStopVal = new Label();
            lblTrafficTitle = new Label();
            lblTrafficVal = new Label();
            btnNextStop = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStops).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(50, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(205, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ΘΕΣΣΑΛΟΝΙΚΗ";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.DarkSlateGray;
            lblSubtitle.Location = new Point(50, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(320, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "MagicBus / 6 στάσεις για να γνωρίσετε την πόλη";
            // 
            // dgvStops
            // 
            dgvStops.AllowUserToAddRows = false;
            dgvStops.AllowUserToDeleteRows = false;
            dgvStops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStops.Location = new Point(50, 110);
            dgvStops.Name = "dgvStops";
            dgvStops.ReadOnly = true;
            dgvStops.Size = new Size(580, 280);
            dgvStops.TabIndex = 2;
            // 
            // lblCurrentStopTitle
            // 
            lblCurrentStopTitle.AutoSize = true;
            lblCurrentStopTitle.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblCurrentStopTitle.ForeColor = Color.DarkSlateGray;
            lblCurrentStopTitle.Location = new Point(660, 110);
            lblCurrentStopTitle.Name = "lblCurrentStopTitle";
            lblCurrentStopTitle.Size = new Size(160, 25);
            lblCurrentStopTitle.TabIndex = 3;
            lblCurrentStopTitle.Text = "Τρέχουσα Στάση:";
            // 
            // lblCurrentStopVal
            // 
            lblCurrentStopVal.AutoSize = true;
            lblCurrentStopVal.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblCurrentStopVal.ForeColor = Color.MidnightBlue;
            lblCurrentStopVal.Location = new Point(660, 145);
            lblCurrentStopVal.Name = "lblCurrentStopVal";
            lblCurrentStopVal.Size = new Size(165, 25);
            lblCurrentStopVal.TabIndex = 4;
            lblCurrentStopVal.Text = "1. Λευκός Πύργος";
            // 
            // lblTrafficTitle
            // 
            lblTrafficTitle.AutoSize = true;
            lblTrafficTitle.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblTrafficTitle.ForeColor = Color.DarkSlateGray;
            lblTrafficTitle.Location = new Point(660, 200);
            lblTrafficTitle.Name = "lblTrafficTitle";
            lblTrafficTitle.Size = new Size(185, 25);
            lblTrafficTitle.TabIndex = 5;
            lblTrafficTitle.Text = "Κίνηση Διαδρομής:";
            // 
            // lblTrafficVal
            // 
            lblTrafficVal.AutoSize = true;
            lblTrafficVal.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblTrafficVal.ForeColor = Color.ForestGreen;
            lblTrafficVal.Location = new Point(660, 235);
            lblTrafficVal.Name = "lblTrafficVal";
            lblTrafficVal.Size = new Size(130, 25);
            lblTrafficVal.TabIndex = 6;
            lblTrafficVal.Text = "Ομαλή ροή";
            // 
            // btnNextStop
            // 
            btnNextStop.BackColor = Color.MidnightBlue;
            btnNextStop.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btnNextStop.ForeColor = Color.White;
            btnNextStop.Location = new Point(660, 300);
            btnNextStop.Name = "btnNextStop";
            btnNextStop.Size = new Size(260, 45);
            btnNextStop.TabIndex = 7;
            btnNextStop.Text = "Επόμενη Στάση ➡️";
            btnNextStop.UseVisualStyleBackColor = false;
            btnNextStop.Click += btnNextStop_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkSlateGray;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(660, 360);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(260, 45);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Τυχαία Ανανέωση / Κίνηση";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(12, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 45);
            btnBack.TabIndex = 9;
            btnBack.Text = "Επιστροφή στον πίνακα";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ScheduleAndStops
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnNextStop);
            Controls.Add(lblTrafficVal);
            Controls.Add(lblTrafficTitle);
            Controls.Add(lblCurrentStopVal);
            Controls.Add(lblCurrentStopTitle);
            Controls.Add(dgvStops);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "ScheduleAndStops";
            Text = "Προγραμματισμός και Στάσεις - MagicBus";
            Load += ScheduleAndStops_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStops).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private DataGridView dgvStops;
        private Label lblCurrentStopTitle;
        private Label lblCurrentStopVal;
        private Label lblTrafficTitle;
        private Label lblTrafficVal;
        private Button btnNextStop;
        private Button btnRefresh;
        private Button btnBack;
    }
}