using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagicBus
{
    public partial class PassengerHome : Form
    {
        public PassengerHome()
        {
            InitializeComponent();
        }

        private void PassengerHome_Load(object sender, EventArgs e)
        {

        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            using MapStops map = new MapStops();
            map.ShowDialog(this);
        }

        private void btnAttractions_Click(object sender, EventArgs e)
        {
            using Attractions attractions = new Attractions();
            attractions.ShowDialog(this);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            using RouteView route = new RouteView();
            route.ShowDialog(this);
        }
    }
}
