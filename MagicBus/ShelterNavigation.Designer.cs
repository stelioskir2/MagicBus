namespace MagicBus
{
    partial class ShelterNavigation
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
            lblStart = new Label();
            cmbStart = new ComboBox();
            lblShelters = new Label();
            lstShelters = new ListBox();
            btnNavigate = new Button();
            btnBack = new Button();
            lblSimulation = new Label();
            picRoute = new PictureBox();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)picRoute).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(49, 39);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(473, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Προστασία από κακοκαιρία";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblStart.Location = new Point(30, 110);
            lblStart.Margin = new Padding(5, 0, 5, 0);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(271, 31);
            lblStart.TabIndex = 1;
            lblStart.Text = "Σε ποια στάση βρίσκεστε;";
            // 
            // cmbStart
            // 
            cmbStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStart.FormattingEnabled = true;
            cmbStart.Items.AddRange(new object[] { "Λευκός Πύργος", "Πλατεία Αριστοτέλους", "Πλατεία Ελευθερίας", "Άγιος Δημήτριος", "Ροτόντα", "Καμάρα" });
            cmbStart.Location = new Point(30, 150);
            cmbStart.Margin = new Padding(5);
            cmbStart.Name = "cmbStart";
            cmbStart.Size = new Size(350, 39);
            cmbStart.TabIndex = 2;
            cmbStart.SelectedIndexChanged += cmbStart_SelectedIndexChanged;
            // 
            // lblShelters
            // 
            lblShelters.AutoSize = true;
            lblShelters.Location = new Point(30, 220);
            lblShelters.Name = "lblShelters";
            lblShelters.Size = new Size(320, 31);
            lblShelters.TabIndex = 3;
            lblShelters.Text = "Διαθέσιμοι χώροι προστασίας";
            // 
            // lstShelters
            // 
            lstShelters.FormattingEnabled = true;
            lstShelters.Location = new Point(30, 260);
            lstShelters.Name = "lstShelters";
            lstShelters.Size = new Size(400, 190);
            lstShelters.TabIndex = 4;
            // 
            // btnNavigate
            // 
            btnNavigate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnNavigate.Location = new Point(470, 260);
            btnNavigate.Name = "btnNavigate";
            btnNavigate.Size = new Size(300, 60);
            btnNavigate.TabIndex = 5;
            btnNavigate.Text = "Πλοήγηση στον χώρο";
            btnNavigate.UseVisualStyleBackColor = true;
            btnNavigate.Click += btnNavigate_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(220, 50);
            btnBack.TabIndex = 6;
            btnBack.Text = "Επιστροφή στο μενού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblSimulation
            // 
            lblSimulation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblSimulation.Location = new Point(470, 340);
            lblSimulation.Name = "lblSimulation";
            lblSimulation.Size = new Size(450, 80);
            lblSimulation.TabIndex = 7;
            lblSimulation.Text = "Εκπαιδευτική προσομοίωση — οι χώροι είναι φανταστικοί.";
            // 
            // picRoute
            // 
            picRoute.BackColor = Color.White;
            picRoute.BorderStyle = BorderStyle.FixedSingle;
            picRoute.Location = new Point(470, 420);
            picRoute.Name = "picRoute";
            picRoute.Size = new Size(450, 100);
            picRoute.TabIndex = 8;
            picRoute.TabStop = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.MidnightBlue;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(900, 39);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(50, 50);
            btnHelp.TabIndex = 9;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // ShelterNavigation
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnHelp);
            Controls.Add(picRoute);
            Controls.Add(lblSimulation);
            Controls.Add(btnBack);
            Controls.Add(btnNavigate);
            Controls.Add(lstShelters);
            Controls.Add(lblShelters);
            Controls.Add(cmbStart);
            Controls.Add(lblStart);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Margin = new Padding(5);
            Name = "ShelterNavigation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Προστασία από κακοκαιρία";
            ((System.ComponentModel.ISupportInitialize)picRoute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStart;
        private ComboBox cmbStart;
        private Label lblShelters;
        private ListBox lstShelters;
        private Button btnNavigate;
        private Button btnBack;
        private Label lblSimulation;
        private PictureBox picRoute;
        private Button btnHelp;
    }
}