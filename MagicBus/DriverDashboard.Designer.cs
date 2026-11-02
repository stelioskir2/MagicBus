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
            btnSafety = new Button();
            btnDoors = new Button();
            SuspendLayout();

            // btnClimate
            btnClimate.BackColor = Color.MidnightBlue;
            btnClimate.FlatStyle = FlatStyle.Flat;
            btnClimate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClimate.ForeColor = Color.White;
            btnClimate.Location = new Point(130, 170);
            btnClimate.Margin = new Padding(3, 4, 3, 4);
            btnClimate.Name = "btnClimate";
            btnClimate.Size = new Size(320, 90);
            btnClimate.TabIndex = 0;
            btnClimate.Text = "Έλεγχος Κλιματισμού";
            btnClimate.UseVisualStyleBackColor = false;
            btnClimate.Click += btnClimate_Click;

            // btnWeatherRoof
            btnWeatherRoof.BackColor = Color.MidnightBlue;
            btnWeatherRoof.FlatStyle = FlatStyle.Flat;
            btnWeatherRoof.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnWeatherRoof.ForeColor = Color.White;
            btnWeatherRoof.Location = new Point(532, 170);
            btnWeatherRoof.Margin = new Padding(3, 4, 3, 4);
            btnWeatherRoof.Name = "btnWeatherRoof";
            btnWeatherRoof.Size = new Size(320, 90);
            btnWeatherRoof.TabIndex = 1;
            btnWeatherRoof.Text = "Καιρός && Οροφή";
            btnWeatherRoof.UseVisualStyleBackColor = false;
            btnWeatherRoof.Click += btnWeatherRoof_Click;

            // btnSafety
            btnSafety.BackColor = Color.MidnightBlue;
            btnSafety.FlatStyle = FlatStyle.Flat;
            btnSafety.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSafety.ForeColor = Color.White;
            btnSafety.Location = new Point(130, 300);
            btnSafety.Margin = new Padding(3, 4, 3, 4);
            btnSafety.Name = "btnSafety";
            btnSafety.Size = new Size(320, 90);
            btnSafety.TabIndex = 2;
            btnSafety.Text = "Ειδοποιήσεις Οδήγησης";
            btnSafety.UseVisualStyleBackColor = false;
            btnSafety.Click += btnSafety_Click;

            // btnDoors
            btnDoors.BackColor = Color.MidnightBlue;
            btnDoors.FlatStyle = FlatStyle.Flat;
            btnDoors.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDoors.ForeColor = Color.White;
            btnDoors.Location = new Point(532, 300);
            btnDoors.Margin = new Padding(3, 4, 3, 4);
            btnDoors.Name = "btnDoors";
            btnDoors.Size = new Size(320, 90);
            btnDoors.TabIndex = 3;
            btnDoors.Text = "Αποβίβαση / Πόρτες";
            btnDoors.UseVisualStyleBackColor = false;
            btnDoors.Click += btnDoors_Click;

            // btnBack
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 525);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 50);
            btnBack.TabIndex = 4;
            btnBack.Text = "Επιστροφή στην επιλογή ρόλου";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // label1
            label1.AutoSize = false;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(922, 70);
            label1.TabIndex = 5;
            label1.Text = "Πίνακας Ελέγχου Οδηγού";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // lblFoundItems
            lblFoundItems.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold,
                GraphicsUnit.Point, 161);
            lblFoundItems.ForeColor = Color.MidnightBlue;
            lblFoundItems.Location = new Point(130, 420);
            lblFoundItems.Name = "lblFoundItems";
            lblFoundItems.Size = new Size(722, 70);
            lblFoundItems.TabIndex = 6;
            lblFoundItems.Text = "Σημερινά ευρήματα: 0";
            lblFoundItems.TextAlign = ContentAlignment.MiddleCenter;

            // DriverDashboard
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(lblFoundItems);
            Controls.Add(btnDoors);
            Controls.Add(btnSafety);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnWeatherRoof);
            Controls.Add(btnClimate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DriverDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MagicBus - Πίνακας Ελέγχου Οδηγού";
            Load += DriverDashboard_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnClimate;
        private System.Windows.Forms.Button btnWeatherRoof;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private Label lblFoundItems;
        private Button btnSafety;
        private Button btnDoors;
    }
}