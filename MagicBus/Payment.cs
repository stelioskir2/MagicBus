using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();

            StringBuilder summary = new StringBuilder();
            summary.AppendLine("Καφετέρια: " + CafeOrder.Cafe);
            summary.AppendLine();
            foreach (CartItem item in CafeOrder.Items)
            {
                summary.AppendLine(item.ToString());
            }
            txtSummary.Text = summary.ToString();

            lblTotal.Text = $"Σύνολο: {CafeOrder.Total:0.00} €";
            btnPay.Text = $"Πληρωμή {CafeOrder.Total:0.00} €";
        }

        private void txtDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool allowSpace = sender == txtCardNumber && e.KeyChar == ' ';
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !allowSpace)
            {
                e.Handled = true;
            }
        }

        private void txtExpiry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private bool ValidateCard()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowError("Συμπληρώστε το ονοματεπώνυμο του κατόχου της κάρτας.", txtName);
                return false;
            }

            string cardNumber = txtCardNumber.Text.Replace(" ", "");
            if (cardNumber.Length != 16)
            {
                ShowError("Ο αριθμός κάρτας πρέπει να έχει 16 ψηφία.", txtCardNumber);
                return false;
            }

            string[] expiry = txtExpiry.Text.Split('/');
            if (expiry.Length != 2
                || !int.TryParse(expiry[0], out int month)
                || !int.TryParse(expiry[1], out int year)
                || month < 1 || month > 12
                || expiry[1].Length != 2)
            {
                ShowError("Η ημερομηνία λήξης πρέπει να είναι της μορφής ΜΜ/ΕΕ (π.χ. 08/28).", txtExpiry);
                return false;
            }

            DateTime validUntil = new DateTime(2000 + year, month, 1).AddMonths(1);
            if (validUntil <= DateTime.Today)
            {
                ShowError("Η κάρτα έχει λήξει.", txtExpiry);
                return false;
            }

            if (txtCvv.Text.Length != 3)
            {
                ShowError("Το CVV πρέπει να έχει 3 ψηφία (πίσω όψη της κάρτας).", txtCvv);
                return false;
            }

            return true;
        }

        private void ShowError(string message, TextBox field)
        {
            MessageBox.Show(
                message,
                "Στοιχεία κάρτας",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            field.Focus();
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            if (!ValidateCard())
            {
                return;
            }

            // προσομοιωση πληρωμης
            btnPay.Enabled = false;
            btnBack.Enabled = false;
            btnPay.Text = "Επεξεργασία πληρωμής...";
            await Task.Delay(1500);
            if (IsDisposed)
            {
                return;
            }

            CafeOrder.PlaceOrder();

            MessageBox.Show(
                $"Η πληρωμή των {CafeOrder.Total:0.00} € ολοκληρώθηκε επιτυχώς!\n\n"
                + $"Αριθμός παραγγελίας: #{CafeOrder.OrderNumber}\n\n"
                + $"Η καφετέρια «{CafeOrder.Cafe}» ετοιμάζει την παραγγελία σας "
                + "και θα σας ενημερώσει σε ποια στάση θα σας παραδοθεί.\n\n"
                + "Μπορείτε να την παρακολουθείτε από το «Η παραγγελία μου».",
                "Επιτυχής πληρωμή",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
