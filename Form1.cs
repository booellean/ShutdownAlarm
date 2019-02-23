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
        private int x = Cursor.Position.X;
        private int y = Cursor.Position.Y;

        public ShutdownAlarm()
        {
            InitializeComponent();
        }

        private void ShutdownAlarm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void ResizeAndMoveContainer(object sender, MouseEventArgs e)
        {
            this.textBoxDynamic.Text = string.Format("X: {0}, Y: {1}, Location: {2}, Button: {3}, Top {4}, Right: {5}, Left: {6}, Bottom: {7}", e.X, e.Y, e.Location, Cursor.Position, this.Top, this.Right, this.Left, this.Bottom); //This logs the x and y position of mouseclick
        }

        private void ChangeMouseCursor(object sender, MouseEventArgs e)
        {
            //Top Left Corner and Bottom Right Corner of Document
            if (((e.X >= 0 && e.X < 5) && (e.Y >= 0 && e.Y < 5)) || ((e.X >= (this.Width - 5) && e.X <= this.Width) && (e.Y >= (this.Height - 5) && e.Y <= this.Height)))
            {
                Cursor.Current = Cursors.SizeNWSE;
            }
            //Top and Bottom of Document
            if (((e.X > 5 && e.X < (this.Width - 5)) && (e.Y >= 0 && e.Y < 5)) || ((e.X > 5 && e.X < (this.Width - 5)) && (e.Y >= (this.Height - 5) && e.Y <= this.Height)))
            {
                Cursor.Current = Cursors.SizeNS;
            }
            //Sides of Document
            if (((e.X >= 0 && e.X < 5) && (e.Y >= 5 && e.Y <= (this.Height - 5))) || ((e.X >= (this.Width - 5) && e.X <= this.Width) && (e.Y >= 5 && e.Y <= (this.Height - 5))))
            {
                Cursor.Current = Cursors.SizeWE;
            }
            //Top Right Corner and Bottom Left Corner of Document
            if (((e.X >= (this.Width - 5) && e.X <= this.Width) && (e.Y >= 0 && e.Y < 5)) || ((e.X >= 0 && e.X < 5) && (e.Y >= (this.Height - 5) && e.Y <= this.Height)))
            {
                Cursor.Current = Cursors.SizeNESW;
            }
        }
    }
}
