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
            btnDriver = new Button();
            btnEmployee = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(224, 31);
            label1.Name = "label1";
            label1.Size = new Size(309, 37);
            label1.TabIndex = 0;
            label1.Text = "Επιλέξτε Ρόλο Χρήστη";
            label1.Click += label1_Click;
            // 
            // btnPassenger
            // 
            btnPassenger.BackColor = Color.MidnightBlue;
            btnPassenger.FlatStyle = FlatStyle.Flat;
            btnPassenger.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPassenger.ForeColor = Color.White;
            btnPassenger.Location = new Point(238, 84);
            btnPassenger.Name = "btnPassenger";
            btnPassenger.Size = new Size(280, 80);
            btnPassenger.TabIndex = 1;
            btnPassenger.Text = "Επιβάτης";
            btnPassenger.UseVisualStyleBackColor = false;
            // 
            // btnDriver
            // 
            btnDriver.BackColor = Color.MidnightBlue;
            btnDriver.FlatStyle = FlatStyle.Flat;
            btnDriver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDriver.ForeColor = Color.White;
            btnDriver.Location = new Point(238, 195);
            btnDriver.Name = "btnDriver";
            btnDriver.Size = new Size(280, 80);
            btnDriver.TabIndex = 2;
            btnDriver.Text = "Οδηγός";
            btnDriver.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.MidnightBlue;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(238, 306);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(280, 80);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "Υπάλληλος / Προσωπικό";
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // RoleSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmployee);
            Controls.Add(btnDriver);
            Controls.Add(btnPassenger);
            Controls.Add(label1);
            Name = "RoleSelection";
            Text = "Επιλογή Ρόλου";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPassenger;
        private Button btnDriver;
        private Button btnEmployee;
    }
}