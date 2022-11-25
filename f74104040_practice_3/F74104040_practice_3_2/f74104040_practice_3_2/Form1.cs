using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stackgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] values = new string[4];
        string[] s = new string[10];
        bool valid, win = false;
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int heap0, heap1, heap2, heap3;
        int count_null = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lb_data.Text = "Please input the data";
            tb_1.Text = "1 1 2";
            tb_2.Text = "2 2";
            tb_3.Text = "";
            tb_4.Text = "3 3 3 1";
        }        

        private void btn_start_Click(object sender, EventArgs e)
        {
            values[0] = tb_1.Text;
            values[1] = tb_2.Text;
            values[2] = tb_3.Text;
            values[3] = tb_4.Text;
            num1 = 0;
            num2 = 0;
            num3 = 0;
            for (int i = 0; i < s.Length; i++) s[i] = "";

            for (int i=0; i<4; i++)
            {
                valid = Regex.IsMatch(values[i], @"[1-3\s]");
                if (!valid && values[i] != "")
                {
                    lb_data.Text = "Wrong Data";
                    break;
                }
                else if (values[i] != "")
                {
                    s = values[i].Split(' ');
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j] != "1" && s[j] != "2" && s[j] != "3")
                        {
                            valid = false;
                            lb_data.Text = "Wrong Data";
                            break;
                        }
                    }
                    if (!valid) break;
                }
            }
            
            if (valid)
            {
                values[0] = values[0].Replace(" ", "");
                values[1] = values[1].Replace(" ", "");
                values[2] = values[2].Replace(" ", "");
                values[3] = values[3].Replace(" ", "");

                for (int i = 0; i < values.Length; i++)
                {
                    if(values[i] == "")
                    {
                        valid = true;
                        continue;
                    }
                    else
                        valid = int.TryParse(values[i], out int result);
                    
                    if (!valid)
                        break;
                }

                heap0 = values[0].Length - 1;
                heap1 = values[1].Length - 1;
                heap2 = values[2].Length - 1;
                heap3 = values[3].Length - 1;
                
                if (heap0 == -1) count_null++;
                if (heap1 == -1) count_null++;
                if (heap2 == -1) count_null++;
                if (heap3 == -1) count_null++;

                for (int j = 0; j < values[0].Length; j++)
                {
                    if (values[0][j] == '1')
                        num1++;
                    else if (values[0][j] == '2')
                        num2++;
                    else if (values[0][j] == '3')
                        num3++;

                }
                for (int j = 0; j < values[1].Length; j++)
                {
                    if (values[1][j] == '1')
                        num1++;
                    else if (values[1][j] == '2')
                        num2++;
                    else if (values[1][j] == '3')
                        num3++;
                }
                for (int j = 0; j < values[2].Length; j++)
                {
                    if (values[2][j] == '1')
                        num1++;
                    else if (values[2][j] == '2')
                        num2++;
                    else if (values[2][j] == '3')
                        num3++;
                }
                for (int j = 0; j < values[3].Length; j++)
                {
                    if (values[3][j] == '1')
                        num1++;
                    else if (values[3][j] == '2')
                        num2++;
                    else if (values[3][j] == '3')
                        num3++;
                }

            }

            if(num1 == 3 && num2 == 3 && num3 == 3 && valid)
            {
                panel1.Visible = false;
                if (heap0 == -1) btn_s1.Enabled = false;
                else btn_s1.Enabled = true;
                if (heap1 == -1) btn_s2.Enabled = false;
                else btn_s2.Enabled = true;
                if (heap2 == -1) btn_s3.Enabled = false;
                else btn_s3.Enabled = true;
                if (heap3 == -1) btn_s4.Enabled = false;
                else btn_s4.Enabled = true;
                label9.Text = "...";
                print();
                Game g = new Game();
                if (count_null == 1)
                {
                    if(heap0 == -1)
                    {
                        win = g.win(values[1], values[2], values[3]);
                        check_win(win);
                    }
                    else if(heap1 == -1)
                    {
                        win = g.win(values[0], values[2], values[3]);
                        check_win(win);
                    }
                    else if(heap2 == -1)
                    {
                        win = g.win(values[0], values[1], values[3]);
                        check_win(win);
                    }
                    else if(heap3 == -1)
                    {
                        win = g.win(values[0], values[1], values[2]);
                        check_win(win);
                    }
                }
                else
                {
                    count_null = 0;
                }

            }
            else
            {
                lb_data.Text = "Wrong Data";
                valid = false;
            }
        }
        
        

        private void btn_back_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            tb_1.Text = "1 1 2";
            tb_2.Text = "2 2";
            tb_3.Text = "";
            tb_4.Text = "3 3 3 1";
            lb_data.Text = "Please input the data";
            btn_s1.Text = "Select";
            btn_s2.Text = "Select";
            btn_s3.Text = "Select";
            btn_s4.Text = "Select";
            num1 = 0;
            num2 = 0;
            num3 = 0;
            count_null = 0;
        }

        char tmp; // use to save selected number
        int state;
        private void btn_s1_Click(object sender, EventArgs e)
        {
            Game w;
            count_null = 0;
            if (btn_s1.Text == "Select")
            {
                state = 0;
                w = new Game(state, heap0);
                label9.Text = "You choose Stack1";
                btn_s1.Text = "Place";
                btn_s2.Text = "Place";
                btn_s3.Text = "Place";
                btn_s4.Text = "Place";

                if (w.cantake)
                {
                    btn_s1.Enabled = true;
                    tmp = values[0][heap0];
                    values[0] = values[0].Substring(0, heap0);
                    heap0--;
                }
                check_heap(state);
            }
            else
            {
                state = 1;
                w = new Game(state, heap0);
                label9.Text = "...";
                btn_s1.Text = "Select";
                btn_s2.Text = "Select";
                btn_s3.Text = "Select";
                btn_s4.Text = "Select";

                if (w.canplace)
                {
                    values[0] += tmp;
                    heap0++;
                }
                check_heap(state);
                print();
                if (heap0 == -1) count_null++;
                if (heap1 == -1) count_null++;
                if (heap2 == -1) count_null++;
                if (heap3 == -1) count_null++;
                if (count_null == 1)
                {
                    if (heap0 == -1)
                    {
                        win = w.win(values[1], values[2], values[3]);
                        check_win(win);
                    }
                    else if (heap1 == -1)
                    {
                        win = w.win(values[0], values[2], values[3]);
                        check_win(win);
                    }
                    else if (heap2 == -1)
                    {
                        win = w.win(values[0], values[1], values[3]);
                        check_win(win);
                    }
                    else if (heap3 == -1)
                    {
                        win = w.win(values[0], values[1], values[2]);
                        check_win(win);
                    }
                }
            }
        }

        private void btn_s2_Click(object sender, EventArgs e)
        {
            Game w;
            count_null = 0;
            if (btn_s2.Text == "Select")
            {
                state = 0;
                w = new Game(state, heap1);
                label9.Text = "You choose Stack2";
                btn_s1.Text = "Place";
                btn_s2.Text = "Place";
                btn_s3.Text = "Place";
                btn_s4.Text = "Place";

                if (w.cantake)
                {
                    tmp = values[1][heap1];
                    values[1] = values[1].Substring(0, heap1);
                    heap1--;
                }
                check_heap(state);
            }
            else
            {
                state = 1;
                w = new Game(state, heap1);
                label9.Text = "...";
                btn_s1.Text = "Select";
                btn_s2.Text = "Select";
                btn_s3.Text = "Select";
                btn_s4.Text = "Select";

                if (w.canplace)
                {
                    btn_s2.Enabled = true;
                    values[1] += tmp;
                    heap1++;
                }
                check_heap(state);
                print();
                if (heap0 == -1) count_null++;
                if (heap1 == -1) count_null++;
                if (heap2 == -1) count_null++;
                if (heap3 == -1) count_null++;
                if (count_null == 1)
                {
                    if (heap0 == -1)
                    {
                        win = w.win(values[1], values[2], values[3]);
                        check_win(win);
                    }
                    else if (heap1 == -1)
                    {
                        win = w.win(values[0], values[2], values[3]);
                        check_win(win);
                    }
                    else if (heap2 == -1)
                    {
                        win = w.win(values[0], values[1], values[3]);
                        check_win(win);
                    }
                    else if (heap3 == -1)
                    {
                        win = w.win(values[0], values[1], values[2]);
                        check_win(win);
                    }
                }
            }
        }

        private void btn_s3_Click(object sender, EventArgs e)
        {
            Game w;
            count_null = 0;
            if (btn_s3.Text == "Select")
            {
                state = 0;
                w = new Game(state, heap2);
                label9.Text = "You choose Stack3";
                btn_s1.Text = "Place";
                btn_s2.Text = "Place";
                btn_s3.Text = "Place";
                btn_s4.Text = "Place";

                if (w.cantake)
                {
                    tmp = values[2][heap2];
                    values[2] = values[2].Substring(0, heap2);
                    heap2--;
                }
                check_heap(state);
            }
            else
            {
                state = 1;
                w = new Game(state, heap2);
                label9.Text = "...";
                btn_s1.Text = "Select";
                btn_s2.Text = "Select";
                btn_s3.Text = "Select";
                btn_s4.Text = "Select";

                if (w.canplace)
                {
                    btn_s3.Enabled = true;
                    values[2] += tmp;
                    heap2++;
                }
                check_heap(state);
                print();
                if (heap0 == -1) count_null++;
                if (heap1 == -1) count_null++;
                if (heap2 == -1) count_null++;
                if (heap3 == -1) count_null++;
                if (count_null == 1)
                {
                    if (heap0 == -1)
                    {
                        win = w.win(values[1], values[2], values[3]);
                        check_win(win);
                    }
                    else if (heap1 == -1)
                    {
                        win = w.win(values[0], values[2], values[3]);
                        check_win(win);
                    }
                    else if (heap2 == -1)
                    {
                        win = w.win(values[0], values[1], values[3]);
                        check_win(win);
                    }
                    else if (heap3 == -1)
                    {
                        win = w.win(values[0], values[1], values[2]);
                        check_win(win);
                    }
                }
            }
        }

        private void btn_s4_Click(object sender, EventArgs e)
        {
            Game w;
            count_null = 0;
            if (btn_s4.Text == "Select")
            {
                state = 0;
                w = new Game(state, heap3);
                label9.Text = "You choose Stack4";
                btn_s1.Text = "Place";
                btn_s2.Text = "Place";
                btn_s3.Text = "Place";
                btn_s4.Text = "Place";

                if (w.cantake)
                {
                    tmp = values[3][heap3];
                    values[3] = values[3].Substring(0, heap3);
                    heap3--;
                }
                check_heap(state);
            }
            else
            {
                state = 1;
                w = new Game(state, heap3);
                label9.Text = "...";
                btn_s1.Text = "Select";
                btn_s2.Text = "Select";
                btn_s3.Text = "Select";
                btn_s4.Text = "Select";

                if (w.canplace)
                {
                    btn_s4.Enabled = true;
                    values[3] += tmp;
                    heap3++;
                }
                check_heap(state);
                print();
                if (heap0 == -1) count_null++;
                if (heap1 == -1) count_null++;
                if (heap2 == -1) count_null++;
                if (heap3 == -1) count_null++;
                if (count_null == 1)
                {
                    if (heap0 == -1)
                    {
                        win = w.win(values[1], values[2], values[3]);
                        check_win(win);
                    }
                    else if (heap1 == -1)
                    {
                        win = w.win(values[0], values[2], values[3]);
                        check_win(win);
                    }
                    else if (heap2 == -1)
                    {
                        win = w.win(values[0], values[1], values[3]);
                        check_win(win);
                    }
                    else if (heap3 == -1)
                    {
                        win = w.win(values[0], values[1], values[2]);
                        check_win(win);
                    }
                }
            }
        }

        // Print current data
        public void print()
        {
            lb_1.Text = "";
            lb_2.Text = "";
            lb_3.Text = "";
            lb_4.Text = "";

            // Stack_label 1
            for (int j = values[0].Length - 1; j >= 0; j--)
            {
                lb_1.Text += values[0][j];
                if (j != 0) lb_1.Text += '\n';
            }

            // Stack_label 2
            for (int j = values[1].Length - 1; j >= 0; j--)
            {
                lb_2.Text += values[1][j];
                if (j != 0) lb_2.Text += '\n';
            }

            // Stack_label 3
            for (int j = values[2].Length - 1; j >= 0; j--)
            {
                lb_3.Text += values[2][j];
                if (j != 0) lb_3.Text += '\n';
            }

            // Stack_label 4
            for (int j = values[3].Length - 1; j >= 0; j--)
            {
                lb_4.Text += values[3][j];
                if (j != 0) lb_4.Text += '\n';
            }
                
        }

        public void check_heap(int state)
        {
            if(state == 0)
            {
                if (heap0 == 3) btn_s1.Enabled = false;
                else btn_s1.Enabled = true;
                if (heap1 == 3) btn_s2.Enabled = false;
                else btn_s2.Enabled = true;
                if (heap2 == 3) btn_s3.Enabled = false;
                else btn_s3.Enabled = true;
                if (heap3 == 3) btn_s4.Enabled = false;
                else btn_s4.Enabled = true;
            }
            else if(state == 1)
            {
                if (heap0 == -1) btn_s1.Enabled = false;
                else btn_s1.Enabled = true;
                if (heap1 == -1) btn_s2.Enabled = false;
                else btn_s2.Enabled = true;
                if (heap2 == -1) btn_s3.Enabled = false;
                else btn_s3.Enabled = true;
                if (heap3 == -1) btn_s4.Enabled = false;
                else btn_s4.Enabled = true;
            }
            
        }

        public void check_win(bool check)
        {
            if (check)
            {
                btn_s1.Enabled = false;
                btn_s2.Enabled = false;
                btn_s3.Enabled = false;
                btn_s4.Enabled = false;
                label9.Text = "You Win!";
            }
        }
    }
}
