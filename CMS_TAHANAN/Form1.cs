using System;
using System.Drawing;
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

        private readonly Font navNormalFont =
            new Font("Segoe UI", 9F, FontStyle.Regular);

        private readonly Font navActiveFont =
            new Font("Segoe UI", 9F, FontStyle.Bold);


        public frmDashboard()
        {
            InitializeComponent();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            FormClosed += frmDashboard_FormClosed;
            InitializeSidebarNavigation();
            btnDashboard.Click += btnDashboard_Click;
            btnBurialPlots.Click += btnBurialPlots_Click;
            btnClassification.Click += btnClassification_Click;
            btnReservations.Click += btnReservations_Click;
            ShowPage(tlpDashboard);
        }

        private void InitializeSidebarNavigation()
        {
            Button[] navButtons =
            {
                btnDashboard,
                btnBurialPlots,
                btnClassification,
                btnReservations,
                btnFamilies,
                btnMaintenance,
                btnPayments,
                btnReports,
                btnSettings
            };

            foreach (Button button in navButtons)
            {
                button.Click -= SidebarButton_Click;
                button.Click += SidebarButton_Click;
            }

            // Dashboard selected when application starts
            SetActiveNavigationButton(btnDashboard);
        }


        private void SidebarButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                SetActiveNavigationButton(clickedButton);
            }
        }


        private void SetActiveNavigationButton(Button activeButton)
        {
            Button[] navButtons =
            {
                btnDashboard,
                btnBurialPlots,
                btnClassification,
                btnReservations,
                btnFamilies,
                btnMaintenance,
                btnPayments,
                btnReports,
                btnSettings
            };

            foreach (Button button in navButtons)
            {
                bool isActive = button == activeButton;

                button.UseVisualStyleBackColor = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;

                // Background color
                button.BackColor = isActive
                    ? Color.FromArgb(40, 88, 63)
                    : Color.FromArgb(17, 49, 39);

                // Text color
                button.ForeColor = isActive
                    ? Color.White
                    : Color.FromArgb(114, 184, 165);

                // Font style
                button.Font = isActive
                    ? navActiveFont
                    : navNormalFont;

                // Hover color
                button.FlatAppearance.MouseOverBackColor = isActive
                    ? Color.FromArgb(40, 88, 63)
                    : Color.FromArgb(29, 72, 55);

                // Click color
                button.FlatAppearance.MouseDownBackColor =
                    Color.FromArgb(40, 88, 63);
            }
        }

        private void ShowPage(Control selectedPage)
        {
            pnlDashboard.Visible = true;
            tlpDashboard.Visible = false;
            pnlBurialPlotsPage.Visible = false;
            pnlGraveClassificationPage.Visible = false;

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
        private void btnClassification_Click(object sender, EventArgs e)
        {
            ShowPage(pnlGraveClassificationPage);
        }
        private void btnReservations_Click(object sender, EventArgs e)
        {
            ShowPage(pnlReservationsPage);
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
