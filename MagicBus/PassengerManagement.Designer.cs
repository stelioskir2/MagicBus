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

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(922, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Διαχείριση Επιβατών";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // dgvPassengers
            dgvPassengers.AllowUserToAddRows = false;
            dgvPassengers.AllowUserToDeleteRows = false;
            dgvPassengers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvPassengers.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dgvPassengers.BackgroundColor = Color.White;
            dgvPassengers.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPassengers.ColumnHeadersDefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dgvPassengers.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dgvPassengers.Font = new Font("Segoe UI", 10F);
            dgvPassengers.Location = new Point(30, 145);
            dgvPassengers.MultiSelect = false;
            dgvPassengers.Name = "dgvPassengers";
            dgvPassengers.ReadOnly = true;
            dgvPassengers.RowHeadersVisible = false;
            dgvPassengers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvPassengers.Size = new Size(600, 310);
            dgvPassengers.TabIndex = 1;

            // lblSeatsAvailable
            lblSeatsAvailable.AutoSize = false;
            lblSeatsAvailable.Font =
                new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeatsAvailable.ForeColor = Color.DarkSlateGray;
            lblSeatsAvailable.Location = new Point(30, 465);
            lblSeatsAvailable.Name = "lblSeatsAvailable";
            lblSeatsAvailable.Size = new Size(600, 45);
            lblSeatsAvailable.TabIndex = 2;
            lblSeatsAvailable.Text = "Ελεύθερες Θέσεις: 33 / 40 (Κρατημένες: 7)";
            lblSeatsAvailable.TextAlign = ContentAlignment.MiddleLeft;

            // lblCancelTitle
            lblCancelTitle.AutoSize = false;
            lblCancelTitle.Font =
                new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCancelTitle.ForeColor = Color.Firebrick;
            lblCancelTitle.Location = new Point(660, 145);
            lblCancelTitle.Name = "lblCancelTitle";
            lblCancelTitle.Size = new Size(292, 60);
            lblCancelTitle.TabIndex = 3;
            lblCancelTitle.Text = "Ακύρωση Εισιτηρίου";
            lblCancelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblTicketCode
            lblTicketCode.AutoSize = false;
            lblTicketCode.Font = new Font("Segoe UI", 12F);
            lblTicketCode.Location = new Point(660, 215);
            lblTicketCode.Name = "lblTicketCode";
            lblTicketCode.Size = new Size(292, 35);
            lblTicketCode.TabIndex = 4;
            lblTicketCode.Text = "Κωδικός Εισιτηρίου:";
            lblTicketCode.TextAlign = ContentAlignment.MiddleLeft;

            // txtTicketCode
            txtTicketCode.Font = new Font("Segoe UI", 12F);
            txtTicketCode.Location = new Point(660, 255);
            txtTicketCode.Name = "txtTicketCode";
            txtTicketCode.Size = new Size(292, 34);
            txtTicketCode.TabIndex = 5;

            // btnCancelTicket
            btnCancelTicket.BackColor = Color.Firebrick;
            btnCancelTicket.FlatStyle = FlatStyle.Flat;
            btnCancelTicket.Font =
                new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancelTicket.ForeColor = Color.White;
            btnCancelTicket.Location = new Point(660, 310);
            btnCancelTicket.Name = "btnCancelTicket";
            btnCancelTicket.Size = new Size(292, 65);
            btnCancelTicket.TabIndex = 6;
            btnCancelTicket.Text = "Ακύρωση Κράτησης";
            btnCancelTicket.UseVisualStyleBackColor = false;
            btnCancelTicket.Click += btnCancelTicket_Click;

            // lblCancelStatus
            lblCancelStatus.AutoSize = false;
            lblCancelStatus.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCancelStatus.ForeColor = Color.ForestGreen;
            lblCancelStatus.Location = new Point(660, 390);
            lblCancelStatus.Name = "lblCancelStatus";
            lblCancelStatus.Size = new Size(292, 95);
            lblCancelStatus.TabIndex = 7;
            lblCancelStatus.TextAlign = ContentAlignment.TopLeft;

            // btnBack
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(340, 50);
            btnBack.TabIndex = 8;
            btnBack.Text = "Επιστροφή στον πίνακα προσωπικού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // PassengerManagement
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
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
            StartPosition = FormStartPosition.CenterParent;
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