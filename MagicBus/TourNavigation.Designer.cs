namespace MagicBus
{
    partial class TourNavigation
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
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblTitle = new Label();
            lstDestinations = new ListBox();
            btnBack = new Button();
            btnNavigate = new Button();
            lblStart = new Label();
            cmbStart = new ComboBox();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblCategory.Location = new Point(26, 75);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(287, 25);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Επιλέξτε κατηγορία προορισμού";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Αξιοθέατα", "Εστιατόρια (ενδεικτικά)", "Στάσεις λεωφορείου" });
            cmbCategory.Location = new Point(26, 105);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(307, 33);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(26, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(282, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Πού θέλετε να πάτε;";
            // 
            // lstDestinations
            // 
            lstDestinations.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstDestinations.FormattingEnabled = true;
            lstDestinations.Location = new Point(26, 158);
            lstDestinations.Margin = new Padding(3, 2, 3, 2);
            lstDestinations.Name = "lstDestinations";
            lstDestinations.Size = new Size(307, 154);
            lstDestinations.TabIndex = 3;
            lstDestinations.SelectedIndexChanged += lstDestinations_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(26, 398);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 38);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή στο μενού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNavigate
            // 
            btnNavigate.Location = new Point(368, 300);
            btnNavigate.Margin = new Padding(3, 2, 3, 2);
            btnNavigate.Name = "btnNavigate";
            btnNavigate.Size = new Size(262, 45);
            btnNavigate.TabIndex = 5;
            btnNavigate.Text = "Έναρξη πλοήγησης";
            btnNavigate.UseVisualStyleBackColor = true;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblStart.Location = new Point(368, 158);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(230, 25);
            lblStart.TabIndex = 6;
            lblStart.Text = "Από ποια στάση ξεκινάτε;";
            // 
            // cmbStart
            // 
            cmbStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbStart.FormattingEnabled = true;
            cmbStart.Items.AddRange(new object[] { "Λευκός Πύργος", "Πλατεία Αριστοτέλους", "Πλατεία Ελευθερίας", "Άγιος Δημήτριος", "Ροτόντα", "Καμάρα" });
            cmbStart.Location = new Point(368, 188);
            cmbStart.Margin = new Padding(3, 2, 3, 2);
            cmbStart.Name = "cmbStart";
            cmbStart.Size = new Size(394, 33);
            cmbStart.TabIndex = 7;
            cmbStart.SelectedIndexChanged += cmbStart_SelectedIndexChanged;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.MidnightBlue;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(788, 19);
            btnHelp.Margin = new Padding(3, 2, 3, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(44, 38);
            btnHelp.TabIndex = 8;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // TourNavigation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(859, 452);
            Controls.Add(btnHelp);
            Controls.Add(cmbStart);
            Controls.Add(lblStart);
            Controls.Add(btnNavigate);
            Controls.Add(btnBack);
            Controls.Add(lstDestinations);
            Controls.Add(lblTitle);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TourNavigation";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Τουριστική πλοήγηση";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblTitle;
        private ListBox lstDestinations;
        private Button btnBack;
        private Button btnNavigate;
        private Label lblStart;
        private ComboBox cmbStart;
        private Button btnHelp;
    }
}