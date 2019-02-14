using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace save_and_read_text_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Strings
        String path_c_goals_settings = @"C:\goals\my_settings.txt";
        String image_local_path = @"C:\Users\laowai\Desktop\edited\goals\";
        //path to same folder as exe
        String path_local = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Text = "111";
            //button2.Text = "222";
            //button3.Text = "aaa";
        }
        
        private void but_open_folder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(image_local_path);

        }       
        private void openFolder_2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path_c_goals_settings);
        }

        private void but_write_Click(object sender, EventArgs e)
        {

            //textBox1.Text =
            //    "Line 1\r\n" +
            //    "Line 2\r\n" +
             //   "Line 3";

            // Create a file to write to.
            /*An UnauthorizedAccessException means one of 4 things:
            1-The caller does not have the required permission.
            2-The file is an executable file that is in use.
            3-Path is a directory.
            4Path specified a read-only file.
            ---$$$$ --- Path is a directory. Embarrassing for me :/*/

            //I think Environment.NewLine will ceate a file if one does not exist
            //string createText = "Hello and Welcome" + Environment.NewLine;
            string createText = textBox1.Text + Environment.NewLine;
            File.WriteAllText(path_c_goals_settings, createText);


        }

        private void but_read_Click(object sender, EventArgs e)
        {
            // Open the file to read from.
            string readText = File.ReadAllText(path_c_goals_settings);
            textBox2.Text = readText;
        }

        String dir_1 = "dir_1 dir_1";
        String dir_2 = "dir_1 dir_2";
        String dir_3 = "dir_1 dir_3";
        String dir_4 = "dir_1 dir_4";

        private void parse_Click(object sender, EventArgs e)
        {
            //puts it all into an array
            string[] my_lines = System.IO.File.ReadAllLines(path_c_goals_settings);

            if (my_lines.Length > 0) { txt_arr_1.Text = my_lines[0];}
            if (my_lines.Length > 1) { txt_arr_2.Text = my_lines[1]; }
            if (my_lines.Length > 2) { txt_arr_3.Text = my_lines[2]; }
            if (my_lines.Length > 3) { txt_arr_4.Text = my_lines[3]; }
            if (my_lines.Length > 4) { txt_arr_5.Text = my_lines[4]; }
            if (my_lines.Length > 5) { txt_arr_6.Text = my_lines[5]; }
            if (my_lines.Length > 6) { txt_arr_7.Text = my_lines[6]; }
            if (my_lines.Length > 7) { txt_arr_8.Text = my_lines[7]; }
            if (my_lines.Length > 8) { txt_arr_9.Text = my_lines[8]; }

        }



        //click this picturebox to select the main folder
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String folder_selected = folderBrowserDialog1.SelectedPath;
                txt_arr_1.Text = folder_selected;
            }
        }
        //click this picturebox to select the sub folder
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String folder_selected = folderBrowserDialog1.SelectedPath;
                txt_arr_2.Text = folder_selected;
            }
        }

        Boolean auto_on_off = true;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            auto_on_off = !auto_on_off;
            txt_arr_3.Text = auto_on_off.ToString();
        }

        public void write_to_file() {
            //first add to array
            // Version 1: create empty string array, then assign into it.
            string[] settings_x = new string[20];
            settings_x[0] = txt_arr_1.Text; //add1 so 0=1 etc.
            settings_x[1] = txt_arr_2.Text;
            settings_x[2] = txt_arr_3.Text;
            settings_x[3] = txt_arr_4.Text;
            settings_x[4] = txt_arr_5.Text;
            settings_x[5] = txt_arr_6.Text;
            settings_x[6] = txt_arr_7.Text;
            settings_x[7] = txt_arr_8.Text;
            settings_x[8] = txt_arr_9.Text;

            File.WriteAllLines(path_c_goals_settings, settings_x);
            //WriteAllLines(String, String[], Encoding)
            //public static void WriteAllLines(string path, string[] contents);
            /* 
                * 
            The following code example demonstrates the use of the WriteAllLines
            method to write text to a file. 
            In this example a file is created, 
            if it doesn't already exist, and text is added to it. 
                * 
                */
            //string path = @"c:\temp\MyTest.txt";

            // This text is added only once to the file.
            //if (!File.Exists(path_c_goals_settings))
            // {
            // Create a file to write to.
            //string[] createText = { "Hello", "And", "Welcome" };

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            write_to_file();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        //these are the hard coded defaults
        private void but_default_Click(object sender, EventArgs e)
        {
            txt_arr_1.Text = "Need to set folder";//Main folder
            txt_arr_2.Text = "sub folder";//sub folder
            txt_arr_3.Text = "true"; //Auto on off
            txt_arr_4.Text = "skip ad"; //Skip ad
            txt_arr_5.Text = "555";
            txt_arr_6.Text = "666";
            txt_arr_7.Text = "777";
            txt_arr_8.Text = "888";
            txt_arr_9.Text = "999";
        }

        private void but_random_Click(object sender, EventArgs e)
        {
            Random my_rnd = new Random();
            //int month = my_rnd.Next(1, 1000000);
            txt_arr_1.Text = "0/1="+ my_rnd.Next(1, 1000000);
            txt_arr_2.Text = "0/2=" + my_rnd.Next(1, 1000000);
            txt_arr_3.Text = "0/3=" + my_rnd.Next(1, 1000000);
            txt_arr_4.Text = "0/4=" + my_rnd.Next(1, 1000000);
            txt_arr_5.Text = "0/5=" + my_rnd.Next(1, 1000000);
            txt_arr_6.Text = "0/6=" + my_rnd.Next(1, 1000000);
            txt_arr_7.Text = "0/7=" + my_rnd.Next(1, 1000000);
            txt_arr_8.Text = "0/8=" + my_rnd.Next(1, 1000000);
            txt_arr_9.Text = "0/9=" + my_rnd.Next(1, 1000000);
        }
    }

    
}


/*
 * 
 * 
dialog.Filter =  "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) |
*.jpg; *.jpeg; *.jpe; *.jfif; *.png"; 
 * 
 * 
 * 
System.Console.WriteLine("Contents of writeLines2.txt =:");
foreach (string each_single_line in my_lines)
{
Console.WriteLine("\t" + each_single_line);
}
for (int a = 0; a<my_lines.Length; a++)
{
Console.WriteLine("value of a: {0}", my_lines[a]);

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //System.IO.StreamReader sr = new
                //System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());

                String folder_selected = folderBrowserDialog1.SelectedPath;
                //sr.Close();
                //temp
                txt_arr_1.Text = folder_selected;
            }

///////////////////////
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                //openFileDialog1
                String path_selected = openFileDialog1.FileName;
                sr.Close();
                //temp
                txt_arr_2.Text = path_selected;
            }
}*/
