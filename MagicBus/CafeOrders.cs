using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class CafeOrders : Form
    {
        public CafeOrders()
        {
            InitializeComponent();

            foreach (PlacedOrder order in CafeOrder.Orders)
            {
                lstOrders.Items.Add(order);
            }

            if (lstOrders.Items.Count > 0)
            {
                lstOrders.SelectedIndex = 0;
            }
            else
            {
                lblStatus.Text = "Δεν υπάρχουν παραγγελίες ακόμα.";
            }

            UpdateButtons();
        }

        private PlacedOrder? SelectedOrder => lstOrders.SelectedItem as PlacedOrder;

        private void UpdateButtons()
        {
            PlacedOrder? order = SelectedOrder;

            btnPrepare.Enabled = order?.Status == PlacedOrder.StatusNew;
            btnSend.Enabled = order?.Status == PlacedOrder.StatusPreparing;
            cmbStop.Enabled = order?.Status == PlacedOrder.StatusPreparing;
            btnDelivered.Enabled = order?.Status == PlacedOrder.StatusReady;
        }

        private void ShowOrder()
        {
            PlacedOrder? order = SelectedOrder;
            if (order == null)
            {
                return;
            }

            txtDetails.Text = order.Details();
            lblStatus.Text = "Κατάσταση: " + order.Status;
            cmbStop.SelectedItem = order.DeliveryStop;
            UpdateButtons();
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowOrder();
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            PlacedOrder? order = SelectedOrder;
            if (order == null)
            {
                return;
            }

            order.Status = PlacedOrder.StatusPreparing;
            ShowOrder();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            PlacedOrder? order = SelectedOrder;
            if (order == null)
            {
                return;
            }

            if (cmbStop.SelectedItem == null)
            {
                MessageBox.Show(
                    "Επιλέξτε σε ποια στάση θα παραδοθεί η παραγγελία.",
                    "Στάση παράδοσης",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            order.DeliveryStop = cmbStop.SelectedItem.ToString();
            order.Status = PlacedOrder.StatusReady;
            ShowOrder();

            MessageBox.Show(
                $"Ο επιβάτης ενημερώθηκε ότι η παραγγελία #{order.Number} "
                + $"θα παραδοθεί στη στάση «{order.DeliveryStop}».",
                "Ενημέρωση επιβάτη",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            PlacedOrder? order = SelectedOrder;
            if (order == null)
            {
                return;
            }

            order.Status = PlacedOrder.StatusDelivered;
            ShowOrder();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
