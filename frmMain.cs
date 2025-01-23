using Newtonsoft.Json;

namespace IPI_PIX
{
    public partial class FrmMain : Form
    {
        private List<Screen> /**/ Screens = new();
        private Settings     /**/ Settings = new();
        private bool         /**/ Showing = false;

        private readonly ToolStripMenuItem[] monitors;

        public FrmMain()
        {
            InitializeComponent();

            Icon = Properties.Resources.ipi_pix;

            monitors = new[] { MenuMonitor0, MenuMonitor1, MenuMonitor2, MenuMonitor3, MenuMonitor4 };

            NIcon.ContextMenuStrip = NIconContextMenuStrip;
            NIcon.Icon = Icon;
            NIcon.Text = "IPI-PIX";
            NIcon.Visible = true;

            string SettingsJson = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) ?? "", "Settings.json");
            if (File.Exists(SettingsJson))
                Settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SettingsJson)) ?? new();

            DisplaysRefresh();
            SetMode();
            MoveTo(Settings.DisplayIndex);
        }

        private void DisplaysRefresh()
        {
            for (int i = 0; i < monitors.Length; i++)
                monitors[i].Visible = false;

            Screens = Screen.AllScreens.OrderBy(x => x.Primary).ToList();

            if (Settings.DisplayIndex > Screens.Count)
                Settings.DisplayIndex = Screens.Count - 1;

            for (int i = 0; i < Screens.Count && i < monitors.Length; i++)
            {
                monitors[i].Image = Settings.DisplayIndex == i ? Properties.Resources.monitor : null;
                monitors[i].Text = Screens[i].DeviceName;
                monitors[i].Visible = true;
            }
        }

        private void PresentToggle()
        {
            TimerHide.Stop();
            TimerShow.Stop();
            (Showing ? TimerHide : TimerShow).Start();
        }
        private void SetMode()
        {
            BackColor = Settings.DarkMode ? Color.Black : Color.White;
            label3.ForeColor =
            label4.ForeColor = Settings.DarkMode ? Color.White : Color.Black;
            pictureBox1.Image = Settings.DarkMode ? Properties.Resources.pix_p : Properties.Resources.pix_b;
        }

        // ################################################################################################################################################

        private void MenuClose_Click(object sender, EventArgs e)
        {
            NIcon?.Dispose();
            Close();
        }

        private void MoveTo(int i)
        {
            if (Settings.DisplayIndex == i && Showing) return;
            Location = new Point(
                Screen.AllScreens[i].WorkingArea.Width + Screen.AllScreens[i].Bounds.Location.X,
                Screen.AllScreens[i].WorkingArea.Height + Screen.AllScreens[i].Bounds.Location.Y - Height);
            Settings.DisplayIndex = i;
            monitors[i].Enabled = false;
            PresentToggle();
        }

        private void TimerHide_Tick(object sender, EventArgs e)
        {
            Showing = false;
            if (Screen.AllScreens[Settings.DisplayIndex].WorkingArea.Width + Screen.AllScreens[Settings.DisplayIndex].Bounds.Location.X > Location.X)
                Location = new Point(Location.X + 20, Location.Y);
            else
            {
                Location = new Point(Screen.AllScreens[Settings.DisplayIndex].WorkingArea.Width + Screen.AllScreens[Settings.DisplayIndex].Bounds.Location.X, Location.Y);
                TimerHide.Stop();
            }
            Opacity = 1 - ((Location.X - (Screen.AllScreens[Settings.DisplayIndex].WorkingArea.Width + Screen.AllScreens[Settings.DisplayIndex].Bounds.Location.X - Width)) * 100 / Width) / 100F;
        }
        private void TimerShow_Tick(object sender, EventArgs e)
        {
            Showing = true;
            if (Screen.AllScreens[Settings.DisplayIndex].WorkingArea.Width + Screen.AllScreens[Settings.DisplayIndex].Bounds.Location.X - Width < Location.X)
                Location = new Point(Location.X - 20, Location.Y);
            else
            {
                Location = new Point(Screen.AllScreens[Settings.DisplayIndex].WorkingArea.Width + Screen.AllScreens[Settings.DisplayIndex].Bounds.Location.X - Width, Location.Y);
                TimerShow.Stop();
            }
            Opacity = 1 - ((Location.X - (Screen.AllScreens[Settings.DisplayIndex].WorkingArea.Width + Screen.AllScreens[Settings.DisplayIndex].Bounds.Location.X - Width)) * 100 / Width) / 100F;
        }

        private void MenuSwitchMode_Click(object sender, EventArgs e)
        {
            Settings.DarkMode = !Settings.DarkMode;
            SetMode();
        }

        private void MenuHideShow_Click(object sender, EventArgs e)
        {
            PresentToggle();
            MenuHideShow.Image = !Showing ? Properties.Resources.arrow_to : Properties.Resources.arrow_from;
            MenuHideShow.Text = !Showing ? "Hide" : "Show";
        }

        private void MenuRefreshMonitor_Click(object sender, EventArgs e) => DisplaysRefresh();

        private void NIcon_MouseDoubleClick(object sender, MouseEventArgs e) => MenuHideShow.PerformClick();

        private void MenuMonitor_Click(object sender, EventArgs e)
        {
            var ctrl = (ToolStripMenuItem)sender;
            int displayIndex = Convert.ToInt32(ctrl.Name.Substring(ctrl.Name.Length - 1, 1));
            if (Settings.DisplayIndex != displayIndex && Showing) Showing = false;
            for (int i = 0; i < monitors.Length; i++)
            {
                monitors[i].Enabled = true;
                monitors[i].Image = null;
            }
            monitors[displayIndex].Image = Properties.Resources.monitor;
            MoveTo(displayIndex);
        }
    }
}