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

            ////Top Left Corner and Bottom Right Corner of Document
            //if ((this.IsLeft(e.X) && this.IsTop(e.Y)) || (this.IsRight(e.X) && IsBottom(e.Y)))
            //{
            //    Cursor.Current = Cursors.SizeNWSE;
            //}
            ////Top and Bottom of Document
            //if ((this.IsMiddleX(e.X) && (this.IsTop(e.Y))) || (this.IsMiddleX(e.X) && (this.IsBottom(e.Y))))
            //{
            //    Cursor.Current = Cursors.SizeNS;
            //    //if (e.Button == MouseButtons.Left)
            //    //{
            //        //this.diffY = Cursor.Position.Y - somethingElse;
            //        //this.Height = this.Height + this.diffY;
            //        //this.Top = Cursor.Position.Y;
            //    //}

            //    if (e.Button == MouseButtons.Left)
            //    {
            //        //this.diffY = Cursor.Position.Y - this.Top;
            //        this.textBoxDynamic.Text = string.Format("{0}", sender);
            //        //this.Height = this.Height + this.diffY;
            //    }
            //}
            ////Sides of Document
            //if ((this.IsRight(e.X) && this.IsMiddleY(e.Y)) || ((this.IsLeft(e.X) && this.IsMiddleY(e.Y))))
            //{
            //    Cursor.Current = Cursors.SizeWE;
            //}
            ////Top Right Corner and Bottom Left Corner of Document
            //if ((this.IsRight(e.X) && this.IsTop(e.Y)) || (this.IsLeft(e.X) && IsBottom(e.Y)))
            //{
            //    Cursor.Current = Cursors.SizeNESW;
            //}
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

        private void InitiateMoveAndResizeEvents(object sender, EventArgs e)
        {   
        //    this.textBoxDynamic.Text = string.Format("X:{0}, Y:{1}, PrevX: {2}, PrevY: {3}", (Cursor.Position.X - this.xPos), (Cursor.Position.Y - this.yPos), Cursor.Position.X, Cursor.Position.Y);

        //    //Move only if mouse click position is in upper bar
        //    if(IsMiddleX(this.xRelPos) && (this.yRelPos >= AMOUNT && this.yRelPos < 23)){
        //        Cursor.Current = Cursors.Arrow;
        //        this.SetDesktopLocation(this.Location.X + (Cursor.Position.X - this.xPos), this.Location.Y + (Cursor.Position.Y - this.yPos));
        //    }
        //    else
        //    {
        //        //Top Left Corner
        //        if ((this.IsLeft(this.xRelPos) && this.IsTop(this.yRelPos)))
        //        {
        //            Cursor.Current = Cursors.SizeNWSE;
        //            this.Height = this.Height - (Cursor.Position.Y - this.yPos);
        //            this.Width = this.Width - (Cursor.Position.X - this.xPos);
        //            this.SetDesktopLocation(this.Location.X + (Cursor.Position.X - this.xPos), this.Location.Y + (Cursor.Position.Y - this.yPos));
        //        }
        //        //Bottom Right Corner of Document
        //        if ((this.IsRight(this.xRelPos) && IsBottom(this.yRelPos)))
        //        {
        //            Cursor.Current = Cursors.SizeNWSE;
        //            this.Height = this.Height + (Cursor.Position.Y - this.yPos);
        //            this.Width = this.Width + (Cursor.Position.X - this.xPos);
        //        }
        //        //Top of Document
        //        if ((this.IsMiddleX(this.xRelPos) && (this.IsTop(this.yRelPos))))
        //        {
        //            Cursor.Current = Cursors.SizeNS;
        //        }
        //        //Bottom of Document
        //        if ((this.IsMiddleX(this.xRelPos) && (this.IsBottom(this.yRelPos))))
        //        {
        //            Cursor.Current = Cursors.SizeNS;
        //        }
        //        //Right Side of Document
        //        if ((this.IsRight(this.xRelPos) && this.IsMiddleY(this.yRelPos)))
        //        {
        //            Cursor.Current = Cursors.SizeWE;
        //        }
        //        //Left Side of Document
        //        if (((this.IsLeft(this.xRelPos) && this.IsMiddleY(this.yRelPos))))
        //        {
        //            Cursor.Current = Cursors.SizeWE;
        //        }
        //        //Top Right Corner of Document
        //        if ((this.IsRight(this.xRelPos) && this.IsTop(this.yRelPos)))
        //        {
        //            Cursor.Current = Cursors.SizeNESW;
        //        }
        //        //Bottom Left Corner of Document
        //        if ((this.IsLeft(this.xRelPos) && IsBottom(this.yRelPos)))
        //        {
        //            Cursor.Current = Cursors.SizeNESW;
        //        }
        //    }

        //    //Reset the previous coordinates at end after changes
        //    this.xPos = Cursor.Position.X;
        //    this.yPos = Cursor.Position.Y;
        }
        private void MouseDownChange(object sender, MouseEventArgs e)
        {
        //    //Set the previous coordinates before the timer starts
        //    this.xPos = Cursor.Position.X;
        //    this.yPos = Cursor.Position.Y;
        //    //Position of mouse relative to Panels
        //    this.xRelPos = e.Location.X;
        //    this.yRelPos = e.Location.Y;
        //    //start the timer
        //    loopTimer.Enabled = true;
        //    loopTimer.Start();
        }
        private void MouseUpChange(object sender, MouseEventArgs e)
        {
        //    loopTimer.Stop();
        //    this.textBoxDynamic.Text = string.Format("Loop Timer Just stopped!");
        }
    }
}
