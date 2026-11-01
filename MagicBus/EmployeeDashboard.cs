using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
            Activated += (_, _) =>
            {
                int count = LostItemsData.Items.Count(
                    item => item.FoundAt.Date == DateTime.Today);

                lblFoundItems.Text = count == 0
                    ? "Δεν υπάρχουν σημερινά ευρήματα."
                    : $"Σημερινά ευρήματα: {count}\n"
                    + "Από το ρομπότ καθαρισμού.";
            };
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            PassengerManagement passengerForm = new PassengerManagement();
            passengerForm.Show();
            this.Hide();
        }

        private void btnBusStatus_Click(object sender, EventArgs e)
        {
            BusStatus statusForm = new BusStatus();
            statusForm.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleAndStops scheduleForm = new ScheduleAndStops();
            scheduleForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RoleSelection roleForm = new RoleSelection();
            roleForm.Show();
            this.Close();
        }

        private void btnRobot_Click(object sender, EventArgs e)
        {
            using RobotCleaner robot = new RobotCleaner();
            robot.ShowDialog(this);
        }

        private void btnCafeOrders_Click(object sender, EventArgs e)
        {
            using CafeOrders cafeOrders = new CafeOrders();
            cafeOrders.ShowDialog(this);
        }

        private void btnCompanyNotifications_Click(object sender, EventArgs e)
        {
            var items = LostItemsData.Items
    .Where(item => item.FoundAt.Date == DateTime.Today)
    .ToList();

            if (items.Count == 0)
            {
                MessageBox.Show(
                    this,
                    "Δεν υπάρχουν σημερινές ειδοποιήσεις ευρημάτων.",
                    "Εταιρεία — Προσομοίωση");
                return;
            }

            StringBuilder message = new StringBuilder();

            message.AppendLine("Σημερινές ειδοποιήσεις προς την εταιρεία:");
            message.AppendLine();

            foreach (var item in items)
            {
                message.AppendLine(
                    $"{item.FoundAt:dd/MM/yyyy HH:mm} — "
                    + $"{item.Name} — {item.Floor}");
                message.AppendLine();
            }

            message.AppendLine(
                "Τοπική εκπαιδευτική προσομοίωση. "
                + "Δεν έχει πραγματοποιηθεί εξωτερική αποστολή.");

            MessageBox.Show(
                this,
                message.ToString(),
                "Εταιρεία — Προσομοίωση",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}