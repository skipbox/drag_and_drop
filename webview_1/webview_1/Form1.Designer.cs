namespace webview_1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.but_go = new System.Windows.Forms.Button();
            this.but_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_main_timer = new System.Windows.Forms.Label();
            this.txt_uptime = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_skipped_views = new System.Windows.Forms.TextBox();
            this.txt_simple_views = new System.Windows.Forms.TextBox();
            this.txt_super_views = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(681, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "on form load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(681, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "on form load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 107);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(681, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "on form load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2, 145);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(681, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "on form load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(760, 15);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(589, 415);
            this.webBrowser1.TabIndex = 7;
            // 
            // but_go
            // 
            this.but_go.Location = new System.Drawing.Point(595, 3);
            this.but_go.Name = "but_go";
            this.but_go.Size = new System.Drawing.Size(87, 28);
            this.but_go.TabIndex = 8;
            this.but_go.Text = "but_go";
            this.but_go.UseVisualStyleBackColor = true;
            this.but_go.Click += new System.EventHandler(this.but_go_Click);
            // 
            // but_start
            // 
            this.but_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_start.Location = new System.Drawing.Point(26, 224);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(85, 39);
            this.but_start.TabIndex = 9;
            this.but_start.Text = "start";
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Main Interval";
            // 
            // but_stop
            // 
            this.but_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_stop.Location = new System.Drawing.Point(139, 224);
            this.but_stop.Name = "but_stop";
            this.but_stop.Size = new System.Drawing.Size(85, 39);
            this.but_stop.TabIndex = 12;
            this.but_stop.Text = "Stop";
            this.but_stop.UseVisualStyleBackColor = true;
            this.but_stop.Click += new System.EventHandler(this.but_stop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(53, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Uptime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(144, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "User";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(31, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "skipped_views";
            // 
            // label_main_timer
            // 
            this.label_main_timer.AutoSize = true;
            this.label_main_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_main_timer.ForeColor = System.Drawing.Color.Green;
            this.label_main_timer.Location = new System.Drawing.Point(256, 224);
            this.label_main_timer.Name = "label_main_timer";
            this.label_main_timer.Size = new System.Drawing.Size(277, 39);
            this.label_main_timer.TabIndex = 13;
            this.label_main_timer.Text = "label_main_timer";
            // 
            // txt_uptime
            // 
            this.txt_uptime.Location = new System.Drawing.Point(213, 304);
            this.txt_uptime.Name = "txt_uptime";
            this.txt_uptime.Size = new System.Drawing.Size(228, 22);
            this.txt_uptime.TabIndex = 16;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(213, 345);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(228, 22);
            this.txt_user.TabIndex = 19;
            // 
            // txt_skipped_views
            // 
            this.txt_skipped_views.Location = new System.Drawing.Point(213, 383);
            this.txt_skipped_views.Name = "txt_skipped_views";
            this.txt_skipped_views.Size = new System.Drawing.Size(228, 22);
            this.txt_skipped_views.TabIndex = 20;
            // 
            // txt_simple_views
            // 
            this.txt_simple_views.Location = new System.Drawing.Point(213, 425);
            this.txt_simple_views.Name = "txt_simple_views";
            this.txt_simple_views.Size = new System.Drawing.Size(228, 22);
            this.txt_simple_views.TabIndex = 21;
            // 
            // txt_super_views
            // 
            this.txt_super_views.Location = new System.Drawing.Point(213, 467);
            this.txt_super_views.Name = "txt_super_views";
            this.txt_super_views.Size = new System.Drawing.Size(228, 22);
            this.txt_super_views.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(44, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "simple_views";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(56, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "super_views";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 652);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_super_views);
            this.Controls.Add(this.txt_simple_views);
            this.Controls.Add(this.txt_skipped_views);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_uptime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_main_timer);
            this.Controls.Add(this.but_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.but_start);
            this.Controls.Add(this.but_go);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button but_go;
        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_main_timer;
        private System.Windows.Forms.TextBox txt_uptime;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_skipped_views;
        private System.Windows.Forms.TextBox txt_simple_views;
        private System.Windows.Forms.TextBox txt_super_views;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

