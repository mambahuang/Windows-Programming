using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] card = new Button[16];
        int[] ran_arr = Create_Random(); // create random number
        int[] same = new int[2]; //save the index of the card
        int cnt = 0; // check player flip the first card or the second card
        bool check; // check if they are the same picture
        int[] pair = new int[16]; // store which pictures have been pair
        int pair_num = 0;
        int gameover = 0;
        int score = 100;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < pair.Length; i++)
                pair[i] = -1;
            btn_conti.Enabled = false;
            tabPage1.Text = "Play area";
            tabPage2.Text = "Historical record area";
            label3.Text = Convert.ToString(score);
            
        }

        private void Create_Button()
        {
            int x = 1;
            int y = 0;

            for (int i = 0; i < card.Length; i++)
            {
                card[i] = new Button();
                card[i].Image = imageList1.Images[16];
                card[i].SetBounds(80 * (i % 4) + 25 * x, 100 * y + 70, 80, 100);
                tabPage1.Controls.Add(card[i]);

                if (i % 4 == 3) y++;
                x++;
                if (x % 4 == 1) x = 1;
                card[i].Click += new EventHandler(btn_Clike);
            }

        }

        //Click one of the cards
        private void btn_Clike(object sender, EventArgs e)
        {
            cnt++;
            if (cnt > 2)
            {
                ;
            }
            else
            {
                
                Button btn = (Button)sender;
                int idx = Array.IndexOf(card, btn);
                btn.Image = imageList1.Images[ran_arr[idx]];
                if (cnt == 1) Check(idx);
                if (cnt == 2)
                {
                    if (check = Check(idx))
                    {
                        card[same[0]].Enabled = false;
                        card[same[1]].Enabled = false;
                        btn_conti.Enabled = false;
                        label3.Text = Convert.ToString(score);
                        if (gameover == 16)
                        {
                            textBox1.Text += usr_name.Text + "'s score is : " + score + Environment.NewLine;
                            var result = MessageBox.Show("Score: " + Convert.ToString(score), "Game Over", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                            if(result == DialogResult.Retry)
                            {
                                for (int i = 0; i < card.Length; i++)
                                {
                                    tabPage1.Controls.Remove(card[i]);
                                }
                                btn_start.Enabled = true;
                                usr_name.Text = "";
                                score = 100;
                                label3.Text = Convert.ToString(score);
                                for (int i = 0; i < pair.Length; i++)
                                {
                                    pair[i] = -1;
                                }
                                pair_num = 0;
                                gameover = 0;
                                ran_arr = Create_Random();
                            }
                        }
                        cnt = 0;
                    }
                    else
                    {
                        label3.Text = Convert.ToString(score);
                        btn_conti.Enabled = true;
                    }
                }
            }
            
        }

        //create random number method
        private static int[] Create_Random()
        {
            int[] random = new int[16];
            for (int i = 0; i < random.Length; i++)
                random[i] = -1;
            var rand = new Random();
            int num;
            for (int i = 0; i < random.Length; i++)
            {
                do
                {
                    num = rand.Next(16);// yield 1 ~ 15 numbers 
                } while (random.Contains(num));
                random[i] = num;
            }
            return random;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (his_Record())
            {
                Create_Button();
                btn_start.Enabled = false;
                btn_conti.Enabled = true;
            }
            
        }

        private void btn_conti_Click(object sender, EventArgs e)
        {
            cnt = 0;
            if (!check)
            {
                for (int i = 0; i < card.Length; i++)
                {
                    if (!pair.Contains(i))
                    {
                        card[i].Image = imageList1.Images[16];
                        tabPage1.Controls.Add(card[i]);
                    }
                }
            }
        }

        int count = 0;
        private bool Check(int index)
        {
            same[count] = index;
            count++;

            if (count == 2)
            {
                count = 0;
                if (Math.Abs(ran_arr[same[0]] - ran_arr[same[1]]) == 8)
                {
                    pair[pair_num] = same[0];
                    pair_num++;
                    pair[pair_num] = same[1];
                    pair_num++;
                    gameover += 2;
                    score += 10;
                    return true;
                }
                else
                {
                    score -= 5;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sure to leave the game ?", "Leave Game", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            for(int i=0; i<card.Length; i++)
            {
                tabPage1.Controls.Remove(card[i]);
            }
            btn_start.Enabled = true;
            usr_name.Text = "";
            score = 100;
            label3.Text = Convert.ToString(score);
            for(int i=0; i<pair.Length; i++)
            {
                pair[i] = -1;
            }
            pair_num = 0;
            gameover = 0;
            ran_arr = Create_Random();
        }

        List<string> name = new List<string>();
        private bool his_Record()
        {
            if ((usr_name.Text.Length <= 3 || usr_name.Text.Length >= 10) && usr_name.Text.Length != 0)
            {
                MessageBox.Show("Incorrect user name format (<=3 && >=10)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(usr_name.Text == "")
            {
                MessageBox.Show("User name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(name.Contains(usr_name.Text))
            {
                MessageBox.Show("Incorrect user name format (User name exist)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                name.Add(usr_name.Text);
                return true;
            }
                
        }
    }
}
