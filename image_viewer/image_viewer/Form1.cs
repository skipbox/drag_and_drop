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

namespace image_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total_files_in_folder = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            //image_local_path
            var list = Directory.GetFiles(image_local_path, "*.png");
            //var list = Directory.GetFiles(@"C:\Users\laowai\Desktop\edited\goals\", "*.png");
            total_files_in_folder = list.Length;
            button1.Text = total_files_in_folder.ToString();

            // if (list.Length > 0)
            // {
            //     button1.Text = list.Length.ToString();
            // }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            next_image();

        }
        //opens the folder of the images
        private void button2_Click(object sender, EventArgs e)
        { System.Diagnostics.Process.Start(image_local_path); }

        private void t1_Tick(object sender, EventArgs e)
        {
            //next_image();
        }
        //global vars
        int ImgCounter = 0;
        String image_local_path = @"C:\Users\laowai\Desktop\edited\goals\";
        String image_final_path = "";
        public void next_image(){
            textImageLocation.Text = pictureBox1.ImageLocation;
            //image_local_path
            if (ImgCounter >= total_files_in_folder) { ImgCounter = 1; }
            ImgCounter++; //will add 1 so its the above +1


            image_final_path = image_local_path + ImgCounter.ToString() + ".png";
            textImageSelector.Text = image_final_path;

            pictureBox1.ImageLocation = image_final_path;
        }
    }
}
