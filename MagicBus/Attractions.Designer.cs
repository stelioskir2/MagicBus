namespace MagicBus
{
    partial class Attractions
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
            lstAttractions = new ListBox();
            btnDetails = new Button();
            btnBack = new Button();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Αξιοθέατα της Θεσσαλονίκης";
            // 
            // lstAttractions
            // 
            lstAttractions.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstAttractions.FormattingEnabled = true;
            lstAttractions.Items.AddRange(new object[] { "Λευκός Πύργος", "Πλατεία Αριστοτέλους", "Άγιος Δημήτριος", "Ροτόντα", "Καμάρα" });
            lstAttractions.Location = new Point(30, 110);
            lstAttractions.Name = "lstAttractions";
            lstAttractions.Size = new Size(350, 283);
            lstAttractions.TabIndex = 1;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.MidnightBlue;
            btnDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnDetails.ForeColor = Color.White;
            btnDetails.Location = new Point(420, 110);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(300, 60);
            btnDetails.TabIndex = 2;
            btnDetails.Text = "Πληροφορίες αξιοθέατου";
            btnDetails.UseMnemonic = false;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(220, 50);
            btnBack.TabIndex = 3;
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
            btnHelp.Location = new Point(900, 25);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(50, 50);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // Attractions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnHelp);
            Controls.Add(btnBack);
            Controls.Add(btnDetails);
            Controls.Add(lstAttractions);
            Controls.Add(lblTitle);
            Name = "Attractions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Αξιοθέατα";
            Load += Attractions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstAttractions;
        private Button btnDetails;
        private Button btnBack;
        private Button btnHelp;
    }
}