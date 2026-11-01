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
            btnRobot = new Button();
            lblFoundItems = new Label();
            btnCafeOrders = new Button();
            btnCompanyNotifications = new Button();
            SuspendLayout();
            // 
            // btnPassengers
            // 
            btnPassengers.BackColor = Color.MidnightBlue;
            btnPassengers.FlatStyle = FlatStyle.Flat;
            btnPassengers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnPassengers.ForeColor = Color.White;
            btnPassengers.Location = new Point(222, 215);
            btnPassengers.Margin = new Padding(3, 4, 3, 4);
            btnPassengers.Name = "btnPassengers";
            btnPassengers.Size = new Size(320, 107);
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
            btnBusStatus.Location = new Point(582, 215);
            btnBusStatus.Margin = new Padding(3, 4, 3, 4);
            btnBusStatus.Name = "btnBusStatus";
            btnBusStatus.Size = new Size(320, 107);
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
            btnSchedule.Location = new Point(222, 360);
            btnSchedule.Margin = new Padding(3, 4, 3, 4);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(320, 107);
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
            btnBack.Location = new Point(14, 695);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(217, 69);
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
            label1.Location = new Point(304, 110);
            label1.Name = "label1";
            label1.Size = new Size(516, 46);
            label1.TabIndex = 4;
            label1.Text = "Πίνακας Ελέγχου Προσωπικού";
            // 
            // btnRobot
            // 
            btnRobot.BackColor = Color.MidnightBlue;
            btnRobot.FlatStyle = FlatStyle.Flat;
            btnRobot.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnRobot.ForeColor = Color.White;
            btnRobot.Location = new Point(582, 360);
            btnRobot.Name = "btnRobot";
            btnRobot.Size = new Size(320, 107);
            btnRobot.TabIndex = 5;
            btnRobot.Text = "Ρομπότ καθαρισμού";
            btnRobot.UseVisualStyleBackColor = false;
            btnRobot.Click += btnRobot_Click;
            // 
            // lblFoundItems
            // 
            lblFoundItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblFoundItems.ForeColor = Color.MidnightBlue;
            lblFoundItems.Location = new Point(920, 360);
            lblFoundItems.Name = "lblFoundItems";
            lblFoundItems.Size = new Size(190, 140);
            lblFoundItems.TabIndex = 7;
            lblFoundItems.Text = "Σημερινά ευρήματα: 0";
            // 
            // btnCafeOrders
            // 
            btnCafeOrders.BackColor = Color.MidnightBlue;
            btnCafeOrders.FlatStyle = FlatStyle.Flat;
            btnCafeOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCafeOrders.ForeColor = Color.White;
            btnCafeOrders.Location = new Point(402, 505);
            btnCafeOrders.Margin = new Padding(3, 4, 3, 4);
            btnCafeOrders.Name = "btnCafeOrders";
            btnCafeOrders.Size = new Size(320, 107);
            btnCafeOrders.TabIndex = 6;
            btnCafeOrders.Text = "Παραγγελίες Καφετέριας";
            btnCafeOrders.UseVisualStyleBackColor = false;
            btnCafeOrders.Click += btnCafeOrders_Click;
            // 
            // btnCompanyNotifications
            // 
            btnCompanyNotifications.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnCompanyNotifications.ForeColor = Color.MidnightBlue;
            btnCompanyNotifications.Location = new Point(14, 600);
            btnCompanyNotifications.Name = "btnCompanyNotifications";
            btnCompanyNotifications.Size = new Size(300, 70);
            btnCompanyNotifications.TabIndex = 8;
            btnCompanyNotifications.Text = "Ενημέρωση εταιρείας";
            btnCompanyNotifications.UseVisualStyleBackColor = true;
            btnCompanyNotifications.Click += btnCompanyNotifications_Click;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 815);
            Controls.Add(btnCompanyNotifications);
            Controls.Add(lblFoundItems);
            Controls.Add(btnCafeOrders);
            Controls.Add(btnRobot);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSchedule);
            Controls.Add(btnBusStatus);
            Controls.Add(btnPassengers);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnRobot;
        private Label lblFoundItems;
        private Button btnCafeOrders;
        private Button btnCompanyNotifications;
    }
}