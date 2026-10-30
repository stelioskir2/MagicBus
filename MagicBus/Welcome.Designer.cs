namespace MagicBus
{
    partial class Welcome
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
            label1 = new Label();
            btnStart = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(227, 150);
            label1.Name = "label1";
            label1.Size = new Size(514, 45);
            label1.TabIndex = 0;
            label1.Text = "Kαλώς ορίσατε στο Magic Bus!";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.MidnightBlue;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(335, 252);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(280, 80);
            btnStart.TabIndex = 1;
            btnStart.Text = "Εκκίνηση";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Control;
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(12, 521);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 45);
            btnExit.TabIndex = 2;
            btnExit.Text = "Κλείσιμο εφαρμογής";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Name = "Welcome";
            Text = "Καλώς ορίσατε - MagicBus";
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button btnExit;
    }
}