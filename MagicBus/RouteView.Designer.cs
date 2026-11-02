namespace MagicBus
{
    partial class RouteView
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
            webVideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnBack = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)webVideo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(26, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Θέα διαδρομής";
            // 
            // webVideo
            // 
            webVideo.AllowExternalDrop = true;
            webVideo.CreationProperties = null;
            webVideo.DefaultBackgroundColor = Color.White;
            webVideo.Location = new Point(26, 75);
            webVideo.Margin = new Padding(3, 2, 3, 2);
            webVideo.Name = "webVideo";
            webVideo.Size = new Size(805, 300);
            webVideo.TabIndex = 1;
            webVideo.ZoomFactor = 1D;
            webVideo.Click += webVideo_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(26, 398);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 38);
            btnBack.TabIndex = 2;
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
            btnHelp.TabIndex = 3;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // RouteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(859, 452);
            Controls.Add(btnHelp);
            Controls.Add(btnBack);
            Controls.Add(webVideo);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RouteView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Θέα διαδρομής";
            ((System.ComponentModel.ISupportInitialize)webVideo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 webVideo;
        private Button btnBack;
        private Button btnHelp;
    }
}