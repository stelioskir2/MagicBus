namespace MagicBus
{
    partial class EmployeeDashboard
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
            btnPassengers = new Button();
            btnBusStatus = new Button();
            btnSchedule = new Button();
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPassengers
            // 
            btnPassengers.BackColor = Color.MidnightBlue;
            btnPassengers.FlatStyle = FlatStyle.Flat;
            btnPassengers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPassengers.ForeColor = Color.White;
            btnPassengers.Location = new Point(352, 133);
            btnPassengers.Name = "btnPassengers";
            btnPassengers.Size = new Size(280, 80);
            btnPassengers.TabIndex = 0;
            btnPassengers.Text = "Διαχείριση Επιβατών";
            btnPassengers.UseVisualStyleBackColor = false;
            btnPassengers.Click += btnPassengers_Click;
            // 
            // btnBusStatus
            // 
            btnBusStatus.BackColor = Color.MidnightBlue;
            btnBusStatus.FlatStyle = FlatStyle.Flat;
            btnBusStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnBusStatus.ForeColor = Color.White;
            btnBusStatus.Location = new Point(352, 240);
            btnBusStatus.Name = "btnBusStatus";
            btnBusStatus.Size = new Size(280, 80);
            btnBusStatus.TabIndex = 1;
            btnBusStatus.Text = "Κατάσταση Λεωφορείου";
            btnBusStatus.UseVisualStyleBackColor = false;
            btnBusStatus.Click += btnBusStatus_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.MidnightBlue;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(352, 347);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(280, 80);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Προγραμματισμός και Στάσεις";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(12, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 52);
            btnBack.TabIndex = 3;
            btnBack.Text = "Επιστροφή στην επιλογή ρόλου";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(285, 69);
            label1.Name = "label1";
            label1.Size = new Size(414, 37);
            label1.TabIndex = 4;
            label1.Text = "Πίνακας Ελέγχου Προσωπικού";
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSchedule);
            Controls.Add(btnBusStatus);
            Controls.Add(btnPassengers);
            Name = "EmployeeDashboard";
            Text = "MagicBus - Πίνακας Ελέγχου Προσωπικού";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnPassengers;
        private System.Windows.Forms.Button btnBusStatus;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}