namespace MagicBus
{
    partial class PassengerHome
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
            btnMap = new Button();
            btnView = new Button();
            btnShelter = new Button();
            btnTour = new Button();
            btnAttractions = new Button();
            btnLost = new Button();
            lblLostNotification = new Label();
            btnCafe = new Button();
            btnOrderTracking = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(533, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Καλώς ήρθατε στο MagicBus";
            // 
            // btnMap
            // 
            btnMap.BackColor = Color.MidnightBlue;
            btnMap.FlatStyle = FlatStyle.Flat;
            btnMap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnMap.ForeColor = Color.White;
            btnMap.Location = new Point(30, 130);
            btnMap.Name = "btnMap";
            btnMap.Size = new Size(280, 100);
            btnMap.TabIndex = 1;
            btnMap.Text = "Χάρτης και στάσεις";
            btnMap.UseVisualStyleBackColor = false;
            btnMap.Click += btnMap_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.MidnightBlue;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(350, 130);
            btnView.Name = "btnView";
            btnView.Size = new Size(280, 100);
            btnView.TabIndex = 2;
            btnView.Text = "Θέα διαδρομής";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnShelter
            // 
            btnShelter.BackColor = Color.MidnightBlue;
            btnShelter.FlatStyle = FlatStyle.Flat;
            btnShelter.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnShelter.ForeColor = Color.White;
            btnShelter.Location = new Point(350, 260);
            btnShelter.Name = "btnShelter";
            btnShelter.Size = new Size(280, 100);
            btnShelter.TabIndex = 3;
            btnShelter.Text = "Ασφαλή καταφύγια";
            btnShelter.UseVisualStyleBackColor = false;
            btnShelter.Click += btnShelter_Click;
            // 
            // btnTour
            // 
            btnTour.BackColor = Color.MidnightBlue;
            btnTour.FlatStyle = FlatStyle.Flat;
            btnTour.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnTour.ForeColor = Color.White;
            btnTour.Location = new Point(30, 260);
            btnTour.Name = "btnTour";
            btnTour.Size = new Size(280, 100);
            btnTour.TabIndex = 4;
            btnTour.Text = "Τουριστική πλοήγηση";
            btnTour.UseVisualStyleBackColor = false;
            btnTour.Click += btnTour_Click;
            // 
            // btnAttractions
            // 
            btnAttractions.BackColor = Color.MidnightBlue;
            btnAttractions.FlatStyle = FlatStyle.Flat;
            btnAttractions.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnAttractions.ForeColor = Color.White;
            btnAttractions.Location = new Point(670, 130);
            btnAttractions.Name = "btnAttractions";
            btnAttractions.Size = new Size(280, 100);
            btnAttractions.TabIndex = 5;
            btnAttractions.Text = "Αξιοθέατα";
            btnAttractions.UseVisualStyleBackColor = false;
            btnAttractions.Click += btnAttractions_Click;
            // 
            // btnLost
            // 
            btnLost.BackColor = Color.MidnightBlue;
            btnLost.FlatStyle = FlatStyle.Flat;
            btnLost.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnLost.ForeColor = Color.White;
            btnLost.Location = new Point(670, 260);
            btnLost.Name = "btnLost";
            btnLost.Size = new Size(280, 100);
            btnLost.TabIndex = 6;
            btnLost.Text = "Απολεσθέντα";
            btnLost.UseVisualStyleBackColor = false;
            btnLost.Click += btnLost_Click;
            // 
            // lblLostNotification
            // 
            lblLostNotification.AutoSize = true;
            lblLostNotification.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblLostNotification.ForeColor = Color.MidnightBlue;
            lblLostNotification.Location = new Point(684, 363);
            lblLostNotification.Name = "lblLostNotification";
            lblLostNotification.Size = new Size(249, 28);
            lblLostNotification.TabIndex = 7;
            lblLostNotification.Text = "Υπάρχουν νέα ευρήματα";
            lblLostNotification.Visible = false;
            // 
            // btnCafe
            // 
            btnCafe.BackColor = Color.MidnightBlue;
            btnCafe.FlatStyle = FlatStyle.Flat;
            btnCafe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnCafe.ForeColor = Color.White;
            btnCafe.Location = new Point(350, 390);
            btnCafe.Name = "btnCafe";
            btnCafe.Size = new Size(280, 100);
            btnCafe.TabIndex = 8;
            btnCafe.Text = "Παραγγελία από καφετέρια";
            btnCafe.UseVisualStyleBackColor = false;
            btnCafe.Click += btnCafe_Click;
            // 
            // btnOrderTracking
            // 
            btnOrderTracking.BackColor = Color.MidnightBlue;
            btnOrderTracking.FlatStyle = FlatStyle.Flat;
            btnOrderTracking.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnOrderTracking.ForeColor = Color.White;
            btnOrderTracking.Location = new Point(30, 390);
            btnOrderTracking.Name = "btnOrderTracking";
            btnOrderTracking.Size = new Size(280, 100);
            btnOrderTracking.TabIndex = 9;
            btnOrderTracking.Text = "Η παραγγελία μου";
            btnOrderTracking.UseVisualStyleBackColor = false;
            btnOrderTracking.Click += btnOrderTracking_Click;
            // 
            // PassengerHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnOrderTracking);
            Controls.Add(btnCafe);
            Controls.Add(lblLostNotification);
            Controls.Add(btnLost);
            Controls.Add(btnAttractions);
            Controls.Add(btnTour);
            Controls.Add(btnShelter);
            Controls.Add(btnView);
            Controls.Add(btnMap);
            Controls.Add(lblTitle);
            Name = "PassengerHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MagicBus — Μενού επιβάτη";
            Load += PassengerHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnMap;
        private Button btnView;
        private Button btnShelter;
        private Button btnTour;
        private Button btnAttractions;
        private Button btnLost;
        private Label lblLostNotification;
        private Button btnCafe;
        private Button btnOrderTracking;
    }
}