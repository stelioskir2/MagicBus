using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class LostItems : Form
    {
        public LostItems()
        {
            InitializeComponent();
            lstItems.Items.AddRange(LostItemsData.Items.ToArray());

            if (lstItems.Items.Count == 0)
            {
                txtDetails.Text = "Δεν έχουν εντοπιστεί αντικείμενα.";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItem is FoundItem item)
            {
                txtDetails.Text =
                    $"Αντικείμενο: {item.Name}\r\n\r\n"
                    + $"Όροφος: {item.Floor}\r\n\r\n"
                    + $"Εντοπίστηκε: {item.FoundAt:dd/MM/yyyy HH:mm}\r\n\r\n"
                    + "Για διεκδίκηση του αντικειμένου, "
                    + "απευθυνθείτε στο προσωπικό.\r\n\r\n"
                    + "Εύρημα εκπαιδευτικής προσομοίωσης.";
            }
        }
    }
}
