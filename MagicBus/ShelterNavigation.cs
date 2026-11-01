using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class ShelterNavigation : Form
    {
        private bool showRoute = false;
        public ShelterNavigation()
        {
            InitializeComponent();
            picRoute.Paint += picRoute_Paint;

            lstShelters.SelectedIndexChanged += (_, _) =>
            {
                showRoute = false;
                picRoute.Invalidate();
            };
        }

        private void picRoute_Paint(object? sender, PaintEventArgs e)
        {
            if (!showRoute)
            {
                return;
            }

            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.ScaleTransform(
                picRoute.ClientSize.Width / 450f,
                picRoute.ClientSize.Height / 100f);

            using Font font = new Font("Segoe UI", 10);
            using Font smallFont = new Font("Segoe UI", 9);
            using Pen routePen = new Pen(Color.MidnightBlue, 3);

            routePen.EndCap =
                System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            string destination = lstShelters.SelectedIndex == 0
                ? "Χώρος Α"
                : "Χώρος Β";

            Point[] route = lstShelters.SelectedIndex == 0
                ? new[]
                {
            new Point(40, 45),
            new Point(390, 45)
                }
                : new[]
                {
            new Point(40, 45),
            new Point(210, 45),
            new Point(210, 65),
            new Point(390, 65)
                };

            e.Graphics.DrawLines(routePen, route);

            e.Graphics.FillEllipse(
                Brushes.MidnightBlue, 32, 37, 16, 16);

            e.Graphics.DrawString(
                "Στάση", font, Brushes.MidnightBlue, 15, 10);

            e.Graphics.DrawString(
                destination, font, Brushes.MidnightBlue, 335, 10);

            e.Graphics.DrawString(
                "Σχηματική διαδρομή — προσομοίωση",
                smallFont, Brushes.DimGray, 110, 78);
        }
        private void cmbStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstShelters.Items.Clear();

            if (cmbStart.SelectedItem == null)
            {
                return;
            }

            string stop = cmbStart.SelectedItem.ToString()!;

            lstShelters.Items.Add("Χώρος υποδοχής Α");
            lstShelters.Items.Add("Στεγασμένος χώρος Β");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            if (cmbStart.SelectedItem == null ||
    lstShelters.SelectedItem == null)
            {
                MessageBox.Show("Επιλέξτε στάση και χώρο προστασίας.");
                return;
            }

            showRoute = true;
            picRoute.Invalidate();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Οδηγίες — Προστασία από Κακοκαιρία:\n\n" +
                "1. Επιλέξτε τη στάση στην οποία βρίσκεστε.\n" +
                "2. Επιλέξτε έναν διαθέσιμο χώρο προστασίας από τη λίστα.\n" +
                "3. Πατήστε 'Πλοήγηση στον χώρο' για να δείτε τη σχηματική διαδρομή πρόσβασης.",
                "On-line Help — Καταφύγια",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}