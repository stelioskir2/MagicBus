namespace MagicBus
{
    partial class Attractions
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
            lstAttractions = new ListBox();
            btnDetails = new Button();
            btnBack = new Button();
            btnHelp = new Button();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font(
                "Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(842, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Αξιοθέατα της Θεσσαλονίκης";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lstAttractions
            lstAttractions.Font = new Font("Segoe UI", 13.8F);
            lstAttractions.FormattingEnabled = true;
            lstAttractions.IntegralHeight = false;
            lstAttractions.Items.AddRange(new object[]
            {
                "Λευκός Πύργος",
                "Πλατεία Αριστοτέλους",
                "Άγιος Δημήτριος",
                "Ροτόντα",
                "Καμάρα"
            });
            lstAttractions.Location = new Point(130, 160);
            lstAttractions.Name = "lstAttractions";
            lstAttractions.Size = new Size(360, 300);
            lstAttractions.TabIndex = 1;

            // btnDetails
            btnDetails.BackColor = Color.MidnightBlue;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnDetails.ForeColor = Color.White;
            btnDetails.Location = new Point(532, 260);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(320, 90);
            btnDetails.TabIndex = 2;
            btnDetails.Text = "Πληροφορίες\nαξιοθέατου";
            btnDetails.UseMnemonic = false;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += button1_Click;

            // btnBack
            btnBack.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(30, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 50);
            btnBack.TabIndex = 3;
            btnBack.Text = "Επιστροφή στο μενού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

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
            btnHelp.TabIndex = 4;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;

            // Attractions
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnHelp);
            Controls.Add(btnBack);
            Controls.Add(btnDetails);
            Controls.Add(lstAttractions);
            Controls.Add(lblTitle);
            Name = "Attractions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Αξιοθέατα";
            Load += Attractions_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private ListBox lstAttractions;
        private Button btnDetails;
        private Button btnBack;
        private Button btnHelp;
    }
}