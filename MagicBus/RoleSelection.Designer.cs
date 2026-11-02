namespace MagicBus
{
    partial class RoleSelection
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
            label1 = new Label();
            btnPassenger = new Button();
            btnDriver = new Button();
            btnEmployee = new Button();
            btnBack = new Button();
            SuspendLayout();

            // label1
            label1.AutoSize = false;
            label1.Font = new Font(
                "Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(922, 70);
            label1.TabIndex = 0;
            label1.Text = "Επιλέξτε Ρόλο Χρήστη";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;

            // btnPassenger
            btnPassenger.BackColor = Color.MidnightBlue;
            btnPassenger.FlatStyle = FlatStyle.Flat;
            btnPassenger.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnPassenger.ForeColor = Color.White;
            btnPassenger.Location = new Point(331, 150);
            btnPassenger.Margin = new Padding(3, 4, 3, 4);
            btnPassenger.Name = "btnPassenger";
            btnPassenger.Size = new Size(320, 90);
            btnPassenger.TabIndex = 1;
            btnPassenger.Text = "Επιβάτης";
            btnPassenger.UseVisualStyleBackColor = false;
            btnPassenger.Click += btnPassenger_Click_1;

            // btnDriver
            btnDriver.BackColor = Color.MidnightBlue;
            btnDriver.FlatStyle = FlatStyle.Flat;
            btnDriver.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnDriver.ForeColor = Color.White;
            btnDriver.Location = new Point(331, 265);
            btnDriver.Margin = new Padding(3, 4, 3, 4);
            btnDriver.Name = "btnDriver";
            btnDriver.Size = new Size(320, 90);
            btnDriver.TabIndex = 2;
            btnDriver.Text = "Οδηγός";
            btnDriver.UseVisualStyleBackColor = false;
            btnDriver.Click += btnDriver_Click;

            // btnEmployee
            btnEmployee.BackColor = Color.MidnightBlue;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(331, 380);
            btnEmployee.Margin = new Padding(3, 4, 3, 4);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(320, 90);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "Υπάλληλος / Προσωπικό";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click_1;

            // btnBack
            btnBack.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 525);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 50);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή στην αρχική";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // RoleSelection
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(btnEmployee);
            Controls.Add(btnDriver);
            Controls.Add(btnPassenger);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RoleSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Επιλογή Ρόλου";
            Load += RoleSelection_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnPassenger;
        private Button btnDriver;
        private Button btnEmployee;
        private Button btnBack;
    }
}