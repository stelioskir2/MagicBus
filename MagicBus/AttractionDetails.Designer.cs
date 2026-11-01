namespace MagicBus
{
    partial class AttractionDetails
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
            picAttraction = new PictureBox();
            txtDescription = new TextBox();
            btnBack = new Button();
            btnPlay = new Button();
            btnStop = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)picAttraction).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(439, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Πληροφορίες αξιοθέατου";
            // 
            // picAttraction
            // 
            picAttraction.BorderStyle = BorderStyle.FixedSingle;
            picAttraction.Location = new Point(30, 110);
            picAttraction.Name = "picAttraction";
            picAttraction.Size = new Size(400, 300);
            picAttraction.SizeMode = PictureBoxSizeMode.Zoom;
            picAttraction.TabIndex = 1;
            picAttraction.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtDescription.Location = new Point(460, 110);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(480, 300);
            txtDescription.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(260, 50);
            btnBack.TabIndex = 0;
            btnBack.Text = "Επιστροφή στα αξιοθέατα";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnPlay.Location = new Point(460, 440);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(280, 50);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Ακούστε την περιγραφή";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnStop.Location = new Point(760, 440);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(180, 50);
            btnStop.TabIndex = 3;
            btnStop.Text = "Διακοπή";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.MidnightBlue;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(890, 25);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(50, 50);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // AttractionDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnHelp);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(btnBack);
            Controls.Add(txtDescription);
            Controls.Add(picAttraction);
            Controls.Add(lblTitle);
            Name = "AttractionDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Πληροφορίες αξιοθέατου";
            ((System.ComponentModel.ISupportInitialize)picAttraction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox picAttraction;
        private TextBox txtDescription;
        private Button btnBack;
        private Button btnPlay;
        private Button btnStop;
        private Button btnHelp;
    }
}