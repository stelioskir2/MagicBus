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
    public partial class ScheduleAndStops : Form
    {
        private DataTable stopsTable;
        private int currentStopIndex = 0;

        // Οι 6 στάσεις της Θεσσαλονίκης σύμφωνα με τον σχεδιασμό
        private readonly string[] stopNames = {
            "Λευκός Πύργος",
            "Πλατεία Αριστοτέλους",
            "Πλατεία Ελευθερίας",
            "Άγιος Δημήτριος",
            "Ροτόντα",
            "Καμάρα"
        };

        public ScheduleAndStops()
        {
            InitializeComponent();
        }

        private void ScheduleAndStops_Load(object sender, EventArgs e)
        {
            LoadStopsData();
            UpdateCurrentStopDisplay();
        }

        private void LoadStopsData()
        {
            stopsTable = new DataTable();
            stopsTable.Columns.Add("Αρ.", typeof(int));
            stopsTable.Columns.Add("Όνομα Στάσης", typeof(string));
            stopsTable.Columns.Add("Ώρα Άφιξης", typeof(string));
            stopsTable.Columns.Add("Κατάσταση", typeof(string));

            TimeSpan baseTime = new TimeSpan(8, 30, 0);

            for (int i = 0; i < stopNames.Length; i++)
            {
                string status = (i == 0) ? "Τρέχουσα Στάση" : "Αναμένεται";
                stopsTable.Rows.Add(i + 1, stopNames[i], baseTime.Add(TimeSpan.FromMinutes(i * 7)).ToString(@"hh\:mm"), status);
            }

            dgvStops.DataSource = stopsTable;
        }

        private void UpdateCurrentStopDisplay()
        {
            if (currentStopIndex < stopNames.Length)
            {
                lblCurrentStopVal.Text = $"{currentStopIndex + 1}. {stopNames[currentStopIndex]}";
            }
            else
            {
                lblCurrentStopVal.Text = "Ολοκλήρωση Διαδρομής!";
            }
        }

        private void btnNextStop_Click(object sender, EventArgs e)
        {
            if (currentStopIndex < stopNames.Length - 1)
            {
                stopsTable.Rows[currentStopIndex]["Κατάσταση"] = "Ολοκληρώθηκε";
                currentStopIndex++;
                stopsTable.Rows[currentStopIndex]["Κατάσταση"] = "Τρέχουσα Στάση";
                UpdateCurrentStopDisplay();
                dgvStops.Refresh();
            }
            else if (currentStopIndex == stopNames.Length - 1)
            {
                stopsTable.Rows[currentStopIndex]["Κατάσταση"] = "Ολοκληρώθηκε";
                currentStopIndex++;
                UpdateCurrentStopDisplay();
                MessageBox.Show("Το λεωφορείο ολοκλήρωσε το κυκλικό δρομολόγιο στις 6 στάσεις!", "Τέλος Διαδρομής", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Η διαδρομή έχει ήδη ολοκληρωθεί. Πατήστε Ανανέωση για επανεκκίνηση.", "Ενημέρωση", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentStopIndex = 0;
            LoadStopsData();
            UpdateCurrentStopDisplay();

            Random rand = new Random();
            string[] trafficOptions = { "Ομαλή ροή", "Μέτρια κίνηση", "Αυξημένη κίνηση (+5λ καθυστέρηση)" };
            lblTrafficVal.Text = trafficOptions[rand.Next(trafficOptions.Length)];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeDashboard staffDashboard = new EmployeeDashboard();
            staffDashboard.Show();
            this.Close();
        }
    }
}