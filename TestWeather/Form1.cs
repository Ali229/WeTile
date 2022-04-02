using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;
using System.Globalization;
namespace TestWeather
{
    public partial class mainForm : Form
    {
        //=================================== Global Declerations =========================================//
        Boolean Connection;
        String Weatherpic;
        public static String szCity = ""; //To get city in SettingsBox.
        public static String cN = ""; //To load city.
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
        const int WS_EX_TOOLWINDOW = 0x80;
        const int WS_EX_APPWINDOW = 0x40000;
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
            this.BackColor = Properties.Settings.Default.colorSetting;
            if (Properties.Settings.Default.positionSetting.X.Equals(0) && Properties.Settings.Default.positionSetting.Y.Equals(0))
            {
                foreach (var scrn in Screen.AllScreens)
                {
                    if (scrn.Bounds.Contains(this.Location))
                    {
                        this.Location = new Point(scrn.Bounds.Right - this.Width - 5, scrn.Bounds.Top + 5);
                        return;
                    }
                }
            }
            else
            {
                Location = Properties.Settings.Default.positionSetting;
            }
        }
        //=============================== Changes The Form Color ==========================================//
        public void changeColor()
        {
            this.BackColor = Properties.Settings.Default.colorSetting;
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
            Screen scn = Screen.FromPoint(this.Location);
            if (DoSnap(this.Left, scn.WorkingArea.Left)) this.Left = scn.WorkingArea.Left + 5;
            if (DoSnap(this.Top, scn.WorkingArea.Top)) this.Top = scn.WorkingArea.Top + 5;
            if (DoSnap(scn.WorkingArea.Right, this.Right)) this.Left = scn.WorkingArea.Right - this.Width - 5;
            if (DoSnap(scn.WorkingArea.Bottom, this.Bottom)) this.Top = scn.WorkingArea.Bottom - this.Height - 5;
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
                var xml = await new WebClient().DownloadStringTaskAsync(new Uri(weburl));
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
                changeWeatherPic(sender, e);
                await Task.Delay(1000);
                exceptionLabel.Visible = false;
            }
            catch (WebException)
            {
                exceptionLabel.Text = "Check internet connection...";
                exceptionLabel.Visible = true;
                Connection = false;
            }
            catch (XmlException)
            {
                exceptionLabel.Text = "Please recheck city name...";
                exceptionLabel.Visible = true;
            }
            catch (Exception ex)
            {
                exceptionLabel.Text = ex.Message;
                exceptionLabel.Visible = true;
            }
            if (Connection == true)
            {
                refreshButton.SendToBack();
            } else
            {
                await Task.Delay(5000);
                getData(sender, e);
            }
        }
        //=================================== Changes Weather Icon ========================================//
        public void changeWeatherPic(object sender, EventArgs e)
        {
            switch (Weatherpic)
            {
                case "800":
                case "951":
                    removeWeatherpic(sender, e);
                    TimeSpan start = new TimeSpan(06, 0, 0);
                    TimeSpan end = new TimeSpan(18, 0, 0);
                    TimeSpan now = DateTime.Now.TimeOfDay;
                    if ((now > start) && (now < end))
                    {
                       sunPictureBox.Visible = true;
                    } else
                    {
                        moonPictureBox.Visible = true;
                    }
                    break;
                case "500":
                case "520":
                case "521":
                case "300":
                case "301":
                case "310":
                case "311":
                    removeWeatherpic(sender, e);
                    lightRainPictureBox.Visible = true;
                    break;
                case "501":
                case "502":
                case "503":
                case "504":
                case "522":
                case "531":
                case "302":
                case "312":
                case "313":
                case "314":
                case "321":
                    removeWeatherpic(sender, e);
                    heavyRainPictureBox.Visible = true;
                    break;
                case "511":
                    removeWeatherpic(sender, e);
                    icyRainPictureBox.Visible = true;
                    break;
                case "801":
                    removeWeatherpic(sender, e);
                    TimeSpan startc = new TimeSpan(05, 0, 0);// 5 am
                    TimeSpan endc = new TimeSpan(18, 0, 0);// 6 pm
                    TimeSpan nowc = DateTime.Now.TimeOfDay;
                    if ((nowc > startc) && (nowc < endc))
                    {
                        sunLightCloudsPictureBox.Visible = true;
                    } else
                    {
                        moonLightCloudsPictureBox.Visible = true;
                    }
                    break;
                case "804":
                   removeWeatherpic(sender, e);
                    TimeSpan starto = new TimeSpan(06, 0, 0);
                    TimeSpan endo = new TimeSpan(18, 0, 0);
                    TimeSpan nowo = DateTime.Now.TimeOfDay;
                    if ((nowo > starto) && (nowo < endo))
                    {
                        sunOvercastPictureBox.Visible = true;
                    } else
                    {
                        moonOvercastPictureBox.Visible = true;
                    }
                    break;
                case "802":
                    removeWeatherpic(sender, e);
                    scatteredPictureBox.Visible = true;
                    break;
                case "803":
                    removeWeatherpic(sender, e);
                    brokenPictureBox.Visible = true;
                    break;
                case "211":
                case "212":
                case "221":
                case "230":
                case "231":
                case "232":
                case "202":
                    removeWeatherpic(sender, e);
                    thunderPictureBox.Visible = true;
                    break;
                case "200":
                case "201":
                case "210":
                    removeWeatherpic(sender, e);
                    TimeSpan startt = new TimeSpan(06, 0, 0);
                    TimeSpan endt = new TimeSpan(18, 0, 0);
                    TimeSpan nowt = DateTime.Now.TimeOfDay;
                    if ((nowt > startt) && (nowt < endt))
                    {
                        moonThunderPictureBox.Visible = true;
                    } else
                    {
                        moonThunderPictureBox.Visible = true;
                    }
                    break;
                case "701":
                case "711":
                case "721":
                case "731":
                case "741":
                case "751":
                case "761":
                case "762":
                case "771":
                case "781":
                case "903":
                case "904":
                    removeWeatherpic(sender, e);
                    fogPictureBox.Visible = true;
                    break;
                case "900":
                case "901":
                case "902":
                case "905":
                case "906":
                    removeWeatherpic(sender, e);
                    tornadoPictureBox.Visible = true;
                    break;
                case "952":
                case "953":
                case "954":
                case "955":
                case "956":
                case "957":
                case "958":
                case "959":
                case "960":
                case "961":
                case "962":
                    removeWeatherpic(sender, e);
                    breezePictureBox.Visible = true;
                    break;
                default:
                    try
                    {
                        removeWeatherpic(sender, e);
                        TimeSpan startd = new TimeSpan(06, 0, 0); //10 o'clock
                        TimeSpan endd = new TimeSpan(18, 0, 0); //12 o'clock
                        TimeSpan nowd = DateTime.Now.TimeOfDay;
                        if ((nowd > startd) && (nowd < endd))
                        {
                            sunPictureBox.Visible = true;
                        }
                        else
                        {
                            moonPictureBox.Visible = true;
                        }
                    }
                    catch(Exception)
                    {
                        removeWeatherpic(sender, e);
                        sunPictureBox.Visible = true;
                    } 
                    break;
            }
        }
        //=================================== Removes Icon On Update ======================================//
        public void removeWeatherpic(object sender, EventArgs e)
            {
                sunPictureBox.Visible = false;
                moonPictureBox.Visible = false;
                cloudyPictureBox.Visible = false;
                lightRainPictureBox.Visible = false;
                heavyRainPictureBox.Visible = false;
                icyRainPictureBox.Visible = false;
                sunLightCloudsPictureBox.Visible = false;
                moonLightCloudsPictureBox.Visible = false;
                sunOvercastPictureBox.Visible = false;
                moonOvercastPictureBox.Visible = false;
                brokenPictureBox.Visible = false;
                scatteredPictureBox.Visible = false;
                thunderPictureBox.Visible = false;
                sunThunderPictureBox.Visible = false;
                moonThunderPictureBox.Visible = false;
                fogPictureBox.Visible = false;
                tornadoPictureBox.Visible = false;
                breezePictureBox.Visible = false;
            }
        //=================================== Opens Settings Form =========================================//
        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsBox box = new settingsBox();
            box.passTBValue = new settingsBox.PassTextBoxValue(PassTB);
            box.ShowDialog();
        }
        //=================================== Saves City Settings =========================================//
        public string valueFromForm2 { get; set; }
        private void PassTB(string tbValue)
        {
            this.valueFromForm2 = tbValue;
            cN = tbValue;
        }
    }//End Class
}//End Namespace
