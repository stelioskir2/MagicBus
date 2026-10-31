namespace MagicBus
{
    partial class OrderTracking
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblOrders = new Label();
            lstOrders = new ListBox();
            lblStatus = new Label();
            prgStatus = new ProgressBar();
            lblSteps = new Label();
            lblStop = new Label();
            txtDetails = new TextBox();
            btnBack = new Button();
            timerRefresh = new System.Windows.Forms.Timer(components);
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
            lblTitle.Text = "Η παραγγελία μου";
            //
            // lblOrders
            //
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblOrders.Location = new Point(30, 85);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(187, 28);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "Οι παραγγελίες σας";
            //
            // lstOrders
            //
            lstOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstOrders.FormattingEnabled = true;
            lstOrders.Location = new Point(30, 120);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(350, 284);
            lstOrders.TabIndex = 2;
            lstOrders.SelectedIndexChanged += lstOrders_SelectedIndexChanged;
            //
            // lblStatus
            //
            lblStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblStatus.ForeColor = Color.MidnightBlue;
            lblStatus.Location = new Point(420, 110);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(530, 45);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Κατάσταση:";
            //
            // prgStatus
            //
            prgStatus.Location = new Point(420, 165);
            prgStatus.Maximum = 3;
            prgStatus.Name = "prgStatus";
            prgStatus.Size = new Size(530, 30);
            prgStatus.TabIndex = 4;
            //
            // lblSteps
            //
            lblSteps.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblSteps.ForeColor = Color.DimGray;
            lblSteps.Location = new Point(420, 200);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(530, 25);
            lblSteps.TabIndex = 5;
            lblSteps.Text = "Νέα  →  Σε προετοιμασία  →  Καθ' οδόν προς τη στάση  →  Παραδόθηκε";
            //
            // lblStop
            //
            lblStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblStop.ForeColor = Color.MidnightBlue;
            lblStop.Location = new Point(420, 235);
            lblStop.Name = "lblStop";
            lblStop.Size = new Size(530, 80);
            lblStop.TabIndex = 6;
            //
            // txtDetails
            //
            txtDetails.BackColor = Color.White;
            txtDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtDetails.Location = new Point(420, 325);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(530, 175);
            txtDetails.TabIndex = 7;
            txtDetails.TabStop = false;
            //
            // btnBack
            //
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(220, 50);
            btnBack.TabIndex = 8;
            btnBack.Text = "Επιστροφή στο μενού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // timerRefresh
            //
            timerRefresh.Interval = 2000;
            timerRefresh.Tick += timerRefresh_Tick;
            //
            // OrderTracking
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(txtDetails);
            Controls.Add(lblStop);
            Controls.Add(lblSteps);
            Controls.Add(prgStatus);
            Controls.Add(lblStatus);
            Controls.Add(lstOrders);
            Controls.Add(lblOrders);
            Controls.Add(lblTitle);
            Name = "OrderTracking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Η παραγγελία μου";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblOrders;
        private ListBox lstOrders;
        private Label lblStatus;
        private ProgressBar prgStatus;
        private Label lblSteps;
        private Label lblStop;
        private TextBox txtDetails;
        private Button btnBack;
        private System.Windows.Forms.Timer timerRefresh;
    }
}
