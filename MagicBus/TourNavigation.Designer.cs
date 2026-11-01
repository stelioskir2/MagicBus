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
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblCategory.Location = new Point(30, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(342, 31);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Επιλέξτε κατηγορία προορισμού";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Αξιοθέατα", "Εστιατόρια (ενδεικτικά)", "Στάσεις λεωφορείου" });
            cmbCategory.Location = new Point(30, 140);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(350, 39);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(352, 46);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Πού θέλετε να πάτε;";
            // 
            // lstDestinations
            // 
            lstDestinations.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstDestinations.FormattingEnabled = true;
            lstDestinations.Location = new Point(30, 210);
            lstDestinations.Name = "lstDestinations";
            lstDestinations.Size = new Size(350, 221);
            lstDestinations.TabIndex = 3;
            lstDestinations.SelectedIndexChanged += lstDestinations_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(220, 50);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή στο μενού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNavigate
            // 
            btnNavigate.Location = new Point(420, 400);
            btnNavigate.Name = "btnNavigate";
            btnNavigate.Size = new Size(300, 60);
            btnNavigate.TabIndex = 5;
            btnNavigate.Text = "Έναρξη πλοήγησης";
            btnNavigate.UseVisualStyleBackColor = true;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblStart.Location = new Point(420, 210);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(275, 31);
            lblStart.TabIndex = 6;
            lblStart.Text = "Από ποια στάση ξεκινάτε;";
            // 
            // cmbStart
            // 
            cmbStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbStart.FormattingEnabled = true;
            cmbStart.Items.AddRange(new object[] { "Λευκός Πύργος", "Πλατεία Αριστοτέλους", "Πλατεία Ελευθερίας", "Άγιος Δημήτριος", "Ροτόντα", "Καμάρα" });
            cmbStart.Location = new Point(420, 250);
            cmbStart.Name = "cmbStart";
            cmbStart.Size = new Size(450, 39);
            cmbStart.TabIndex = 7;
            cmbStart.SelectedIndexChanged += cmbStart_SelectedIndexChanged;
            // 
            // TourNavigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(cmbStart);
            Controls.Add(lblStart);
            Controls.Add(btnNavigate);
            Controls.Add(btnBack);
            Controls.Add(lstDestinations);
            Controls.Add(lblTitle);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
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
    }
}