using System;
using System.Drawing;
using Microsoft.Win32;

namespace ShutdownAlarmApp
{
    partial class ShutdownAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.shutdown_button = new System.Windows.Forms.Button();
            this.alarm_button = new System.Windows.Forms.Button();
            this.hours_button = new System.Windows.Forms.Button();
            this.time_button = new System.Windows.Forms.Button();
            this.shutdown_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.operations = new System.Windows.Forms.ComboBox();
            this.standardTime = new System.Windows.Forms.Label();
            this.militaryTime = new System.Windows.Forms.Label();
            this.PM = new System.Windows.Forms.Label();
            this.AM = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minutesSecond = new System.Windows.Forms.TextBox();
            this.minutesFirst = new System.Windows.Forms.TextBox();
            this.hoursSecond = new System.Windows.Forms.TextBox();
            this.hoursFirst = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.container_panel = new System.Windows.Forms.Panel();
            this.alarm_panel = new System.Windows.Forms.Panel();
            this.filePathText = new System.Windows.Forms.TextBox();
            this.executeSelectFileToPlay = new System.Windows.Forms.Button();
            this.repeats = new System.Windows.Forms.CheckBox();
            this.closePanel = new System.Windows.Forms.Panel();
            this.maxPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.initiateCountdown = new System.Windows.Forms.Timer(this.components);
            this.countDownTimer = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.hoursPanel = new System.Windows.Forms.Panel();
            this.hours = new System.Windows.Forms.TextBox();
            this.minutes = new System.Windows.Forms.TextBox();
            this.selectFileToPlay = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.shutdown_panel.SuspendLayout();
            this.alarm_panel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.hoursPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shutdown_button
            // 
            this.shutdown_button.Location = new System.Drawing.Point(12, 12);
            this.shutdown_button.Name = "shutdown_button";
            this.shutdown_button.Size = new System.Drawing.Size(214, 84);
            this.shutdown_button.TabIndex = 3;
            this.shutdown_button.Text = "Shutdown";
            this.shutdown_button.UseVisualStyleBackColor = true;
            this.shutdown_button.Click += new System.EventHandler(this.LoadShutdownInterface);
            // 
            // alarm_button
            // 
            this.alarm_button.Location = new System.Drawing.Point(12, 120);
            this.alarm_button.Name = "alarm_button";
            this.alarm_button.Size = new System.Drawing.Size(214, 84);
            this.alarm_button.TabIndex = 2;
            this.alarm_button.Text = "Alarm";
            this.alarm_button.UseVisualStyleBackColor = true;
            this.alarm_button.Click += new System.EventHandler(this.LoadAlarmInterface);
            // 
            // hours_button
            // 
            this.hours_button.Location = new System.Drawing.Point(12, 227);
            this.hours_button.Name = "hours_button";
            this.hours_button.Size = new System.Drawing.Size(150, 49);
            this.hours_button.TabIndex = 5;
            this.hours_button.Text = "Hours";
            this.hours_button.UseVisualStyleBackColor = true;
            this.hours_button.Click += new System.EventHandler(this.LoadHoursInterface);
            // 
            // time_button
            // 
            this.time_button.Location = new System.Drawing.Point(12, 298);
            this.time_button.Name = "time_button";
            this.time_button.Size = new System.Drawing.Size(150, 61);
            this.time_button.TabIndex = 4;
            this.time_button.Text = "Time";
            this.time_button.UseVisualStyleBackColor = true;
            this.time_button.Click += new System.EventHandler(this.LoadTimeInterface);
            // 
            // shutdown_panel
            // 
            this.shutdown_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shutdown_panel.BackColor = System.Drawing.Color.LightGreen;
            this.shutdown_panel.Controls.Add(this.label1);
            this.shutdown_panel.Controls.Add(this.operations);
            this.shutdown_panel.Location = new System.Drawing.Point(271, 24);
            this.shutdown_panel.Name = "shutdown_panel";
            this.shutdown_panel.Size = new System.Drawing.Size(329, 97);
            this.shutdown_panel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // operations
            // 
            this.operations.FormattingEnabled = true;
            this.operations.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Sleep",
            "Hibernate"});
            this.operations.Location = new System.Drawing.Point(23, 41);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(287, 21);
            this.operations.TabIndex = 2;
            this.operations.Text = "Shutdown";
            // 
            // standardTime
            // 
            this.standardTime.AutoSize = true;
            this.standardTime.Location = new System.Drawing.Point(90, 14);
            this.standardTime.Name = "standardTime";
            this.standardTime.Size = new System.Drawing.Size(50, 13);
            this.standardTime.TabIndex = 11;
            this.standardTime.Text = "Standard";
            this.standardTime.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // militaryTime
            // 
            this.militaryTime.AutoSize = true;
            this.militaryTime.Location = new System.Drawing.Point(43, 14);
            this.militaryTime.Name = "militaryTime";
            this.militaryTime.Size = new System.Drawing.Size(39, 13);
            this.militaryTime.TabIndex = 10;
            this.militaryTime.Text = "Military";
            this.militaryTime.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // PM
            // 
            this.PM.AutoSize = true;
            this.PM.Location = new System.Drawing.Point(205, 53);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(23, 13);
            this.PM.TabIndex = 9;
            this.PM.Text = "PM";
            this.PM.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // AM
            // 
            this.AM.AutoSize = true;
            this.AM.Location = new System.Drawing.Point(205, 40);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(23, 13);
            this.AM.TabIndex = 8;
            this.AM.Text = "AM";
            this.AM.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(41, 78);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(302, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // minutesSecond
            // 
            this.minutesSecond.Location = new System.Drawing.Point(157, 40);
            this.minutesSecond.MaxLength = 1;
            this.minutesSecond.Name = "minutesSecond";
            this.minutesSecond.Size = new System.Drawing.Size(27, 20);
            this.minutesSecond.TabIndex = 6;
            this.minutesSecond.Text = "0";
            this.minutesSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // minutesFirst
            // 
            this.minutesFirst.Location = new System.Drawing.Point(124, 40);
            this.minutesFirst.MaxLength = 1;
            this.minutesFirst.Name = "minutesFirst";
            this.minutesFirst.Size = new System.Drawing.Size(27, 20);
            this.minutesFirst.TabIndex = 5;
            this.minutesFirst.Text = "0";
            this.minutesFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // hoursSecond
            // 
            this.hoursSecond.Location = new System.Drawing.Point(80, 40);
            this.hoursSecond.MaxLength = 1;
            this.hoursSecond.Name = "hoursSecond";
            this.hoursSecond.Size = new System.Drawing.Size(27, 20);
            this.hoursSecond.TabIndex = 4;
            this.hoursSecond.Text = "0";
            this.hoursSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // hoursFirst
            // 
            this.hoursFirst.Location = new System.Drawing.Point(46, 40);
            this.hoursFirst.MaxLength = 1;
            this.hoursFirst.Name = "hoursFirst";
            this.hoursFirst.Size = new System.Drawing.Size(28, 20);
            this.hoursFirst.TabIndex = 3;
            this.hoursFirst.Text = "0";
            this.hoursFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(365, 438);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(182, 51);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Set";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // container_panel
            // 
            this.container_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container_panel.AutoSize = true;
            this.container_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.container_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.container_panel.Location = new System.Drawing.Point(0, 47);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(0, 0);
            this.container_panel.TabIndex = 1;
            // 
            // alarm_panel
            // 
            this.alarm_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarm_panel.BackColor = System.Drawing.Color.Maroon;
            this.alarm_panel.Controls.Add(this.filePathText);
            this.alarm_panel.Controls.Add(this.executeSelectFileToPlay);
            this.alarm_panel.Controls.Add(this.repeats);
            this.alarm_panel.Location = new System.Drawing.Point(312, 24);
            this.alarm_panel.Name = "alarm_panel";
            this.alarm_panel.Size = new System.Drawing.Size(329, 122);
            this.alarm_panel.TabIndex = 7;
            this.alarm_panel.Visible = false;
            // 
            // filePathText
            // 
            this.filePathText.Location = new System.Drawing.Point(28, 15);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(241, 20);
            this.filePathText.TabIndex = 2;
            this.filePathText.Text = "...";
            this.filePathText.TextChanged += new System.EventHandler(this.SetVariable);
            // 
            // executeSelectFileToPlay
            // 
            this.executeSelectFileToPlay.Location = new System.Drawing.Point(28, 45);
            this.executeSelectFileToPlay.Name = "executeSelectFileToPlay";
            this.executeSelectFileToPlay.Size = new System.Drawing.Size(121, 23);
            this.executeSelectFileToPlay.TabIndex = 1;
            this.executeSelectFileToPlay.Text = "Browse...";
            this.executeSelectFileToPlay.UseVisualStyleBackColor = true;
            this.executeSelectFileToPlay.Click += new System.EventHandler(this.InitiateFileSearch);
            // 
            // repeats
            // 
            this.repeats.AutoSize = true;
            this.repeats.Location = new System.Drawing.Point(285, 12);
            this.repeats.Name = "repeats";
            this.repeats.Size = new System.Drawing.Size(72, 17);
            this.repeats.TabIndex = 0;
            this.repeats.Text = "Repeats?";
            this.repeats.UseVisualStyleBackColor = true;
            // 
            // closePanel
            // 
            this.closePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePanel.BackColor = System.Drawing.Color.DarkRed;
            this.closePanel.Location = new System.Drawing.Point(632, 2);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(20, 17);
            this.closePanel.TabIndex = 50;
            this.closePanel.Click += new System.EventHandler(this.CloseForm);
            // 
            // maxPanel
            // 
            this.maxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPanel.BackColor = System.Drawing.Color.LightCoral;
            this.maxPanel.Location = new System.Drawing.Point(606, 2);
            this.maxPanel.Name = "maxPanel";
            this.maxPanel.Size = new System.Drawing.Size(20, 17);
            this.maxPanel.TabIndex = 50;
            this.maxPanel.Click += new System.EventHandler(this.MaximizeForm);
            // 
            // minPanel
            // 
            this.minPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minPanel.BackColor = System.Drawing.Color.Lime;
            this.minPanel.Location = new System.Drawing.Point(580, 2);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(20, 17);
            this.minPanel.TabIndex = 50;
            this.minPanel.Click += new System.EventHandler(this.MinimizeForm);
            // 
            // initiateCountdown
            // 
            this.initiateCountdown.Interval = 1000;
            this.initiateCountdown.Tick += new System.EventHandler(this.CountDown);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countDownTimer.AutoSize = true;
            this.countDownTimer.Font = new System.Drawing.Font("8-bit Operator+ SC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownTimer.Location = new System.Drawing.Point(281, 334);
            this.countDownTimer.Name = "countDownTimer";
            this.countDownTimer.Size = new System.Drawing.Size(346, 89);
            this.countDownTimer.TabIndex = 8;
            this.countDownTimer.Text = "00:00:00";
            this.countDownTimer.Click += new System.EventHandler(this.countDownTimer_Click);
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.OrangeRed;
            this.timePanel.Controls.Add(this.hoursPanel);
            this.timePanel.Controls.Add(this.dateTimePicker);
            this.timePanel.Controls.Add(this.standardTime);
            this.timePanel.Controls.Add(this.hoursFirst);
            this.timePanel.Controls.Add(this.militaryTime);
            this.timePanel.Controls.Add(this.hoursSecond);
            this.timePanel.Controls.Add(this.PM);
            this.timePanel.Controls.Add(this.minutesFirst);
            this.timePanel.Controls.Add(this.AM);
            this.timePanel.Controls.Add(this.minutesSecond);
            this.timePanel.Location = new System.Drawing.Point(272, 161);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(355, 149);
            this.timePanel.TabIndex = 8;
            // 
            // hoursPanel
            // 
            this.hoursPanel.BackColor = System.Drawing.Color.Teal;
            this.hoursPanel.Controls.Add(this.hours);
            this.hoursPanel.Controls.Add(this.minutes);
            this.hoursPanel.Location = new System.Drawing.Point(23, 0);
            this.hoursPanel.Name = "hoursPanel";
            this.hoursPanel.Size = new System.Drawing.Size(346, 149);
            this.hoursPanel.TabIndex = 9;
            this.hoursPanel.Visible = false;
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(131, 66);
            this.hours.MaxLength = 2;
            this.hours.Name = "hours";
            this.hours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hours.Size = new System.Drawing.Size(30, 20);
            this.hours.TabIndex = 5;
            this.hours.Text = "00";
            this.hours.TextChanged += new System.EventHandler(this.hours_TextChanged);
            this.hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(185, 66);
            this.minutes.MaxLength = 2;
            this.minutes.Name = "minutes";
            this.minutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minutes.Size = new System.Drawing.Size(30, 20);
            this.minutes.TabIndex = 6;
            this.minutes.Text = "00";
            this.minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // selectFileToPlay
            // 
            this.selectFileToPlay.FileName = "selectFileToPlay";
            this.selectFileToPlay.InitialDirectory = "Desktop";
            this.selectFileToPlay.Title = "Choose a File to Execute at Timer";
            this.selectFileToPlay.FileOk += new System.ComponentModel.CancelEventHandler(this.SetFileLocation);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ShutdownAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(198)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 501);
            this.Controls.Add(this.time_button);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.hours_button);
            this.Controls.Add(this.shutdown_button);
            this.Controls.Add(this.alarm_button);
            this.Controls.Add(this.countDownTimer);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.minPanel);
            this.Controls.Add(this.maxPanel);
            this.Controls.Add(this.closePanel);
            this.Controls.Add(this.shutdown_panel);
            this.Controls.Add(this.alarm_panel);
            this.Controls.Add(this.container_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(652, 501);
            this.Name = "ShutdownAlarm";
            this.Text = "Shutdown";
            this.Load += new System.EventHandler(this.ShutdownAlarm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConvertToPolygon);
            this.Resize += new System.EventHandler(this.ClearGraphics);
            this.shutdown_panel.ResumeLayout(false);
            this.shutdown_panel.PerformLayout();
            this.alarm_panel.ResumeLayout(false);
            this.alarm_panel.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.hoursPanel.ResumeLayout(false);
            this.hoursPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shutdown_button;
        private System.Windows.Forms.Button alarm_button;
        private System.Windows.Forms.Panel shutdown_panel;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.Panel alarm_panel;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Panel maxPanel;
        private System.Windows.Forms.Panel minPanel;
        private System.Windows.Forms.ComboBox operations;
        private System.Windows.Forms.TextBox hoursSecond;
        private System.Windows.Forms.TextBox hoursFirst;
        private System.Windows.Forms.TextBox minutesSecond;
        private System.Windows.Forms.TextBox minutesFirst;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer initiateCountdown;
        private System.Windows.Forms.Label countDownTimer;
        private System.Windows.Forms.Label PM;
        private System.Windows.Forms.Label AM;
        private System.Windows.Forms.Label standardTime;
        private System.Windows.Forms.Label militaryTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Panel hoursPanel;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.TextBox minutes;
        private System.Windows.Forms.Button hours_button;
        private System.Windows.Forms.Button time_button;
        private System.Windows.Forms.CheckBox repeats;
        private System.Windows.Forms.OpenFileDialog selectFileToPlay;
        private System.Windows.Forms.Button executeSelectFileToPlay;
        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.ImageList imageList1;
    }

}

