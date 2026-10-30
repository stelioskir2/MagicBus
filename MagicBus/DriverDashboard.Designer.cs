namespace MagicBus
{
    partial class DriverDashboard
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
            btnClimate = new Button();
            btnWeatherRoof = new Button();
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClimate
            // 
            btnClimate.BackColor = Color.MidnightBlue;
            btnClimate.FlatStyle = FlatStyle.Flat;
            btnClimate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClimate.ForeColor = Color.White;
            btnClimate.Location = new Point(347, 203);
            btnClimate.Name = "btnClimate";
            btnClimate.Size = new Size(280, 70);
            btnClimate.TabIndex = 0;
            btnClimate.Text = "Έλεγχος Κλιματισμού";
            btnClimate.UseVisualStyleBackColor = false;
            btnClimate.Click += btnClimate_Click;
            // 
            // btnWeatherRoof
            // 
            btnWeatherRoof.BackColor = Color.MidnightBlue;
            btnWeatherRoof.FlatStyle = FlatStyle.Flat;
            btnWeatherRoof.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnWeatherRoof.ForeColor = Color.White;
            btnWeatherRoof.Location = new Point(347, 304);
            btnWeatherRoof.Name = "btnWeatherRoof";
            btnWeatherRoof.Size = new Size(280, 70);
            btnWeatherRoof.TabIndex = 1;
            btnWeatherRoof.Text = "Καιρός && Οροφή";
            btnWeatherRoof.UseVisualStyleBackColor = false;
            btnWeatherRoof.Click += btnWeatherRoof_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(12, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 49);
            btnBack.TabIndex = 2;
            btnBack.Text = "Επιστροφή στον έλεγχο προσωπικού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(314, 135);
            label1.Name = "label1";
            label1.Size = new Size(346, 37);
            label1.TabIndex = 3;
            label1.Text = "Πίνακας Ελέγχου Οδηγού";
            // 
            // DriverDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnWeatherRoof);
            Controls.Add(btnClimate);
            Name = "DriverDashboard";
            Text = "MagicBus - Πίνακας Ελέγχου Οδηγού";
            Load += DriverDashboard_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnClimate;
        private System.Windows.Forms.Button btnWeatherRoof;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}