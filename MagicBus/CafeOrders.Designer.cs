namespace MagicBus
{
    partial class CafeOrders
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
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(397, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Παραγγελίες καφετέριας";
            //
            // lblOrders
            //
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblOrders.Location = new Point(30, 85);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(247, 28);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "Εισερχόμενες παραγγελίες";
            //
            // lstOrders
            //
            lstOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstOrders.FormattingEnabled = true;
            lstOrders.Location = new Point(30, 120);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(400, 368);
            lstOrders.TabIndex = 2;
            lstOrders.SelectedIndexChanged += lstOrders_SelectedIndexChanged;
            //
            // txtDetails
            //
            txtDetails.BackColor = Color.White;
            txtDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtDetails.Location = new Point(470, 120);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(480, 150);
            txtDetails.TabIndex = 3;
            txtDetails.TabStop = false;
            //
            // lblStatus
            //
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblStatus.ForeColor = Color.MidnightBlue;
            lblStatus.Location = new Point(470, 280);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(480, 35);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Κατάσταση:";
            //
            // lblStop
            //
            lblStop.AutoSize = true;
            lblStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblStop.Location = new Point(470, 333);
            lblStop.Name = "lblStop";
            lblStop.Size = new Size(165, 28);
            lblStop.TabIndex = 5;
            lblStop.Text = "Στάση παράδοσης:";
            //
            // cmbStop
            //
            cmbStop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbStop.FormattingEnabled = true;
            cmbStop.Items.AddRange(new object[] { "Λευκός Πύργος", "Πλατεία Αριστοτέλους", "Πλατεία Ελευθερίας", "Άγιος Δημήτριος", "Ροτόντα", "Καμάρα" });
            cmbStop.Location = new Point(650, 330);
            cmbStop.Name = "cmbStop";
            cmbStop.Size = new Size(300, 36);
            cmbStop.TabIndex = 6;
            //
            // btnPrepare
            //
            btnPrepare.BackColor = Color.MidnightBlue;
            btnPrepare.FlatStyle = FlatStyle.Flat;
            btnPrepare.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnPrepare.ForeColor = Color.White;
            btnPrepare.Location = new Point(470, 390);
            btnPrepare.Name = "btnPrepare";
            btnPrepare.Size = new Size(230, 55);
            btnPrepare.TabIndex = 7;
            btnPrepare.Text = "Αποδοχή παραγγελίας";
            btnPrepare.UseVisualStyleBackColor = false;
            btnPrepare.Click += btnPrepare_Click;
            //
            // btnSend
            //
            btnSend.BackColor = Color.MidnightBlue;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(720, 390);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(230, 55);
            btnSend.TabIndex = 8;
            btnSend.Text = "Αποστολή στη στάση";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            //
            // btnDelivered
            //
            btnDelivered.BackColor = Color.MidnightBlue;
            btnDelivered.FlatStyle = FlatStyle.Flat;
            btnDelivered.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnDelivered.ForeColor = Color.White;
            btnDelivered.Location = new Point(470, 460);
            btnDelivered.Name = "btnDelivered";
            btnDelivered.Size = new Size(230, 55);
            btnDelivered.TabIndex = 9;
            btnDelivered.Text = "Παραδόθηκε";
            btnDelivered.UseVisualStyleBackColor = false;
            btnDelivered.Click += btnDelivered_Click;
            //
            // btnBack
            //
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(300, 50);
            btnBack.TabIndex = 10;
            btnBack.Text = "Επιστροφή στον πίνακα προσωπικού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // CafeOrders
            //
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
