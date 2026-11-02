namespace MagicBus
{
    partial class CafeMenu
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
            lblMenu = new Label();
            lstMenu = new ListBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnAdd = new Button();
            lblCart = new Label();
            lstCart = new ListBox();
            btnRemove = new Button();
            lblTotal = new Label();
            btnPay = new Button();
            btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font(
                "Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(922, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Κατάλογος";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblMenu
            lblMenu.AutoSize = false;
            lblMenu.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            lblMenu.Location = new Point(30, 115);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(440, 35);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Προϊόντα";
            lblMenu.TextAlign = ContentAlignment.MiddleLeft;

            // lstMenu
            lstMenu.Font = new Font("Segoe UI", 13.8F);
            lstMenu.FormattingEnabled = true;
            lstMenu.IntegralHeight = false;
            lstMenu.Location = new Point(30, 155);
            lstMenu.Margin = new Padding(3, 2, 3, 2);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(440, 245);
            lstMenu.TabIndex = 2;
            lstMenu.DoubleClick += lstMenu_DoubleClick;

            // lblQuantity
            lblQuantity.AutoSize = false;
            lblQuantity.Font = new Font("Segoe UI", 11F);
            lblQuantity.Location = new Point(30, 430);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(120, 40);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Ποσότητα:";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;

            // numQuantity
            numQuantity.Font = new Font("Segoe UI", 13.8F);
            numQuantity.Location = new Point(155, 435);
            numQuantity.Margin = new Padding(3, 2, 3, 2);
            numQuantity.Maximum =
                new decimal(new int[] { 10, 0, 0, 0 });
            numQuantity.Minimum =
                new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(70, 38);
            numQuantity.TabIndex = 4;
            numQuantity.Value =
                new decimal(new int[] { 1, 0, 0, 0 });

            // btnAdd
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(240, 420);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 70);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Προσθήκη στο καλάθι";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // lblCart
            lblCart.AutoSize = false;
            lblCart.Font = new Font(
                "Segoe UI", 12F, FontStyle.Bold);
            lblCart.Location = new Point(512, 115);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(440, 35);
            lblCart.TabIndex = 6;
            lblCart.Text = "Το καλάθι σας";
            lblCart.TextAlign = ContentAlignment.MiddleLeft;

            // lstCart
            lstCart.Font = new Font("Segoe UI", 12F);
            lstCart.FormattingEnabled = true;
            lstCart.IntegralHeight = false;
            lstCart.Location = new Point(512, 155);
            lstCart.Margin = new Padding(3, 2, 3, 2);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(440, 245);
            lstCart.TabIndex = 7;

            // btnRemove
            btnRemove.Font = new Font("Segoe UI", 12F);
            btnRemove.Location = new Point(512, 420);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(260, 50);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Αφαίρεση προϊόντος";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;

            // lblTotal
            lblTotal.AutoSize = false;
            lblTotal.Font = new Font(
                "Segoe UI", 16.2F, FontStyle.Bold);
            lblTotal.ForeColor = Color.MidnightBlue;
            lblTotal.Location = new Point(512, 475);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(440, 45);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Σύνολο: 0,00 €";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;

            // btnPay
            btnPay.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Right;
            btnPay.BackColor = Color.MidnightBlue;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font(
                "Segoe UI", 13.8F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(632, 525);
            btnPay.Margin = new Padding(3, 2, 3, 2);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(320, 50);
            btnPay.TabIndex = 10;
            btnPay.Text = "Συνέχεια στην πληρωμή";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;

            // btnBack
            btnBack.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(30, 525);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(280, 50);
            btnBack.TabIndex = 11;
            btnBack.Text = "Επιστροφή στις καφετέριες";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // CafeMenu
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(btnBack);
            Controls.Add(btnPay);
            Controls.Add(lblTotal);
            Controls.Add(btnRemove);
            Controls.Add(lstCart);
            Controls.Add(lblCart);
            Controls.Add(btnAdd);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(lstMenu);
            Controls.Add(lblMenu);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CafeMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Κατάλογος καφετέριας";

            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblMenu;
        private ListBox lstMenu;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button btnAdd;
        private Label lblCart;
        private ListBox lstCart;
        private Button btnRemove;
        private Label lblTotal;
        private Button btnPay;
        private Button btnBack;
    }
}