﻿using System;
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
        private int amount = 10;
        private int diffX;
        private int diffY;
        private int originalY = 0;
        private int originalX = 0;
        private bool mouseDown = false;

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
            //this.textBoxDynamic.Text = string.Format("X: {0}, Y: {1}, Location: {2}, Button: {3}, Top {4}, Right: {5}, Left: {6}, Bottom: {7}", e.X, e.Y, e.Location, Cursor.Position, this.Top, this.Right, this.Left, this.Bottom); //This logs the x and y position of mouseclick
            //Top Left Corner and Bottom Right Corner of Document
            if ((this.IsLeft(e.X) && this.IsTop(e.Y)) || (this.IsRight(e.X) && IsBottom(e.Y)))
            {
                Cursor.Current = Cursors.SizeNWSE;
            }
            //Top and Bottom of Document
            if ((this.IsMiddleX(e.X) && (this.IsTop(e.Y))) || (this.IsMiddleX(e.X) && (this.IsBottom(e.Y))))
            {
                Cursor.Current = Cursors.SizeNS;
                this.textBoxDynamic.Text = string.Format("button: {3}, difference: {0}, Cursor: {1}, Top: {2}", this.diffY, Cursor.Position.Y, this.originalY, e.Button);
                //if (e.Button == MouseButtons.Left)
                //{
                    //this.diffY = Cursor.Position.Y - this.originalY;
                    //this.Height = this.Height + this.diffY;
                    //this.Top = Cursor.Position.Y;
                //}

                this.textBoxDynamic.Text = string.Format("X: {0}, Y: {1}, Location: {2}, Button: {3}, Top {4}, Right: {5}, Left: {6}, Bottom: {7}", e.X, e.Y, e.Location, Cursor.Position, this.Top, this.Right, this.Left, this.Bottom); //This logs the x and y position of mouseclick

                if (e.Button == MouseButtons.Left)
                {
                    this.diffY = Cursor.Position.Y - this.Top;
                    this.textBoxDynamic.Text = string.Format("{0}", sender);
                    this.Height = this.Height + this.diffY;
                }
            }
            //Sides of Document
            if ((this.IsRight(e.X) && this.IsMiddleY(e.Y)) || ((this.IsLeft(e.X) && this.IsMiddleY(e.Y))))
            {
                Cursor.Current = Cursors.SizeWE;
            }
            //Top Right Corner and Bottom Left Corner of Document
            if ((this.IsRight(e.X) && this.IsTop(e.Y)) || (this.IsLeft(e.X) && IsBottom(e.Y)))
            {
                Cursor.Current = Cursors.SizeNESW;
            }
        }

        //methods for returning values

        private bool IsTop(int y){
            if (y >= 0 && y < amount) return true;

            return false;
        }

        private bool IsBottom(int y)
        {
            if (y >= (this.Height - amount) && y <= this.Height) return true;

            return false;
        }

        private bool IsLeft(int x)
        {
            if (x >= 0 && x < amount) return true;

            return false;
        }

        private bool IsRight(int x)
        {
            if (x >= (this.Width - amount) && x <= this.Width) return true;

            return false;
        }
        private bool IsMiddleX(int x)
        {
            if (x > amount && x < (this.Width - amount)) return true;

            return false;
        }
        private bool IsMiddleY(int y)
        {
            if (y >= amount && y <= (this.Height - amount)) return true;

            return false;
        }

        private void MoveOrResizeContainer(object sender, MouseEventArgs e)
        {
            this.originalY = this.Top;
            this.originalX = this.Left;

            //Top and Bottom of Document
                if ((this.IsMiddleX(e.X) && (this.IsTop(e.Y))) || (this.IsMiddleX(e.X) && (this.IsBottom(e.Y))))
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.diffY = Cursor.Position.Y - this.originalY;
                    this.Height = this.Height + this.diffY;
                    this.Top = Cursor.Position.Y;
                }
            }
        }

        private void MoveContainer(object sender, MouseEventArgs e)
        {
            //while(this.mouseDown)
            //{
                if (this.IsMiddleX(e.X) && ((e.Y >= amount) && (e.Y < 30)))
                {
                    this.Top = Cursor.Position.Y;
                }
            //}
        }
    }
}
