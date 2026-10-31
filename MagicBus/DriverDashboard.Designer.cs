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
            lblFoundItems = new Label();
            SuspendLayout();
            // 
            // btnClimate
            // 
            btnClimate.BackColor = Color.MidnightBlue;
            btnClimate.FlatStyle = FlatStyle.Flat;
            btnClimate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClimate.ForeColor = Color.White;
            btnClimate.Location = new Point(397, 271);
            btnClimate.Margin = new Padding(3, 4, 3, 4);
            btnClimate.Name = "btnClimate";
            btnClimate.Size = new Size(320, 93);
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
            btnWeatherRoof.Location = new Point(397, 405);
            btnWeatherRoof.Margin = new Padding(3, 4, 3, 4);
            btnWeatherRoof.Name = "btnWeatherRoof";
            btnWeatherRoof.Size = new Size(320, 93);
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
            btnBack.Location = new Point(14, 695);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(217, 65);
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
            label1.Location = new Point(359, 180);
            label1.Name = "label1";
            label1.Size = new Size(433, 46);
            label1.TabIndex = 3;
            label1.Text = "Πίνακας Ελέγχου Οδηγού";
            // 
            // lblFoundItems
            // 
            lblFoundItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblFoundItems.ForeColor = Color.MidnightBlue;
            lblFoundItems.Location = new Point(395, 520);
            lblFoundItems.Name = "lblFoundItems";
            lblFoundItems.Size = new Size(400, 100);
            lblFoundItems.TabIndex = 4;
            lblFoundItems.Text = "Σημερινά ευρήματα: 0";
            lblFoundItems.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DriverDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 815);
            Controls.Add(lblFoundItems);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnWeatherRoof);
            Controls.Add(btnClimate);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblFoundItems;
    }
}