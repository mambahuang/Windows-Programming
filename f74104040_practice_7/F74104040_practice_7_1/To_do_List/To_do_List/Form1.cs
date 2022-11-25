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

        string filePath = "";
        StreamWriter sw;
        FileInfo fInfo;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void new_TSMI_Click(object sender, EventArgs e) // sub item of file_tsmi
        {
            textBox1.Text = "";
            filePath = Path.GetFullPath(openFileDialog1.FileName);
            fInfo = new FileInfo(filePath);
            StreamWriter sw = fInfo.CreateText();
            sw = fInfo.CreateText();
        }

        private void fontSize_TSMI_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void open_TSMI_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.ShowDialog();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if(f2.cfm_can == true)
                this.Enabled = true;
            textBox1.AppendText(f2.new_matter + Environment.NewLine);
        }

        private void save_TSMI_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog1.ShowDialog();
            filePath = Path.GetFullPath(saveFileDialog1.FileName);
            fInfo = new FileInfo(filePath);
            
            if (saveFileDialog1.CheckFileExists)
                sw = fInfo.AppendText();
            else
                sw = fInfo.CreateText();
            
        }
    }
}
