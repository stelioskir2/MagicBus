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
            btnHelp = new Button();
            timerRefresh = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(71, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(717, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Η παραγγελία μου";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblOrders.Location = new Point(26, 64);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(158, 21);
            lblOrders.TabIndex = 1;
            lblOrders.Text = "Οι παραγγελίες σας";
            // 
            // lstOrders
            // 
            lstOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstOrders.FormattingEnabled = true;
            lstOrders.Location = new Point(26, 90);
            lstOrders.Margin = new Padding(3, 2, 3, 2);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(307, 214);
            lstOrders.TabIndex = 2;
            lstOrders.SelectedIndexChanged += lstOrders_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblStatus.ForeColor = Color.MidnightBlue;
            lblStatus.Location = new Point(368, 82);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(464, 34);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Κατάσταση:";
            // 
            // prgStatus
            // 
            prgStatus.Location = new Point(368, 124);
            prgStatus.Margin = new Padding(3, 2, 3, 2);
            prgStatus.Maximum = 3;
            prgStatus.Name = "prgStatus";
            prgStatus.Size = new Size(464, 22);
            prgStatus.TabIndex = 4;
            // 
            // lblSteps
            // 
            lblSteps.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblSteps.ForeColor = Color.DimGray;
            lblSteps.Location = new Point(368, 150);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(464, 19);
            lblSteps.TabIndex = 5;
            lblSteps.Text = "Νέα  →  Σε προετοιμασία  →  Καθ' οδόν προς τη στάση  →  Παραδόθηκε";
            // 
            // lblStop
            // 
            lblStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblStop.ForeColor = Color.MidnightBlue;
            lblStop.Location = new Point(368, 176);
            lblStop.Name = "lblStop";
            lblStop.Size = new Size(464, 60);
            lblStop.TabIndex = 6;
            // 
            // txtDetails
            // 
            txtDetails.BackColor = Color.White;
            txtDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtDetails.Location = new Point(368, 244);
            txtDetails.Margin = new Padding(3, 2, 3, 2);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(464, 132);
            txtDetails.TabIndex = 7;
            txtDetails.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(26, 398);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 38);
            btnBack.TabIndex = 8;
            btnBack.Text = "Επιστροφή στο μενού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.MidnightBlue;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(788, 19);
            btnHelp.Margin = new Padding(3, 2, 3, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(44, 38);
            btnHelp.TabIndex = 9;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // timerRefresh
            // 
            timerRefresh.Interval = 2000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // OrderTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(859, 452);
            Controls.Add(btnHelp);
            Controls.Add(btnBack);
            Controls.Add(txtDetails);
            Controls.Add(lblStop);
            Controls.Add(lblSteps);
            Controls.Add(prgStatus);
            Controls.Add(lblStatus);
            Controls.Add(lstOrders);
            Controls.Add(lblOrders);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnHelp;
        private System.Windows.Forms.Timer timerRefresh;
    }
}