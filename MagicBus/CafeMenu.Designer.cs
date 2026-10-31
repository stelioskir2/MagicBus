namespace MagicBus
{
    partial class CafeMenu
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
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Κατάλογος";
            //
            // lblMenu
            //
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblMenu.Location = new Point(30, 85);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(98, 28);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Προϊόντα";
            //
            // lstMenu
            //
            lstMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(30, 120);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(420, 283);
            lstMenu.TabIndex = 2;
            lstMenu.DoubleClick += lstMenu_DoubleClick;
            //
            // lblQuantity
            //
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lblQuantity.Location = new Point(30, 432);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(97, 28);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Ποσότητα:";
            //
            // numQuantity
            //
            numQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            numQuantity.Location = new Point(140, 427);
            numQuantity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(70, 38);
            numQuantity.TabIndex = 4;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(230, 420);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 50);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Προσθήκη στο καλάθι";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // lblCart
            //
            lblCart.AutoSize = true;
            lblCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblCart.Location = new Point(510, 85);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(148, 28);
            lblCart.TabIndex = 6;
            lblCart.Text = "Το καλάθι σας";
            //
            // lstCart
            //
            lstCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            lstCart.FormattingEnabled = true;
            lstCart.Location = new Point(510, 120);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(440, 228);
            lstCart.TabIndex = 7;
            //
            // btnRemove
            //
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnRemove.Location = new Point(510, 360);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(220, 45);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Αφαίρεση προϊόντος";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            lblTotal.ForeColor = Color.MidnightBlue;
            lblTotal.Location = new Point(510, 425);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(206, 38);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Σύνολο: 0,00 €";
            //
            // btnPay
            //
            btnPay.BackColor = Color.MidnightBlue;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(650, 520);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(300, 60);
            btnPay.TabIndex = 10;
            btnPay.Text = "Συνέχεια στην πληρωμή";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            //
            // btnBack
            //
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            btnBack.Location = new Point(30, 530);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(260, 50);
            btnBack.TabIndex = 11;
            btnBack.Text = "Επιστροφή στις καφετέριες";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // CafeMenu
            //
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
            Name = "CafeMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MagicBus — Κατάλογος καφετέριας";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
