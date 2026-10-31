using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class OrderTracking : Form
    {
        public OrderTracking()
        {
            InitializeComponent();
            LoadOrders();

            if (lstOrders.Items.Count > 0)
            {
                lstOrders.SelectedIndex = lstOrders.Items.Count - 1;
            }
            else
            {
                lblStatus.Text = "Δεν έχετε κάνει ακόμα παραγγελία.";
                lblStop.Text = "Μπορείτε να παραγγείλετε από το «Παραγγελία από καφετέρια».";
            }

            timerRefresh.Start();
        }

        private void LoadOrders()
        {
            for (int i = lstOrders.Items.Count; i < CafeOrder.Orders.Count; i++)
            {
                lstOrders.Items.Add(CafeOrder.Orders[i]);
            }
        }

        private void ShowOrder()
        {
            if (lstOrders.SelectedItem is not PlacedOrder order)
            {
                return;
            }

            txtDetails.Text = order.Details();
            lblStatus.Text = "Κατάσταση: " + order.Status;

            prgStatus.Value = order.Status switch
            {
                PlacedOrder.StatusPreparing => 1,
                PlacedOrder.StatusReady => 2,
                PlacedOrder.StatusDelivered => 3,
                _ => 0
            };

            if (order.Status == PlacedOrder.StatusDelivered)
            {
                lblStop.Text = $"Η παραγγελία παραδόθηκε στη στάση «{order.DeliveryStop}». Καλή απόλαυση!";
            }
            else if (order.DeliveryStop != null)
            {
                lblStop.Text = $"Θα παραλάβετε την παραγγελία σας στη στάση «{order.DeliveryStop}».";
            }
            else
            {
                lblStop.Text = "Η καφετέρια θα σας ενημερώσει σε ποια στάση θα γίνει η παράδοση.";
            }
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowOrder();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadOrders();
            ShowOrder();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
