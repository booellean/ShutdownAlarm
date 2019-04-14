using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ShutdownAlarmApp
{
    public partial class ShutdownAlarm : Form
    {
        const int AMOUNT = 10;
        private bool MAX = false;
        private bool initiate = false;

        //Time Input variables
        private bool miltime = true;
        private bool timeInput = false;
        private string meridiem = "AM";

        //Variables for Countdown effect
        string endString = "";
        DateTime end;

        //Variables for selecting files
        string filePath = "";

        //Responsive Colors and sizes determined for screen sizes
        static Color activeColor = Color.FromArgb(216, 71, 158);
        static Color passiveColor = Color.FromArgb(198, 198, 198);

        public ShutdownAlarm()
        {
            InitializeComponent();
        }

        private void ShutdownAlarm_Load(object sender, EventArgs e)
        {

        }

        // Reset Functionality for BorderLess Form
        // Original code derrived from Sunsetquest
        // 2015/07/03
        // https://stackoverflow.com/questions/31199437/borderless-and-resizable-form-c
        // obtained on 2019/03/09
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= AMOUNT)
                        {
                            if (clientPoint.X <= AMOUNT)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - AMOUNT))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - AMOUNT))
                        {
                            if (clientPoint.X <= AMOUNT)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - AMOUNT))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= AMOUNT)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - AMOUNT))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        //Aesthetic Changing functions

        public void LoadAlarmInterface(object sender, EventArgs e)
        {
            this.alarm_panel.Visible = true;
            this.shutdown_panel.Visible = false;
        }

        public void LoadShutdownInterface(object sender, EventArgs e)
        {
            this.alarm_panel.Visible = false;
            this.shutdown_panel.Visible = true;
        }

        private void LoadTimeInterface(object sender, EventArgs e)
        {
            this.timePanel.Visible = true;
            this.hoursPanel.Visible = false;
        }

        private void LoadHoursInterface(object sender, EventArgs e)
        {
            this.timePanel.Visible = false;
            this.hoursPanel.Visible = true;

        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void MaximizeForm(object sender, EventArgs e)
        {
            if (this.MAX == false)
            {
                WindowState = FormWindowState.Maximized;
                this.MAX = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.MAX = false;
            }
        }

        private void MinimizeForm(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TimeCharCheck(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;

            switch (box.Name)
            {
                case "hoursFirst":
                    box.SelectAll();
                    if (this.miltime == true)
                    {
                        if (!((e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.D2) || (e.KeyChar == (char)Keys.NumPad0 || e.KeyChar == (char)Keys.NumPad1 || e.KeyChar == (char)Keys.NumPad2)))
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if (!(e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.D1 || (e.KeyChar == (char)Keys.NumPad0 || e.KeyChar == (char)Keys.NumPad1)))
                        {
                            e.Handled = true;
                        }
                    }
                    SendKeys.Send("{TAB}");
                    break;
                case "hoursSecond":
                    box.SelectAll();
                    if (this.miltime == true)
                    {
                        if (this.hoursFirst.Text == "2")
                        {
                            if (!(e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.D2 || e.KeyChar == (char)Keys.D3 || e.KeyChar == (char)Keys.NumPad0 || e.KeyChar == (char)Keys.NumPad1 || e.KeyChar == (char)Keys.NumPad2 || e.KeyChar == (char)Keys.NumPad3))
                            {
                                e.Handled = true;
                            }
                        }
                        else
                        {
                            if (!(Char.IsDigit(e.KeyChar)))
                            {
                                e.Handled = true;
                            }
                        }
                    }
                    else
                    {
                        //Adding the focused property gaurantees that only the relevant textbox is checked against relevant textbox
                        if(this.hoursFirst.Text == "1")
                        {
                            if (!(e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.D2 || e.KeyChar == (char)Keys.NumPad1 || e.KeyChar == (char)Keys.NumPad2))
                            {
                                e.Handled = true;
                            }
                        }
                        else
                        {
                            if (!(Char.IsDigit(e.KeyChar)))
                            {
                                e.Handled = true;
                            }
                        }
                    }
                    SendKeys.Send("{TAB}");
                    break;
                case "minutesFirst":
                    box.SelectAll();
                    if (!(((e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.D2 || e.KeyChar == (char)Keys.D3 || e.KeyChar == (char)Keys.D4 || e.KeyChar == (char)Keys.D5) || ((e.KeyChar == (char)Keys.NumPad0 || e.KeyChar == (char)Keys.NumPad1 || e.KeyChar == (char)Keys.NumPad2 || e.KeyChar == (char)Keys.NumPad3 || e.KeyChar == (char)Keys.NumPad4 || e.KeyChar == (char)Keys.NumPad5)))))
                    {
                        e.Handled = true;
                    }
                    SendKeys.Send("{TAB}");
                    break;
                case "minutesSecond":
                    box.SelectAll();
                    if (!(Char.IsDigit(e.KeyChar)))
                    {
                        e.Handled = true;
                    }
                    SendKeys.Send("{TAB}");
                    break;
                case "hours":
                case "minutes":
                    if(box.Text.Length > 1)
                    {
                        box.SelectAll();
                    }
                    if (!(Char.IsDigit(e.KeyChar)))
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    box.Text = "0";
                    break;
            }
        }

        private void SetTimeFormat(object sender, EventArgs e)
        {
            var box = (Label)sender;
            switch (box.Text)
            {
                case "Military":
                    //IMPORTANT: convert prior to changing boolean, prevents errors elsewhere in code
                    var convertedNumbers = ConvertTime(this.hoursFirst.Text, this.hoursSecond.Text);
                    this.hoursFirst.Text = convertedNumbers.Item1;
                    this.hoursSecond.Text = convertedNumbers.Item2;

                    this.miltime = true;
                    break;
                case "Standard":
                    //IMPORTANT: convert prior to changing boolean, prevents errors elsewhere in code

                    convertedNumbers = ConvertTime(this.hoursFirst.Text, this.hoursSecond.Text);
                    this.hoursFirst.Text = convertedNumbers.Item1;
                    this.hoursSecond.Text = convertedNumbers.Item2;

                    this.miltime = false;
                    break;
                case "AM":
                    this.meridiem = "AM";
                    break;
                case "PM":
                    this.meridiem = "PM";
                    break;
                default:
                    this.miltime = true;
                    break;
            }
            this.ChangeTimeLabelFunctions(this.miltime, this.meridiem);
        }

        //Method will change stylings and click events based on SetTimeFormat input
        private void ChangeTimeLabelFunctions(bool time, string meridiem)
        {
            if(time)
            {
                //Remove click events for items
                ChangeTimeLabelStyle(false, this.AM);
                ChangeTimeLabelStyle(false, this.PM);
                this.AM.Click -= new System.EventHandler(this.SetTimeFormat);
                this.PM.Click -= new System.EventHandler(this.SetTimeFormat);
            }
            else
            {
                //Add click events back for items
                ChangeTimeLabelStyle(true, this.AM);
                ChangeTimeLabelStyle(true, this.PM);
                this.AM.Click += new System.EventHandler(this.SetTimeFormat);
                this.PM.Click += new System.EventHandler(this.SetTimeFormat);
            }
        }
 
        private void ChangeTimeLabelStyle(bool clickable, object element)
        {
            var el = (Label)element;
            if (clickable)
            {
                el.ForeColor = activeColor;
            }
            else
            {
                el.ForeColor = passiveColor;

            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.timePanel.Visible)
                {
                    this.end = GetDateTime(this.dateTimePicker.Value, this.hoursFirst.Text, this.hoursSecond.Text, this.minutesFirst.Text, this.minutesSecond.Text);
                    //Check if the time is before now. If so, add a day, most likely are trying to shutdown at midnight
                    if (this.end < DateTime.Now)
                    {
                        this.end = this.end.AddDays(1);
                    }
                }
                else
                {
                    this.end = DateTime.Now.AddHours(int.Parse(this.hours.Text)).AddMinutes(int.Parse(this.minutes.Text));
                }
                
            }
            catch
            {
                this.countDownTimer.Text = "Unexpected Error: Can't Parse Date";
            }
            if (this.initiate == false)
            {
                this.initiateCountdown.Enabled = true;
                this.initiate = true;
                this.Submit.Text = "Cancel";
            }
            else
            {
                this.initiateCountdown.Enabled = false;
                this.initiate = false;
                this.countDownTimer.Text = "00:00:00";
                this.Submit.Text = "Set";
            }
        }

        private DateTime GetDateTime(DateTime dateInput, String firstHour, String secondHour, String firstMinutes, String secondMinutes)
        {
            if(this.miltime == false)
            {
                var convertedNumbers = ConvertTime(firstHour, secondHour);
                firstHour = convertedNumbers.Item1;
                secondHour = convertedNumbers.Item2;
            }
            this.endString = dateInput.ToString("yyyy-MM-dd") + " " + firstHour + secondHour + ":" + firstMinutes + secondMinutes;
            return DateTime.ParseExact(this.endString, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture);
        }

        private Tuple<string, string> ConvertTime(String firstHour, String secondHour)
        {
            int fullNum = int.Parse(firstHour + secondHour);
            if (this.miltime == true)
            {
                //convert to Standard Time
                if (fullNum > 12)
                {
                    this.meridiem = "PM";
                    fullNum -= 12;
                }
                else if (fullNum == 12)
                {
                    this.meridiem = "PM";
                }
                else
                {
                    this.meridiem = "AM";
                }
            }
            else
            {
                //convert to Military Time
                if(this.meridiem == "PM" && fullNum < 12)
                {
                    fullNum += 12;
                }
            }

            //Check if fullNum changed and parse accordingly
            if(fullNum != int.Parse(firstHour + secondHour))
            {
                if (fullNum <= 10)
                {
                    firstHour = "0";
                    secondHour = fullNum.ToString();
                }
                else
                {
                    firstHour = (fullNum.ToString()).Substring(0, 1);
                    secondHour = (fullNum.ToString()).Substring(1, 1);
                }
            }

            return new Tuple<string, string>(firstHour, secondHour);
        }

        private void CountDown(object sender, EventArgs e)
        {
            TimeSpan timeRemaining = this.end - DateTime.Now;
            if(timeRemaining<TimeSpan.Zero)
            {
                this.countDownTimer.Text = "00:00:00";
                if (this.repeats.Checked && this.alarm_panel.Visible)
                {
                    this.end = DateTime.Now.AddHours(int.Parse(this.hours.Text)).AddMinutes(int.Parse(this.minutes.Text));
                }
                else
                {
                    this.initiateCountdown.Enabled = false;
                }

                if (this.shutdown_panel.Visible)
                {
                    switch (this.operations.Text)
                    {
                        case "Shutdown":
                            System.Diagnostics.Process.Start("shutdown", "/s");
                            break;
                        case "Restart":
                            System.Diagnostics.Process.Start("shutdown.exe", "-r");
                            break;
                        case "Sleep":
                            //Try to put computer into sleep mode and, if it fails, hibernate
                            try
                            {
                                Application.SetSuspendState(PowerState.Suspend, true, true);
                            }
                            catch
                            {
                                Application.SetSuspendState(PowerState.Hibernate, true, true);
                            }
                            break;
                        case "Hibernate":
                            //Try to put computer into hibernate and, if it fails, put it to sleep
                            try
                            {
                                Application.SetSuspendState(PowerState.Hibernate, true, true);
                            }
                            catch
                            {
                                Application.SetSuspendState(PowerState.Suspend, true, true);
                            }
                            break;
                        default:
                            System.Diagnostics.Process.Start("shutdown", "/s");
                            break;
                    }
                }
                else
                {
                    WakeUpEvent();
                }            
            }
            else
            {
                this.countDownTimer.Text = String.Format("{0:hh\\:mm\\:ss}",timeRemaining);
            }
        }

        private void WakeUpEvent()
        {
            Process.Start(filePath);
        }

        private void InitiateFileSearch(object sender, EventArgs e)
        {
            DialogResult result = this.selectFileToPlay.ShowDialog();

            if(result == DialogResult.OK)
            {
                this.filePath = this.selectFileToPlay.FileName;
                this.filePathText.Text = this.filePath;
            }
        }

        private void SetFileLocation(object sender, CancelEventArgs e)
        {

        }

        private void SetVariable(object sender, EventArgs e)
        {
            this.filePath = this.filePathText.Text;
        }
    }
}