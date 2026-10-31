namespace MagicBus
{
    partial class StaffLogin
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
            labelTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            rbDriver = new RadioButton();
            rbEmployee = new RadioButton();
            btnLogin = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.MidnightBlue;
            labelTitle.Location = new Point(250, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(299, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Είσοδος Προσωπικού";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F);
            lblUsername.Location = new Point(220, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(115, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Όνομα Χρήστη:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.Location = new Point(250, 160);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Κωδικός:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(350, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(350, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 4;
            // 
            // rbDriver
            // 
            rbDriver.AutoSize = true;
            rbDriver.Font = new Font("Segoe UI", 11F);
            rbDriver.Location = new Point(350, 220);
            rbDriver.Name = "rbDriver";
            rbDriver.Size = new Size(80, 24);
            rbDriver.TabIndex = 5;
            rbDriver.TabStop = true;
            rbDriver.Text = "Οδηγός";
            rbDriver.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            rbEmployee.AutoSize = true;
            rbEmployee.Font = new Font("Segoe UI", 11F);
            rbEmployee.Location = new Point(470, 220);
            rbEmployee.Name = "rbEmployee";
            rbEmployee.Size = new Size(99, 24);
            rbEmployee.TabIndex = 6;
            rbEmployee.TabStop = true;
            rbEmployee.Text = "Υπάλληλος";
            rbEmployee.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(350, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Είσοδος";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 370);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 49);
            btnBack.TabIndex = 8;
            btnBack.Text = "Έπιστροφή στην Επιλογή Ρόλου";
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // StaffLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(rbEmployee);
            Controls.Add(rbDriver);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(labelTitle);
            Name = "StaffLogin";
            Text = "Είσοδος Προσωπικού - MagicBus";
            Load += StaffLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private RadioButton rbDriver;
        private RadioButton rbEmployee;
        private Button btnLogin;
        private Button btnBack;
    }
}