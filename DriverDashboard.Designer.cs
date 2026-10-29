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
            this.btnClimate = new System.Windows.Forms.Button();
            this.btnWeatherRoof = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClimate
            // 
            this.btnClimate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClimate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClimate.ForeColor = System.Drawing.Color.White;
            this.btnClimate.Location = new System.Drawing.Point(260, 140);
            this.btnClimate.Name = "btnClimate";
            this.btnClimate.Size = new System.Drawing.Size(280, 70);
            this.btnClimate.TabIndex = 0;
            this.btnClimate.Text = "Έλεγχος Κλιματισμού";
            this.btnClimate.UseVisualStyleBackColor = false;
            this.btnClimate.Click += new System.EventHandler(this.btnClimate_Click);
            // 
            // btnWeatherRoof
            // 
            this.btnWeatherRoof.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnWeatherRoof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeatherRoof.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnWeatherRoof.ForeColor = System.Drawing.Color.White;
            this.btnWeatherRoof.Location = new System.Drawing.Point(260, 230);
            this.btnWeatherRoof.Name = "btnWeatherRoof";
            this.btnWeatherRoof.Size = new System.Drawing.Size(280, 70);
            this.btnWeatherRoof.TabIndex = 1;
            this.btnWeatherRoof.Text = "Καιρός && Οροφή";
            this.btnWeatherRoof.UseVisualStyleBackColor = false;
            this.btnWeatherRoof.Click += new System.EventHandler(this.btnWeatherRoof_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(260, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(280, 70);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Επιστροφή";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(235, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Πίνακας Ελέγχου Οδηγού";
            // 
            // DriverDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWeatherRoof);
            this.Controls.Add(this.btnClimate);
            this.Name = "DriverDashboard";
            this.Text = "MagicBus - Πίνακας Ελέγχου Οδηγού";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnClimate;
        private System.Windows.Forms.Button btnWeatherRoof;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}