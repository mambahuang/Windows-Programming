using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            lb_time.Visible = false;
            lb_time.Text = "10";
            btn_Warrior1.Visible = false;
            btn_Warrior1.Enabled = false;
            btn_Warrior2.Visible = false;
            btn_Warrior2.Enabled = false;
            btn_Mage1.Visible = false;
            btn_Mage1.Enabled = false;
            btn_Mage2.Visible = false;
            btn_Mage2.Enabled = false;
            btn_Ranger1.Visible = false;
            btn_Ranger1.Enabled = false;
            btn_Ranger2.Visible = false;
            btn_Ranger2.Enabled = false;
            label2.Visible = false;
            label4.Visible = false;
            lb_WMR1.Visible = false;
            lb_WMR2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            btn_atk1.Enabled = false;
            btn_atk2.Enabled = false;
            btn_move1.Enabled = false;
            btn_move2.Enabled = false;
            btn_skill1.Enabled = false;
            btn_skill2.Enabled = false;
            btn_standby1.Enabled = false;
            btn_standby2.Enabled = false;
            btn_finish1.Enabled = false;
            btn_finish2.Enabled = false;
        }

        // Variables
        int sec = 10;
        int turn = 1;
        int method;
        int die1 = 0, die2 = 0;
        bool placed_W1 = false;
        bool placed_M1 = false;
        bool placed_R1 = false;
        bool placed_W2 = false;
        bool placed_M2 = false;
        bool placed_R2 = false;
        int current_W1;
        int current_M1;
        int current_R1;
        int current_W2;
        int current_M2;
        int current_R2;
        int current_W1_hp = 100;
        int current_M1_hp = 70;
        int current_R1_hp = 90;
        int current_W2_hp = 100;
        int current_M2_hp = 70;
        int current_R2_hp = 90;
        bool die_w1 = false;
        bool die_m1 = false;
        bool die_r1 = false;
        bool die_w2 = false;
        bool die_m2 = false;
        bool die_r2 = false;
        Button[] chess = new Button[42];

        private void btn_start_Click(object sender, EventArgs e)
        {
            Create_Button();
            btn_Warrior1.Visible = true;
            btn_Warrior1.Enabled = true;
            btn_Warrior2.Visible = true;
            btn_Mage1.Visible = true;
            btn_Mage1.Enabled = true;
            btn_Mage2.Visible = true;
            btn_Ranger1.Visible = true;
            btn_Ranger1.Enabled = true;
            btn_Ranger2.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            lb_WMR1.Visible = true;
            lb_WMR2.Visible = true;
            lb_WMR1.Text = "";
            lb_WMR2.Text = "";
            label1.Visible = true;
            lb_time.Visible = true;
            timer1.Interval = 1000;
            timer2.Interval = 1000;

            timer1.Start();
            for(int i=3; i<chess.Length; i++)
            {
                chess[i].Enabled = false;
                if (i % 6 == 5) i += 3;
            }
            btn_start.Visible = false;
            btn_start.Enabled = false;

            for (int i = 0; i < chess.Length; i++)
                chess[i].Click += new EventHandler(btn_Chess_Click);
        }

        private void Create_Button()
        {
            int x = 1, y = 0;
            for (int i = 0; i < chess.Length; i++)
            {
                chess[i] = new Button();
                chess[i].SetBounds(50 * (i % 6) + 240, 50 * y + 100, 50, 50);
                
                Controls.Add(chess[i]);
                if (i % 6 == 5) y++;
                x++;
                if (x % 6 == 1) x = 1;
            }

        }

        // p1 sets chesses first
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                timer1.Stop();
                TimeOver1(0);
            }
            else
            {
                sec--;
                lb_time.Text = sec.ToString();
            }
                
        }

        // then p2 sets chesses 
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(sec == 0)
            {
                timer2.Stop();
                TimeOver2(5);
            }
            else
            {
                sec--;
                lb_time.Text = sec.ToString();
            }
        }

        // when ButtonArray clicked...
        private void btn_Click_W1(object sender, EventArgs e)
        {
            if (!placed_W1)
            {
                Button btn = (Button)sender;
                int idx = Array.IndexOf(chess, btn);
                chess[idx].BackColor = Color.LightBlue;
                chess[idx].Text = "Warrior";
                current_W1 = idx;
            }
            placed_W1 = true;
        }

        private void btn_Click_M1(object sender, EventArgs e)
        {
            if (!placed_M1)
            {
                Button btn = (Button)sender;
                int idx = Array.IndexOf(chess, btn);
                chess[idx].BackColor = Color.LightBlue;
                chess[idx].Text = "Mage";
                current_M1 = idx;
            }
            placed_M1 = true;
        }

        private void btn_Click_R1(object sender, EventArgs e)
        {
            if (!placed_R1)
            {
                Button btn = (Button)sender;
                int idx = Array.IndexOf(chess, btn);
                chess[idx].BackColor = Color.LightBlue;
                chess[idx].Text = "Ranger";
                current_R1 = idx;
            }
            placed_R1 = true;
        }
        private void btn_Click_W2(object sender, EventArgs e)
        {
            if (!placed_W2)
            {
                Button btn = (Button)sender;
                int idx = Array.IndexOf(chess, btn);
                chess[idx].BackColor = Color.LightPink;
                chess[idx].Text = "Warrior";
                current_W2 = idx;
            }
            placed_W2 = true;
        }

        private void btn_Click_M2(object sender, EventArgs e)
        {
            if (!placed_M2)
            {
                Button btn = (Button)sender;
                int idx = Array.IndexOf(chess, btn);
                chess[idx].BackColor = Color.LightPink;
                chess[idx].Text = "Mage";
                current_M2 = idx;
            }
            placed_M2 = true;
        }

        private void btn_Click_R2(object sender, EventArgs e)
        {
            if (!placed_R2)
            {
                Button btn = (Button)sender;
                int idx = Array.IndexOf(chess, btn);
                chess[idx].BackColor = Color.LightPink;
                chess[idx].Text = "Ranger";
                current_R2 = idx;
            }
            placed_R2 = true;
        }

        // Setting button
        private void btn_Warrior1_Click(object sender, EventArgs e)
        {
            lb_WMR1.Text = "Warrior";
            btn_Warrior1.Enabled = false;
            btn_Warrior1.Text = "Warrior : 0";
            for (int i=0; i<chess.Length; i++)
            {
                chess[i].Click += new EventHandler(btn_Click_W1);
            }
        }

        private void btn_Mage1_Click(object sender, EventArgs e)
        {
            lb_WMR1.Text = "Mage";
            btn_Mage1.Enabled = false;
            btn_Mage1.Text = "Mage : 0";
            for (int i = 0; i < chess.Length; i++)
            {
                chess[i].Click += new EventHandler(btn_Click_M1);
            }
        }

        private void btn_Ranger1_Click(object sender, EventArgs e)
        {
            lb_WMR1.Text = "Ranger";
            btn_Ranger1.Enabled = false;
            btn_Ranger1.Text = "Ranger : 0";
            for (int i = 0; i < chess.Length; i++)
            {
                chess[i].Click += new EventHandler(btn_Click_R1);
            }
        }

        private void btn_Warrior2_Click(object sender, EventArgs e)
        {
            lb_WMR2.Text = "Warrior";
            btn_Warrior2.Enabled = false;
            btn_Warrior2.Text = "Warrior : 0";
            for (int i = 0; i < chess.Length; i++)
            {
                chess[i].Click += new EventHandler(btn_Click_W2);
            }
        }

        private void btn_Mage2_Click(object sender, EventArgs e)
        {
            lb_WMR2.Text = "Mage";
            btn_Mage2.Enabled = false;
            btn_Mage2.Text = "Mage : 0";
            for (int i = 0; i < chess.Length; i++)
            {
                chess[i].Click += new EventHandler(btn_Click_M2);
                
            }
        }

        private void btn_Ranger2_Click(object sender, EventArgs e)
        {
            lb_WMR2.Text = "Ranger";
            btn_Ranger2.Enabled = false;
            btn_Ranger2.Text = "Ranger : 0";
            for (int i = 0; i < chess.Length; i++)
            {
                chess[i].Click += new EventHandler(btn_Click_R2);
            }
        }
        //　Setting button end

        private void TimeOver1(int idx1)
        {
            for (int i=idx1; i<chess.Length; i+=6)
            {
                if (btn_Warrior1.Text == "Warrior : 1")
                {
                    if (chess[i].Text == "")
                    {
                        chess[i].Text = "Warrior";
                        chess[i].BackColor = Color.LightBlue;
                        btn_Warrior1.Enabled = false;
                        btn_Warrior1.Text = "Warrior : 0";
                    }
                    continue;
                }
                if (btn_Mage1.Text == "Mage : 1")
                {
                    if (chess[i].Text == "")
                    {
                        chess[i].Text = "Mage";
                        chess[i].BackColor = Color.LightBlue;
                        btn_Mage1.Enabled = false;
                        btn_Mage1.Text = "Mage : 0";
                    }
                    continue;
                }
                if (btn_Ranger1.Text == "Ranger : 1")
                {
                    if (chess[i].Text == "")
                    {
                        chess[i].Text = "Ranger";
                        chess[i].BackColor = Color.LightBlue;
                        btn_Ranger1.Enabled = false;
                        btn_Ranger1.Text = "Ranger : 0";
                    }
                    continue;
                }
            }
            
            sec = 10;
            timer2.Start();
            btn_Warrior2.Enabled = true;
            btn_Mage2.Enabled = true;
            btn_Ranger2.Enabled = true;
            for (int i = 3; i < chess.Length; i++)
            {
                chess[i].Enabled = true;
                if (i % 6 == 5) i += 3;
            }
            for (int i = 0; i < chess.Length; i++)
            {
                chess[i].Enabled = false;
                if (i % 6 == 2) i += 3;
            }
            lb_time.Text = sec.ToString();
        }

        private void TimeOver2(int idx2)
        {
            for(int i=idx2; i<chess.Length; i += 6)
            {
                if (btn_Warrior2.Text == "Warrior : 1")
                {
                    if (chess[i].Text == "")
                    {
                        chess[i].Text = "Warrior";
                        chess[i].BackColor = Color.LightPink;
                        current_W2 = i;
                        btn_Warrior2.Enabled = false;
                        btn_Warrior2.Text = "Warrior : 0";
                    }
                    continue;
                }
                if (btn_Mage2.Text == "Mage : 1")
                {
                    if (chess[i].Text == "")
                    {
                        chess[i].Text = "Mage";
                        chess[i].BackColor = Color.LightPink;
                        current_M2 = i;
                        btn_Mage2.Enabled = false;
                        btn_Mage2.Text = "Mage : 0";
                    }
                    continue;
                }
                if (btn_Ranger2.Text == "Ranger : 1")
                {
                    if (chess[i].Text == "")
                    {
                        chess[i].Text = "Ranger";
                        chess[i].BackColor = Color.LightPink;
                        current_R2 = i;
                        btn_Ranger2.Enabled = false;
                        btn_Ranger2.Text = "Ranger : 0";
                    }
                    continue;
                }
            }

            lb_time.Visible = false;
            for (int i = 0; i < chess.Length; i++)
            {
                chess[i].Enabled = true;
                if (i % 6 == 2) i += 3;
            }
            Turn();
            lb_G_WMR2.Text = "";
            lb_hp2.Text = "";
            lb_mp2.Text = "";
            lb_atk2.Text = "";
            lb_atk_r2.Text = "";
            lb_move_r2.Text = "";
            panel1.Visible = true;
            panel2.Visible = true;
            
            
        }

        private void Turn()
        {
            if(turn == 1)
            {
                if (!die_w1)
                    Warrior1(); // Start from P1
                else if (!die_m1)
                    Mage1();
                else if (!die_r1)
                    Ranger1();
                else
                    Win("p2");

                btn_atk1.Enabled = true;
                btn_move1.Enabled = true;
                btn_skill1.Enabled = true;
                btn_standby1.Enabled = true;
                btn_finish1.Enabled = false;
                btn_atk2.Enabled = false;
                btn_move2.Enabled = false;
                btn_skill2.Enabled = false;
                btn_standby2.Enabled = false;
                btn_finish2.Enabled = false;
                label1.Text = "P1 Turn";
                turn++;
            }
            else
            {
                if (!die_w2)
                    Warrior2();
                else if (!die_m2)
                    Mage2();
                else if (!die_r2)
                    Ranger1();
                else
                    Win("p1");

                btn_atk2.Enabled = true;
                btn_move2.Enabled = true;
                btn_skill2.Enabled = true;
                btn_standby2.Enabled = true;
                btn_finish2.Enabled = false;
                btn_atk1.Enabled = false;
                btn_move1.Enabled = false;
                btn_skill1.Enabled = false;
                btn_standby1.Enabled = false;
                btn_finish1.Enabled = false;
                label1.Text = "P2 Turn";
                turn--;
            }    

        }

        // Initialize
        Warrior1 w1 = new Warrior1("Warrior", 100, 15, 30, 1, 2);
        Mage1 m1 = new Mage1("Mage", 70, 25, 20, 2, 2);
        Ranger1 r1 = new Ranger1("Ranger", 90, 10, 30, 3, 1);
        Warrior2 w2 = new Warrior2("Warrior", 100, 15, 30, 1, 2);
        Mage2 m2 = new Mage2("Mage", 70, 25, 20, 2, 2);
        Ranger2 r2 = new Ranger2("Ranger", 90, 10, 30, 3, 1);

        private void Warrior1()
        {
            Info1(w1);
            lb_hp1.Text = "HP : " + w1.curr_hp.ToString();
            lb_mp1.Text = "MP : " + w2.curr_mp_w1.ToString();
        }
        private void Mage1()
        {
            Info1(m1);
            lb_hp1.Text = "HP : " + m1.curr_hp.ToString();
            lb_mp1.Text = "MP : " + m2.curr_mp_m1.ToString();
        }

        private void Ranger1()
        {
            Info1(r1);
            lb_hp1.Text = "HP : " + r1.curr_hp.ToString();
            lb_mp1.Text = "MP : " + r2.curr_mp_r1.ToString();
        }

        private void Warrior2()
        {
            Info2(w2);
            lb_hp2.Text = "HP : " + w2.curr_hp.ToString();
            lb_mp2.Text = "MP : " + w1.curr_mp_w2.ToString();
        }
        private void Mage2()
        {
            Info2(m2);
            lb_hp2.Text = "HP : " + m2.curr_hp.ToString();
            lb_mp2.Text = "MP : " + m1.curr_mp_m2.ToString();
        }

        private void Ranger2()
        {
            Info2(r2);
            lb_hp2.Text = "HP : " + r2.curr_hp.ToString();
            lb_mp2.Text = "MP : " + r1.curr_mp_r2.ToString();
        }

        private void Info1(Chess c)
        {
            lb_G_WMR1.Text = c.character;
            lb_atk1.Text = "ATK : " + c.atk.ToString();
            lb_atk_r1.Text = "ATK Range : " + c.atkRange.ToString();
            lb_move_r1.Text = "MOVE Range : " + c.moveRange.ToString();
        }

        private void Info2(Chess c2)
        {
            lb_G_WMR2.Text = c2.character;
            lb_atk2.Text = "ATK : " + c2.atk.ToString();
            lb_atk_r2.Text = "ATK Range : " + c2.atkRange.ToString();
            lb_move_r2.Text = "MOVE Range : " + c2.moveRange.ToString();
        }

        private void btn_Chess_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (method == 0) // p1 attack
            {
                if (btn.BackColor == Color.LightPink)
                {
                    int idx = Array.IndexOf(chess, btn);
                    // w1 attack
                    if (lb_G_WMR1.Text == "Warrior")
                    {
                        if (idx == current_W1 + 1 || idx == current_W1 - 1 || idx == current_W1 + 6 || idx == current_W1 - 6)
                        {
                            // attack w2
                            if (btn.Text == "Warrior")
                            {
                                Warrior2();
                                current_W2_hp = w2.Attack("Warrior");
                                lb_hp2.Text = "HP : " + current_W2_hp.ToString();
                                Die();
                            }
                            else if (btn.Text == "Mage") // attack m2
                            {
                                Mage2();
                                current_M2_hp = m2.Attack("Warrior");
                                lb_hp2.Text = "HP : " + current_M2_hp.ToString();
                                Die();
                            }
                            else // attack r2
                            {
                                Ranger2();
                                current_R2_hp = r2.Attack("Warrior");
                                lb_hp2.Text = "HP : " + current_R2_hp.ToString();
                                Die();
                            }
                            if (!die_m1)
                                Mage1();
                            else if (!die_r1)
                                Ranger1();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (lb_G_WMR1.Text == "Mage")
                    {
                        if ((idx <= current_M1 + 2 && idx >= current_M1 - 2) || idx == current_M1 + 6 || idx == current_M1 - 6 || idx == current_M1 + 12 || idx == current_M1 - 12)
                        {
                            // attack w2
                            if (btn.Text == "Warrior")
                            {
                                Warrior2();
                                current_W2_hp = w2.Attack("Mage");
                                lb_hp2.Text = "HP : " + current_W2_hp.ToString();
                                Die();
                            }
                            else if (btn.Text == "Mage") // attack m2
                            {
                                Mage2();
                                current_M2_hp = m2.Attack("Mage");
                                lb_hp2.Text = "HP : " + current_M2_hp.ToString();
                                Die();
                            }
                            else // attack r2
                            {
                                Ranger2();
                                current_R2_hp = r2.Attack("Mage");
                                lb_hp2.Text = "HP : " + current_R2_hp.ToString();
                                Die();
                            }
                            if (!die_r1)
                                Ranger1();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (lb_G_WMR1.Text == "Ranger")
                    {
                        if ((idx <= current_R1 + 3 && idx >= current_R1 - 3) || idx == current_R1 + 6 || idx == current_R1 - 6 || idx == current_R1 + 12 || idx == current_R1 - 12 || idx == current_R1 + 18 || idx == current_R1 - 18)
                        {
                            // attack w2
                            if (btn.Text == "Warrior")
                            {
                                Warrior2();
                                current_W2_hp = w2.Attack("Ranger");
                                lb_hp2.Text = "HP : " + current_W2_hp.ToString();
                                Die();
                            }
                            else if (btn.Text == "Mage") // attack m2
                            {
                                Mage2();
                                current_M2_hp = m2.Attack("Ranger");
                                lb_hp2.Text = "HP : " + current_M2_hp.ToString();
                                Die();
                            }
                            else // attack r2
                            {
                                Ranger2();
                                current_R2_hp = r2.Attack("Ranger");
                                lb_hp2.Text = "HP : " + current_R2_hp.ToString();
                                Die();
                            }
                            btn_atk1.Enabled = false;
                            btn_move1.Enabled = false;
                            btn_skill1.Enabled = false;
                            btn_standby1.Enabled = false;
                            btn_finish1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }

                }
            }
            else if(method == 1) // p1 move
            {
                if (lb_G_WMR1.Text == "Warrior")
                {
                    if (btn.Text == "")
                    {
                        int idx = Array.IndexOf(chess, btn);
                        if ((idx <= current_W1 + 2 && idx >= current_W1 - 2) || idx == current_W1 + 6 || idx == current_W1 - 6 || idx == current_W1 + 12 || idx == current_W1 - 12)
                        {
                            chess[current_W1].Text = "";
                            chess[current_W1].BackColor = SystemColors.ControlLight;
                            current_W1 = idx;
                            chess[current_W1].Text = "Warrior";
                            chess[current_W1].BackColor = Color.LightBlue;
                            if (!die_m1)
                                Mage1();
                            else if (!die_r1)
                                Ranger1();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed move range", "", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Already exist item", "", MessageBoxButtons.OK);
                    }
                }
                else if (lb_G_WMR1.Text == "Mage")
                {
                    if (btn.Text == "")
                    {
                        int idx = Array.IndexOf(chess, btn);
                        if ((idx <= current_M1 + 2 && idx >= current_M1 - 2) || idx == current_M1 + 6 || idx == current_M1 - 6 || idx == current_M1 + 12 || idx == current_M1 - 12)
                        {
                            chess[current_M1].Text = "";
                            chess[current_M1].BackColor = SystemColors.ControlLight;
                            current_M1 = idx;
                            chess[current_M1].Text = "Mage";
                            chess[current_M1].BackColor = Color.LightBlue;
                            if (!die_r1)
                                Ranger1();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed move range", "", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Already exist item", "", MessageBoxButtons.OK);
                    }
                }
                else if (lb_G_WMR1.Text == "Ranger")
                {
                    if (btn.Text == "")
                    {
                        int idx = Array.IndexOf(chess, btn);
                        if ((idx <= current_R1 + 2 && idx >= current_R1 - 2) || idx == current_R1 + 6 || idx == current_R1 - 6 || idx == current_R1 + 12 || idx == current_R1 - 12)
                        {
                            chess[current_R1].Text = "";
                            chess[current_R1].BackColor = SystemColors.ControlLight;
                            current_R1 = idx;
                            chess[current_R1].Text = "Ranger";
                            chess[current_R1].BackColor = Color.LightBlue;
                            btn_atk1.Enabled = false;
                            btn_move1.Enabled = false;
                            btn_skill1.Enabled = false;
                            btn_standby1.Enabled = false;
                            btn_finish1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Exceed move range", "", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Already exist item", "", MessageBoxButtons.OK);
                    }
                }
            }
            else if(method == 2) // p1 skill
            {
                if (btn.BackColor == Color.LightPink)
                {
                    int idx = Array.IndexOf(chess, btn);
                    // w1 skill
                    if (lb_G_WMR1.Text == "Warrior")
                    {
                        if (idx == current_W1 + 1 || idx == current_W1 - 1 || idx == current_W1 + 6 || idx == current_W1 - 6)
                        {
                            // skill w2
                            if (btn.Text == "Warrior")
                            {
                                Warrior2();
                                current_W2_hp = w2.curr_hp;
                                lb_hp1.Text = "HP : " + w2.Skill("Warrior").ToString();
                                lb_hp2.Text = "HP : " + w2.curr_hp.ToString();
                                if(w2.curr_mp_w1 >= 0)
                                    lb_mp1.Text = "MP : " + w2.curr_mp_w1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();

                            }
                            else if (btn.Text == "Mage") // skill m2
                            {
                                Mage2();
                                current_M2_hp = m2.Skill("Warrior");
                                lb_hp2.Text = "HP : " + current_M2_hp.ToString();
                                if (m2.curr_mp_w1 >= 0)
                                    lb_mp1.Text = "MP : " + m2.curr_mp_w1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else // skill r2
                            {
                                Ranger2();
                                current_R2_hp = r2.Skill("Warrior");
                                lb_hp2.Text = "HP : " + current_R2_hp.ToString();
                                if (r2.curr_mp_w1 >= 0)
                                    lb_mp1.Text = "MP : " + r2.curr_mp_w1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            if (!die_m1)
                                Mage1();
                            else if (!die_r1)
                                Ranger1();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (lb_G_WMR1.Text == "Mage") // m1 skill
                    {
                        if ((idx <= current_M1 + 2 && idx >= current_M1 - 2) || idx == current_M1 + 6 || idx == current_M1 - 6 || idx == current_M1 + 12 || idx == current_M1 - 12)
                        {
                            // skill w2
                            if (btn.Text == "Warrior")
                            {
                                Warrior2();
                                current_W2_hp = w2.Skill("Mage");
                                lb_hp2.Text = "HP : " + current_W2_hp.ToString(); // w2 is attacked, so its hp decreasing
                                if (w2.curr_mp_m1 >= 0)
                                    lb_mp1.Text = "MP : " + w2.curr_mp_m1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else if (btn.Text == "Mage") // skill m2
                            {
                                Mage2();
                                current_M2_hp = m2.Skill("Mage");
                                lb_hp2.Text = "HP : " + current_M2_hp.ToString();
                                if (m2.curr_mp_m1 >= 0)
                                    lb_mp1.Text = "MP : " + m2.curr_mp_m1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else // skill r2
                            {
                                Ranger2();
                                current_R2_hp = r2.Skill("Mage");
                                lb_hp2.Text = "HP : " + current_R2_hp.ToString();
                                if (r2.curr_mp_m1 >= 0)
                                    lb_mp1.Text = "MP : " + r2.curr_mp_m1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            if (!die_r1)
                                Ranger1();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (lb_G_WMR1.Text == "Ranger") // r1 skill
                    {
                        if ((idx <= current_R1 + 4 && idx >= current_R1 - 4) || (idx <= current_R1 + 24 && idx >= current_R1 - 24 && Math.Abs(current_R1 - idx) % 6 == 0 && current_R1 + 24 < 42 && current_R1 - 24 >= 0))
                        {
                            // skill w2
                            if (btn.Text == "Warrior")
                            {
                                Warrior2();
                                current_W2_hp = w2.Skill("Ranger");
                                lb_hp2.Text = "HP : " + current_W2_hp.ToString();
                                if (w2.curr_mp_r1 >= 0)
                                    lb_mp1.Text = "MP : " + w2.curr_mp_r1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else if (btn.Text == "Mage") // skill m2
                            {
                                Mage2();
                                current_M2_hp = m2.Skill("Ranger");
                                lb_hp2.Text = "HP : " + current_M2_hp.ToString();
                                if (m2.curr_mp_r1 >= 0)
                                    lb_mp1.Text = "MP : " + m2.curr_mp_r1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else // skill r2
                            {
                                Ranger2();
                                current_R2_hp = r2.Skill("Ranger");
                                lb_hp2.Text = "HP : " + current_R2_hp.ToString();
                                if (m2.curr_mp_r1 >= 0)
                                    lb_mp1.Text = "MP : " + m2.curr_mp_r1.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            btn_atk1.Enabled = false;
                            btn_move1.Enabled = false;
                            btn_skill1.Enabled = false;
                            btn_standby1.Enabled = false;
                            btn_finish1.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else if(method == 3)
            {
                if (btn.BackColor == Color.LightBlue)
                {
                    int idx = Array.IndexOf(chess, btn);
                    // w2 attack
                    if (lb_G_WMR2.Text == "Warrior")
                    {
                        if (idx == current_W2 + 1 || idx == current_W2 - 1 || idx == current_W2 + 6 || idx == current_W2 - 6)
                        {
                            // attack w1
                            if (btn.Text == "Warrior")
                            {
                                Warrior1();
                                current_W1_hp = w1.Attack("Warrior");
                                lb_hp1.Text = "HP : " + current_W1_hp.ToString(); // warrior == attacker
                                Die();
                            }
                            else if (btn.Text == "Mage") // attack m1
                            {
                                Mage1();
                                current_M1_hp = m1.Attack("Warrior");
                                lb_hp1.Text = "HP : " + current_M1_hp.ToString();
                                Die();
                            }
                            else // attack r1
                            {
                                Ranger1();
                                current_R1_hp = r1.Attack("Warrior");
                                lb_hp1.Text = "HP : " + current_R1_hp.ToString();
                                Die();
                            }
                            if (!die_m2)
                                Mage2();
                            else if (!die_r2)
                                Ranger2();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (lb_G_WMR2.Text == "Mage")
                    {
                        if ((idx <= current_M2 + 2 && idx >= current_M2 - 2) || idx == current_M2 + 6 || idx == current_M2 - 6 || idx == current_M2 + 12 || idx == current_M2 - 12)
                        {
                            // attack w1
                            if (btn.Text == "Warrior")
                            {
                                Warrior1();
                                current_W1_hp = w1.Attack("Mage");
                                lb_hp1.Text = "HP : " + current_W1_hp.ToString();
                                Die();
                            }
                            else if (btn.Text == "Mage") // attack m1
                            {
                                Mage1();
                                current_M1_hp = m1.Attack("Mage");
                                lb_hp1.Text = "HP : " + current_M1_hp.ToString();
                                Die();
                            }
                            else // attack r1
                            {
                                Ranger1();
                                current_R1_hp = r1.Attack("Mage");
                                lb_hp1.Text = "HP : " + current_R1_hp.ToString();
                                Die();
                            }
                            if (!die_r2)
                                Ranger2();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (lb_G_WMR2.Text == "Ranger")
                    {
                        if ((idx <= current_R2 + 3 && idx >= current_R2 - 3) || idx == current_M2 + 6 || idx == current_M2 - 6 || idx == current_M2 + 12 || idx == current_M2 - 12 || idx == current_M2 + 18 || idx == current_M2 - 18)
                        {
                            // attack w2
                            if (btn.Text == "Warrior")
                            {
                                Warrior1();
                                current_W1_hp = w1.Attack("Ranger");
                                lb_hp1.Text = "HP : " + current_W1_hp.ToString();
                                Die();
                            }
                            else if (btn.Text == "Mage") // attack m2
                            {
                                Mage1();
                                current_M1_hp = m1.Attack("Ranger");
                                lb_hp1.Text = "HP : " + current_M1_hp.ToString();
                                Die();
                            }
                            else // attack r2
                            {
                                Ranger1();
                                current_R1_hp = r1.Attack("Ranger");
                                lb_hp1.Text = "HP : " + current_R1_hp.ToString();
                                Die();
                            }
                            btn_atk2.Enabled = false;
                            btn_move2.Enabled = false;
                            btn_skill2.Enabled = false;
                            btn_standby2.Enabled = false;
                            btn_finish2.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }

                }
            }
            else if(method == 4)
            {
                if (lb_G_WMR2.Text == "Warrior")
                {
                    if (btn.Text == "")
                    {
                        int idx = Array.IndexOf(chess, btn);
                        if ((idx <= current_W2 + 2 && idx >= current_W2 - 2) || idx == current_W2 + 6 || idx == current_W2 - 6 || idx == current_W2 + 12 || idx == current_W2 - 12)
                        {
                            chess[current_W2].Text = "";
                            chess[current_W2].BackColor = SystemColors.ControlLight;
                            current_W2 = idx;
                            chess[current_W2].Text = "Warrior";
                            chess[current_W2].BackColor = Color.LightPink;
                            Mage2();
                        }
                        else
                        {
                            MessageBox.Show("Exceed move range", "", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Already exist item", "", MessageBoxButtons.OK);
                    }
                }
                else if (lb_G_WMR2.Text == "Mage")
                {
                    if (btn.Text == "")
                    {
                        int idx = Array.IndexOf(chess, btn);
                        if ((idx <= current_M2 + 2 && idx >= current_M2 - 2) || idx == current_M2 + 6 || idx == current_M2 - 6 || idx == current_M2 + 12 || idx == current_M2 - 12)
                        {
                            chess[current_M2].Text = "";
                            chess[current_M2].BackColor = SystemColors.ControlLight;
                            current_M2 = idx;
                            chess[current_M2].Text = "Mage";
                            chess[current_M2].BackColor = Color.LightPink;
                            Ranger2();
                        }
                        else
                        {
                            MessageBox.Show("Exceed move range", "", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Already exist item", "", MessageBoxButtons.OK);
                    }
                }
                else if (lb_G_WMR2.Text == "Ranger")
                {
                    if (btn.Text == "")
                    {
                        int idx = Array.IndexOf(chess, btn);
                        if ((idx <= current_R2 + 2 && idx >= current_R2 - 2) || idx == current_R2 + 6 || idx == current_R2 - 6 || idx == current_R2 + 12 || idx == current_R2 - 12)
                        {
                            chess[current_R2].Text = "";
                            chess[current_R2].BackColor = SystemColors.ControlLight;
                            current_R2 = idx;
                            chess[current_R2].Text = "Ranger";
                            chess[current_R2].BackColor = Color.LightPink;
                            btn_atk2.Enabled = false;
                            btn_move2.Enabled = false;
                            btn_skill2.Enabled = false;
                            btn_standby2.Enabled = false;
                            btn_finish2.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Exceed move range", "", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Already exist item", "", MessageBoxButtons.OK);
                    }
                }
            }
            else if(method == 5)
            {
                if (btn.BackColor == Color.LightBlue)
                {
                    int idx = Array.IndexOf(chess, btn);
                    // w2 skill
                    if (lb_G_WMR2.Text == "Warrior")
                    {
                        if (idx == current_W2 + 1 || idx == current_W2 - 1 || idx == current_W2 + 6 || idx == current_W2 - 6)
                        {
                            // skill w1
                            if (btn.Text == "Warrior")
                            {
                                Warrior1();
                                current_W1_hp = w1.curr_hp;
                                lb_hp2.Text = "HP : " + w1.Skill("Warrior").ToString();
                                lb_hp1.Text = "HP : " + w1.curr_hp.ToString();
                                if (w1.curr_mp_w2 >= 0)
                                    lb_mp2.Text = "MP : " + w1.curr_mp_w2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else if (btn.Text == "Mage") // skill m1
                            {
                                Mage1();
                                current_M1_hp = m1.Skill("Warrior");
                                lb_hp1.Text = "HP : " + current_M1_hp.ToString();
                                if (m1.curr_mp_w2 >= 0)
                                    lb_mp2.Text = "MP : " + m1.curr_mp_w2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else // skill r1
                            {
                                Ranger1();
                                current_R1_hp = r1.Skill("Warrior");
                                lb_hp1.Text = "HP : " + current_R1_hp.ToString();
                                if (r1.curr_mp_w2 >= 0)
                                    lb_mp2.Text = "MP : " + r1.curr_mp_w2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            if (!die_m2)
                                Mage2();
                            else if (!die_r2)
                                Ranger2();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (lb_G_WMR2.Text == "Mage") // m2 skill
                    {
                        if ((idx <= current_M2 + 2 && idx >= current_M2 - 2) || idx == current_M2 + 6 || idx == current_M2 - 6 || idx == current_M2 + 12 || idx == current_M2 - 12)
                        {
                            // skill w1
                            if (btn.Text == "Warrior")
                            {
                                Warrior1();
                                current_W1_hp = w1.Skill("Mage");
                                lb_hp1.Text = "HP : " + current_W1_hp.ToString();
                                if (w1.curr_mp_m2 >= 0)
                                    lb_mp2.Text = "MP : " + w1.curr_mp_m2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                                
                            }
                            else if (btn.Text == "Mage") // skill m1
                            {
                                Mage1();
                                current_M1_hp = m1.Skill("Mage");
                                lb_hp1.Text = "HP : " + current_M1_hp.ToString();
                                if (m1.curr_mp_m2 >= 0)
                                    lb_mp2.Text = "MP : " + m1.curr_mp_m2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else // skill r1
                            {
                                Ranger1();
                                current_R1_hp = r1.Skill("Mage");
                                lb_hp1.Text = "HP : " + current_R1_hp.ToString();
                                if (r1.curr_mp_m2 >= 0)
                                    lb_mp2.Text = "MP : " + r1.curr_mp_m2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            if (!die_r2)
                                Ranger2();
                            else
                                Turn();
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                    else if (lb_G_WMR2.Text == "Ranger") // r2 skill
                    {
                        if ((idx <= current_R2 + 4 && idx >= current_R2 - 4) || (idx <= current_R2 + 24 && idx >= current_R2 - 24 && Math.Abs(current_R2 - idx) % 6 == 0 && current_R2 + 24 < 42 && current_R2 - 24 >= 0))
                        {
                            // skill w1
                            if (btn.Text == "Warrior")
                            {
                                Warrior1();
                                current_W1_hp = w1.Skill("Ranger");
                                lb_hp1.Text = "HP : " + current_W1_hp.ToString();
                                if (w1.curr_mp_r2 >= 0)
                                    lb_mp2.Text = "MP : " + w1.curr_mp_r2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else if (btn.Text == "Mage") // skill m1
                            {
                                Mage1();
                                current_M1_hp = m1.Skill("Ranger");
                                lb_hp1.Text = "HP : " + current_M1_hp.ToString();
                                if (m1.curr_mp_r2 >= 0)
                                    lb_mp2.Text = "MP : " + m1.curr_mp_r2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            else // skill r1
                            {
                                Ranger1();
                                current_R1_hp = r1.Skill("Ranger");
                                lb_hp1.Text = "HP : " + current_R1_hp.ToString();
                                if (r1.curr_mp_r2 >= 0)
                                    lb_mp2.Text = "MP : " + r1.curr_mp_r2.ToString();
                                else
                                    MessageBox.Show("You don't have enough magic point", "", MessageBoxButtons.OK);
                                Die();
                            }
                            btn_atk2.Enabled = false;
                            btn_move2.Enabled = false;
                            btn_skill2.Enabled = false;
                            btn_standby2.Enabled = false;
                            btn_finish2.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Exceed attack range", "", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
        private void btn_atk1_Click(object sender, EventArgs e) // p1 attack
        {
            method = 0;
            /*if (lb_G_WMR1.Text == "Warrior")
            {
            }
            else if (lb_G_WMR1.Text == "Mage")
            {
            }
            else if(lb_G_WMR1.Text == "Ranger")
            {
                btn_atk1.Enabled = false;
                btn_move1.Enabled = false;
                btn_skill1.Enabled = false;
                btn_standby1.Enabled = false;
                btn_finish1.Enabled = true;
            }*/
        }

        private void btn_move1_Click(object sender, EventArgs e)
        {
            method = 1;
        }

        private void btn_skill1_Click(object sender, EventArgs e)
        {
            method = 2;
            /*if (lb_G_WMR1.Text == "Warrior")
            {
            }
            else if (lb_G_WMR1.Text == "Mage")
            {
            }
            else if (lb_G_WMR1.Text == "Ranger")
            {
                btn_atk1.Enabled = false;
                btn_move1.Enabled = false;
                btn_skill1.Enabled = false;
                btn_standby1.Enabled = false;
                btn_finish1.Enabled = true;
            }*/
        }

        private void btn_standby1_Click(object sender, EventArgs e)
        {
            if(lb_G_WMR1.Text == "Warrior")
            {
                lb_G_WMR1.Text = "Mage";
                lb_hp1.Text = "HP : " + m1.curr_hp.ToString();
                lb_mp1.Text = "MP : " + m1.curr_mp.ToString();
                lb_atk1.Text = "ATK : " + m1.atk.ToString();
                lb_atk_r1.Text = "ATK Range : " + m1.atkRange.ToString();
                lb_move_r1.Text = "MOVE Range : " + m1.moveRange.ToString();
            }
            else if(lb_G_WMR1.Text == "Mage")
            {
                lb_G_WMR1.Text = "Ranger";
                lb_hp1.Text = "HP : " + r1.curr_hp.ToString();
                lb_mp1.Text = "MP : " + r1.curr_mp.ToString();
                lb_atk1.Text = "ATK : " + r1.atk.ToString();
                lb_atk_r1.Text = "ATK Range : " + r1.atkRange.ToString();
                lb_move_r1.Text = "MOVE Range : " + r1.moveRange.ToString();
            }
            else if(lb_G_WMR1.Text == "Ranger")
            {
                btn_atk1.Enabled = false;
                btn_move1.Enabled = false;
                btn_skill1.Enabled = false;
                btn_standby1.Enabled = false;
                btn_finish1.Enabled = true;
            }
        }

        private void btn_finish1_Click(object sender, EventArgs e)
        {
            Turn();
        }

        private void btn_atk2_Click(object sender, EventArgs e)
        {
            method = 3;
            /*if (lb_G_WMR2.Text == "Warrior")
            {
            }
            else if (lb_G_WMR2.Text == "Mage")
            {
            }
            else if (lb_G_WMR2.Text == "Ranger")
            {
                btn_atk2.Enabled = false;
                btn_move2.Enabled = false;
                btn_skill2.Enabled = false;
                btn_standby2.Enabled = false;
                btn_finish2.Enabled = true;
            }*/
        }

        private void btn_move2_Click(object sender, EventArgs e)
        {
            method = 4;
        }

        private void btn_skill2_Click(object sender, EventArgs e)
        {
            method = 5;
            /*if (lb_G_WMR2.Text == "Warrior")
            {
            }
            else if (lb_G_WMR2.Text == "Mage")
            {
            }
            else if (lb_G_WMR2.Text == "Ranger")
            {
                btn_atk2.Enabled = false;
                btn_move2.Enabled = false;
                btn_skill2.Enabled = false;
                btn_standby2.Enabled = false;
                btn_finish2.Enabled = true;
            }*/
        }

        private void btn_standby2_Click(object sender, EventArgs e)
        {
            if (lb_G_WMR2.Text == "Warrior")
            {
                lb_G_WMR2.Text = "Mage";
                lb_hp2.Text = "HP : " + m2.curr_hp.ToString();
                lb_mp2.Text = "MP : " + m2.curr_mp.ToString();
                lb_atk2.Text = "ATK : " + m2.atk.ToString();
                lb_atk_r2.Text = "ATK Range : " + m2.atkRange.ToString();
                lb_move_r2.Text = "MOVE Range : " + m2.moveRange.ToString();
            }
            else if (lb_G_WMR2.Text == "Mage")
            {
                lb_G_WMR2.Text = "Ranger";
                lb_hp2.Text = "HP : " + r2.curr_hp.ToString();
                lb_mp2.Text = "MP : " + r2.curr_mp.ToString();
                lb_atk2.Text = "ATK : " + r2.atk.ToString();
                lb_atk_r2.Text = "ATK Range : " + r2.atkRange.ToString();
                lb_move_r2.Text = "MOVE Range : " + r2.moveRange.ToString();
            }
            else if (lb_G_WMR2.Text == "Ranger")
            {
                btn_atk2.Enabled = false;
                btn_move2.Enabled = false;
                btn_skill2.Enabled = false;
                btn_standby2.Enabled = false;
                btn_finish2.Enabled = true;
            }
        }

        private void btn_finish2_Click(object sender, EventArgs e)
        {
            Turn();
        }

        private void Die()
        {
            if(current_W1_hp <= 0)
            {
                chess[current_W1].Text = "";
                chess[current_W1].BackColor = SystemColors.ControlLight;
                die_w1 = true;
                if (die_w1 && die_m1 && die_r1)
                    Win("p2");
            }
            if(current_M1_hp <= 0)
            {
                chess[current_M1].Text = "";
                chess[current_M1].BackColor = SystemColors.ControlLight;
                die_m1 = true;
                if (die_w1 && die_m1 && die_r1)
                    Win("p2");
            }
            if(current_R1_hp <= 0)
            {
                chess[current_R1].Text = "";
                chess[current_R1].BackColor = SystemColors.ControlLight;
                die_r1 = true;
                if (die_w1 && die_m1 && die_r1)
                    Win("p2");
            }
            if(current_W2_hp <= 0)
            {
                chess[current_W2].Text = "";
                chess[current_W2].BackColor = SystemColors.ControlLight;
                die_w2 = true;
                if (die_w2 && die_m2 && die_r2)
                    Win("p1");
            }
            if(current_M2_hp <= 0)
            {
                chess[current_M2].Text = "";
                chess[current_M2].BackColor = SystemColors.ControlLight;
                die_m2 = true;
                if (die_w2 && die_m2 && die_r2)
                    Win("p1");
            }
            if(current_R2_hp <= 0)
            {
                chess[current_R2].Text = "";
                chess[current_R2].BackColor = SystemColors.ControlLight;
                die_r2 = true;
                if (die_w2 && die_m2 && die_r2)
                    Win("p1");
            }
            
        }

        private void Win(string winner)
        {
            
            if (winner == "p1")
                MessageBox.Show("P1 wins!", "", MessageBoxButtons.OK);
            if (winner == "p2")
                MessageBox.Show("P2 wins!", "", MessageBoxButtons.OK);

            if (MessageBox.Show("P1 wins!", "", MessageBoxButtons.OK) == DialogResult.OK || MessageBox.Show("P2 wins!", "", MessageBoxButtons.OK) == DialogResult.OK)
                Application.Exit();

        }
    }
}

