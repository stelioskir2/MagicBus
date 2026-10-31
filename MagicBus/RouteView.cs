using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MagicBus
{
    public partial class RouteView : Form
    {
        public RouteView()
        {
            InitializeComponent();
            Shown += RouteView_Shown;
        }
        private async void RouteView_Shown(object? sender, EventArgs e)
        {
            try
            {
                string videoPath = Path.Combine(
                    AppContext.BaseDirectory, "Media", "route.mp4");

                await webVideo.EnsureCoreWebView2Async();

                if (!File.Exists(videoPath))
                {
                    webVideo.NavigateToString("""
                <html lang="el">
                <body style="background:#191970;color:white;
                    font-family:Segoe UI;text-align:center;padding:60px">
                    <h2>Προσομοίωση θέας διαδρομής</h2>
                    <p>Το βίντεο της διαδρομής δεν είναι ακόμη διαθέσιμο.</p>
                </body>
                </html>
                """);
                    return;
                }

                webVideo.CoreWebView2.Navigate(
                    new Uri(videoPath).AbsoluteUri);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Δεν ήταν δυνατή η προβολή: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void webVideo_Click(object sender, EventArgs e)
        {

        }
    }
}
