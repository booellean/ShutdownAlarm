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
            this.shutdown_panel = new System.Windows.Forms.Panel();
            this.textBoxDynamic = new System.Windows.Forms.TextBox();
            this.textBoxStatic = new System.Windows.Forms.TextBox();
            this.container_panel = new System.Windows.Forms.Panel();
            this.main_app = new System.Windows.Forms.SplitContainer();
            this.alarm_panel = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            this.shutdown_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_app)).BeginInit();
            this.main_app.SuspendLayout();
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
            this.alarm_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeMouseCursor);
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
            this.menu_panel.Size = new System.Drawing.Size(249, 673);
            this.menu_panel.TabIndex = 1;
            // 
            // shutdown_panel
            // 
            this.shutdown_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shutdown_panel.BackColor = System.Drawing.Color.LightGreen;
            this.shutdown_panel.Controls.Add(this.textBoxDynamic);
            this.shutdown_panel.Controls.Add(this.textBoxStatic);
            this.shutdown_panel.Location = new System.Drawing.Point(271, 25);
            this.shutdown_panel.Name = "shutdown_panel";
            this.shutdown_panel.Size = new System.Drawing.Size(658, 673);
            this.shutdown_panel.TabIndex = 0;
            // 
            // textBoxDynamic
            // 
            this.textBoxDynamic.Location = new System.Drawing.Point(31, 97);
            this.textBoxDynamic.Name = "textBoxDynamic";
            this.textBoxDynamic.Size = new System.Drawing.Size(287, 20);
            this.textBoxDynamic.TabIndex = 1;
            // 
            // textBoxStatic
            // 
            this.textBoxStatic.Location = new System.Drawing.Point(28, 55);
            this.textBoxStatic.Name = "textBoxStatic";
            this.textBoxStatic.Size = new System.Drawing.Size(315, 20);
            this.textBoxStatic.TabIndex = 0;
            this.textBoxStatic.Text = "The Current Mouse Position is";
            // 
            // container_panel
            // 
            this.container_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container_panel.AutoSize = true;
            this.container_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.container_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.container_panel.Location = new System.Drawing.Point(1, 1);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(0, 0);
            this.container_panel.TabIndex = 1;
            // 
            // main_app
            // 
            this.main_app.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_app.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.main_app.Location = new System.Drawing.Point(42, 19);
            this.main_app.Name = "main_app";
            this.main_app.Size = new System.Drawing.Size(54, 0);
            this.main_app.TabIndex = 2;
            // 
            // alarm_panel
            // 
            this.alarm_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarm_panel.BackColor = System.Drawing.Color.Maroon;
            this.alarm_panel.Location = new System.Drawing.Point(271, 25);
            this.alarm_panel.Name = "alarm_panel";
            this.alarm_panel.Size = new System.Drawing.Size(658, 672);
            this.alarm_panel.TabIndex = 3;
            // 
            // ShutdownAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(940, 710);
            this.Controls.Add(this.shutdown_panel);
            this.Controls.Add(this.alarm_panel);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.main_app);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(652, 501);
            this.Name = "ShutdownAlarm";
            this.Text = "Shutdown";
            this.Load += new System.EventHandler(this.ShutdownAlarm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoveContainer);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeMouseCursor);
            this.menu_panel.ResumeLayout(false);
            this.shutdown_panel.ResumeLayout(false);
            this.shutdown_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_app)).EndInit();
            this.main_app.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shutdown_button;
        private System.Windows.Forms.Button alarm_button;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel shutdown_panel;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.SplitContainer main_app;
        private System.Windows.Forms.Panel alarm_panel;
        private System.Windows.Forms.TextBox textBoxStatic;
        private System.Windows.Forms.TextBox textBoxDynamic;
    }
}

