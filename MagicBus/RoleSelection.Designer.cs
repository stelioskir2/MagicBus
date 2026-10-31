namespace MagicBus
{
    partial class RoleSelection
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
            label1 = new Label();
            btnPassenger = new Button();
            btnBack = new Button();
            btnStaffLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(320, 156);
            label1.Name = "label1";
            label1.Size = new Size(309, 37);
            label1.TabIndex = 0;
            label1.Text = "Επιλέξτε Ρόλο Χρήστη";
            // 
            // btnPassenger
            // 
            btnPassenger.BackColor = Color.MidnightBlue;
            btnPassenger.FlatStyle = FlatStyle.Flat;
            btnPassenger.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPassenger.ForeColor = Color.White;
            btnPassenger.Location = new Point(334, 238);
            btnPassenger.Name = "btnPassenger";
            btnPassenger.Size = new Size(280, 80);
            btnPassenger.TabIndex = 1;
            btnPassenger.Text = "Επιβάτης";
            btnPassenger.UseVisualStyleBackColor = false;
            btnPassenger.Click += btnPassenger_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(12, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 45);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή στην αρχική";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnStaffLogin
            // 
            btnStaffLogin.BackColor = SystemColors.Control;
            btnStaffLogin.Font = new Font("Segoe UI", 10F);
            btnStaffLogin.ForeColor = Color.Black;
            btnStaffLogin.Location = new Point(782, 521);
            btnStaffLogin.Name = "btnStaffLogin";
            btnStaffLogin.Size = new Size(190, 45);
            btnStaffLogin.TabIndex = 5;
            btnStaffLogin.Text = "Είσοδος Προσωπικού";
            btnStaffLogin.UseVisualStyleBackColor = true;
            btnStaffLogin.Click += btnStaffLogin_Click;
            // 
            // RoleSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnStaffLogin);
            Controls.Add(btnBack);
            Controls.Add(btnPassenger);
            Controls.Add(label1);
            Name = "RoleSelection";
            Text = "Επιλογή Ρόλου";
            Load += RoleSelection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPassenger;
        private Button btnBack;
        private Button btnStaffLogin;
    }
}