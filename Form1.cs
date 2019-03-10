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
        private int diffX;
        private int diffY;
        private int yPos;
        private int xPos;
        private int yRelPos;
        private int xRelPos;

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

        private void ChangeMouseCursor(object sender, MouseEventArgs e)
        {

        }

        //methods for returning values

        private bool IsTop(int y){
            if (y >= 0 && y < AMOUNT) return true;

            return false;
        }

        private bool IsBottom(int y)
        {
            if (y >= (this.Height - AMOUNT) && y <= this.Height) return true;

            return false;
        }

        private bool IsLeft(int x)
        {
            if (x >= 0 && x < AMOUNT) return true;

            return false;
        }

        private bool IsRight(int x)
        {
            if (x >= (this.Width - AMOUNT) && x <= this.Width) return true;

            return false;
        }
        private bool IsMiddleX(int x)
        {
            if (x > AMOUNT && x < (this.Width - AMOUNT)) return true;

            return false;
        }
        private bool IsMiddleY(int y)
        {
            if (y >= AMOUNT && y <= (this.Height - AMOUNT)) return true;

            return false;
        }
    }
}
