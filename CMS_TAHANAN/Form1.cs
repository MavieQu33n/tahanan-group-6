using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CMS_TAHANAN
{
    public partial class frmDashboard : Form
    {
        private readonly TrustedClock trustedClock = new TrustedClock();
        private readonly System.Windows.Forms.Timer clockTimer = new System.Windows.Forms.Timer();
        private static readonly TimeZoneInfo PhilippineTimeZone = TimeZoneInfo.CreateCustomTimeZone(
            "Philippine Standard Time", TimeSpan.FromHours(8), "Philippine Standard Time", "Philippine Standard Time");

        public frmDashboard()
        {
            InitializeComponent();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            FormClosed += frmDashboard_FormClosed;
            btnDashboard.Click += btnDashboard_Click;
            btnBurialPlots.Click += btnBurialPlots_Click;
            ShowPage(tlpDashboard);
        }
        private void ShowPage(Control selectedPage)
        {
            pnlDashboard.Visible = true;
            tlpDashboard.Visible = false;
            pnlBurialPlotsPage.Visible = false;

            selectedPage.Dock = DockStyle.Fill;
            selectedPage.Visible = true;
            selectedPage.BringToFront();
        }

        private async void frmDashboard_Load(object sender, EventArgs e)
        {
            lblTodayLocation.Text = "Today in Davao";
            lblMemorialDate.Text = "Synchronizing...";
            lblMemorialTime.Text = "Please wait";

            if (await trustedClock.SynchronizeAsync(CancellationToken.None))
            {
                UpdateClockDisplay();
                clockTimer.Start();
            }
            else
            {
                lblMemorialDate.Text = "Time unavailable";
                lblMemorialTime.Text = "No connection";
            }
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClockDisplay();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPage(tlpDashboard);
        }

        private void btnBurialPlots_Click(object sender, EventArgs e)
        {
            ShowPage(pnlBurialPlotsPage);
        }

        private void UpdateClockDisplay()
        {
            DateTime davaoTime = TimeZoneInfo.ConvertTimeFromUtc(trustedClock.Now, PhilippineTimeZone);
            lblMemorialDate.Text = davaoTime.ToString("dddd, MMMM dd, yyyy", CultureInfo.InvariantCulture);
            lblMemorialTime.Text = davaoTime.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            clockTimer.Stop();
            clockTimer.Dispose();
            trustedClock.Dispose();
        }
    }
}
