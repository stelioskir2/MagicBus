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
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(456, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Συνεργαζόμενες καφετέριες";
            // 
            // lstCafes
            // 
            lstCafes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstCafes.FormattingEnabled = true;
            lstCafes.Items.AddRange(new object[] { "Καφέ Λευκός Πύργος", "Αριστοτέλους Coffee", "Bougatsa Ροτόντα" });
            lstCafes.Location = new Point(30, 110);
            lstCafes.Name = "lstCafes";
            lstCafes.Size = new Size(350, 283);
            lstCafes.TabIndex = 1;
            lstCafes.SelectedIndexChanged += lstCafes_SelectedIndexChanged;
            // 
            // lblCafeInfo
            // 
            lblCafeInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblCafeInfo.ForeColor = Color.MidnightBlue;
            lblCafeInfo.Location = new Point(420, 110);
            lblCafeInfo.Name = "lblCafeInfo";
            lblCafeInfo.Size = new Size(520, 160);
            lblCafeInfo.TabIndex = 2;
            lblCafeInfo.Text = "Επιλέξτε μια καφετέρια από τη λίστα";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.MidnightBlue;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(420, 300);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(300, 60);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Δείτε τον κατάλογο";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(220, 50);
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
            btnHelp.Location = new Point(900, 25);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(50, 50);
            btnHelp.TabIndex = 5;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // CafeSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnHelp);
            Controls.Add(btnBack);
            Controls.Add(btnMenu);
            Controls.Add(lblCafeInfo);
            Controls.Add(lstCafes);
            Controls.Add(lblTitle);
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