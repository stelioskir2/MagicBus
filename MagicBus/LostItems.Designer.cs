namespace MagicBus
{
    partial class LostItems
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
            lblItems = new Label();
            lstItems = new ListBox();
            txtDetails = new TextBox();
            btnBack = new Button();
            btnHelp = new Button();
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
            lblTitle.Text = "Απολεσθέντα αντικείμενα";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblItems.ForeColor = Color.MidnightBlue;
            lblItems.Location = new Point(26, 75);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(274, 25);
            lblItems.TabIndex = 1;
            lblItems.Text = "Αντικείμενα που εντοπίστηκαν";
            // 
            // lstItems
            // 
            lstItems.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstItems.FormattingEnabled = true;
            lstItems.IntegralHeight = false;
            lstItems.Location = new Point(26, 105);
            lstItems.Margin = new Padding(3, 2, 3, 2);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(307, 226);
            lstItems.TabIndex = 2;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // txtDetails
            // 
            txtDetails.BackColor = Color.White;
            txtDetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtDetails.Location = new Point(368, 105);
            txtDetails.Margin = new Padding(3, 2, 3, 2);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(456, 226);
            txtDetails.TabIndex = 3;
            txtDetails.TabStop = false;
            txtDetails.Text = "Επιλέξτε ένα αντικείμενο για να δείτε πληροφορίες.";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(26, 398);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 38);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή";
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
            btnHelp.TabIndex = 5;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // LostItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(859, 452);
            Controls.Add(btnHelp);
            Controls.Add(btnBack);
            Controls.Add(txtDetails);
            Controls.Add(lstItems);
            Controls.Add(lblItems);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LostItems";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Απολεσθέντα";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblItems;
        private ListBox lstItems;
        private TextBox txtDetails;
        private Button btnBack;
        private Button btnHelp;
    }
}