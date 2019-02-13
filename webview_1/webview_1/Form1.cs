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

namespace webview_1
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




        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "https://www.google.com";
            button2.Text = "https://www.yahoo.com";
            button3.Text = "https://www.bing.com";
            button4.Text = "https://www.autojacker.com";
        }
        private void button1_Click(object sender, EventArgs e)
        { textBox1.Text= button1.Text; webBrowser1.Navigate(textBox1.Text); }

        private void button2_Click_1(object sender, EventArgs e)
        { textBox1.Text = button2.Text; webBrowser1.Navigate(textBox1.Text); }

        private void button3_Click(object sender, EventArgs e)
        { textBox1.Text = button3.Text; webBrowser1.Navigate(textBox1.Text); }

        private void button4_Click(object sender, EventArgs e)
        { textBox1.Text = button4.Text; webBrowser1.Navigate(textBox1.Text); }

        //use this to cut and paste a web address
        private void but_go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }
    }
}
