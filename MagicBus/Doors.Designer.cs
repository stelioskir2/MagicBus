namespace MagicBus
{
    partial class Doors
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
            lblStop = new Label();
            lblNextStop = new Label();
            pnlDoors = new Panel();
            lblDoors = new Label();
            lblPassengers = new Label();
            prgExit = new ProgressBar();
            btnOpen = new Button();
            btnClose = new Button();
            btnDepart = new Button();
            lblMessage = new Label();
            btnBack = new Button();
            timerExit = new System.Windows.Forms.Timer(components);
            pnlDoors.SuspendLayout();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(359, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Αποβίβαση και πόρτες";
            //
            // lblStop
            //
            lblStop.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblStop.ForeColor = Color.MidnightBlue;
            lblStop.Location = new Point(30, 95);
            lblStop.Name = "lblStop";
            lblStop.Size = new Size(450, 40);
            lblStop.TabIndex = 1;
            lblStop.Text = "Στάση:";
            //
            // lblNextStop
            //
            lblNextStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblNextStop.ForeColor = Color.DimGray;
            lblNextStop.Location = new Point(30, 135);
            lblNextStop.Name = "lblNextStop";
            lblNextStop.Size = new Size(450, 30);
            lblNextStop.TabIndex = 2;
            lblNextStop.Text = "Επόμενη στάση:";
            //
            // pnlDoors
            //
            pnlDoors.BackColor = Color.SeaGreen;
            pnlDoors.Controls.Add(lblDoors);
            pnlDoors.Location = new Point(30, 180);
            pnlDoors.Name = "pnlDoors";
            pnlDoors.Size = new Size(420, 110);
            pnlDoors.TabIndex = 3;
            //
            // lblDoors
            //
            lblDoors.Dock = DockStyle.Fill;
            lblDoors.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblDoors.ForeColor = Color.White;
            lblDoors.Location = new Point(0, 0);
            lblDoors.Name = "lblDoors";
            lblDoors.Size = new Size(420, 110);
            lblDoors.TabIndex = 0;
            lblDoors.Text = "Πόρτες: Κλειστές";
            lblDoors.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblPassengers
            //
            lblPassengers.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblPassengers.Location = new Point(30, 310);
            lblPassengers.Name = "lblPassengers";
            lblPassengers.Size = new Size(420, 35);
            lblPassengers.TabIndex = 4;
            lblPassengers.Text = "Επιβάτες που αποβιβάζονται: 0";
            //
            // prgExit
            //
            prgExit.Location = new Point(30, 355);
            prgExit.Name = "prgExit";
            prgExit.Size = new Size(420, 30);
            prgExit.TabIndex = 5;
            //
            // btnOpen
            //
            btnOpen.BackColor = Color.MidnightBlue;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(520, 180);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(430, 55);
            btnOpen.TabIndex = 6;
            btnOpen.Text = "Άνοιγμα θυρών";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.MidnightBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(520, 250);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(430, 55);
            btnClose.TabIndex = 7;
            btnClose.Text = "Κλείσιμο θυρών";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // btnDepart
            //
            btnDepart.BackColor = Color.MidnightBlue;
            btnDepart.FlatStyle = FlatStyle.Flat;
            btnDepart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnDepart.ForeColor = Color.White;
            btnDepart.Location = new Point(520, 320);
            btnDepart.Name = "btnDepart";
            btnDepart.Size = new Size(430, 55);
            btnDepart.TabIndex = 8;
            btnDepart.Text = "Αναχώρηση για την επόμενη στάση";
            btnDepart.UseVisualStyleBackColor = false;
            btnDepart.Click += btnDepart_Click;
            //
            // lblMessage
            //
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblMessage.ForeColor = Color.MidnightBlue;
            lblMessage.Location = new Point(520, 400);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(430, 100);
            lblMessage.TabIndex = 9;
            //
            // btnBack
            //
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(300, 50);
            btnBack.TabIndex = 10;
            btnBack.Text = "Επιστροφή στον πίνακα οδηγού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // timerExit
            //
            timerExit.Interval = 1000;
            timerExit.Tick += timerExit_Tick;
            //
            // Doors
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(lblMessage);
            Controls.Add(btnDepart);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(prgExit);
            Controls.Add(lblPassengers);
            Controls.Add(pnlDoors);
            Controls.Add(lblNextStop);
            Controls.Add(lblStop);
            Controls.Add(lblTitle);
            Name = "Doors";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Αποβίβαση και πόρτες";
            pnlDoors.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStop;
        private Label lblNextStop;
        private Panel pnlDoors;
        private Label lblDoors;
        private Label lblPassengers;
        private ProgressBar prgExit;
        private Button btnOpen;
        private Button btnClose;
        private Button btnDepart;
        private Label lblMessage;
        private Button btnBack;
        private System.Windows.Forms.Timer timerExit;
    }
}
