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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(445, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Απολεσθέντα αντικείμενα";
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblItems.ForeColor = Color.MidnightBlue;
            lblItems.Location = new Point(30, 100);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(328, 31);
            lblItems.TabIndex = 1;
            lblItems.Text = "Αντικείμενα που εντοπίστηκαν";
            // 
            // lstItems
            // 
            lstItems.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstItems.FormattingEnabled = true;
            lstItems.IntegralHeight = false;
            lstItems.Location = new Point(30, 140);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(350, 300);
            lstItems.TabIndex = 2;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // txtDetails
            // 
            txtDetails.BackColor = Color.White;
            txtDetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtDetails.Location = new Point(420, 140);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(520, 300);
            txtDetails.TabIndex = 3;
            txtDetails.TabStop = false;
            txtDetails.Text = "Επιλέξτε ένα αντικείμενο για να δείτε πληροφορίες.";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(220, 50);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // LostItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(txtDetails);
            Controls.Add(lstItems);
            Controls.Add(lblItems);
            Controls.Add(lblTitle);
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
    }
}