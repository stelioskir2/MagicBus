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
            cmbWeather = new ComboBox();
            lblWeatherScenario = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(377, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(454, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Καιρός && Έλεγχος Οροφής";
            // 
            // lblWeatherTitle
            // 
            lblWeatherTitle.AutoSize = true;
            lblWeatherTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWeatherTitle.ForeColor = Color.DarkSlateGray;
            lblWeatherTitle.Location = new Point(91, 133);
            lblWeatherTitle.Name = "lblWeatherTitle";
            lblWeatherTitle.Size = new Size(228, 37);
            lblWeatherTitle.TabIndex = 1;
            lblWeatherTitle.Text = "Στοιχεία Καιρού";
            // 
            // lblWeatherInfo
            // 
            lblWeatherInfo.AutoSize = true;
            lblWeatherInfo.Font = new Font("Segoe UI", 12F);
            lblWeatherInfo.Location = new Point(91, 200);
            lblWeatherInfo.Name = "lblWeatherInfo";
            lblWeatherInfo.Size = new Size(284, 28);
            lblWeatherInfo.TabIndex = 2;
            lblWeatherInfo.Text = "Εξωτερική Θερμοκρασία: 24°C";
            // 
            // lblFeelsLike
            // 
            lblFeelsLike.AutoSize = true;
            lblFeelsLike.Font = new Font("Segoe UI", 12F);
            lblFeelsLike.Location = new Point(91, 253);
            lblFeelsLike.Name = "lblFeelsLike";
            lblFeelsLike.Size = new Size(278, 28);
            lblFeelsLike.TabIndex = 3;
            lblFeelsLike.Text = "Αίσθηση Θερμοκρασίας: 26°C";
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Font = new Font("Segoe UI", 12F);
            lblHumidity.Location = new Point(91, 307);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(133, 28);
            lblHumidity.TabIndex = 4;
            lblHumidity.Text = "Υγρασία: 45%";
            // 
            // lblPollen
            // 
            lblPollen.AutoSize = true;
            lblPollen.Font = new Font("Segoe UI", 12F);
            lblPollen.Location = new Point(91, 360);
            lblPollen.Name = "lblPollen";
            lblPollen.Size = new Size(215, 28);
            lblPollen.TabIndex = 5;
            lblPollen.Text = "Φορτίο Γύρης: Χαμηλό";
            // 
            // lblVisibility
            // 
            lblVisibility.AutoSize = true;
            lblVisibility.Font = new Font("Segoe UI", 12F);
            lblVisibility.Location = new Point(91, 413);
            lblVisibility.Name = "lblVisibility";
            lblVisibility.Size = new Size(190, 28);
            lblVisibility.TabIndex = 6;
            lblVisibility.Text = "Ορατότητα: Άριστη";
            // 
            // lblSunSet
            // 
            lblSunSet.AutoSize = true;
            lblSunSet.Font = new Font("Segoe UI", 12F);
            lblSunSet.Location = new Point(91, 467);
            lblSunSet.Name = "lblSunSet";
            lblSunSet.Size = new Size(229, 28);
            lblSunSet.TabIndex = 7;
            lblSunSet.Text = "Ώρα Δύσης Ηλίου: 20:30";
            // 
            // lblRoofTitle
            // 
            lblRoofTitle.AutoSize = true;
            lblRoofTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRoofTitle.ForeColor = Color.DarkSlateGray;
            lblRoofTitle.Location = new Point(663, 133);
            lblRoofTitle.Name = "lblRoofTitle";
            lblRoofTitle.Size = new Size(404, 37);
            lblRoofTitle.TabIndex = 8;
            lblRoofTitle.Text = "Έλεγχος Οροφής Λεωφορείου";
            // 
            // btnRoofOpen
            // 
            btnRoofOpen.BackColor = Color.ForestGreen;
            btnRoofOpen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRoofOpen.ForeColor = Color.White;
            btnRoofOpen.Location = new Point(663, 200);
            btnRoofOpen.Margin = new Padding(3, 4, 3, 4);
            btnRoofOpen.Name = "btnRoofOpen";
            btnRoofOpen.Size = new Size(160, 67);
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
            btnRoofClose.Location = new Point(846, 200);
            btnRoofClose.Margin = new Padding(3, 4, 3, 4);
            btnRoofClose.Name = "btnRoofClose";
            btnRoofClose.Size = new Size(160, 67);
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
            lblRoofStatus.Location = new Point(720, 300);
            lblRoofStatus.Name = "lblRoofStatus";
            lblRoofStatus.Size = new Size(290, 28);
            lblRoofStatus.TabIndex = 11;
            lblRoofStatus.Text = "Κατάσταση Οροφής: Κλειστή";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(14, 695);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(217, 68);
            btnBack.TabIndex = 12;
            btnBack.Text = "Επιστροφή στον 'Ελεγχο Οδηγού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbWeather
            // 
            cmbWeather.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeather.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            cmbWeather.FormattingEnabled = true;
            cmbWeather.Location = new Point(91, 560);
            cmbWeather.Name = "cmbWeather";
            cmbWeather.Size = new Size(300, 36);
            cmbWeather.TabIndex = 13;
            // 
            // lblWeatherScenario
            // 
            lblWeatherScenario.AutoSize = true;
            lblWeatherScenario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblWeatherScenario.Location = new Point(91, 520);
            lblWeatherScenario.Name = "lblWeatherScenario";
            lblWeatherScenario.Size = new Size(234, 28);
            lblWeatherScenario.TabIndex = 14;
            lblWeatherScenario.Text = "Καιρός — προσομοίωση";
            // 
            // WeatherAndRoof
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 815);
            Controls.Add(lblWeatherScenario);
            Controls.Add(cmbWeather);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox cmbWeather;
        private Label lblWeatherScenario;
    }
}