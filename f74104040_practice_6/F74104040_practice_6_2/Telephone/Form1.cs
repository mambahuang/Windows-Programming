using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Telephone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] btn = new Button[15];
        int y = 0, x = 0;
        bool dial = false;
        bool dial2 = false; 
        int[] dtmf = { 697, 770, 852, 941 };
        int[] dtmf2 = { 1209, 1336, 1477 };

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i=0; i<btn.Length; i++)
            {
                btn[i] = new Button();
                btn[i].SetBounds(60 * x + 200, 60 * y + 150, 50, 50);
                tbp_telephone.Controls.Add(btn[i]);
                x++;
                if (i % 3 == 2)
                {
                    x = 0;  y++;
                }
                btn[i].Click += new EventHandler(btn_Click);

                if (i != 12 && i != 13 && i!= 14)
                {
                    btn[i].MouseUp += new MouseEventHandler(btn_MouseUP);
                    btn[i].MouseDown += new MouseEventHandler(btn_MouseDown);
                }
            }
            for(int i=1; i<10; i++)
            {
                btn[i - 1].Text = i.ToString();
                btn[i - 1].Font = new Font(btn[i - 1].Font.Name, 16, btn[i - 1].Font.Style);
            }

            btn[9].Text = "*";
            btn[10].Text = "0";
            btn[11].Text = "#";
            btn[9].Font = new Font(btn[9].Font.Name, 16, btn[9].Font.Style);
            btn[10].Font = new Font(btn[10].Font.Name, 16, btn[10].Font.Style);
            btn[11].Font = new Font(btn[11].Font.Name, 16, btn[11].Font.Style);
            btn[12].Image = imageList1.Images[0];
            btn[13].Image = imageList1.Images[1];
            btn[14].Image = imageList1.Images[2];
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button key = (Button)sender;
            if(label1.Text == "Telephone" && Array.IndexOf(btn, key) != 14)
                label1.Text = "";
            if (Array.IndexOf(btn, key) == 12) 
            {
                label1.Text = "";
            }
            if(Array.IndexOf(btn, key) == 13)
            {
                if(!dial)
                {
                    dial = true;
                    key.Image = imageList1.Images[3];
                    for (int i = 0; i < btn.Length; i++)
                        if (i != 13) btn[i].Enabled = false;
                    Show_number();
                }
                else
                {
                    dial = false;
                    key.Image = imageList1.Images[1];
                    for (int i = 0; i < btn.Length; i++)
                        btn[i].Enabled = true;
                    label1.Text = "Telephone";
                }
                
                
            }
            if(Array.IndexOf(btn, key) == 14)
            {
                string tmp = label1.Text;
                label1.Text = "";
                for(int i=0; i<tmp.Length - 1; i++)
                {
                    label1.Text += tmp[i];
                }
            }
            
        }

        private void btn_MouseUP(object sender, MouseEventArgs e)
        {
            WMP1.Ctlcontrols.stop();
            WMP2.Ctlcontrols.stop();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button key = (Button)sender;
            if (label1.Text == "Telephone" && Array.IndexOf(btn, key) != 14)
                label1.Text = "";
            if (int.TryParse(key.Text, out int result) || key.Text == "*" || key.Text == "#")
            {
                label1.Text += key.Text;
                switch (Array.IndexOf(btn, key))
                {
                    case 0:
                        WMP1.URL = dtmf[0].ToString() + ".wav";
                        WMP2.URL = dtmf2[0].ToString() + ".wav";
                        break;
                    case 1:
                        WMP1.URL = dtmf[0].ToString() + ".wav";
                        WMP2.URL = dtmf2[1].ToString() + ".wav";
                        break;
                    case 2:
                        WMP1.URL = dtmf[0].ToString() + ".wav";
                        WMP2.URL = dtmf2[2].ToString() + ".wav";
                        break;
                    case 3:
                        WMP1.URL = dtmf[1].ToString() + ".wav";
                        WMP2.URL = dtmf2[0].ToString() + ".wav";
                        break;
                    case 4:
                        WMP1.URL = dtmf[1].ToString() + ".wav";
                        WMP2.URL = dtmf2[1].ToString() + ".wav";
                        break;
                    case 5:
                        WMP1.URL = dtmf[1].ToString() + ".wav";
                        WMP2.URL = dtmf2[2].ToString() + ".wav";
                        break;
                    case 6:
                        WMP1.URL = dtmf[2].ToString() + ".wav";
                        WMP2.URL = dtmf2[0].ToString() + ".wav";
                        break;
                    case 7:
                        WMP1.URL = dtmf[2].ToString() + ".wav";
                        WMP2.URL = dtmf2[1].ToString() + ".wav";
                        break;
                    case 8:
                        WMP1.URL = dtmf[2].ToString() + ".wav";
                        WMP2.URL = dtmf2[2].ToString() + ".wav";
                        break;
                    case 9:
                        WMP1.URL = dtmf[3].ToString() + ".wav";
                        WMP2.URL = dtmf2[0].ToString() + ".wav";
                        break;
                    case 10:
                        WMP1.URL = dtmf[3].ToString() + ".wav";
                        WMP2.URL = dtmf2[1].ToString() + ".wav";
                        break;
                    case 11:
                        WMP1.URL = dtmf[3].ToString() + ".wav";
                        WMP2.URL = dtmf2[2].ToString() + ".wav";
                        break;
                    default:
                        break;


                }
            }
            WMP1.Ctlcontrols.play();
            WMP2.Ctlcontrols.play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key_d = e.KeyValue;
            soundFile(key_d, e);
            if (label1.Text == "Telephone" && (key_d >= 48 && key_d <= 57))
                label1.Text = "";
            if (tabControl1.SelectedIndex != 1)
            {
                if ((e.Modifiers == Keys.Shift && e.KeyCode == Keys.D3) || (e.Modifiers == Keys.Shift && e.KeyCode == Keys.D8) || (key_d >= 48 && key_d <= 57))
                {
                    if (tabControl1.SelectedIndex != 1)
                    {
                        WMP1.Ctlcontrols.play();
                        WMP2.Ctlcontrols.play();
                    }
                }

                if (e.KeyCode == Keys.Enter)
                {
                    if (!dial)
                    {
                        dial = true;
                        btn[13].Image = imageList1.Images[3];
                        for (int i = 0; i < btn.Length; i++)
                            if (i != 13) btn[i].Enabled = false;
                        Show_number();
                    }
                    else
                    {
                        dial = false;
                        btn[13].Image = imageList1.Images[1];
                        for (int i = 0; i < btn.Length; i++)
                            btn[i].Enabled = true;
                        label1.Text = "Telephone";
                    }
                }
            }
            else
            {
                WMP1.Ctlcontrols.stop();
                WMP2.Ctlcontrols.stop();
            }
            
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int key_d = e.KeyValue;
            if (tabControl1.SelectedIndex != 1)
            {
                if (e.KeyCode == Keys.Back)
                {
                    string tmp = label1.Text;
                    label1.Text = "";
                    for (int i = 0; i < tmp.Length - 1; i++)
                    {
                        label1.Text += tmp[i];
                    }
                }
                if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.D3)
                {
                    label1.Text += '#';
                }
                else if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.D8)
                {
                    label1.Text += '*';
                }
                else if (key_d >= 48 && key_d <= 57)
                {
                    label1.Text += (char)key_d;
                }
            }
            WMP1.Ctlcontrols.stop();
            WMP2.Ctlcontrols.stop();
        }

        private void soundFile(int key, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.D8)
            {
                WMP1.URL = dtmf[3].ToString() + ".wav";
                WMP2.URL = dtmf2[0].ToString() + ".wav";
                return;
            }
            if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.D3)
            {
                WMP1.URL = dtmf[3].ToString() + ".wav";
                WMP2.URL = dtmf2[2].ToString() + ".wav";
                return;
            }

            switch (key)
            {
                case 49:
                    WMP1.URL = dtmf[0].ToString() + ".wav";
                    WMP2.URL = dtmf2[0].ToString() + ".wav";
                    break;
                case 50:
                    WMP1.URL = dtmf[0].ToString() + ".wav";
                    WMP2.URL = dtmf2[1].ToString() + ".wav";
                    break;
                case 51:
                    WMP1.URL = dtmf[0].ToString() + ".wav";
                    WMP2.URL = dtmf2[2].ToString() + ".wav";
                    break;
                case 52:
                    WMP1.URL = dtmf[1].ToString() + ".wav";
                    WMP2.URL = dtmf2[0].ToString() + ".wav";
                    break;
                case 53:
                    WMP1.URL = dtmf[1].ToString() + ".wav";
                    WMP2.URL = dtmf2[1].ToString() + ".wav";
                    break;
                case 54:
                    WMP1.URL = dtmf[1].ToString() + ".wav";
                    WMP2.URL = dtmf2[2].ToString() + ".wav";
                    break;
                case 55:
                    WMP1.URL = dtmf[2].ToString() + ".wav";
                    WMP2.URL = dtmf2[0].ToString() + ".wav";
                    break;
                case 56:
                    WMP1.URL = dtmf[2].ToString() + ".wav";
                    WMP2.URL = dtmf2[1].ToString() + ".wav";
                    break;
                case 57:
                    WMP1.URL = dtmf[2].ToString() + ".wav";
                    WMP2.URL = dtmf2[2].ToString() + ".wav";
                    break;
                case 48:
                    WMP1.URL = dtmf[3].ToString() + ".wav";
                    WMP2.URL = dtmf2[1].ToString() + ".wav";
                    break;
                default:
                    break;

            }
        }

        string[] dir;
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(tb_path.Text == "")
            {
                MessageBox.Show("Empty String", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                dir = tb_path.Text.Split('\\'); // get directory's name

                Check_dir(dir[0] + '\\' + dir[1]);
                label1.Text = "Telephone";
                tb_path.Text = "";
                tb_number.Text = "";
            }
            catch
            {
                MessageBox.Show("Invalid Input", "", MessageBoxButtons.OK);
            }
            
            
        }

        int i = 1;
        private void Check_dir(string path)
        {
            
            if (i == dir.Length - 1)
            {
                FileInfo finfo = new FileInfo(@path);
                StreamWriter sw = finfo.CreateText();
                //StreamWriter sw = finfo.AppendText();
                sw.WriteLine(tb_number.Text);
                sw.Flush();
                sw.Close();
                MessageBox.Show("Done\n" + finfo.FullName);
                return;
            }
            
            if (!Directory.Exists(@path))
            {
                MessageBox.Show("Directory Not Found", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                i++;
                Check_dir(path + '\\' + dir[i]);
                
            }

        }

        private void Show_number()
        {
            tb_number.Text += label1.Text;
            tb_number.Text += Environment.NewLine;
        }
    }
}

/*
         1209    1336    1447
    697   1       2       3 

    770   4       5       6

    852   7       8       9

    941   *       0       #

 */


