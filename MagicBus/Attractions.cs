using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class Attractions : Form
    {
        public Attractions()
        {
            InitializeComponent();
        }

        private void Attractions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstAttractions.SelectedItem == null)
            {
                MessageBox.Show(
                    "Επιλέξτε πρώτα ένα αξιοθέατο από τη λίστα.",
                    "Επιλογή αξιοθέατου",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string attraction = lstAttractions.SelectedItem.ToString()!;

            using AttractionDetails details = new AttractionDetails(attraction);
            details.ShowDialog(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
