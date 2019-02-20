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

        private void ShutdownButton(object sender, EventArgs e)
        {
            Console.WriteLine("Shutdown Interface was Loaded");
        }

        private void AlarmButton(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm Interface was Loaded");
        }
    }
}
