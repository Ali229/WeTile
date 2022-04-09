using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WeTile
{
    public partial class mainForm : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        Weather Weather = new Weather();
        AirQuality AirQuality = new AirQuality();
        settingsBox Box = new settingsBox();
        #region Prevent Minimize
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MINIMIZE = 0xf020;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam.ToInt32() == SC_MINIMIZE)
                {
                    m.Result = IntPtr.Zero;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion
        #region Form Disable Alt+Tab
        private const int WS_EX_TOOLWINDOW = 0x80;
        private const int WS_EX_APPWINDOW = 0x40000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TOOLWINDOW;
                cp.ExStyle &= ~WS_EX_APPWINDOW; //ShowInTaskbar = false
                return cp;
            }
        }
        #endregion
        #region Making Form Move On Click
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void moveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Properties.Settings.Default.positionSetting = Location;
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        public mainForm()
        {
            InitializeComponent();
            ChangeColor();
            SetStartingPosition();
            AutomateAccentColor();
        }
        #region Set starting position
        private void SetStartingPosition()
        {
            if (Properties.Settings.Default.positionSetting.X.Equals(0) && Properties.Settings.Default.positionSetting.Y.Equals(0))
            {
                foreach (Screen scrn in Screen.AllScreens)
                {
                    if (scrn.Bounds.Contains(Location))
                    {
                        Location = new Point(scrn.Bounds.Right - Width - 5, scrn.Bounds.Top + 5);
                        return;
                    }
                }
            }
            else
            {
                Location = Properties.Settings.Default.positionSetting;
            }
        }
        #endregion
        #region Automate windows accent color
        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void AutomateAccentColor()
        {
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
        }
        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                ChangeColor();
            }
        }
        #endregion
        #region Change The Form Color
        public void ChangeColor()
        {
            if (Properties.Settings.Default.useAccentSetting)
            {
                try
                {
                    this.BackColor = ControlPaint.Dark(WinTheme.GetAccentColor());
                    Properties.Settings.Default.colorSetting = this.BackColor;
                }
                catch (Exception)
                {
                    this.BackColor = Properties.Settings.Default.colorSetting;
                }
            }
            else
            {
                this.BackColor = Properties.Settings.Default.colorSetting;
            }
            Opacity = Properties.Settings.Default.opacitySetting / 100;
        }
        #endregion
        #region Snap Form To Sides
        private const int SnapDist = 100;
        private bool DoSnap(int pos, int edge)
        {
            int delta = pos - edge;
            return delta > 0 && delta <= SnapDist;
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            Screen scn = Screen.FromPoint(Location);
            if (DoSnap(Left, scn.WorkingArea.Left))
            {
                Left = scn.WorkingArea.Left + 5;
            }

            if (DoSnap(Top, scn.WorkingArea.Top))
            {
                Top = scn.WorkingArea.Top + 5;
            }

            if (DoSnap(scn.WorkingArea.Right, Right))
            {
                Left = scn.WorkingArea.Right - Width - 5;
            }

            if (DoSnap(scn.WorkingArea.Bottom, Bottom))
            {
                Top = scn.WorkingArea.Bottom - Height - 5;
            }
        }
        #endregion
        #region Mouse enter form
        private void mainForm_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Show();
            refreshButton.Show();
            refreshButtonStill.Show();
            settingsButton.Show();
            TimestampShow();
        }
        #endregion
        #region Set Timestamp
        private void TimestampShow()
        {
            if (exceptionLabel.Visible == false && !Weather.Timestamp.Equals(DateTime.MinValue))
            {
                timestampLabel.Text = "Updated " + TimeAgo.GetTimeAgo(Weather.Timestamp);
                timestampLabel.Show();
            }
        }
        #endregion
        #region Mouse leave form
        private void mainForm_MouseLeave(object sender, EventArgs e)
        {
            checkMouse.Enabled = true;
        }
        #endregion
        #region Check Mouse After Leave
        private void checkMouse_Tick(object sender, EventArgs e)
        {
            Point pt = new Point(MousePosition.X, MousePosition.Y);
            pt = PointToClient(pt);
            if (!ClientRectangle.Contains(pt))
            {
                closeButton.Hide();
                refreshButton.Hide();
                refreshButtonStill.Hide();
                settingsButton.Hide();
                timestampLabel.Hide();
                checkMouse.Enabled = false;
            }
        }
        #endregion
        #region Form Close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        public async void GetData()
        {
            try
            {
                refreshButton.BringToFront();
                dateLabel.Text = DateTime.Now.DayOfWeek + ", " + DateTime.Now.Day;
                await Weather.GetWeather();

                TemperatureLabel.Text = Weather.Temperature.ToString("N0") + "°";
                weatherLabel.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Weather.WeatherName);
                cityLabel.Text = Weather.City;

                await AirQuality.GetAirQuality(Weather.Latitude, Weather.Longitude);
                setWeatherImage();
                autoScaleFont();
                refreshButton.SendToBack();
                exceptionLabel.Visible = false;
            }
            catch (WebException we)
            {
                if (we.Status == WebExceptionStatus.ProtocolError)
                {
                    FailedCall("Please recheck city name...");
                }
                else
                {
                    FailedCall("Check internet connection...");
                }
            }
            catch (Exception ex)
            {
                FailedCall(ex.Message);
            }
        }
        #region If Weather Call Failed
        private async void FailedCall(string Message)
        {
            exceptionLabel.Text = Message;
            exceptionLabel.Visible = true;
            Weather.Connection = false;
            timestampLabel.Hide();
            await Task.Delay(5000);
            GetData();
        }
        #endregion
        #region Auto scale font
        private void autoScaleFont()
        {
            if (weatherLabel.Text.Length > 30)
            {
                weatherLabel.Font = new Font("Segoe UI", 6f, FontStyle.Regular);
            }
            else if (weatherLabel.Text.Length > 25)
            {
                weatherLabel.Font = new Font("Segoe UI", 7f, FontStyle.Regular);
            }
            else if (weatherLabel.Text.Length > 20)
            {
                weatherLabel.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
            }
            else if (weatherLabel.Text.Length > 15)
            {
                weatherLabel.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            }
            else
            {
                weatherLabel.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular);
            }
        }
        #endregion
        #region Set weather image
        public bool isItDayTime()
        {
            TimeSpan start = new TimeSpan(06, 0, 0);
            TimeSpan end = new TimeSpan(18, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setWeatherImage()
        {
            bool dayTime = isItDayTime();
            Image tImage;
            switch (Weather.WeatherIcon)
            {
                case "200":
                case "201":
                case "202":
                case "210":
                    tImage = dayTime ? Properties.Resources.storm_chance : Properties.Resources.storm_chance_n;
                    break;
                case "211":
                case "212":
                case "221":
                case "230":
                case "231":
                case "232":
                    tImage = Properties.Resources.storm;
                    break;
                case "300":
                case "301":
                case "302":
                case "310":
                case "311":
                case "312":
                case "313":
                case "314":
                case "321":
                    tImage = dayTime ? Properties.Resources.rain_light : Properties.Resources.rain_light;
                    break;
                case "500":
                case "501":
                case "502":
                case "503":
                case "504":
                case "520":
                case "521":
                case "522":
                case "531":
                    tImage = Properties.Resources.rain;
                    break;
                case "511":
                    tImage = Properties.Resources.rain_ice;
                    break;
                case "600":
                case "601":
                case "602":
                case "611":
                case "612":
                case "613":
                case "615":
                case "616":
                case "620":
                case "621":
                case "622":
                    tImage = Properties.Resources.snow;
                    break;
                case "701":
                case "711":
                case "721":
                case "731":
                case "741":
                case "751":
                case "761":
                case "762":
                    tImage = Properties.Resources.fog;
                    break;
                case "771":
                case "781":
                    tImage = Properties.Resources.tornado;
                    break;
                case "800":
                    tImage = dayTime ? Properties.Resources.sunny : Properties.Resources.sunny_n;
                    break;
                case "801":
                    tImage = dayTime ? Properties.Resources.cloudy_mostly : Properties.Resources.cloudy_mostly_n;
                    break;
                case "802":
                case "803":
                    tImage = Properties.Resources.scattered;
                    break;
                case "804":
                    tImage = Properties.Resources.cloudy;
                    break;
                default:
                    tImage = dayTime ? Properties.Resources.sunny : Properties.Resources.sunny_n;
                    break;
            }
            WeatherPictureBox.Image = tImage;
        }
        #endregion
        #region Opens Settings Form
        private void settingsButton_Click(object sender, EventArgs e)
        {
            Box.ShowDialog();
        }
        #endregion

        private void mainForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void weatherTimer_Tick(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
