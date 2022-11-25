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

namespace To_do_List
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
            new_open = true;
            textBox1.Text = "";
            this.Text = "untitled*-To_Do_List";
        }

        private void new_TSMI_Click(object sender, EventArgs e) // sub item of file_tsmi
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
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            
        }

        private void save_TSMI_Click(object sender, EventArgs e)
        {

            if (this.Text == "untitled*-To_Do_List")
            {
                saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
                DialogResult rlt = saveFileDialog1.ShowDialog();
                
                if(rlt == DialogResult.OK)
                {
                    FileInfo fInfo = new FileInfo(saveFileDialog1.FileName);
                    StreamWriter sw2 = fInfo.CreateText();
                    sw2.WriteLine(textBox1.Text);
                    this.Text = fInfo.Name + "-To_Do_List";
                    sw2.Flush();
                    sw2.Close();
                }
                
            }
            else
            {
                string[] s = this.Text.Split('-');
                saveFileDialog1.Title = s[0];

                FileInfo fInfo2 = new FileInfo(s[0]);
                StreamWriter sw3 = fInfo2.CreateText();

                sw3.WriteLine(textBox1.Text);
                this.Text = fInfo2.Name + "-To_Do_List";
                sw3.Flush();
                sw3.Close();


            }
        }

        private void saveAs_TSMI_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            DialogResult rlt = saveFileDialog1.ShowDialog();
            

            if (rlt == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                StreamWriter w = fi.CreateText();
                w.WriteLine(textBox1.Text);
                this.Text = file_TSMI.Name + "-To_Do_List";
                w.Flush();
                w.Close();
            }

            
        }

        private void fontSize_TSMI_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if(f2.cfm_can == true)
                this.Enabled = true;

            if (new_open)
                textBox1.AppendText(f2.new_matter);
            else
                textBox1.AppendText(Environment.NewLine + f2.new_matter);
        }

        private void close_TSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
