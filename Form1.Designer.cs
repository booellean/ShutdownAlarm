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
            this.shutdown = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(12, 12);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(217, 84);
            this.shutdown.TabIndex = 0;
            this.shutdown.Text = "Shutdown";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.ShutdownButton);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Shutdown",
            "Sleep",
            "Restart"});
            this.listBox1.Location = new System.Drawing.Point(668, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // alarm
            // 
            this.alarm.Location = new System.Drawing.Point(12, 113);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(217, 84);
            this.alarm.TabIndex = 2;
            this.alarm.Text = "Alarm";
            this.alarm.UseVisualStyleBackColor = true;
            this.alarm.Click += new System.EventHandler(this.AlarmButton);
            // 
            // ShutdownAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 579);
            this.Controls.Add(this.alarm);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.shutdown);
            this.Name = "ShutdownAlarm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShutdownAlarm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button alarm;
    }
}

