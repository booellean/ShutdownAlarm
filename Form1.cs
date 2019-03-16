using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownAlarmApp
{
    public partial class ShutdownAlarm : Form
    {
        const int AMOUNT = 10;
        private bool MAX = false;

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
            Console.WriteLine("Alarm Interface was Loaded");
            this.alarm_panel.Visible = true;
            this.shutdown_panel.Visible = false;
        }

        public void LoadShutdownInterface(object sender, EventArgs e)
        {
            this.alarm_panel.Visible = false;
            this.shutdown_panel.Visible = true;
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

            box.SelectAll();

            if (box == this.hoursFirst)
            {
                if (!((e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.D2) || (e.KeyChar == (char)Keys.NumPad0 || e.KeyChar == (char)Keys.NumPad1 || e.KeyChar == (char)Keys.NumPad2) || (e.KeyChar == (char)Keys.Back)))
                {
                    e.Handled = true;
                }
            }
            if (box == this.hoursSecond)
            {
                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                {
                    e.Handled = true;
                }                   
            }
            if (box == this.minutesFirst)
            {
                if (!(((e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.D2 || e.KeyChar == (char)Keys.D3 || e.KeyChar == (char)Keys.D4 || e.KeyChar == (char)Keys.D5) || ((e.KeyChar == (char)Keys.NumPad0 || e.KeyChar == (char)Keys.NumPad1 || e.KeyChar == (char)Keys.NumPad2 || e.KeyChar == (char)Keys.NumPad3 || e.KeyChar == (char)Keys.NumPad4 || e.KeyChar == (char)Keys.NumPad5)) || (e.KeyChar == (char)Keys.Back))))
                {
                    e.Handled = true;
                }
            }
            if (box == this.minutesSecond)
            {
                if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                {
                    e.Handled = true;
                }
            }
            SendKeys.Send("{TAB}");
        }
    }
}
//this.textBoxDynamic.Text = String.Format("x: {0} y: {1} Width: {2} Height: {3}", this.leftPOS, this.topPOS, this.winWidth, this.winHeight);