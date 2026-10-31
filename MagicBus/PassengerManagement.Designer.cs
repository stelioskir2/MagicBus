namespace MagicBus
{
    partial class PassengerManagement
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
            lblTitle = new Label();
            dgvPassengers = new DataGridView();
            lblSeatsAvailable = new Label();
            lblCancelTitle = new Label();
            lblTicketCode = new Label();
            txtTicketCode = new TextBox();
            btnCancelTicket = new Button();
            lblCancelStatus = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(350, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Διαχείριση Επιβατών";
            // 
            // dgvPassengers
            // 
            dgvPassengers.AllowUserToAddRows = false;
            dgvPassengers.AllowUserToDeleteRows = false;
            dgvPassengers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPassengers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPassengers.Location = new Point(50, 90);
            dgvPassengers.Name = "dgvPassengers";
            dgvPassengers.ReadOnly = true;
            dgvPassengers.Size = new Size(580, 320);
            dgvPassengers.TabIndex = 1;
            // 
            // lblSeatsAvailable
            // 
            lblSeatsAvailable.AutoSize = true;
            lblSeatsAvailable.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSeatsAvailable.ForeColor = Color.DarkSlateGray;
            lblSeatsAvailable.Location = new Point(50, 430);
            lblSeatsAvailable.Name = "lblSeatsAvailable";
            lblSeatsAvailable.Size = new Size(240, 25);
            lblSeatsAvailable.TabIndex = 2;
            lblSeatsAvailable.Text = "Ελεύθερες Θέσεις: 12 / 40";
            // 
            // lblCancelTitle
            // 
            lblCancelTitle.AutoSize = true;
            lblCancelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCancelTitle.ForeColor = Color.Firebrick;
            lblCancelTitle.Location = new Point(670, 90);
            lblCancelTitle.Name = "lblCancelTitle";
            lblCancelTitle.Size = new Size(233, 30);
            lblCancelTitle.TabIndex = 3;
            lblCancelTitle.Text = "Ακύρωση Εισιτηρίου";
            // 
            // lblTicketCode
            // 
            lblTicketCode.AutoSize = true;
            lblTicketCode.Font = new Font("Segoe UI", 11F);
            lblTicketCode.Location = new Point(670, 150);
            lblTicketCode.Name = "lblTicketCode";
            lblTicketCode.Size = new Size(145, 20);
            lblTicketCode.TabIndex = 4;
            lblTicketCode.Text = "Κωδικός Εισιτηρίου:";
            // 
            // txtTicketCode
            // 
            txtTicketCode.Font = new Font("Segoe UI", 11F);
            txtTicketCode.Location = new Point(670, 185);
            txtTicketCode.Name = "txtTicketCode";
            txtTicketCode.Size = new Size(240, 27);
            txtTicketCode.TabIndex = 5;
            // 
            // btnCancelTicket
            // 
            btnCancelTicket.BackColor = Color.Firebrick;
            btnCancelTicket.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelTicket.ForeColor = Color.White;
            btnCancelTicket.Location = new Point(670, 230);
            btnCancelTicket.Name = "btnCancelTicket";
            btnCancelTicket.Size = new Size(240, 45);
            btnCancelTicket.TabIndex = 6;
            btnCancelTicket.Text = "Ακύρωση Κράτησης";
            btnCancelTicket.UseVisualStyleBackColor = false;
            btnCancelTicket.Click += btnCancelTicket_Click;
            // 
            // lblCancelStatus
            // 
            lblCancelStatus.AutoSize = true;
            lblCancelStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCancelStatus.ForeColor = Color.ForestGreen;
            lblCancelStatus.Location = new Point(670, 295);
            lblCancelStatus.Name = "lblCancelStatus";
            lblCancelStatus.Size = new Size(0, 20);
            lblCancelStatus.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(12, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 48);
            btnBack.TabIndex = 8;
            btnBack.Text = "Επιστροφή στον 'Ελεγχο Προσωπικού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PassengerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnBack);
            Controls.Add(lblCancelStatus);
            Controls.Add(btnCancelTicket);
            Controls.Add(txtTicketCode);
            Controls.Add(lblTicketCode);
            Controls.Add(lblCancelTitle);
            Controls.Add(lblSeatsAvailable);
            Controls.Add(dgvPassengers);
            Controls.Add(lblTitle);
            Name = "PassengerManagement";
            Text = "Διαχείριση Επιβατών - MagicBus";
            Load += PassengerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvPassengers;
        private Label lblSeatsAvailable;
        private Label lblCancelTitle;
        private Label lblTicketCode;
        private TextBox txtTicketCode;
        private Button btnCancelTicket;
        private Label lblCancelStatus;
        private Button btnBack;
    }
}