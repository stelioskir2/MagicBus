using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class CafeMenu : Form
    {
        public CafeMenu()
        {
            InitializeComponent();
        }

        public CafeMenu(string cafe) : this()
        {
            lblTitle.Text = "Κατάλογος — " + cafe;

            if (CafeOrder.Cafe != cafe || CafeOrder.OrderNumber != null)
            {
                CafeOrder.Start(cafe);
            }

            CafeProduct[] products = cafe switch
            {
                "Καφέ Λευκός Πύργος" => new[]
                {
                    new CafeProduct("Espresso", 2.50m),
                    new CafeProduct("Freddo Espresso", 3.00m),
                    new CafeProduct("Cappuccino", 3.20m),
                    new CafeProduct("Σοκολάτα", 3.50m),
                    new CafeProduct("Κρουασάν βουτύρου", 1.50m),
                    new CafeProduct("Muffin σοκολάτας", 2.30m)
                },

                "Αριστοτέλους Coffee" => new[]
                {
                    new CafeProduct("Filter coffee", 2.80m),
                    new CafeProduct("Freddo Cappuccino", 3.50m),
                    new CafeProduct("Φυσικός χυμός πορτοκάλι", 3.80m),
                    new CafeProduct("Αναψυκτικό", 2.00m),
                    new CafeProduct("Νερό 500ml", 0.50m),
                    new CafeProduct("Τοστ γαλοπούλα", 3.00m)
                },

                "Bougatsa Ροτόντα" => new[]
                {
                    new CafeProduct("Μπουγάτσα με κρέμα", 3.00m),
                    new CafeProduct("Μπουγάτσα με τυρί", 3.00m),
                    new CafeProduct("Τυρόπιτα", 2.20m),
                    new CafeProduct("Ελληνικός καφές", 2.00m),
                    new CafeProduct("Τσάι του βουνού", 2.00m),
                    new CafeProduct("Αναψυκτικό", 2.00m)
                },

                _ => Array.Empty<CafeProduct>()
            };

            lstMenu.Items.AddRange(products);
            RefreshCart();
        }

        private void RefreshCart()
        {
            lstCart.Items.Clear();
            foreach (CartItem item in CafeOrder.Items)
            {
                lstCart.Items.Add(item);
            }

            lblTotal.Text = $"Σύνολο: {CafeOrder.Total:0.00} €";
            btnPay.Enabled = CafeOrder.Items.Count > 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem is not CafeProduct product)
            {
                MessageBox.Show(
                    "Επιλέξτε πρώτα ένα προϊόν από τον κατάλογο.",
                    "Προσθήκη στο καλάθι",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            CafeOrder.Add(product.Name, product.Price, (int)numQuantity.Value);
            numQuantity.Value = 1;
            RefreshCart();
        }

        private void lstMenu_DoubleClick(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItem is not CartItem item)
            {
                MessageBox.Show(
                    "Επιλέξτε πρώτα ένα προϊόν από το καλάθι.",
                    "Αφαίρεση από το καλάθι",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            CafeOrder.Items.Remove(item);
            RefreshCart();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            using Payment payment = new Payment();
            if (payment.ShowDialog(this) == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
