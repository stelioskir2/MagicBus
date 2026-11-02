namespace MagicBus
{
    partial class Welcome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            btnStart = new Button();
            btnExit = new Button();
            SuspendLayout();

            // label1
            label1.AutoSize = false;
            label1.Font = new Font(
                "Segoe UI Black",
                24F,
                FontStyle.Bold | FontStyle.Italic,
                GraphicsUnit.Point,
                0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(30, 140);
            label1.Name = "label1";
            label1.Size = new Size(922, 100);
            label1.TabIndex = 0;
            label1.Text = "Καλώς ορίσατε στο Magic Bus!";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // btnStart
            btnStart.BackColor = Color.MidnightBlue;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(331, 285);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(320, 90);
            btnStart.TabIndex = 1;
            btnStart.Text = "Εκκίνηση";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;

            // btnExit
            btnExit.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = SystemColors.Control;
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(30, 525);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(280, 50);
            btnExit.TabIndex = 2;
            btnExit.Text = "Κλείσιμο εφαρμογής";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            // Welcome
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Καλώς ορίσατε - MagicBus";
            Load += Welcome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button btnExit;
    }
}