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

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(922, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Καιρός && Έλεγχος Οροφής";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblWeatherTitle
            lblWeatherTitle.AutoSize = false;
            lblWeatherTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWeatherTitle.ForeColor = Color.DarkSlateGray;
            lblWeatherTitle.Location = new Point(45, 130);
            lblWeatherTitle.Name = "lblWeatherTitle";
            lblWeatherTitle.Size = new Size(440, 45);
            lblWeatherTitle.TabIndex = 1;
            lblWeatherTitle.Text = "Στοιχεία Καιρού";
            lblWeatherTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblWeatherInfo
            lblWeatherInfo.AutoSize = false;
            lblWeatherInfo.Font = new Font("Segoe UI", 12F);
            lblWeatherInfo.Location = new Point(45, 185);
            lblWeatherInfo.Name = "lblWeatherInfo";
            lblWeatherInfo.Size = new Size(440, 36);
            lblWeatherInfo.TabIndex = 2;
            lblWeatherInfo.Text = "Εξωτερική Θερμοκρασία: 24°C";
            lblWeatherInfo.TextAlign = ContentAlignment.MiddleLeft;

            // lblFeelsLike
            lblFeelsLike.AutoSize = false;
            lblFeelsLike.Font = new Font("Segoe UI", 12F);
            lblFeelsLike.Location = new Point(45, 225);
            lblFeelsLike.Name = "lblFeelsLike";
            lblFeelsLike.Size = new Size(440, 36);
            lblFeelsLike.TabIndex = 3;
            lblFeelsLike.Text = "Αίσθηση Θερμοκρασίας: 26°C";
            lblFeelsLike.TextAlign = ContentAlignment.MiddleLeft;

            // lblHumidity
            lblHumidity.AutoSize = false;
            lblHumidity.Font = new Font("Segoe UI", 12F);
            lblHumidity.Location = new Point(45, 265);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(440, 36);
            lblHumidity.TabIndex = 4;
            lblHumidity.Text = "Υγρασία: 45%";
            lblHumidity.TextAlign = ContentAlignment.MiddleLeft;

            // lblPollen
            lblPollen.AutoSize = false;
            lblPollen.Font = new Font("Segoe UI", 12F);
            lblPollen.Location = new Point(45, 305);
            lblPollen.Name = "lblPollen";
            lblPollen.Size = new Size(440, 36);
            lblPollen.TabIndex = 5;
            lblPollen.Text = "Φορτίο Γύρης: Χαμηλό";
            lblPollen.TextAlign = ContentAlignment.MiddleLeft;

            // lblVisibility
            lblVisibility.AutoSize = false;
            lblVisibility.Font = new Font("Segoe UI", 12F);
            lblVisibility.Location = new Point(45, 345);
            lblVisibility.Name = "lblVisibility";
            lblVisibility.Size = new Size(440, 36);
            lblVisibility.TabIndex = 6;
            lblVisibility.Text = "Ορατότητα: Καλή";
            lblVisibility.TextAlign = ContentAlignment.MiddleLeft;

            // lblSunSet
            lblSunSet.AutoSize = false;
            lblSunSet.Font = new Font("Segoe UI", 12F);
            lblSunSet.Location = new Point(45, 385);
            lblSunSet.Name = "lblSunSet";
            lblSunSet.Size = new Size(440, 36);
            lblSunSet.TabIndex = 7;
            lblSunSet.Text = "Ώρα Δύσης Ηλίου: 20:30";
            lblSunSet.TextAlign = ContentAlignment.MiddleLeft;

            // lblRoofTitle
            lblRoofTitle.AutoSize = false;
            lblRoofTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRoofTitle.ForeColor = Color.DarkSlateGray;
            lblRoofTitle.Location = new Point(525, 130);
            lblRoofTitle.Name = "lblRoofTitle";
            lblRoofTitle.Size = new Size(412, 65);
            lblRoofTitle.TabIndex = 8;
            lblRoofTitle.Text = "Έλεγχος Οροφής Λεωφορείου";
            lblRoofTitle.TextAlign = ContentAlignment.MiddleCenter;

            // btnRoofOpen
            btnRoofOpen.BackColor = Color.ForestGreen;
            btnRoofOpen.FlatStyle = FlatStyle.Flat;
            btnRoofOpen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRoofOpen.ForeColor = Color.White;
            btnRoofOpen.Location = new Point(535, 220);
            btnRoofOpen.Margin = new Padding(3, 4, 3, 4);
            btnRoofOpen.Name = "btnRoofOpen";
            btnRoofOpen.Size = new Size(180, 75);
            btnRoofOpen.TabIndex = 1;
            btnRoofOpen.Text = "Άνοιγμα\nΟροφής";
            btnRoofOpen.UseVisualStyleBackColor = false;
            btnRoofOpen.Click += btnRoofOpen_Click;

            // btnRoofClose
            btnRoofClose.BackColor = Color.Firebrick;
            btnRoofClose.FlatStyle = FlatStyle.Flat;
            btnRoofClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRoofClose.ForeColor = Color.White;
            btnRoofClose.Location = new Point(745, 220);
            btnRoofClose.Margin = new Padding(3, 4, 3, 4);
            btnRoofClose.Name = "btnRoofClose";
            btnRoofClose.Size = new Size(180, 75);
            btnRoofClose.TabIndex = 2;
            btnRoofClose.Text = "Κλείσιμο\nΟροφής";
            btnRoofClose.UseVisualStyleBackColor = false;
            btnRoofClose.Click += btnRoofClose_Click;

            // lblRoofStatus
            lblRoofStatus.AutoSize = false;
            lblRoofStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRoofStatus.ForeColor = Color.Firebrick;
            lblRoofStatus.Location = new Point(525, 320);
            lblRoofStatus.Name = "lblRoofStatus";
            lblRoofStatus.Size = new Size(412, 70);
            lblRoofStatus.TabIndex = 11;
            lblRoofStatus.Text = "Κατάσταση Οροφής: Κλειστή";
            lblRoofStatus.TextAlign = ContentAlignment.MiddleCenter;

            // btnBack
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(30, 525);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 50);
            btnBack.TabIndex = 3;
            btnBack.Text = "Επιστροφή στον πίνακα οδηγού";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // cmbWeather
            cmbWeather.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeather.Font = new Font(
                "Segoe UI", 12F, FontStyle.Regular,
                GraphicsUnit.Point, 161);
            cmbWeather.FormattingEnabled = true;
            cmbWeather.Location = new Point(45, 475);
            cmbWeather.Name = "cmbWeather";
            cmbWeather.Size = new Size(300, 36);
            cmbWeather.TabIndex = 0;

            // lblWeatherScenario
            lblWeatherScenario.AutoSize = false;
            lblWeatherScenario.Font = new Font(
                "Segoe UI", 12F, FontStyle.Regular,
                GraphicsUnit.Point, 161);
            lblWeatherScenario.Location = new Point(45, 435);
            lblWeatherScenario.Name = "lblWeatherScenario";
            lblWeatherScenario.Size = new Size(440, 36);
            lblWeatherScenario.TabIndex = 14;
            lblWeatherScenario.Text = "Καιρός — προσομοίωση";
            lblWeatherScenario.TextAlign = ContentAlignment.MiddleLeft;

            // WeatherAndRoof
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Καιρός & Οροφή - MagicBus";
            Load += WeatherAndRoof_Load;
            ResumeLayout(false);
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