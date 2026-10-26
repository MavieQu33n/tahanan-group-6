using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CMS_TAHANAN
{
	public partial class frmDashboard : Form
	{
		public frmDashboard()
		{
			InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

        }

        private async void frmDashboard_Load(object sender, EventArgs e)
        {
            lblMemorialDate.Text = "Syncing...";
            lblMemorialTime.Text = "--:-- --";

            bool ok = await TrustedClock.SyncAsync();

            if (!ok)
            {
                lblMemorialDate.Text = "No internet connection";
                lblMemorialTime.Text = "--:-- --";
            }

            timer1.Start();
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (!TrustedClock.IsSynced)
            {
                // retry quietly if the first sync failed
                await TrustedClock.SyncAsync();
                return;
            }

            DateTime now = TrustedClock.DavaoNow;
            lblMemorialDate.Text = now.ToString("dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            lblMemorialTime.Text = now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
        }
    }
}
