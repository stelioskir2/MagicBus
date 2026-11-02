namespace MagicBus
{
    partial class MapStops
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
            btnBack = new Button();
            lblTitle = new Label();
            lstStops = new ListBox();
            lblStop = new Label();
            picMap = new PictureBox();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)picMap).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(26, 398);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "Επιστροφή στο μενού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.Location = new Point(26, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(483, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Θεσσαλονίκη — Χάρτης και στάσεις";
            lblTitle.Click += label1_Click;
            // 
            // lstStops
            // 
            lstStops.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstStops.FormattingEnabled = true;
            lstStops.Items.AddRange(new object[] { "Λευκός Πύργος", "Πλατεία Αριστοτέλους", "Πλατεία Ελευθερίας", "Άγιος Δημήτριος", "Ροτόντα", "Καμάρα" });
            lstStops.Location = new Point(26, 82);
            lstStops.Margin = new Padding(3, 2, 3, 2);
            lstStops.Name = "lstStops";
            lstStops.Size = new Size(263, 204);
            lstStops.TabIndex = 2;
            lstStops.SelectedIndexChanged += lstStops_SelectedIndexChanged;
            // 
            // lblStop
            // 
            lblStop.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblStop.ForeColor = Color.MidnightBlue;
            lblStop.Location = new Point(324, 82);
            lblStop.Name = "lblStop";
            lblStop.Size = new Size(481, 60);
            lblStop.TabIndex = 3;
            lblStop.Text = "\tΕπιλέξτε μια στάση από τη λίστα";
            lblStop.Click += label1_Click_1;
            // 
            // picMap
            // 
            picMap.BackColor = Color.White;
            picMap.BorderStyle = BorderStyle.FixedSingle;
            picMap.Image = Properties.Resources.thessaloniki_route;
            picMap.Location = new Point(324, 150);
            picMap.Margin = new Padding(3, 2, 3, 2);
            picMap.Name = "picMap";
            picMap.Size = new Size(482, 226);
            picMap.SizeMode = PictureBoxSizeMode.Zoom;
            picMap.TabIndex = 4;
            picMap.TabStop = false;
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
            btnHelp.TabIndex = 5;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // MapStops
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(859, 452);
            Controls.Add(btnHelp);
            Controls.Add(picMap);
            Controls.Add(lblStop);
            Controls.Add(lstStops);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MapStops";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Χάρτης και στάσεις";
            ((System.ComponentModel.ISupportInitialize)picMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblTitle;
        private ListBox lstStops;
        private Label lblStop;
        private PictureBox picMap;
        private Button btnHelp;
    }
}