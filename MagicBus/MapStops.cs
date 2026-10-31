using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class MapStops : Form
    {
        public MapStops()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lstStops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStops.SelectedItem != null)
            {
                lblStop.Text = "Επιλεγμένη στάση: "
                    + lstStops.SelectedItem.ToString();
            }
        }
    }
}
