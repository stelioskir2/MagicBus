namespace MagicBus
{
    partial class Payment
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
            lblSummary = new Label();
            txtSummary = new TextBox();
            lblTotal = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblCardNumber = new Label();
            txtCardNumber = new TextBox();
            lblExpiry = new Label();
            txtExpiry = new TextBox();
            lblCvv = new Label();
            txtCvv = new TextBox();
            lblSecure = new Label();
            btnPay = new Button();
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
            lblTitle.Size = new Size(296, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Πληρωμή με κάρτα";
            //
            // lblSummary
            //
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblSummary.Location = new Point(30, 85);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(205, 28);
            lblSummary.TabIndex = 1;
            lblSummary.Text = "Σύνοψη παραγγελίας";
            //
            // txtSummary
            //
            txtSummary.BackColor = Color.White;
            txtSummary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtSummary.Location = new Point(30, 120);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(400, 283);
            txtSummary.TabIndex = 2;
            txtSummary.TabStop = false;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTotal.ForeColor = Color.MidnightBlue;
            lblTotal.Location = new Point(30, 420);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(206, 38);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Σύνολο: 0,00 €";
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblName.Location = new Point(480, 85);
            lblName.Name = "lblName";
            lblName.Size = new Size(238, 28);
            lblName.TabIndex = 4;
            lblName.Text = "Ονοματεπώνυμο κατόχου";
            //
            // txtName
            //
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtName.Location = new Point(480, 118);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new Size(460, 34);
            txtName.TabIndex = 5;
            //
            // lblCardNumber
            //
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblCardNumber.Location = new Point(480, 170);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(155, 28);
            lblCardNumber.TabIndex = 6;
            lblCardNumber.Text = "Αριθμός κάρτας";
            //
            // txtCardNumber
            //
            txtCardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtCardNumber.Location = new Point(480, 203);
            txtCardNumber.MaxLength = 19;
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.PlaceholderText = "1234 5678 9012 3456";
            txtCardNumber.Size = new Size(460, 34);
            txtCardNumber.TabIndex = 7;
            txtCardNumber.KeyPress += txtDigits_KeyPress;
            //
            // lblExpiry
            //
            lblExpiry.AutoSize = true;
            lblExpiry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblExpiry.Location = new Point(480, 255);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(141, 28);
            lblExpiry.TabIndex = 8;
            lblExpiry.Text = "Λήξη (ΜΜ/ΕΕ)";
            //
            // txtExpiry
            //
            txtExpiry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtExpiry.Location = new Point(480, 288);
            txtExpiry.MaxLength = 5;
            txtExpiry.Name = "txtExpiry";
            txtExpiry.PlaceholderText = "08/28";
            txtExpiry.Size = new Size(150, 34);
            txtExpiry.TabIndex = 9;
            txtExpiry.KeyPress += txtExpiry_KeyPress;
            //
            // lblCvv
            //
            lblCvv.AutoSize = true;
            lblCvv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblCvv.Location = new Point(680, 255);
            lblCvv.Name = "lblCvv";
            lblCvv.Size = new Size(46, 28);
            lblCvv.TabIndex = 10;
            lblCvv.Text = "CVV";
            //
            // txtCvv
            //
            txtCvv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtCvv.Location = new Point(680, 288);
            txtCvv.MaxLength = 3;
            txtCvv.Name = "txtCvv";
            txtCvv.Size = new Size(100, 34);
            txtCvv.TabIndex = 11;
            txtCvv.UseSystemPasswordChar = true;
            txtCvv.KeyPress += txtDigits_KeyPress;
            //
            // lblSecure
            //
            lblSecure.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 161);
            lblSecure.ForeColor = Color.DimGray;
            lblSecure.Location = new Point(480, 345);
            lblSecure.Name = "lblSecure";
            lblSecure.Size = new Size(460, 50);
            lblSecure.TabIndex = 12;
            lblSecure.Text = "Η πληρωμή γίνεται με ασφάλεια. Τα στοιχεία της κάρτας σας δεν αποθηκεύονται.";
            //
            // btnPay
            //
            btnPay.BackColor = Color.MidnightBlue;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(650, 520);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(300, 60);
            btnPay.TabIndex = 13;
            btnPay.Text = "Πληρωμή";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            //
            // btnBack
            //
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(260, 50);
            btnBack.TabIndex = 14;
            btnBack.Text = "Επιστροφή στο καλάθι";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // Payment
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(btnPay);
            Controls.Add(lblSecure);
            Controls.Add(txtCvv);
            Controls.Add(lblCvv);
            Controls.Add(txtExpiry);
            Controls.Add(lblExpiry);
            Controls.Add(txtCardNumber);
            Controls.Add(lblCardNumber);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTotal);
            Controls.Add(txtSummary);
            Controls.Add(lblSummary);
            Controls.Add(lblTitle);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Πληρωμή";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSummary;
        private TextBox txtSummary;
        private Label lblTotal;
        private Label lblName;
        private TextBox txtName;
        private Label lblCardNumber;
        private TextBox txtCardNumber;
        private Label lblExpiry;
        private TextBox txtExpiry;
        private Label lblCvv;
        private TextBox txtCvv;
        private Label lblSecure;
        private Button btnPay;
        private Button btnBack;
    }
}
