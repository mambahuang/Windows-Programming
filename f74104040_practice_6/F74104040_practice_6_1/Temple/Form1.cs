using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Temple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Some variables
        private static System.Timers.Timer timer;
        private static System.Timers.Timer timer2;
        Button[] btn4 = new Button[4];
        Button[] btn8 = new Button[8];
        SoundPlayer ding;
        SoundPlayer dong;
        SoundPlayer doo;
        int check_btn = 4;
        int check_note = 1;
        
        // Initialize  some component before start
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("quarternote.png");
            pictureBox2.Image = new Bitmap("quavers.png");
            ding = new SoundPlayer("ding.wav");
            dong = new SoundPlayer("dong.wav");
            doo = new SoundPlayer("doo.wav");
            for (int i = 0; i < btn4.Length; i++)
            {
                btn4[i] = new Button();
                btn4[i].SetBounds(180 * i + 130, 140, 50, 50);
                Controls.Add(btn4[i]);
            }
            for (int i = 0; i < btn8.Length; i++)
            {
                btn8[i] = new Button();
                btn8[i].SetBounds(80 * i + 130, 140, 50, 50);
                Controls.Add(btn8[i]);
                btn8[i].Visible = false;
                btn8[i].Enabled = false;
            }
            label1.Text = "120 BPM";
            trackBar1.Minimum = 60;
            trackBar1.Maximum = 180;
            trackBar1.Value = 120;
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(8);

        }
        
        // btn_start Clicked... 
        private void btn_start_Click(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + " BPM"; // Initialization is 120
            if (btn_start.Text == "Start")
            {
                SetTimer(trackBar1.Value); // go to start timer(s)
                btn_start.Text = "Stop";
            }
            else if(btn_start.Text == "Stop")
            {
                timer.Stop();
                timer2.Stop();
                btn_start.Text = "Start";
            }
        }

        // trackBar scrolled...
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (btn_start.Text == "Stop") // First stop timer, then change mode and resume timer(s)
            {
                timer.Stop();
                timer2.Stop();
            }
            label1.Text = trackBar1.Value.ToString() + " BPM";
            if (btn_start.Text == "Stop") // If btn_start's text is "Start", we hope user click the btn_start and then start, or it will automatically start the metronome
                SetTimer(trackBar1.Value);
        }

        private void SetTimer(double val) // Let timer start running
        {
            if(check_note == 1) // 1 beat 1 note
            {
                timer = new System.Timers.Timer((60 / val) * 1000);
                timer2 = new System.Timers.Timer((60 / val) * 1000);
                timer.Start();
                timer.Elapsed += playSounds; // Invoke "playSounds" every "60 / trackBar.value" sec
            }   
            else if(check_note == 2) // 1 beat 2 notes
            {
                timer = new System.Timers.Timer((60 / val) * 1000);
                timer.Start();
                timer.Elapsed += playSounds; // Invoke "playSounds" every "60 / trackBar.value" sec

                Thread.Sleep((int)((60 /(2 * val)) * 1000)); // Let timer2 delay half of timer's time to begin
                delay(val); // Call timer2
            } 
            
        }

        private void delay(double val) // Start timer2
        {
            timer2 = new System.Timers.Timer((60 / val) * 1000);
            timer2.Start();
            timer2.Elapsed += playSounds2;
        }

        int i = 0;
        int k = 0;
        private void playSounds(Object source, System.Timers.ElapsedEventArgs e) // play the sounds
        {
            if(check_btn == 4) // four beats
            {
                k = 0;
                if (i == 4)
                    i = 0;

                i++;
                btn4[i - 1].BackColor = Color.LightGreen;
                for (int j = 0; j < 3; j++)
                    btn4[(i + j) % 4].BackColor = SystemColors.ControlLight;
            }
            else if(check_btn == 8) // eight beats
            {
                i = 0;
                if (k == 8)
                    k = 0;
                k++;
                btn8[k - 1].BackColor = Color.LightGreen;
                for(int j = 0; j < 7; j++)
                    btn8[(k + j) % 8].BackColor = SystemColors.ControlLight;
                
            }
            if (i == 1 || k == 1)
            {
                ding.Play();
            }
            else
            {
                dong.Play();
            }

        }

        private void playSounds2(Object source, System.Timers.ElapsedEventArgs e) // For 1 beat two notes
        {
            doo.Play();
        }

        // combobox changed...
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btn_start.Text == "Stop")
            {
                timer.Stop();
                timer2.Stop();
            }
            ComboBox list = (ComboBox)sender;
            if(list.Text == "4")
            {
                check_btn = 4;
                for (int i = 0; i < btn4.Length; i++)
                {
                    btn4[i].Visible = true;
                    btn4[i].BackColor = SystemColors.ControlLight;
                }
                for (int i = 0; i < btn8.Length; i++)
                {
                    btn8[i].Visible = false;
                    btn8[i].BackColor = SystemColors.ControlLight;
                }
                if (btn_start.Text == "Stop")
                    SetTimer(trackBar1.Value);
            }
            else
            {
                check_btn = 8;
                for (int i = 0; i < btn4.Length; i++)
                {
                    btn4[i].Visible = false;
                    btn4[i].BackColor = SystemColors.ControlLight;
                }
                for (int i = 0; i < btn8.Length; i++)
                {
                    btn8[i].Visible = true;
                    btn8[i].BackColor = SystemColors.ControlLight;
                }
                if (btn_start.Text == "Stop")
                    SetTimer(trackBar1.Value);
            }
        }

        // radio button1 checked changed...
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(btn_start.Text == "Stop")
            {
                timer.Stop();
                timer2.Stop();
            }

            if(radioButton1.Checked == true)
                check_note = 1;
            else
                check_note = 2;
            if (btn_start.Text == "Stop")
                SetTimer(trackBar1.Value);
        }

        // radio button2 checked changed...
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_start.Text == "Stop")
            {
                timer.Stop();
                timer2.Stop();
            }
            if (radioButton2.Checked == true)
                check_note = 2;
            else
                check_note = 1;
            if (btn_start.Text == "Stop")
                SetTimer(trackBar1.Value);
        }
    }
}
