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

namespace To_Do_List2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool new_open = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.Text = "untitled*-To_Do_List";
            btn_cs.Visible = false;
            btn_cs.Enabled = false;
            new_open = true;
        }
        
        private void new_TSMI_Click(object sender, EventArgs e)
        {
            new_open = true;
            textBox1.Text = "";
            this.Text = "untitled*-To_Do_List";
        }

        private void open_TSMI_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            DialogResult r = openFileDialog1.ShowDialog();
            StreamReader sr;
            string[] f_name = openFileDialog1.FileName.Split('\\');
            new_open = true;

            if (r == DialogResult.OK)
            {
                this.Text = f_name[f_name.Length - 1] + "-To_Do_List";
                sr = new StreamReader(openFileDialog1.OpenFile());
                char sign;
                string matter;

                while((sign = (char)sr.Read()) == '+' || sign == '-')
                {
                    matter = sr.ReadLine();
                    if (sign == '+')
                    {
                        textBox1.AppendText(" [" + ((char)0x2713).ToString() + "] " + matter + Environment.NewLine);
                    }    
                    else if(sign == '-')
                    {
                        textBox1.AppendText(" [ ] " + matter + Environment.NewLine);
                    }
                        
                }
                sr.Close();
            }
        }

        private void save_TSMI_Click(object sender, EventArgs e)
        {
            char[] sp = { '\r', '\n' };
            string[] matter = textBox1.Text.Split(sp, StringSplitOptions.RemoveEmptyEntries);

            if (this.Text == "untitled*-To_Do_List")
            {
                saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
                DialogResult rlt = saveFileDialog1.ShowDialog();
                

                if (rlt == DialogResult.OK)
                {
                    FileInfo fInfo = new FileInfo(saveFileDialog1.FileName);
                    StreamWriter sw2 = fInfo.CreateText();
                    for (int i = 0; i < matter.Length; i++)
                    {
                        int idx = matter[i].IndexOf(']');

                        if (!matter[i].Contains(((char)0x2713).ToString()))
                        {
                            sw2.WriteLine('-' + matter[i].Substring(idx + 2));
                        }
                        else
                        {
                            sw2.WriteLine('+' + matter[i].Substring(idx + 2));
                        }

                    }
                    this.Text = fInfo.Name + "-To_Do_List";
                    sw2.Flush();
                    sw2.Close();
                }

            }
            else
            {
                FileInfo fInfo2;

                int pos = this.Text.IndexOf('.');
                if (this.Text.Contains(".txt"))
                {
                    fInfo2 = new FileInfo(this.Text.Substring(0, pos) + ".txt");
                    this.Text = this.Text.Substring(0, pos) + ".txt" + "-To_Do_List";
                }
                else
                {
                    fInfo2 = new FileInfo(this.Text.Substring(0, pos) + ".todo");
                    this.Text = this.Text.Substring(0, pos) + ".todo" + "-To_Do_List";
                }

                StreamWriter sw3 = fInfo2.CreateText();

                for (int i = 0; i < matter.Length; i++)
                {
                    int idx = matter[i].IndexOf(']');

                    if (!matter[i].Contains(((char)0x2713).ToString()))
                    {
                        sw3.WriteLine('-' + matter[i].Substring(idx + 2));
                    }
                    else
                    {
                        sw3.WriteLine('+' + matter[i].Substring(idx + 2));
                    }

                }
                sw3.Flush();
                sw3.Close();
            }
        }

        private void saveAs_TSMI_Click(object sender, EventArgs e)
        {
            char[] sp = { '\r', '\n' };
            string[] matter = textBox1.Text.Split(sp, StringSplitOptions.RemoveEmptyEntries);

            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            DialogResult rlt = saveFileDialog1.ShowDialog();
            

            if (rlt == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                StreamWriter w = fi.CreateText();
                for (int i = 0; i < matter.Length; i++)
                {
                    int idx = matter[i].IndexOf(']');

                    if (!matter[i].Contains(((char)0x2713).ToString()))
                    {
                        w.WriteLine('-' + matter[i].Substring(idx + 2));
                    }
                    else
                    {
                        w.WriteLine('+' + matter[i].Substring(idx + 2));
                    }

                }
                this.Text = fi.Name + "-To_Do_List";
                w.Flush();
                w.Close();
            }
            
        }

        private void close_TSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontSize_TSMI_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void showFinishedMatters_TSMI_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (string s in pre2)
            {
                textBox1.AppendText(s + Environment.NewLine);
            }
        }

        string[] pre2;
        private void hideFinishedMatters_TSMI_Click(object sender, EventArgs e)
        {
            char[] sp = { '\r', '\n' };
            pre2 = textBox1.Text.Split(sp, StringSplitOptions.RemoveEmptyEntries);

            textBox1.Text = "";
            foreach (string s in pre2)
            {
                if (!s.Contains(((char)0x2713).ToString()))
                {
                    textBox1.AppendText(s + Environment.NewLine);
                }

            }
        }

        string[] pre;
        private void find_TSMI_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();

            if (f3.cfm_can_f3 == true)
                this.Enabled = true;

            char[] sp = { '\r', '\n' };
            pre = textBox1.Text.Split(sp, StringSplitOptions.RemoveEmptyEntries);
            int[] item_idx3 = new int[pre.Length];
            for (int i = 0; i < item_idx3.Length; i++)
                item_idx3[i] = -1;

            int j = 0;
            foreach (string s in pre)
            {
                int idx = s.IndexOf("]");

                if (s.Substring(idx + 2).Contains(f3.check_matter))
                {
                    item_idx3[j] = Array.IndexOf(pre, s);
                    j++;
                }
                
            }

            textBox1.Text = "";
            for (int k=0; k<item_idx3.Length; k++)
            {
                if(item_idx3[k] != -1)
                {
                    textBox1.AppendText(pre[item_idx3[k]] + Environment.NewLine);
                    menuStrip1.Enabled = false;
                    btn_finished.Enabled = false;
                    btn_new.Enabled = false;
                    btn_finished.Visible = false;
                    btn_new.Visible = false;
                    btn_cs.Enabled = true;
                    btn_cs.Visible = true;
                }
                    
            }
            
        }

        private void newMatter_TSMI_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if (f2.cfm_can == true)
                this.Enabled = true;
            textBox1.AppendText(" [ ] " + f2.new_matter);
        }

        bool exist2 = false;
        int item_idx2;
        private void finishedMatters_TSMI_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form3 f3 = new Form3();
            f3.ShowDialog();

            if (f3.cfm_can_f3 == true)
                this.Enabled = true;

            char[] sp = { '\r', '\n' };
            string[]  matter = textBox1.Text.Split(sp, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in matter)
            {
                int idx = s.IndexOf("]");

                if (s.Substring(idx + 2) == f3.check_matter)
                {
                    item_idx2 = Array.IndexOf(matter, s);
                    exist2 = true;
                    break;
                }

            }

            int i = matter[item_idx2].IndexOf(']');
            if (exist2 == true)
                matter[item_idx2] = " [" + ((char)0x2713).ToString() + "] " + matter[item_idx2].Substring(i + 2);
            else
                f3.Close();

            textBox1.Text = "";
            foreach (string s in matter)
            {
                textBox1.AppendText(s + Environment.NewLine);
            }
        }

        bool exist3 = false;
        int item_idx3;
        private void deleteMatters_TSMI_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form3 f3 = new Form3();
            f3.ShowDialog();

            if (f3.cfm_can_f3 == true)
                this.Enabled = true;

            char[] sp = { '\r', '\n' };
            string[] matter = textBox1.Text.Split(sp, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in matter)
            {
                int idx = s.IndexOf("]");

                if (s.Substring(idx + 2) == f3.check_matter)
                {
                    item_idx3 = Array.IndexOf(matter, s);
                    exist3 = true;
                    break;
                }

            }

            if (exist3 == true)
            {
                textBox1.Text = "";
                for (int i=0; i<matter.Length; i++)
                {
                    if(i != item_idx3)
                        textBox1.AppendText(matter[i] + Environment.NewLine);
                }
            }    
            else
                f3.Close();

            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if (f2.cfm_can == true)
                this.Enabled = true;

            if (new_open)
                textBox1.AppendText(" [ ] " + f2.new_matter);
            else
                textBox1.AppendText(Environment.NewLine + " [ ] " + f2.new_matter);
        }

        bool exist = false;
        int item_idx;
        private void btn_finished_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form3 f3 = new Form3();
            f3.ShowDialog();

            if (f3.cfm_can_f3 == true)
                this.Enabled = true;

            char[] sp = { '\r', '\n' };
            string[] matter = textBox1.Text.Split(sp, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in matter)
            {
                int idx = s.IndexOf("]");

                if (s.Substring(idx + 2) == f3.check_matter)
                {
                    item_idx = Array.IndexOf(matter, s);
                    exist = true;
                    break;
                }
                    
            }

            int i = matter[item_idx].IndexOf(']');
            if (exist == true)
                matter[item_idx] = " [" + ((char)0x2713).ToString() + "] " + matter[item_idx].Substring(i + 2);
            else
                f3.Close();

            textBox1.Text = "";
            foreach (string s in matter)
            {
                textBox1.AppendText(s + Environment.NewLine);
            }
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
            btn_finished.Enabled = true;
            btn_new.Enabled = true;
            btn_finished.Visible = true;
            btn_new.Visible = true;
            btn_cs.Enabled = false;
            btn_cs.Visible = false;

            textBox1.Text = "";
            foreach(string s in pre)
            {
                textBox1.AppendText(s + Environment.NewLine);
            }
        }
    }
}
