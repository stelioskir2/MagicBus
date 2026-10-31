namespace MagicBus
{
    partial class WeatherAndRoof
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
            lblTitle = new Label();
            lblWeatherTitle = new Label();
            lblWeatherInfo = new Label();
            lblFeelsLike = new Label();
            lblHumidity = new Label();
            lblPollen = new Label();
            lblVisibility = new Label();
            lblSunSet = new Label();
            lblRoofTitle = new Label();
            btnRoofOpen = new Button();
            btnRoofClose = new Button();
            lblRoofStatus = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(330, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(338, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Καιρός & Έλεγχος Οροφής";
            // 
            // lblWeatherTitle
            // 
            lblWeatherTitle.AutoSize = true;
            lblWeatherTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWeatherTitle.ForeColor = Color.DarkSlateGray;
            lblWeatherTitle.Location = new Point(80, 100);
            lblWeatherTitle.Name = "lblWeatherTitle";
            lblWeatherTitle.Size = new Size(182, 30);
            lblWeatherTitle.TabIndex = 1;
            lblWeatherTitle.Text = "Στοιχεία Καιρού";
            // 
            // lblWeatherInfo
            // 
            lblWeatherInfo.AutoSize = true;
            lblWeatherInfo.Font = new Font("Segoe UI", 12F);
            lblWeatherInfo.Location = new Point(80, 150);
            lblWeatherInfo.Name = "lblWeatherInfo";
            lblWeatherInfo.Size = new Size(224, 21);
            lblWeatherInfo.TabIndex = 2;
            lblWeatherInfo.Text = "Εξωτερική Θερμοκρασία: 24°C";
            // 
            // lblFeelsLike
            // 
            lblFeelsLike.AutoSize = true;
            lblFeelsLike.Font = new Font("Segoe UI", 12F);
            lblFeelsLike.Location = new Point(80, 190);
            lblFeelsLike.Name = "lblFeelsLike";
            lblFeelsLike.Size = new Size(217, 21);
            lblFeelsLike.TabIndex = 3;
            lblFeelsLike.Text = "Αίσθηση Θερμοκρασίας: 26°C";
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Font = new Font("Segoe UI", 12F);
            lblHumidity.Location = new Point(80, 230);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(107, 21);
            lblHumidity.TabIndex = 4;
            lblHumidity.Text = "Υγρασία: 45%";
            // 
            // lblPollen
            // 
            lblPollen.AutoSize = true;
            lblPollen.Font = new Font("Segoe UI", 12F);
            lblPollen.Location = new Point(80, 270);
            lblPollen.Name = "lblPollen";
            lblPollen.Size = new Size(168, 21);
            lblPollen.TabIndex = 5;
            lblPollen.Text = "Φορτίο Γύρης: Χαμηλό";
            // 
            // lblVisibility
            // 
            lblVisibility.AutoSize = true;
            lblVisibility.Font = new Font("Segoe UI", 12F);
            lblVisibility.Location = new Point(80, 310);
            lblVisibility.Name = "lblVisibility";
            lblVisibility.Size = new Size(149, 21);
            lblVisibility.TabIndex = 6;
            lblVisibility.Text = "Ορατότητα: Άριστη";
            // 
            // lblSunSet
            // 
            lblSunSet.AutoSize = true;
            lblSunSet.Font = new Font("Segoe UI", 12F);
            lblSunSet.Location = new Point(80, 350);
            lblSunSet.Name = "lblSunSet";
            lblSunSet.Size = new Size(181, 21);
            lblSunSet.TabIndex = 7;
            lblSunSet.Text = "Ώρα Δύσης Ηλίου: 20:30";
            // 
            // lblRoofTitle
            // 
            lblRoofTitle.AutoSize = true;
            lblRoofTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRoofTitle.ForeColor = Color.DarkSlateGray;
            lblRoofTitle.Location = new Point(580, 100);
            lblRoofTitle.Name = "lblRoofTitle";
            lblRoofTitle.Size = new Size(324, 30);
            lblRoofTitle.TabIndex = 8;
            lblRoofTitle.Text = "Έλεγχος Οροφής Λεωφορείου";
            // 
            // btnRoofOpen
            // 
            btnRoofOpen.BackColor = Color.ForestGreen;
            btnRoofOpen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRoofOpen.ForeColor = Color.White;
            btnRoofOpen.Location = new Point(580, 150);
            btnRoofOpen.Name = "btnRoofOpen";
            btnRoofOpen.Size = new Size(140, 50);
            btnRoofOpen.TabIndex = 9;
            btnRoofOpen.Text = "Άνοιγμα Οροφής";
            btnRoofOpen.UseVisualStyleBackColor = false;
            btnRoofOpen.Click += btnRoofOpen_Click;
            // 
            // btnRoofClose
            // 
            btnRoofClose.BackColor = Color.Firebrick;
            btnRoofClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRoofClose.ForeColor = Color.White;
            btnRoofClose.Location = new Point(740, 150);
            btnRoofClose.Name = "btnRoofClose";
            btnRoofClose.Size = new Size(140, 50);
            btnRoofClose.TabIndex = 10;
            btnRoofClose.Text = "Κλείσιμο Οροφής";
            btnRoofClose.UseVisualStyleBackColor = false;
            btnRoofClose.Click += btnRoofClose_Click;
            // 
            // lblRoofStatus
            // 
            lblRoofStatus.AutoSize = true;
            lblRoofStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRoofStatus.ForeColor = Color.Firebrick;
            lblRoofStatus.Location = new Point(630, 225);
            lblRoofStatus.Name = "lblRoofStatus";
            lblRoofStatus.Size = new Size(232, 21);
            lblRoofStatus.TabIndex = 11;
            lblRoofStatus.Text = "Κατάσταση Οροφής: Κλειστή";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(12, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 51);
            btnBack.TabIndex = 12;
            btnBack.Text = "Επιστροφή στον 'Ελεγχο Οδηγού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // WeatherAndRoof
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnBack);
            Controls.Add(lblRoofStatus);
            Controls.Add(btnRoofClose);
            Controls.Add(btnRoofOpen);
            Controls.Add(lblRoofTitle);
            Controls.Add(lblSunSet);
            Controls.Add(lblVisibility);
            Controls.Add(lblPollen);
            Controls.Add(lblHumidity);
            Controls.Add(lblFeelsLike);
            Controls.Add(lblWeatherInfo);
            Controls.Add(lblWeatherTitle);
            Controls.Add(lblTitle);
            Name = "WeatherAndRoof";
            Text = "Καιρός & Οροφή - MagicBus";
            Load += WeatherAndRoof_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWeatherTitle;
        private Label lblWeatherInfo;
        private Label lblFeelsLike;
        private Label lblHumidity;
        private Label lblPollen;
        private Label lblVisibility;
        private Label lblSunSet;
        private Label lblRoofTitle;
        private Button btnRoofOpen;
        private Button btnRoofClose;
        private Label lblRoofStatus;
        private Button btnBack;
    }
}