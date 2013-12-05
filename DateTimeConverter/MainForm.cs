using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DateTimeConverter
{
    public partial class MainForm : Form
    {
        static string RTN = Environment.NewLine;

        const string FORMAT_READ = "Readable   : {0}";
        const string FORMAT_TICK = "C# Ticks   : {0}";
        const string FORMAT_EXEL = "Excel      : {0}";
        const string FORMAT_NTPT = "NTP Time   : {0}";
        const string FORMAT_UNIX = "UNIX Epoch : {0}";
        const string FORMAT_WNNT = "Win NT     : {0}";

        const string ERROR_DOMAIN = "domain error";

        static string hyperLink = "http://twitter.com/#!/yyamasak";

        DateTime NtpBase = new DateTime(1900, 1, 1);
        DateTime UnixEpochBase = new DateTime(1970, 1, 1);
        DateTime WinNTBase = new DateTime(1601, 1, 1);

        List<CultureInfo> cultures;
        string[] formats = new[]{
            "yyyy-MM-dd HH:mm:ss",
            "MM/dd/yyyy HH:mm:ss",
            "dd/MM/yyyy HH:mm:ss",
            "d",
            "D",
            "f",
            "F",
            "g",
            "G",
            "m",
            "M",
            "o",
            "r",
            "R",
            "s",
            "t",
            "T",
            "u",
            "U",
            "y",
            "Y",
            "",
        };

        public MainForm()
        {
            InitializeComponent();

            // Format combobox items
            cbxFormat.Items.AddRange(formats);
            cbxFormat.SelectedIndex = 0;

            // TimeZone combobox items
            var zones = TimeZoneInfo.GetSystemTimeZones();
            cbxTimeZone.DataSource = zones;
            cbxTimeZone.SelectedItem = TimeZoneInfo.Local;

            // Culture combobox items
            cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .OrderBy(ci => ci.Name).ToList();

            int defaultIndex = cultures
                .Select((c, i) => new {Culture = c, Index = i})
                .Where(ci => ci.Culture.Name == CultureInfo.CurrentCulture.Name)
                .Select(ob => ob.Index).First();

            var cultureTextItems = from c in cultures
                                   select String.Format("{1}, {0}", c.DisplayName, c.Name);
            
            cbxCulture.Items.AddRange(cultureTextItems.ToArray());
            cbxCulture.SelectedIndex = defaultIndex;

            // Output
            tbxOutput1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            tbxOutput1.Clear();

            // Version
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            var ver = asm.GetName().Version;
            linkVersion.Text = String.Format("Version {0}", ver.ToString());
            //linkVersion.LinkClicked += linkVersion_LinkClicked;
            //toolTip1.SetToolTip(linkVersion, hyperLink);
        }

        /// <summary>
        /// Scroll to the end of TextBox and go back by 1 character.
        /// </summary>
        /// <param name="tbx">TextBox</param>
        private void ScrollToEnd(TextBox tbx)
        {
            tbx.SelectionStart = tbx.Text.Length - 1;
            tbx.Focus();
            tbx.ScrollToCaret();
        }

        private string ToReadable(DateTime _dt)
        {
            string formatString = cbxFormat.Text;
            string formattedDateTime;
            TimeZoneInfo selectedTimeZone = (TimeZoneInfo)cbxTimeZone.SelectedItem;
            try
            {
                DateTime dt = TimeZoneInfo.ConvertTime(_dt, TimeZoneInfo.Local, selectedTimeZone);
                TimeSpan ts = selectedTimeZone.GetUtcOffset(dt);
                formattedDateTime = String.Format("{0} UTC{1:+0;-0;\\ }{2::00;\\ ;\\ }", dt.ToString(formatString), ts.Hours, ts.Minutes).TrimEnd();
            }
            catch
            {
                formattedDateTime = String.Format("Bad format specifier. \"{0}\"", formatString);
            }
            return formattedDateTime;
        }

        private bool IsNtpCompatible(DateTime dt)
        {
            DateTime maxDt = FromNtp(UInt32.MaxValue);
            return dt >= NtpBase && dt < maxDt;
        }

        private DateTime FromNtp(UInt32 nt)
        {
            TimeSpan ts = new TimeSpan(nt * 10000000L); // 1 tick/100 nsec -> 10^7 ticks/sec
            return TimeZoneInfo.ConvertTimeFromUtc(NtpBase + ts, TimeZoneInfo.Local);
        }

        private UInt32 ToNtp(DateTime dt)
        {
            TimeSpan ts = TimeZoneInfo.ConvertTimeToUtc(dt, TimeZoneInfo.Local) - NtpBase;
            return Convert.ToUInt32(ts.TotalSeconds);
        }

        private bool IsUnixEpochCompatible(DateTime dt)
        {
            DateTime maxDt = FromUnixEpoch(UInt32.MaxValue);
            return dt >= UnixEpochBase && dt <= maxDt;
        }

        private DateTime FromUnixEpoch(UInt32 ue)
        {
            TimeSpan ts = new TimeSpan(ue * 10000000L); // 1 tick/100 nsec -> 10^7 ticks/sec
            return TimeZoneInfo.ConvertTimeFromUtc(UnixEpochBase + ts, TimeZoneInfo.Local);
        }

        private UInt32 ToUnixEpoch(DateTime dt)
        {
            TimeSpan ts = TimeZoneInfo.ConvertTimeToUtc(dt, TimeZoneInfo.Local) - UnixEpochBase;
            return Convert.ToUInt32(ts.TotalSeconds);
        }

        private void SetNow()
        {
            var now = DateTime.Now;
            dtpInput1.Value = now;
            tbxInput2.Text = now.Ticks.ToString();
            tbxInput3.Text = ToNtp(now).ToString();
            tbxInput4.Text = ToUnixEpoch(now).ToString();
            tbxInput5.Text = now.ToOADate().ToString();
            tbxInput6.Text = now.ToFileTime().ToString();
        }

        private void MakeOutput(DateTime dt, ref string output)
        {
            output += String.Format(FORMAT_READ, ToReadable(dt)) + RTN;
            output += String.Format(FORMAT_TICK, dt.Ticks) + RTN;
            if (IsNtpCompatible(dt))
            {
                output += String.Format(FORMAT_NTPT, ToNtp(dt)) + RTN;
            }
            else
            {
                output += String.Format(FORMAT_NTPT, ERROR_DOMAIN) + RTN;
            }
            if (IsUnixEpochCompatible(dt))
            {
                output += String.Format(FORMAT_UNIX, ToUnixEpoch(dt)) + RTN;
            }
            else
            {
                output += String.Format(FORMAT_UNIX, ERROR_DOMAIN) + RTN;
            }
            try
            {
                output += String.Format(FORMAT_EXEL, dt.ToOADate()) + RTN;
            }
            catch (Exception ex)
            {
                output += String.Format(FORMAT_EXEL, ex.ToString()) + RTN;
            }
            try
            {
                output += String.Format(FORMAT_WNNT, dt.ToFileTime()) + RTN;
            }
            catch (Exception ex)
            {
                output += String.Format(FORMAT_WNNT, ex.ToString()) + RTN;
            }

        }

        #region <Event Handlers>
        private void Form1_Load(object sender, EventArgs e)
        {
            SetNow();
        }

        private void cbxCulture_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxCulture.SelectedIndex;
            var currentCulture = cultures[selectedIndex];
            Thread.CurrentThread.CurrentCulture = currentCulture;
            toolTip1.SetToolTip(cbxCulture, currentCulture.Name);
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            SetNow();
            //btnConv1.PerformClick();
        }

        private void btnJustTime_Click(object sender, EventArgs e)
        {
            var dt = dtpInput1.Value;
            dt = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
            dtpInput1.Value = dt;
            //btnConv1.PerformClick();
        }

        private void btnConv1_Click(object sender, EventArgs e) // Readable
        {
            DateTime dt = dtpInput1.Value;
            string output = "";
            MakeOutput(dt, ref output);
            tbxOutput1.Text += output;
            ScrollToEnd(tbxOutput1);
        }

        private void btnConv2_Click(object sender, EventArgs e) // C# Ticks
        {
            string sTicks = tbxInput2.Text;
            long lTicks;
            DateTime dt;
            string output = "";
            if (long.TryParse(sTicks, out lTicks))
            {
                dt = new DateTime(lTicks);
                MakeOutput(dt, ref output);
            }
            else
            {
                output = String.Format("Invalid input: {0}", sTicks) + RTN;
            }
            tbxOutput1.Text += output;
            ScrollToEnd(tbxOutput1);
        }

        private void btnConv3_Click(object sender, EventArgs e) // NTP
        {
            string sNtp = tbxInput3.Text;
            UInt32 uNtp;
            DateTime dt;
            string output = "";
            if (UInt32.TryParse(sNtp, out uNtp))
            {
                dt = FromNtp(uNtp);
                MakeOutput(dt, ref output);
            }
            else
            {
                output = String.Format("Invalid input: {0}", uNtp) + RTN;
            }
            tbxOutput1.Text += output;
            ScrollToEnd(tbxOutput1);
        }

        private void btnConv4_Click(object sender, EventArgs e) // UNIX
        {
            string sUnix = tbxInput4.Text;
            UInt32 uUnix;
            DateTime dt;
            string output = "";
            if (UInt32.TryParse(sUnix, out uUnix))
            {
                dt = FromUnixEpoch(uUnix);
                MakeOutput(dt, ref output);
            }
            else
            {
                output = String.Format("Invalid input: {0}", uUnix) + RTN;
            }
            tbxOutput1.Text += output;
            ScrollToEnd(tbxOutput1);            
        }

        private void btnConv5_Click(object sender, EventArgs e) // Excel
        {
            string sExcel = tbxInput5.Text;
            double dExcel;
            DateTime dt;
            string output = "";
            try
            {
                dExcel = double.Parse(sExcel);
                dt = DateTime.FromOADate(dExcel);
                MakeOutput(dt, ref output);
            }
            catch (Exception)
            {
                output += String.Format("Invalid input {0}", sExcel) + RTN;
            }
            tbxOutput1.Text += output;
            ScrollToEnd(tbxOutput1);
        }

        private void btnConv6_Click(object sender, EventArgs e) // Win NT
        {
            string sTicks = tbxInput6.Text;
            long lTicks;
            DateTime dt;
            string output = "";
            if (long.TryParse(sTicks, out lTicks))
            {
                dt = DateTime.FromFileTime(lTicks);
                MakeOutput(dt, ref output);
            }
            else
            {
                output = String.Format("Invalid input: {0}", sTicks) + RTN;
            }
            tbxOutput1.Text += output;
            ScrollToEnd(tbxOutput1);

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (tbxOutput1.TextLength > 0)
            {
                Clipboard.Clear();
                Clipboard.SetText(tbxOutput1.Text);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            tbxOutput1.Clear();
        }

        void linkVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(hyperLink);
        }

        #endregion </Event Handlers>
    }
}
