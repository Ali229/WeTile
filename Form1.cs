using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WeTile
{
    public partial class mainForm : Form
    {
        //=================================== Global Declerations =========================================//
        private bool Connection;
        private string Weatherpic;
        public static string szCity = ""; //To get city in SettingsBox.
        public static string cN = ""; //To load city.
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        //=================================== Prevent Minimize ============================================//
        #region
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
        //=================================== Form Disable Alt+Tab ========================================//
        #region
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
        //=================================== Making Form Move On Click ===================================//
        #region
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
        //=================================== Main Form ===================================================//
        public mainForm()
        {
            InitializeComponent();
            //=============================== Starting Position ===========================================//
            changeColor();
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
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
        }

        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                changeColor();
            }
        }
        //=============================== Changes The Form Color ==========================================//
        public void changeColor()
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
        //=================================== Snap Form To Sides ==========================================//
        #region
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
        //=================================== Form Mouse Enters ===========================================//
        private void mainForm_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Show();
            refreshButton.Show();
            refreshButtonStill.Show();
            settingsButton.Show();
        }
        //=================================== Form Mouse Leave ============================================//
        private void mainForm_MouseLeave(object sender, EventArgs e)
        {
            checkMouse.Enabled = true;
        }
        //=================================== Check Mouse After Leave =====================================//
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
                checkMouse.Enabled = false;
            }

        }
        //=================================== Form Close Button ===========================================//
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //=================================== Getting Data Method =========================================//
        public async void getData(object sender, EventArgs e)
        {
            try
            {
                refreshButton.BringToFront();
                dateLabel.Text = System.DateTime.Now.DayOfWeek + ", " + System.DateTime.Now.Day;
                //=========================== Getting XML =================================================//
                cN = Properties.Settings.Default.citySetting;
                string weburl;
                if (Properties.Settings.Default.unitSetting == "C")
                {
                    weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + cN + "&APPID=a1916e5365462ceb65cfa9bb0606d1d8&units=metric&mode=xml";
                }
                else
                {
                    weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + cN + "&APPID=a1916e5365462ceb65cfa9bb0606d1d8&units=imperial&mode=xml";
                }
                string xml = await new WebClient().DownloadStringTaskAsync(new Uri(weburl));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                //=========================== Parsing XML =================================================//
                string szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
                double temp = double.Parse(szTemp);
                TemperatureLabel.Text = temp.ToString("N0") + "°";
                string szWeather = doc.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;
                weatherLabel.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(szWeather);
                szCity = doc.DocumentElement.SelectSingleNode("city").Attributes["name"].Value;
                cityLabel.Text = szCity;
                string szWeatherpic = doc.DocumentElement.SelectSingleNode("weather").Attributes["number"].Value;
                Weatherpic = szWeatherpic;
                //=========================== If Connection Made ==========================================//
                Connection = true;
                setWeatherImage();
                await Task.Delay(1000);
                exceptionLabel.Visible = false;
            }
            catch (WebException we)
            {
                if (we.Status == WebExceptionStatus.ProtocolError)
                {
                    exceptionLabel.Text = "Please recheck city name...";
                }
                else
                {
                    exceptionLabel.Text = "Check internet connection..."; ;
                }
                exceptionLabel.Visible = true;
                Connection = false;
            }
            catch (Exception ex)
            {
                exceptionLabel.Text = ex.Message;
                exceptionLabel.Visible = true;
                Connection = false;
            }
            if (Connection == true)
            {
                refreshButton.SendToBack();
            }
            else
            {
                await Task.Delay(5000);
                getData(sender, e);
            }
        }
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
        //=================================== Changes Weather Icon ========================================//
        public void setWeatherImage()
        {
            bool dayTime = isItDayTime();
            Image tImage;
            switch (Weatherpic)
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
        //=================================== Opens Settings Form =========================================//
        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsBox box = new settingsBox
            {
                passTBValue = new settingsBox.PassTextBoxValue(PassTB)
            };
            box.ShowDialog();
        }
        //=================================== Saves City Settings =========================================//
        public string valueFromForm2 { get; set; }
        private void PassTB(string tbValue)
        {
            valueFromForm2 = tbValue;
            cN = tbValue;
        }
    }//End Class
}//End Namespace
