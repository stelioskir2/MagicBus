namespace MagicBus
{
    partial class CafeSelection
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
            lstCafes = new ListBox();
            lblCafeInfo = new Label();
            btnMenu = new Button();
            btnBack = new Button();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(26, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(378, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Συνεργαζόμενες καφετέριες";
            // 
            // lstCafes
            // 
            lstCafes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstCafes.FormattingEnabled = true;
            lstCafes.Items.AddRange(new object[] { "Καφέ Λευκός Πύργος", "Αριστοτέλους Coffee", "Bougatsa Ροτόντα" });
            lstCafes.Location = new Point(26, 82);
            lstCafes.Margin = new Padding(3, 2, 3, 2);
            lstCafes.Name = "lstCafes";
            lstCafes.Size = new Size(307, 204);
            lstCafes.TabIndex = 1;
            lstCafes.SelectedIndexChanged += lstCafes_SelectedIndexChanged;
            // 
            // lblCafeInfo
            // 
            lblCafeInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblCafeInfo.ForeColor = Color.MidnightBlue;
            lblCafeInfo.Location = new Point(368, 82);
            lblCafeInfo.Name = "lblCafeInfo";
            lblCafeInfo.Size = new Size(455, 120);
            lblCafeInfo.TabIndex = 2;
            lblCafeInfo.Text = "Επιλέξτε μια καφετέρια από τη λίστα";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.MidnightBlue;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(368, 225);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(262, 45);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Δείτε τον κατάλογο";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
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
            btnHelp.TabIndex = 5;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // CafeSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(859, 452);
            Controls.Add(btnHelp);
            Controls.Add(btnBack);
            Controls.Add(btnMenu);
            Controls.Add(lblCafeInfo);
            Controls.Add(lstCafes);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CafeSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Επιλογή καφετέριας";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstCafes;
        private Label lblCafeInfo;
        private Button btnMenu;
        private Button btnBack;
        private Button btnHelp;
    }
}