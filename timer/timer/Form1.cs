using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }
        int jj = 0;
        private void button1_Click(object sender, EventArgs e)
        {timer1.Enabled = true;}

        private void timer1_Tick(object sender, EventArgs e)
        {
            jj++;
            button1.Text = jj.ToString();
            timer1.Interval = speed_x;
            if (jj >= 1000) { timer1.Enabled = false;jj = 0; }
        }

        int speed_x = 50;
        private void but_speed_slowerClick(object sender, EventArgs e)
        {
            speed_x = speed_x + 50;
            label1.Text = speed_x.ToString();
            timer1.Interval = speed_x;
        }

        private void but_speed_faster_Click(object sender, EventArgs e)
        {
            speed_x = speed_x - 50;
            if (speed_x <= 50) speed_x = 50;// is the slowest
            label1.Text = speed_x.ToString();
            timer1.Interval = speed_x;
        }
    }
}
