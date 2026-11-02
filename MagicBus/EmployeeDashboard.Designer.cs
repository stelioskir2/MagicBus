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

            // btnPassengers
            btnPassengers.BackColor = Color.MidnightBlue;
            btnPassengers.FlatStyle = FlatStyle.Flat;
            btnPassengers.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPassengers.ForeColor = Color.White;
            btnPassengers.Location = new Point(130, 145);
            btnPassengers.Name = "btnPassengers";
            btnPassengers.Size = new Size(320, 80);
            btnPassengers.TabIndex = 0;
            btnPassengers.Text = "Διαχείριση Επιβατών";
            btnPassengers.UseVisualStyleBackColor = false;
            btnPassengers.Click += btnPassengers_Click;

            // btnBusStatus
            btnBusStatus.BackColor = Color.MidnightBlue;
            btnBusStatus.FlatStyle = FlatStyle.Flat;
            btnBusStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnBusStatus.ForeColor = Color.White;
            btnBusStatus.Location = new Point(532, 145);
            btnBusStatus.Name = "btnBusStatus";
            btnBusStatus.Size = new Size(320, 80);
            btnBusStatus.TabIndex = 1;
            btnBusStatus.Text = "Κατάσταση Λεωφορείου";
            btnBusStatus.UseVisualStyleBackColor = false;
            btnBusStatus.Click += btnBusStatus_Click;

            // btnSchedule
            btnSchedule.BackColor = Color.MidnightBlue;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(130, 245);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(320, 80);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Προγραμματισμός και Στάσεις";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;

            // btnBack
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 50);
            btnBack.TabIndex = 6;
            btnBack.Text = "Επιστροφή στην επιλογή ρόλου";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // label1
            label1.AutoSize = false;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(922, 70);
            label1.TabIndex = 7;
            label1.Text = "Πίνακας Ελέγχου Προσωπικού";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // btnRobot
            btnRobot.BackColor = Color.MidnightBlue;
            btnRobot.FlatStyle = FlatStyle.Flat;
            btnRobot.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRobot.ForeColor = Color.White;
            btnRobot.Location = new Point(532, 245);
            btnRobot.Margin = new Padding(3, 2, 3, 2);
            btnRobot.Name = "btnRobot";
            btnRobot.Size = new Size(320, 80);
            btnRobot.TabIndex = 3;
            btnRobot.Text = "Ρομπότ καθαρισμού";
            btnRobot.UseVisualStyleBackColor = false;
            btnRobot.Click += btnRobot_Click;

            // lblFoundItems
            lblFoundItems.AutoSize = false;
            lblFoundItems.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold,
                GraphicsUnit.Point, 161);
            lblFoundItems.ForeColor = Color.MidnightBlue;
            lblFoundItems.Location = new Point(130, 440);
            lblFoundItems.Name = "lblFoundItems";
            lblFoundItems.Size = new Size(722, 60);
            lblFoundItems.TabIndex = 8;
            lblFoundItems.Text = "Σημερινά ευρήματα: 0";
            lblFoundItems.TextAlign = ContentAlignment.MiddleCenter;

            // btnCafeOrders
            btnCafeOrders.BackColor = Color.MidnightBlue;
            btnCafeOrders.FlatStyle = FlatStyle.Flat;
            btnCafeOrders.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCafeOrders.ForeColor = Color.White;
            btnCafeOrders.Location = new Point(331, 345);
            btnCafeOrders.Name = "btnCafeOrders";
            btnCafeOrders.Size = new Size(320, 80);
            btnCafeOrders.TabIndex = 4;
            btnCafeOrders.Text = "Παραγγελίες Καφετέριας";
            btnCafeOrders.UseVisualStyleBackColor = false;
            btnCafeOrders.Click += btnCafeOrders_Click;

            // btnCompanyNotifications
            btnCompanyNotifications.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Right;
            btnCompanyNotifications.Font = new Font("Segoe UI", 10F);
            btnCompanyNotifications.ForeColor = Color.MidnightBlue;
            btnCompanyNotifications.Location = new Point(672, 525);
            btnCompanyNotifications.Margin = new Padding(3, 2, 3, 2);
            btnCompanyNotifications.Name = "btnCompanyNotifications";
            btnCompanyNotifications.Size = new Size(280, 50);
            btnCompanyNotifications.TabIndex = 5;
            btnCompanyNotifications.Text = "Ενημέρωση εταιρείας";
            btnCompanyNotifications.UseVisualStyleBackColor = true;
            btnCompanyNotifications.Click += btnCompanyNotifications_Click;

            // EmployeeDashboard
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(btnCompanyNotifications);
            Controls.Add(lblFoundItems);
            Controls.Add(btnCafeOrders);
            Controls.Add(btnRobot);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSchedule);
            Controls.Add(btnBusStatus);
            Controls.Add(btnPassengers);
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MagicBus - Πίνακας Ελέγχου Προσωπικού";
            ResumeLayout(false);
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