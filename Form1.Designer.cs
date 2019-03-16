﻿using System;

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
            this.shutdown_button = new System.Windows.Forms.Button();
            this.alarm_button = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.shutdown_panel = new System.Windows.Forms.Panel();
            this.minutesSecond = new System.Windows.Forms.TextBox();
            this.minutesFirst = new System.Windows.Forms.TextBox();
            this.hoursSecond = new System.Windows.Forms.TextBox();
            this.hoursFirst = new System.Windows.Forms.TextBox();
            this.operations = new System.Windows.Forms.ComboBox();
            this.textBoxDynamic = new System.Windows.Forms.TextBox();
            this.container_panel = new System.Windows.Forms.Panel();
            this.alarm_panel = new System.Windows.Forms.Panel();
            this.closePanel = new System.Windows.Forms.Panel();
            this.maxPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            this.shutdown_panel.SuspendLayout();
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
            this.shutdown_panel.Controls.Add(this.minutesSecond);
            this.shutdown_panel.Controls.Add(this.minutesFirst);
            this.shutdown_panel.Controls.Add(this.hoursSecond);
            this.shutdown_panel.Controls.Add(this.hoursFirst);
            this.shutdown_panel.Controls.Add(this.operations);
            this.shutdown_panel.Controls.Add(this.textBoxDynamic);
            this.shutdown_panel.Location = new System.Drawing.Point(271, 24);
            this.shutdown_panel.Name = "shutdown_panel";
            this.shutdown_panel.Size = new System.Drawing.Size(370, 464);
            this.shutdown_panel.TabIndex = 0;
            // 
            // minutesSecond
            // 
            this.minutesSecond.Location = new System.Drawing.Point(158, 113);
            this.minutesSecond.MaxLength = 1;
            this.minutesSecond.Name = "minutesSecond";
            this.minutesSecond.Size = new System.Drawing.Size(27, 20);
            this.minutesSecond.TabIndex = 6;
            this.minutesSecond.Text = "0";
            this.minutesSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // minutesFirst
            // 
            this.minutesFirst.Location = new System.Drawing.Point(125, 113);
            this.minutesFirst.MaxLength = 1;
            this.minutesFirst.Name = "minutesFirst";
            this.minutesFirst.Size = new System.Drawing.Size(27, 20);
            this.minutesFirst.TabIndex = 5;
            this.minutesFirst.Text = "0";
            this.minutesFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // hoursSecond
            // 
            this.hoursSecond.Location = new System.Drawing.Point(81, 113);
            this.hoursSecond.MaxLength = 1;
            this.hoursSecond.Name = "hoursSecond";
            this.hoursSecond.Size = new System.Drawing.Size(27, 20);
            this.hoursSecond.TabIndex = 4;
            this.hoursSecond.Text = "0";
            this.hoursSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeCharCheck);
            // 
            // hoursFirst
            // 
            this.hoursFirst.Location = new System.Drawing.Point(47, 113);
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
            // 
            // textBoxDynamic
            // 
            this.textBoxDynamic.Location = new System.Drawing.Point(42, 13);
            this.textBoxDynamic.Name = "textBoxDynamic";
            this.textBoxDynamic.Size = new System.Drawing.Size(287, 20);
            this.textBoxDynamic.TabIndex = 1;
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
            this.alarm_panel.Location = new System.Drawing.Point(271, 25);
            this.alarm_panel.Name = "alarm_panel";
            this.alarm_panel.Size = new System.Drawing.Size(370, 463);
            this.alarm_panel.TabIndex = 3;
            this.alarm_panel.Visible = false;
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
            // ShutdownAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(652, 501);
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
    }

}

