﻿using System;
using System.Drawing;
using System.Windows.Forms;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownAlarm));
            this.shutdown_button = new System.Windows.Forms.Button();
            this.alarm_button = new System.Windows.Forms.Button();
            this.hours_button = new System.Windows.Forms.Button();
            this.time_button = new System.Windows.Forms.Button();
            this.shutdown_panel = new System.Windows.Forms.Panel();
            this.operations = new System.Windows.Forms.ComboBox();
            this.standardTime = new System.Windows.Forms.Label();
            this.militaryTime = new System.Windows.Forms.Label();
            this.PM = new System.Windows.Forms.Label();
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
            this.initiateCountdown = new System.Windows.Forms.Timer(this.components);
            this.countDownTimer = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.AM = new System.Windows.Forms.Label();
            this.clockColon = new System.Windows.Forms.Label();
            this.backSlashLabel = new System.Windows.Forms.Label();
            this.hoursPanel = new System.Windows.Forms.Panel();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.TextBox();
            this.minutes = new System.Windows.Forms.TextBox();
            this.colon = new System.Windows.Forms.Label();
            this.minuteZero = new System.Windows.Forms.Label();
            this.hourZero = new System.Windows.Forms.Label();
            this.selectFileToPlay = new System.Windows.Forms.OpenFileDialog();
            this.controls_panel = new System.Windows.Forms.Panel();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.maxPanel = new System.Windows.Forms.Panel();
            this.closePanel = new System.Windows.Forms.Panel();
            this.shutdown_panel.SuspendLayout();
            this.alarm_panel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.hoursPanel.SuspendLayout();
            this.controls_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shutdown_button
            // 
            this.shutdown_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shutdown_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.shutdown_button.FlatAppearance.BorderSize = 0;
            this.shutdown_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdown_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdown_button.Location = new System.Drawing.Point(12, 12);
            this.shutdown_button.Name = "shutdown_button";
            this.shutdown_button.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.shutdown_button.Size = new System.Drawing.Size(166, 70);
            this.shutdown_button.TabIndex = 3;
            this.shutdown_button.TabStop = false;
            this.shutdown_button.Text = "Shutdown";
            this.shutdown_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shutdown_button.UseVisualStyleBackColor = false;
            this.shutdown_button.Click += new System.EventHandler(this.LoadShutdownInterface);
            // 
            // alarm_button
            // 
            this.alarm_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarm_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.alarm_button.FlatAppearance.BorderSize = 0;
            this.alarm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_button.Location = new System.Drawing.Point(12, 107);
            this.alarm_button.Name = "alarm_button";
            this.alarm_button.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.alarm_button.Size = new System.Drawing.Size(166, 69);
            this.alarm_button.TabIndex = 2;
            this.alarm_button.TabStop = false;
            this.alarm_button.Text = "Alarm";
            this.alarm_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alarm_button.UseVisualStyleBackColor = false;
            this.alarm_button.Click += new System.EventHandler(this.LoadAlarmInterface);
            // 
            // hours_button
            // 
            this.hours_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hours_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.hours_button.FlatAppearance.BorderSize = 0;
            this.hours_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hours_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_button.Location = new System.Drawing.Point(12, 279);
            this.hours_button.Name = "hours_button";
            this.hours_button.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.hours_button.Size = new System.Drawing.Size(84, 49);
            this.hours_button.TabIndex = 5;
            this.hours_button.TabStop = false;
            this.hours_button.Text = "Hours";
            this.hours_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hours_button.UseVisualStyleBackColor = false;
            this.hours_button.Click += new System.EventHandler(this.LoadHoursInterface);
            // 
            // time_button
            // 
            this.time_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.time_button.FlatAppearance.BorderSize = 0;
            this.time_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_button.Location = new System.Drawing.Point(12, 345);
            this.time_button.Name = "time_button";
            this.time_button.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.time_button.Size = new System.Drawing.Size(84, 49);
            this.time_button.TabIndex = 4;
            this.time_button.TabStop = false;
            this.time_button.Text = "Time";
            this.time_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time_button.UseVisualStyleBackColor = false;
            this.time_button.Click += new System.EventHandler(this.LoadTimeInterface);
            // 
            // shutdown_panel
            // 
            this.shutdown_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shutdown_panel.BackColor = System.Drawing.Color.Transparent;
            this.shutdown_panel.Controls.Add(this.operations);
            this.shutdown_panel.Location = new System.Drawing.Point(0, 0);
            this.shutdown_panel.Name = "shutdown_panel";
            this.shutdown_panel.Size = new System.Drawing.Size(382, 91);
            this.shutdown_panel.TabIndex = 6;
            // 
            // operations
            // 
            this.operations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operations.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.operations.FormattingEnabled = true;
            this.operations.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Sleep",
            "Hibernate"});
            this.operations.Location = new System.Drawing.Point(45, 32);
            this.operations.Margin = new System.Windows.Forms.Padding(0);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(302, 33);
            this.operations.TabIndex = 2;
            this.operations.Text = "Shutdown";
            // 
            // standardTime
            // 
            this.standardTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.standardTime.AutoSize = true;
            this.standardTime.BackColor = System.Drawing.Color.Transparent;
            this.standardTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardTime.Location = new System.Drawing.Point(183, 21);
            this.standardTime.Name = "standardTime";
            this.standardTime.Size = new System.Drawing.Size(92, 25);
            this.standardTime.TabIndex = 11;
            this.standardTime.Text = "Standard";
            this.standardTime.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // militaryTime
            // 
            this.militaryTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.militaryTime.AutoSize = true;
            this.militaryTime.BackColor = System.Drawing.Color.Transparent;
            this.militaryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.militaryTime.Location = new System.Drawing.Point(88, 20);
            this.militaryTime.Name = "militaryTime";
            this.militaryTime.Size = new System.Drawing.Size(73, 25);
            this.militaryTime.TabIndex = 10;
            this.militaryTime.Text = "Military";
            this.militaryTime.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // PM
            // 
            this.PM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PM.AutoSize = true;
            this.PM.BackColor = System.Drawing.Color.Transparent;
            this.PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM.Location = new System.Drawing.Point(252, 94);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(32, 20);
            this.PM.TabIndex = 9;
            this.PM.Text = "PM";
            this.PM.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.AccessibleName = "Calendar";
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker.CustomFormat = "MMMM yyyy/MM/dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(30, 137);
            this.dateTimePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(315, 31);
            this.dateTimePicker.TabIndex = 7;
            // 
            // minutesSecond
            // 
            this.minutesSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minutesSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesSecond.Location = new System.Drawing.Point(209, 70);
            this.minutesSecond.MaxLength = 1;
            this.minutesSecond.Name = "minutesSecond";
            this.minutesSecond.Size = new System.Drawing.Size(27, 44);
            this.minutesSecond.TabIndex = 6;
            this.minutesSecond.Text = "0";
            this.minutesSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // minutesFirst
            // 
            this.minutesFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minutesFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesFirst.Location = new System.Drawing.Point(176, 70);
            this.minutesFirst.MaxLength = 1;
            this.minutesFirst.Name = "minutesFirst";
            this.minutesFirst.Size = new System.Drawing.Size(27, 44);
            this.minutesFirst.TabIndex = 5;
            this.minutesFirst.Text = "0";
            this.minutesFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // hoursSecond
            // 
            this.hoursSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hoursSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursSecond.Location = new System.Drawing.Point(132, 70);
            this.hoursSecond.MaxLength = 1;
            this.hoursSecond.Name = "hoursSecond";
            this.hoursSecond.Size = new System.Drawing.Size(27, 44);
            this.hoursSecond.TabIndex = 4;
            this.hoursSecond.Text = "0";
            this.hoursSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // hoursFirst
            // 
            this.hoursFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hoursFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursFirst.Location = new System.Drawing.Point(98, 70);
            this.hoursFirst.MaxLength = 1;
            this.hoursFirst.Name = "hoursFirst";
            this.hoursFirst.Size = new System.Drawing.Size(28, 44);
            this.hoursFirst.TabIndex = 3;
            this.hoursFirst.Text = "0";
            this.hoursFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // Submit
            // 
            this.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(119, 395);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(138, 43);
            this.Submit.TabIndex = 10;
            this.Submit.TabStop = false;
            this.Submit.Text = "Set";
            this.Submit.UseCompatibleTextRendering = true;
            this.Submit.UseVisualStyleBackColor = false;
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
            this.container_panel.Location = new System.Drawing.Point(0, 46);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(0, 0);
            this.container_panel.TabIndex = 1;
            // 
            // alarm_panel
            // 
            this.alarm_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarm_panel.BackColor = System.Drawing.Color.Transparent;
            this.alarm_panel.Controls.Add(this.filePathText);
            this.alarm_panel.Controls.Add(this.executeSelectFileToPlay);
            this.alarm_panel.Location = new System.Drawing.Point(0, 0);
            this.alarm_panel.Name = "alarm_panel";
            this.alarm_panel.Size = new System.Drawing.Size(382, 91);
            this.alarm_panel.TabIndex = 7;
            this.alarm_panel.Visible = false;
            // 
            // filePathText
            // 
            this.filePathText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathText.Location = new System.Drawing.Point(21, 12);
            this.filePathText.Name = "filePathText";
            this.filePathText.Size = new System.Drawing.Size(342, 20);
            this.filePathText.TabIndex = 2;
            this.filePathText.Text = "...";
            this.filePathText.TextChanged += new System.EventHandler(this.SetVariable);
            // 
            // executeSelectFileToPlay
            // 
            this.executeSelectFileToPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.executeSelectFileToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.executeSelectFileToPlay.FlatAppearance.BorderSize = 0;
            this.executeSelectFileToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeSelectFileToPlay.Location = new System.Drawing.Point(242, 55);
            this.executeSelectFileToPlay.Name = "executeSelectFileToPlay";
            this.executeSelectFileToPlay.Size = new System.Drawing.Size(121, 23);
            this.executeSelectFileToPlay.TabIndex = 1;
            this.executeSelectFileToPlay.TabStop = false;
            this.executeSelectFileToPlay.Text = "Browse...";
            this.executeSelectFileToPlay.UseVisualStyleBackColor = false;
            this.executeSelectFileToPlay.Click += new System.EventHandler(this.LoadAlarmInterface);
            // 
            // repeats
            // 
            this.repeats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repeats.AutoSize = true;
            this.repeats.Location = new System.Drawing.Point(168, 133);
            this.repeats.Name = "repeats";
            this.repeats.Size = new System.Drawing.Size(67, 17);
            this.repeats.TabIndex = 0;
            this.repeats.Text = "Repeat?";
            this.repeats.UseVisualStyleBackColor = true;
            this.repeats.CheckedChanged += new System.EventHandler(this.repeatsCheckedChanged);
            // 
            // initiateCountdown
            // 
            this.initiateCountdown.Interval = 1000;
            this.initiateCountdown.Tick += new System.EventHandler(this.CountDown);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countDownTimer.BackColor = System.Drawing.Color.Transparent;
            this.countDownTimer.Enabled = false;
            this.countDownTimer.Font = new System.Drawing.Font("8-bit Operator+ SC", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownTimer.Location = new System.Drawing.Point(0, 290);
            this.countDownTimer.Name = "countDownTimer";
            this.countDownTimer.Size = new System.Drawing.Size(382, 89);
            this.countDownTimer.TabIndex = 8;
            this.countDownTimer.Text = "00:00:00";
            this.countDownTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countDownTimer.Click += new System.EventHandler(this.countDownTimer_Click);
            // 
            // timePanel
            // 
            this.timePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePanel.BackColor = System.Drawing.Color.Transparent;
            this.timePanel.Controls.Add(this.dateTimePicker);
            this.timePanel.Controls.Add(this.hoursFirst);
            this.timePanel.Controls.Add(this.militaryTime);
            this.timePanel.Controls.Add(this.hoursSecond);
            this.timePanel.Controls.Add(this.PM);
            this.timePanel.Controls.Add(this.minutesFirst);
            this.timePanel.Controls.Add(this.AM);
            this.timePanel.Controls.Add(this.minutesSecond);
            this.timePanel.Controls.Add(this.clockColon);
            this.timePanel.Controls.Add(this.backSlashLabel);
            this.timePanel.Controls.Add(this.standardTime);
            this.timePanel.Location = new System.Drawing.Point(2, 91);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(380, 204);
            this.timePanel.TabIndex = 8;
            // 
            // AM
            // 
            this.AM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AM.AutoSize = true;
            this.AM.BackColor = System.Drawing.Color.Transparent;
            this.AM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AM.Location = new System.Drawing.Point(251, 70);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(33, 20);
            this.AM.TabIndex = 8;
            this.AM.Text = "AM";
            this.AM.Click += new System.EventHandler(this.SetTimeFormat);
            // 
            // clockColon
            // 
            this.clockColon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clockColon.AutoSize = true;
            this.clockColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockColon.Location = new System.Drawing.Point(156, 76);
            this.clockColon.Name = "clockColon";
            this.clockColon.Size = new System.Drawing.Size(24, 33);
            this.clockColon.TabIndex = 100;
            this.clockColon.Text = ":";
            // 
            // backSlashLabel
            // 
            this.backSlashLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backSlashLabel.AutoSize = true;
            this.backSlashLabel.BackColor = System.Drawing.Color.Transparent;
            this.backSlashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSlashLabel.Location = new System.Drawing.Point(158, 17);
            this.backSlashLabel.Name = "backSlashLabel";
            this.backSlashLabel.Size = new System.Drawing.Size(23, 33);
            this.backSlashLabel.TabIndex = 101;
            this.backSlashLabel.Text = "/";
            // 
            // hoursPanel
            // 
            this.hoursPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursPanel.BackColor = System.Drawing.Color.Transparent;
            this.hoursPanel.Controls.Add(this.minutesLabel);
            this.hoursPanel.Controls.Add(this.label1);
            this.hoursPanel.Controls.Add(this.hours);
            this.hoursPanel.Controls.Add(this.minutes);
            this.hoursPanel.Controls.Add(this.repeats);
            this.hoursPanel.Controls.Add(this.colon);
            this.hoursPanel.Controls.Add(this.minuteZero);
            this.hoursPanel.Controls.Add(this.hourZero);
            this.hoursPanel.Location = new System.Drawing.Point(0, 118);
            this.hoursPanel.Name = "hoursPanel";
            this.hoursPanel.Size = new System.Drawing.Size(382, 161);
            this.hoursPanel.TabIndex = 9;
            this.hoursPanel.Visible = false;
            this.hoursPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.hoursPanel_Paint);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(223, 39);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(44, 13);
            this.minutesLabel.TabIndex = 11;
            this.minutesLabel.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hours";
            // 
            // hours
            // 
            this.hours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(131, 55);
            this.hours.Margin = new System.Windows.Forms.Padding(0);
            this.hours.MaxLength = 2;
            this.hours.Name = "hours";
            this.hours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hours.Size = new System.Drawing.Size(60, 62);
            this.hours.TabIndex = 5;
            this.hours.Text = "00";
            this.hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // minutes
            // 
            this.minutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(208, 55);
            this.minutes.Margin = new System.Windows.Forms.Padding(0);
            this.minutes.MaxLength = 2;
            this.minutes.Name = "minutes";
            this.minutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minutes.Size = new System.Drawing.Size(60, 62);
            this.minutes.TabIndex = 6;
            this.minutes.Text = "00";
            this.minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // colon
            // 
            this.colon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colon.AutoSize = true;
            this.colon.BackColor = System.Drawing.Color.Transparent;
            this.colon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon.Location = new System.Drawing.Point(187, 66);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(27, 37);
            this.colon.TabIndex = 9;
            this.colon.Text = ":";
            // 
            // minuteZero
            // 
            this.minuteZero.AutoSize = true;
            this.minuteZero.BackColor = System.Drawing.Color.Transparent;
            this.minuteZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteZero.Location = new System.Drawing.Point(212, 51);
            this.minuteZero.Name = "minuteZero";
            this.minuteZero.Size = new System.Drawing.Size(0, 37);
            this.minuteZero.TabIndex = 8;
            this.minuteZero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hourZero
            // 
            this.hourZero.AutoSize = true;
            this.hourZero.BackColor = System.Drawing.Color.Transparent;
            this.hourZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourZero.Location = new System.Drawing.Point(139, 51);
            this.hourZero.Name = "hourZero";
            this.hourZero.Size = new System.Drawing.Size(0, 37);
            this.hourZero.TabIndex = 7;
            this.hourZero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectFileToPlay
            // 
            this.selectFileToPlay.FileName = "selectFileToPlay";
            this.selectFileToPlay.InitialDirectory = "Desktop";
            this.selectFileToPlay.Title = "Choose a File to Execute at Timer";
            this.selectFileToPlay.FileOk += new System.ComponentModel.CancelEventHandler(this.SetFileLocation);
            // 
            // controls_panel
            // 
            this.controls_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controls_panel.BackColor = System.Drawing.Color.Transparent;
            this.controls_panel.Controls.Add(this.container_panel);
            this.controls_panel.Controls.Add(this.shutdown_button);
            this.controls_panel.Controls.Add(this.alarm_button);
            this.controls_panel.Controls.Add(this.hours_button);
            this.controls_panel.Controls.Add(this.time_button);
            this.controls_panel.Location = new System.Drawing.Point(21, 21);
            this.controls_panel.Margin = new System.Windows.Forms.Padding(0);
            this.controls_panel.Name = "controls_panel";
            this.controls_panel.Size = new System.Drawing.Size(224, 458);
            this.controls_panel.TabIndex = 1;
            // 
            // menu_panel
            // 
            this.menu_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.menu_panel.Controls.Add(this.Submit);
            this.menu_panel.Controls.Add(this.countDownTimer);
            this.menu_panel.Controls.Add(this.timePanel);
            this.menu_panel.Controls.Add(this.hoursPanel);
            this.menu_panel.Controls.Add(this.shutdown_panel);
            this.menu_panel.Controls.Add(this.alarm_panel);
            this.menu_panel.Location = new System.Drawing.Point(244, 21);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(382, 458);
            this.menu_panel.TabIndex = 51;
            // 
            // minPanel
            // 
            this.minPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.minPanel.BackgroundImage = global::Alarm.Properties.Resources.custom_icons_timer_02;
            this.minPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minPanel.Location = new System.Drawing.Point(571, 3);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(20, 15);
            this.minPanel.TabIndex = 50;
            this.minPanel.Click += new System.EventHandler(this.MinimizeForm);
            // 
            // maxPanel
            // 
            this.maxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.maxPanel.BackgroundImage = global::Alarm.Properties.Resources.custom_icons_timer_03;
            this.maxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxPanel.Location = new System.Drawing.Point(600, 3);
            this.maxPanel.Name = "maxPanel";
            this.maxPanel.Size = new System.Drawing.Size(20, 15);
            this.maxPanel.TabIndex = 50;
            this.maxPanel.Click += new System.EventHandler(this.MaximizeForm);
            // 
            // closePanel
            // 
            this.closePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.closePanel.BackgroundImage = global::Alarm.Properties.Resources.custom_icons_timer_01;
            this.closePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanel.Location = new System.Drawing.Point(627, 3);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(20, 15);
            this.closePanel.TabIndex = 50;
            this.closePanel.Click += new System.EventHandler(this.CloseForm);
            // 
            // ShutdownAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(223)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(652, 501);
            this.Controls.Add(this.minPanel);
            this.Controls.Add(this.maxPanel);
            this.Controls.Add(this.closePanel);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.controls_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(652, 501);
            this.Name = "ShutdownAlarm";
            this.Text = "Shutdown";
            this.Load += new System.EventHandler(this.ShutdownAlarm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConvertToPolygon);
            this.Resize += new System.EventHandler(this.ClearGraphics);
            this.shutdown_panel.ResumeLayout(false);
            this.alarm_panel.ResumeLayout(false);
            this.alarm_panel.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.hoursPanel.ResumeLayout(false);
            this.hoursPanel.PerformLayout();
            this.controls_panel.ResumeLayout(false);
            this.controls_panel.PerformLayout();
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label standardTime;
        private System.Windows.Forms.Label militaryTime;
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
        private System.Windows.Forms.Panel controls_panel;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Label hourZero;
        private System.Windows.Forms.Label minuteZero;
        private System.Windows.Forms.Label colon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label AM;
        private System.Windows.Forms.Label clockColon;
        private System.Windows.Forms.Label backSlashLabel;
    }

}

