using System;

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
            this.alarm_panel = new System.Windows.Forms.Panel();
            this.shutdown_panel = new System.Windows.Forms.Panel();
            this.container_panel = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            this.container_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shutdown_button
            // 
            this.shutdown_button.Location = new System.Drawing.Point(23, 114);
            this.shutdown_button.Name = "shutdown_button";
            this.shutdown_button.Size = new System.Drawing.Size(217, 84);
            this.shutdown_button.TabIndex = 0;
            this.shutdown_button.Text = "Shutdown";
            this.shutdown_button.UseVisualStyleBackColor = true;
            this.shutdown_button.Click += new System.EventHandler(this.LoadShutdownInterface);
            // 
            // alarm_button
            // 
            this.alarm_button.Location = new System.Drawing.Point(23, 14);
            this.alarm_button.Name = "alarm_button";
            this.alarm_button.Size = new System.Drawing.Size(217, 84);
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
            this.menu_panel.Controls.Add(this.alarm_button);
            this.menu_panel.Controls.Add(this.shutdown_button);
            this.menu_panel.Location = new System.Drawing.Point(3, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(249, 557);
            this.menu_panel.TabIndex = 1;
            this.menu_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_panel_Paint);
            // 
            // alarm_panel
            // 
            this.alarm_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarm_panel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.alarm_panel.Location = new System.Drawing.Point(258, 3);
            this.alarm_panel.Name = "alarm_panel";
            this.alarm_panel.Size = new System.Drawing.Size(459, 558);
            this.alarm_panel.TabIndex = 2;
            // 
            // shutdown_panel
            // 
            this.shutdown_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shutdown_panel.AutoSize = true;
            this.shutdown_panel.BackColor = System.Drawing.Color.Maroon;
            this.shutdown_panel.Location = new System.Drawing.Point(261, 3);
            this.shutdown_panel.Name = "shutdown_panel";
            this.shutdown_panel.Size = new System.Drawing.Size(453, 558);
            this.shutdown_panel.TabIndex = 4;
            // 
            // container_panel
            // 
            this.container_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container_panel.Controls.Add(this.menu_panel);
            this.container_panel.Controls.Add(this.shutdown_panel);
            this.container_panel.Controls.Add(this.alarm_panel);
            this.container_panel.Location = new System.Drawing.Point(-2, 0);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(717, 561);
            this.container_panel.TabIndex = 5;
            // 
            // ShutdownAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(714, 560);
            this.Controls.Add(this.container_panel);
            this.Name = "ShutdownAlarm";
            this.Text = "Shutdown";
            this.Load += new System.EventHandler(this.ShutdownAlarm_Load);
            this.menu_panel.ResumeLayout(false);
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shutdown_button;
        private System.Windows.Forms.Button alarm_button;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel alarm_panel;
        private System.Windows.Forms.Panel shutdown_panel;
        private System.Windows.Forms.Panel container_panel;
    }
}

