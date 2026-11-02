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

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(922, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ΘΕΣΣΑΛΟΝΙΚΗ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblSubtitle
            lblSubtitle.AutoSize = false;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.DarkSlateGray;
            lblSubtitle.Location = new Point(30, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(922, 40);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text =
                "MagicBus / 6 στάσεις για να γνωρίσετε την πόλη";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            // dgvStops
            dgvStops.AllowUserToAddRows = false;
            dgvStops.AllowUserToDeleteRows = false;
            dgvStops.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvStops.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dgvStops.BackgroundColor = Color.White;
            dgvStops.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStops.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dgvStops.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dgvStops.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvStops.Location = new Point(30, 145);
            dgvStops.MultiSelect = false;
            dgvStops.Name = "dgvStops";
            dgvStops.ReadOnly = true;
            dgvStops.RowHeadersVisible = false;
            dgvStops.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvStops.Size = new Size(600, 350);
            dgvStops.TabIndex = 2;

            // lblCurrentStopTitle
            lblCurrentStopTitle.AutoSize = false;
            lblCurrentStopTitle.Font = new System.Drawing.Font(
                "Segoe UI", 14F, FontStyle.Bold);
            lblCurrentStopTitle.ForeColor = Color.DarkSlateGray;
            lblCurrentStopTitle.Location = new Point(660, 145);
            lblCurrentStopTitle.Name = "lblCurrentStopTitle";
            lblCurrentStopTitle.Size = new Size(292, 40);
            lblCurrentStopTitle.TabIndex = 3;
            lblCurrentStopTitle.Text = "Τρέχουσα Στάση:";
            lblCurrentStopTitle.TextAlign =
                ContentAlignment.MiddleLeft;

            // lblCurrentStopVal
            lblCurrentStopVal.AutoSize = false;
            lblCurrentStopVal.Font = new System.Drawing.Font(
                "Segoe UI", 14F, FontStyle.Bold);
            lblCurrentStopVal.ForeColor = Color.MidnightBlue;
            lblCurrentStopVal.Location = new Point(660, 190);
            lblCurrentStopVal.Name = "lblCurrentStopVal";
            lblCurrentStopVal.Size = new Size(292, 80);
            lblCurrentStopVal.TabIndex = 4;
            lblCurrentStopVal.Text = "1. Λευκός Πύργος";
            lblCurrentStopVal.TextAlign = ContentAlignment.TopLeft;

            // lblTrafficTitle
            lblTrafficTitle.AutoSize = false;
            lblTrafficTitle.Font = new System.Drawing.Font(
                "Segoe UI", 14F, FontStyle.Bold);
            lblTrafficTitle.ForeColor = Color.DarkSlateGray;
            lblTrafficTitle.Location = new Point(660, 275);
            lblTrafficTitle.Name = "lblTrafficTitle";
            lblTrafficTitle.Size = new Size(292, 40);
            lblTrafficTitle.TabIndex = 5;
            lblTrafficTitle.Text = "Κίνηση Διαδρομής:";
            lblTrafficTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblTrafficVal
            lblTrafficVal.AutoSize = false;
            lblTrafficVal.Font = new System.Drawing.Font(
                "Segoe UI", 12F);
            lblTrafficVal.ForeColor = Color.ForestGreen;
            lblTrafficVal.Location = new Point(660, 320);
            lblTrafficVal.Name = "lblTrafficVal";
            lblTrafficVal.Size = new Size(292, 65);
            lblTrafficVal.TabIndex = 6;
            lblTrafficVal.Text = "Ομαλή ροή";
            lblTrafficVal.TextAlign = ContentAlignment.TopLeft;

            // btnNextStop
            btnNextStop.BackColor = Color.MidnightBlue;
            btnNextStop.FlatStyle = FlatStyle.Flat;
            btnNextStop.Font = new System.Drawing.Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnNextStop.ForeColor = Color.White;
            btnNextStop.Location = new Point(660, 390);
            btnNextStop.Name = "btnNextStop";
            btnNextStop.Size = new Size(292, 50);
            btnNextStop.TabIndex = 7;
            btnNextStop.Text = "Επόμενη Στάση ➡";
            btnNextStop.UseVisualStyleBackColor = false;
            btnNextStop.Click += btnNextStop_Click;

            // btnRefresh
            btnRefresh.BackColor = Color.DarkSlateGray;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font(
                "Segoe UI", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(660, 450);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(292, 50);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Τυχαία Ανανέωση / Κίνηση";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;

            // btnBack
            btnBack.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(340, 50);
            btnBack.TabIndex = 9;
            btnBack.Text = "Επιστροφή στον πίνακα προσωπικού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // ScheduleAndStops
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
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
            StartPosition = FormStartPosition.CenterParent;
            Text = "Προγραμματισμός και Στάσεις - MagicBus";
            Load += ScheduleAndStops_Load;

            ((System.ComponentModel.ISupportInitialize)dgvStops).EndInit();
            ResumeLayout(false);
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