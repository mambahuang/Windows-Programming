using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GuessWord
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        int sec;
        Button[] keyboard = new Button[26];
        string[] ch = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                        "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        int wrong = 0; // count wrong times
        bool check = false; // check if there are some characters equal to player's click

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_time.Visible = false;
            lb_wg.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            panel1.Visible = true;

        }

        // create button on the Form
        private void Create_Button()
        {
            int x = 1, y = 0;
            for (int i = 0; i < keyboard.Length; i++)
            {
                keyboard[i] = new Button();
                keyboard[i].Text = ch[i];
                if (i <= 19)
                    keyboard[i].SetBounds(50 * (i % 10) + 80, 50 * y + 60, 50, 50);
                else
                    keyboard[i].SetBounds(50 * ((i % 10) + 2) + 80, 50 * y + 60, 50, 50);
                Controls.Add(keyboard[i]);
                if (i % 10 == 9) y++;
                x++;
                if (x % 10 == 1) x = 1;
            }

        }

        Label[] word = new Label[100]; // store textbox's word (Upper form)
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (tb_word.Text == "" || !Regex.IsMatch(tb_word.Text, @"^[a-zA-Z]+$")) // let input string contains only letters
            {
                ;
            }
            else
            {
                Create_Button();
                lb_time.Visible = true;
                lb_wg.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                timer1.Start();
                lb_wg.Text = wrong.ToString() + " times";
                panel1.Visible = false;
                btn_start.Enabled = false;
                tb_word.Enabled = false;
                for (int i = 0; i < tb_word.Text.Length; i++)
                {
                    word[i] = new Label();
                    word[i].Text = "__";
                    word[i].SetBounds(30 * i + 200, 350, 30, 30);
                    Controls.Add(word[i]);

                }
                for (int i = 0; i < keyboard.Length; i++)
                {
                    keyboard[i].Click += new EventHandler(btn_Click);
                }
            }
        }

        // when button clicked...
        private void btn_Click(object sender, EventArgs e)
        {
            check = false;
            Button btn = (Button)sender;
            int idx = Array.IndexOf(keyboard, btn);
            char[] single_ch = new char[tb_word.Text.Length];
            single_ch = tb_word.Text.ToUpper().ToCharArray();
            int j;
            for (j = 0; j < tb_word.Text.Length; j++)
            {
                if (keyboard[idx].Text == single_ch[j].ToString())
                {
                    word[j].Text = keyboard[idx].Text;
                    keyboard[idx].BackColor = Color.LightGreen;
                    check = true;
                }
            }

            if (!check)
            {
                keyboard[idx].Visible = false;
                wrong++;
                lb_wg.Text = wrong.ToString() + " times";
            }

            if (wrong == 6)
                Game_over(single_ch);
            else
            {
                for (int i = 0; i < tb_word.Text.Length; i++)
                {
                    if (word[i].Text == "__")
                        break;
                    else if (i == tb_word.Text.Length - 1)
                        Win();
                }
            }
        }

        // Lose condition
        private void Game_over(char[] a_single_ch)
        {
            timer1.Stop();
            for (int i = 0; i < tb_word.Text.Length; i++)
            {
                if (word[i].Text == "__")
                {
                    word[i].Text = a_single_ch[i].ToString();
                }
            }
            DialogResult rlt_L = MessageBox.Show("You lose!", "", MessageBoxButtons.OK);
            if (rlt_L == DialogResult.OK) Reset();

        }
        //Win condition
        private void Win()
        {
            timer1.Stop();
            DialogResult rlt_W = MessageBox.Show("Time consumption: " + lb_time.Text + "\nGuess wrong " + wrong.ToString() + " times", "You win!", MessageBoxButtons.OK);
            if (rlt_W == DialogResult.OK) Reset();
        }

        // Replay the game
        private void Reset()
        {
            panel1.Visible = true;
            btn_start.Enabled = true;
            wrong = 0;
            for (int i = 0; i < tb_word.Text.Length; i++)
            {
                Controls.Remove(word[i]);
                word[i].Dispose();
            }
            tb_word.Text = "";
            tb_word.Enabled = true;
            for (int i = 0; i < keyboard.Length; i++)
            {
                Controls.Remove(keyboard[i]);
                keyboard[i].Dispose();
            }
            sec = 0;
            lb_time.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            lb_time.Text = sec.ToString(); 
        }
    }   
}
