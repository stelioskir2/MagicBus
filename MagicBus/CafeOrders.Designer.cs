namespace MagicBus
{
    partial class CafeOrders
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
            lblOrders = new Label();
            lstOrders = new ListBox();
            txtDetails = new TextBox();
            lblStatus = new Label();
            lblStop = new Label();
            cmbStop = new ComboBox();
            btnPrepare = new Button();
            btnSend = new Button();
            btnDelivered = new Button();
            btnBack = new Button();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font(
                "Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(922, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Παραγγελίες καφετέριας";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblOrders
            lblOrders.AutoSize = false;
            lblOrders.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            lblOrders.Location = new Point(30, 115);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(380, 35);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "Εισερχόμενες παραγγελίες";
            lblOrders.TextAlign = ContentAlignment.MiddleLeft;

            // lstOrders
            lstOrders.Font = new Font("Segoe UI", 12F);
            lstOrders.FormattingEnabled = true;
            lstOrders.IntegralHeight = false;
            lstOrders.Location = new Point(30, 155);
            lstOrders.Margin = new Padding(3, 2, 3, 2);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(380, 345);
            lstOrders.TabIndex = 2;
            lstOrders.SelectedIndexChanged +=
                lstOrders_SelectedIndexChanged;

            // txtDetails
            txtDetails.BackColor = Color.White;
            txtDetails.Font = new Font("Segoe UI", 12F);
            txtDetails.Location = new Point(440, 155);
            txtDetails.Margin = new Padding(3, 2, 3, 2);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(512, 155);
            txtDetails.TabIndex = 3;
            txtDetails.TabStop = false;
            txtDetails.WordWrap = true;

            // lblStatus
            lblStatus.AutoSize = false;
            lblStatus.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            lblStatus.ForeColor = Color.MidnightBlue;
            lblStatus.Location = new Point(440, 320);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(512, 55);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Κατάσταση:";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            // lblStop
            lblStop.AutoSize = false;
            lblStop.Font = new Font("Segoe UI", 12F);
            lblStop.Location = new Point(440, 375);
            lblStop.Name = "lblStop";
            lblStop.Size = new Size(180, 60);
            lblStop.TabIndex = 5;
            lblStop.Text = "Στάση\nπαράδοσης:";
            lblStop.TextAlign = ContentAlignment.MiddleLeft;

            // cmbStop
            cmbStop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStop.Font = new Font("Segoe UI", 12F);
            cmbStop.FormattingEnabled = true;
            cmbStop.Items.AddRange(new object[]
            {
                "Λευκός Πύργος",
                "Πλατεία Αριστοτέλους",
                "Πλατεία Ελευθερίας",
                "Άγιος Δημήτριος",
                "Ροτόντα",
                "Καμάρα"
            });
            cmbStop.Location = new Point(630, 390);
            cmbStop.Margin = new Padding(3, 2, 3, 2);
            cmbStop.Name = "cmbStop";
            cmbStop.Size = new Size(322, 36);
            cmbStop.TabIndex = 6;

            // btnPrepare
            btnPrepare.BackColor = Color.MidnightBlue;
            btnPrepare.FlatStyle = FlatStyle.Flat;
            btnPrepare.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            btnPrepare.ForeColor = Color.White;
            btnPrepare.Location = new Point(440, 445);
            btnPrepare.Margin = new Padding(3, 2, 3, 2);
            btnPrepare.Name = "btnPrepare";
            btnPrepare.Size = new Size(246, 55);
            btnPrepare.TabIndex = 7;
            btnPrepare.Text = "Αποδοχή παραγγελίας";
            btnPrepare.UseVisualStyleBackColor = false;
            btnPrepare.Click += btnPrepare_Click;

            // btnSend
            btnSend.BackColor = Color.MidnightBlue;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(706, 445);
            btnSend.Margin = new Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(246, 55);
            btnSend.TabIndex = 8;
            btnSend.Text = "Αποστολή στη στάση";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;

            // btnDelivered
            btnDelivered.BackColor = Color.MidnightBlue;
            btnDelivered.FlatStyle = FlatStyle.Flat;
            btnDelivered.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            btnDelivered.ForeColor = Color.White;
            btnDelivered.Location = new Point(440, 520);
            btnDelivered.Margin = new Padding(3, 2, 3, 2);
            btnDelivered.Name = "btnDelivered";
            btnDelivered.Size = new Size(246, 55);
            btnDelivered.TabIndex = 9;
            btnDelivered.Text = "Παραδόθηκε";
            btnDelivered.UseVisualStyleBackColor = false;
            btnDelivered.Click += btnDelivered_Click;

            // btnBack
            btnBack.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(30, 525);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(340, 50);
            btnBack.TabIndex = 10;
            btnBack.Text = "Επιστροφή στον πίνακα προσωπικού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // CafeOrders
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(btnDelivered);
            Controls.Add(btnSend);
            Controls.Add(btnPrepare);
            Controls.Add(cmbStop);
            Controls.Add(lblStop);
            Controls.Add(lblStatus);
            Controls.Add(txtDetails);
            Controls.Add(lstOrders);
            Controls.Add(lblOrders);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CafeOrders";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Παραγγελίες καφετέριας";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblOrders;
        private ListBox lstOrders;
        private TextBox txtDetails;
        private Label lblStatus;
        private Label lblStop;
        private ComboBox cmbStop;
        private Button btnPrepare;
        private Button btnSend;
        private Button btnDelivered;
        private Button btnBack;
    }
}