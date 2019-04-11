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
            this.menu_panel = new System.Windows.Forms.Panel();
            this.shutdown_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.standardTime = new System.Windows.Forms.Label();
            this.militaryTime = new System.Windows.Forms.Label();
            this.PM = new System.Windows.Forms.Label();
            this.AM = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minutesSecond = new System.Windows.Forms.TextBox();
            this.minutesFirst = new System.Windows.Forms.TextBox();
            this.hoursSecond = new System.Windows.Forms.TextBox();
            this.hoursFirst = new System.Windows.Forms.TextBox();
            this.operations = new System.Windows.Forms.ComboBox();
            this.textBoxDynamic = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.container_panel = new System.Windows.Forms.Panel();
            this.alarm_panel = new System.Windows.Forms.Panel();
            this.alarmPM = new System.Windows.Forms.Label();
            this.alarmAM = new System.Windows.Forms.Label();
            this.alarmDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.alarmMinutesSecond = new System.Windows.Forms.TextBox();
            this.alarmMinutesFirst = new System.Windows.Forms.TextBox();
            this.alarmHoursSecond = new System.Windows.Forms.TextBox();
            this.alarmHoursFirst = new System.Windows.Forms.TextBox();
            this.closePanel = new System.Windows.Forms.Panel();
            this.maxPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.initiateCountdown = new System.Windows.Forms.Timer(this.components);
            this.countDownTimer = new System.Windows.Forms.Label();
            this.initiateWakeUp = new System.Windows.Forms.Timer(this.components);
            this.menu_panel.SuspendLayout();
            this.shutdown_panel.SuspendLayout();
            this.alarm_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shutdown_button
            // 
            this.shutdown_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shutdown_button.Location = new System.Drawing.Point(11, 109);
            this.shutdown_button.Name = "shutdown_button";
            this.shutdown_button.Size = new System.Drawing.Size(226, 84);
            this.shutdown_button.TabIndex = 0;
            this.shutdown_button.Text = "Shutdown";
            this.shutdown_button.UseVisualStyleBackColor = true;
            this.shutdown_button.Click += new System.EventHandler(this.LoadShutdownInterface);
            // 
            // alarm_button
            // 
            this.alarm_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarm_button.Location = new System.Drawing.Point(11, 12);
            this.alarm_button.Name = "alarm_button";
            this.alarm_button.Size = new System.Drawing.Size(226, 84);
            this.alarm_button.TabIndex = 2;
            this.alarm_button.Text = "Alarm";
            this.alarm_button.UseVisualStyleBackColor = true;
            this.alarm_button.Click += new System.EventHandler(this.LoadAlarmInterface);
            // 
            // menu_panel
            // 
            this.menu_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu_panel.BackColor = System.Drawing.Color.Navy;
            this.menu_panel.Controls.Add(this.shutdown_button);
            this.menu_panel.Controls.Add(this.alarm_button);
            this.menu_panel.Location = new System.Drawing.Point(12, 25);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(249, 464);
            this.menu_panel.TabIndex = 1;
            // 
            // shutdown_panel
            // 
            this.shutdown_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shutdown_panel.BackColor = System.Drawing.Color.LightGreen;
            this.shutdown_panel.Controls.Add(this.label1);
            this.shutdown_panel.Controls.Add(this.standardTime);
            this.shutdown_panel.Controls.Add(this.militaryTime);
            this.shutdown_panel.Controls.Add(this.PM);
            this.shutdown_panel.Controls.Add(this.AM);
            this.shutdown_panel.Controls.Add(this.dateTimePicker);
            this.shutdown_panel.Controls.Add(this.minutesSecond);
            this.shutdown_panel.Controls.Add(this.minutesFirst);
            this.shutdown_panel.Controls.Add(this.hoursSecond);
            this.shutdown_panel.Controls.Add(this.hoursFirst);
            this.shutdown_panel.Controls.Add(this.operations);
            this.shutdown_panel.Controls.Add(this.textBoxDynamic);
            this.shutdown_panel.Location = new System.Drawing.Point(271, 24);
            this.shutdown_panel.Name = "shutdown_panel";
            this.shutdown_panel.Size = new System.Drawing.Size(370, 205);
            this.shutdown_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // standardTime
            // 
            this.standardTime.AutoSize = true;
            this.standardTime.Location = new System.Drawing.Point(91, 110);
            this.standardTime.Name = "standardTime";
            this.standardTime.Size = new System.Drawing.Size(50, 13);
            this.standardTime.TabIndex = 11;
            this.standardTime.Text = "Standard";
            this.standardTime.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // militaryTime
            // 
            this.militaryTime.AutoSize = true;
            this.militaryTime.Location = new System.Drawing.Point(44, 110);
            this.militaryTime.Name = "militaryTime";
            this.militaryTime.Size = new System.Drawing.Size(39, 13);
            this.militaryTime.TabIndex = 10;
            this.militaryTime.Text = "Military";
            this.militaryTime.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // PM
            // 
            this.PM.AutoSize = true;
            this.PM.Location = new System.Drawing.Point(206, 149);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(23, 13);
            this.PM.TabIndex = 9;
            this.PM.Text = "PM";
            this.PM.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // AM
            // 
            this.AM.AutoSize = true;
            this.AM.Location = new System.Drawing.Point(206, 136);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(23, 13);
            this.AM.TabIndex = 8;
            this.AM.Text = "AM";
            this.AM.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(42, 174);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(302, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // minutesSecond
            // 
            this.minutesSecond.Location = new System.Drawing.Point(158, 136);
            this.minutesSecond.MaxLength = 1;
            this.minutesSecond.Name = "minutesSecond";
            this.minutesSecond.Size = new System.Drawing.Size(27, 20);
            this.minutesSecond.TabIndex = 6;
            this.minutesSecond.Text = "0";
            this.minutesSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // minutesFirst
            // 
            this.minutesFirst.Location = new System.Drawing.Point(125, 136);
            this.minutesFirst.MaxLength = 1;
            this.minutesFirst.Name = "minutesFirst";
            this.minutesFirst.Size = new System.Drawing.Size(27, 20);
            this.minutesFirst.TabIndex = 5;
            this.minutesFirst.Text = "0";
            this.minutesFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // hoursSecond
            // 
            this.hoursSecond.Location = new System.Drawing.Point(81, 136);
            this.hoursSecond.MaxLength = 1;
            this.hoursSecond.Name = "hoursSecond";
            this.hoursSecond.Size = new System.Drawing.Size(27, 20);
            this.hoursSecond.TabIndex = 4;
            this.hoursSecond.Text = "0";
            this.hoursSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // hoursFirst
            // 
            this.hoursFirst.Location = new System.Drawing.Point(47, 136);
            this.hoursFirst.MaxLength = 1;
            this.hoursFirst.Name = "hoursFirst";
            this.hoursFirst.Size = new System.Drawing.Size(28, 20);
            this.hoursFirst.TabIndex = 3;
            this.hoursFirst.Text = "0";
            this.hoursFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // operations
            // 
            this.operations.FormattingEnabled = true;
            this.operations.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Sleep",
            "Hibernate"});
            this.operations.Location = new System.Drawing.Point(42, 61);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(287, 21);
            this.operations.TabIndex = 2;
            this.operations.Text = "Shutdown";
            // 
            // textBoxDynamic
            // 
            this.textBoxDynamic.Location = new System.Drawing.Point(42, 13);
            this.textBoxDynamic.Name = "textBoxDynamic";
            this.textBoxDynamic.Size = new System.Drawing.Size(287, 20);
            this.textBoxDynamic.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(365, 438);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(182, 51);
            this.Submit.TabIndex = 7;
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
            this.alarm_panel.Controls.Add(this.alarmPM);
            this.alarm_panel.Controls.Add(this.alarmAM);
            this.alarm_panel.Controls.Add(this.alarmDateTimePicker);
            this.alarm_panel.Controls.Add(this.alarmMinutesSecond);
            this.alarm_panel.Controls.Add(this.alarmMinutesFirst);
            this.alarm_panel.Controls.Add(this.alarmHoursSecond);
            this.alarm_panel.Controls.Add(this.alarmHoursFirst);
            this.alarm_panel.Location = new System.Drawing.Point(271, 235);
            this.alarm_panel.Name = "alarm_panel";
            this.alarm_panel.Size = new System.Drawing.Size(369, 137);
            this.alarm_panel.TabIndex = 3;
            this.alarm_panel.Visible = false;
            // 
            // alarmPM
            // 
            this.alarmPM.AutoSize = true;
            this.alarmPM.Location = new System.Drawing.Point(206, 58);
            this.alarmPM.Name = "alarmPM";
            this.alarmPM.Size = new System.Drawing.Size(23, 13);
            this.alarmPM.TabIndex = 16;
            this.alarmPM.Text = "PM";
            // 
            // alarmAM
            // 
            this.alarmAM.AutoSize = true;
            this.alarmAM.Location = new System.Drawing.Point(206, 45);
            this.alarmAM.Name = "alarmAM";
            this.alarmAM.Size = new System.Drawing.Size(23, 13);
            this.alarmAM.TabIndex = 15;
            this.alarmAM.Text = "AM";
            // 
            // alarmDateTimePicker
            // 
            this.alarmDateTimePicker.Location = new System.Drawing.Point(42, 83);
            this.alarmDateTimePicker.Name = "alarmDateTimePicker";
            this.alarmDateTimePicker.Size = new System.Drawing.Size(302, 20);
            this.alarmDateTimePicker.TabIndex = 14;
            // 
            // alarmMinutesSecond
            // 
            this.alarmMinutesSecond.Location = new System.Drawing.Point(158, 45);
            this.alarmMinutesSecond.MaxLength = 1;
            this.alarmMinutesSecond.Name = "alarmMinutesSecond";
            this.alarmMinutesSecond.Size = new System.Drawing.Size(27, 20);
            this.alarmMinutesSecond.TabIndex = 13;
            this.alarmMinutesSecond.Text = "0";
            this.alarmMinutesSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // alarmMinutesFirst
            // 
            this.alarmMinutesFirst.Location = new System.Drawing.Point(125, 45);
            this.alarmMinutesFirst.MaxLength = 1;
            this.alarmMinutesFirst.Name = "alarmMinutesFirst";
            this.alarmMinutesFirst.Size = new System.Drawing.Size(27, 20);
            this.alarmMinutesFirst.TabIndex = 12;
            this.alarmMinutesFirst.Text = "0";
            this.alarmMinutesFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // alarmHoursSecond
            // 
            this.alarmHoursSecond.Location = new System.Drawing.Point(81, 45);
            this.alarmHoursSecond.MaxLength = 1;
            this.alarmHoursSecond.Name = "alarmHoursSecond";
            this.alarmHoursSecond.Size = new System.Drawing.Size(27, 20);
            this.alarmHoursSecond.TabIndex = 11;
            this.alarmHoursSecond.Text = "0";
            this.alarmHoursSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // alarmHoursFirst
            // 
            this.alarmHoursFirst.Location = new System.Drawing.Point(47, 45);
            this.alarmHoursFirst.MaxLength = 1;
            this.alarmHoursFirst.Name = "alarmHoursFirst";
            this.alarmHoursFirst.Size = new System.Drawing.Size(28, 20);
            this.alarmHoursFirst.TabIndex = 10;
            this.alarmHoursFirst.Text = "0";
            this.alarmHoursFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // closePanel
            // 
            this.closePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePanel.BackColor = System.Drawing.Color.DarkRed;
            this.closePanel.Location = new System.Drawing.Point(632, 2);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(20, 17);
            this.closePanel.TabIndex = 4;
            this.closePanel.Click += new System.EventHandler(this.CloseForm);
            // 
            // maxPanel
            // 
            this.maxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPanel.BackColor = System.Drawing.Color.LightCoral;
            this.maxPanel.Location = new System.Drawing.Point(606, 2);
            this.maxPanel.Name = "maxPanel";
            this.maxPanel.Size = new System.Drawing.Size(20, 17);
            this.maxPanel.TabIndex = 5;
            this.maxPanel.Click += new System.EventHandler(this.MaximizeForm);
            // 
            // minPanel
            // 
            this.minPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minPanel.BackColor = System.Drawing.Color.Lime;
            this.minPanel.Location = new System.Drawing.Point(580, 2);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(20, 17);
            this.minPanel.TabIndex = 6;
            this.minPanel.Click += new System.EventHandler(this.MinimizeForm);
            // 
            // initiateCountdown
            // 
            this.initiateCountdown.Interval = 1000;
            this.initiateCountdown.Tick += new System.EventHandler(this.CountDown);
            // 
            // countDownTimer
            // 
            this.countDownTimer.AutoSize = true;
            this.countDownTimer.Location = new System.Drawing.Point(435, 409);
            this.countDownTimer.Name = "countDownTimer";
            this.countDownTimer.Size = new System.Drawing.Size(49, 13);
            this.countDownTimer.TabIndex = 8;
            this.countDownTimer.Text = "00:00:00";
            // 
            // initiateWakeUp
            // 
            this.initiateWakeUp.Tick += new System.EventHandler(this.WakeUpEvent);
            // 
            // ShutdownAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(652, 501);
            this.Controls.Add(this.countDownTimer);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.minPanel);
            this.Controls.Add(this.maxPanel);
            this.Controls.Add(this.closePanel);
            this.Controls.Add(this.shutdown_panel);
            this.Controls.Add(this.alarm_panel);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.container_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(652, 501);
            this.Name = "ShutdownAlarm";
            this.Text = "Shutdown";
            this.Load += new System.EventHandler(this.ShutdownAlarm_Load);
            this.menu_panel.ResumeLayout(false);
            this.shutdown_panel.ResumeLayout(false);
            this.shutdown_panel.PerformLayout();
            this.alarm_panel.ResumeLayout(false);
            this.alarm_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shutdown_button;
        private System.Windows.Forms.Button alarm_button;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel shutdown_panel;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.Panel alarm_panel;
        private System.Windows.Forms.TextBox textBoxDynamic;
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
        private System.Windows.Forms.Label alarmPM;
        private System.Windows.Forms.Label alarmAM;
        private System.Windows.Forms.DateTimePicker alarmDateTimePicker;
        private System.Windows.Forms.TextBox alarmMinutesSecond;
        private System.Windows.Forms.TextBox alarmMinutesFirst;
        private System.Windows.Forms.TextBox alarmHoursSecond;
        private System.Windows.Forms.TextBox alarmHoursFirst;
        private System.Windows.Forms.Timer initiateWakeUp;
    }

}

