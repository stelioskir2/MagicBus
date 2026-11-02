namespace MagicBus
{
    partial class ShelterNavigation
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
            lblStart = new Label();
            cmbStart = new ComboBox();
            lblShelters = new Label();
            lstShelters = new ListBox();
            btnNavigate = new Button();
            btnBack = new Button();
            lblSimulation = new Label();
            picRoute = new PictureBox();
            lblRouteDetails = new Label();
            btnHelp = new Button();

            ((System.ComponentModel.ISupportInitialize)picRoute).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font(
                "Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(842, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Προστασία από κακοκαιρία";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblStart
            lblStart.AutoSize = false;
            lblStart.Font = new Font("Segoe UI", 13.8F);
            lblStart.Location = new Point(30, 140);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(400, 40);
            lblStart.TabIndex = 1;
            lblStart.Text = "Σε ποια στάση βρίσκεστε;";
            lblStart.TextAlign = ContentAlignment.MiddleLeft;

            // cmbStart
            cmbStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStart.Font = new Font("Segoe UI", 13.8F);
            cmbStart.FormattingEnabled = true;
            cmbStart.Items.AddRange(new object[]
            {
                "Λευκός Πύργος",
                "Πλατεία Αριστοτέλους",
                "Πλατεία Ελευθερίας",
                "Άγιος Δημήτριος",
                "Ροτόντα",
                "Καμάρα"
            });
            cmbStart.Location = new Point(30, 190);
            cmbStart.Name = "cmbStart";
            cmbStart.Size = new Size(400, 39);
            cmbStart.TabIndex = 2;
            cmbStart.SelectedIndexChanged +=
                cmbStart_SelectedIndexChanged;

            // lblShelters
            lblShelters.AutoSize = false;
            lblShelters.Font = new Font("Segoe UI", 12F);
            lblShelters.Location = new Point(30, 245);
            lblShelters.Name = "lblShelters";
            lblShelters.Size = new Size(400, 40);
            lblShelters.TabIndex = 3;
            lblShelters.Text = "Διαθέσιμοι χώροι προστασίας";
            lblShelters.TextAlign = ContentAlignment.MiddleLeft;

            // lstShelters
            lstShelters.Font = new Font("Segoe UI", 12F);
            lstShelters.FormattingEnabled = true;
            lstShelters.IntegralHeight = false;
            lstShelters.Location = new Point(30, 290);
            lstShelters.Name = "lstShelters";
            lstShelters.Size = new Size(400, 200);
            lstShelters.TabIndex = 4;

            // btnNavigate
            btnNavigate.BackColor = Color.MidnightBlue;
            btnNavigate.FlatStyle = FlatStyle.Flat;
            btnNavigate.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnNavigate.ForeColor = Color.White;
            btnNavigate.Location = new Point(470, 150);
            btnNavigate.Name = "btnNavigate";
            btnNavigate.Size = new Size(320, 60);
            btnNavigate.TabIndex = 5;
            btnNavigate.Text = "Πλοήγηση στον χώρο";
            btnNavigate.UseVisualStyleBackColor = false;
            btnNavigate.Click += btnNavigate_Click;

            // btnBack
            btnBack.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(30, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 50);
            btnBack.TabIndex = 6;
            btnBack.Text = "Επιστροφή στο μενού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // lblSimulation
            lblSimulation.AutoSize = false;
            lblSimulation.Font = new Font("Segoe UI", 12F);
            lblSimulation.Location = new Point(470, 230);
            lblSimulation.Name = "lblSimulation";
            lblSimulation.Size = new Size(450, 60);
            lblSimulation.TabIndex = 7;
            lblSimulation.Text =
                "Εκπαιδευτική προσομοίωση — οι χώροι είναι φανταστικοί.";

            // picRoute
            picRoute.BackColor = Color.White;
            picRoute.BorderStyle = BorderStyle.FixedSingle;
            picRoute.Location = new Point(470, 300);
            picRoute.Name = "picRoute";
            picRoute.Size = new Size(450, 100);
            picRoute.TabIndex = 8;
            picRoute.TabStop = false;

            // lblRouteDetails
            lblRouteDetails.AutoSize = false;
            lblRouteDetails.Font = new Font("Segoe UI", 12F);
            lblRouteDetails.Location = new Point(470, 415);
            lblRouteDetails.Name = "lblRouteDetails";
            lblRouteDetails.Size = new Size(450, 150);
            lblRouteDetails.TabIndex = 9;
            lblRouteDetails.Text =
                "Επιλέξτε στάση και χώρο προστασίας.";
            lblRouteDetails.TextAlign = ContentAlignment.TopLeft;

            // btnHelp
            btnHelp.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
            btnHelp.BackColor = Color.MidnightBlue;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(902, 25);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(50, 50);
            btnHelp.TabIndex = 10;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;

            // ShelterNavigation
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnHelp);
            Controls.Add(lblRouteDetails);
            Controls.Add(picRoute);
            Controls.Add(lblSimulation);
            Controls.Add(btnBack);
            Controls.Add(btnNavigate);
            Controls.Add(lstShelters);
            Controls.Add(lblShelters);
            Controls.Add(cmbStart);
            Controls.Add(lblStart);
            Controls.Add(lblTitle);
            Name = "ShelterNavigation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Προστασία από κακοκαιρία";

            ((System.ComponentModel.ISupportInitialize)picRoute).EndInit();
            ResumeLayout(false);
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
        private Label lblRouteDetails;
        private Button btnHelp;
    }
}