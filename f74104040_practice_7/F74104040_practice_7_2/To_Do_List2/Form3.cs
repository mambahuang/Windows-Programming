using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public bool cfm_can_f3 = false;
        public string check_matter = "";
        private void Form3_Load(object sender, EventArgs e)
        {
            tb_f3.Text = "";
        }

        private void btn_cfm_Click(object sender, EventArgs e)
        {
            if (tb_f3.Text == "")
                MessageBox.Show("Please input matters", "", MessageBoxButtons.OK);
            else
            {
                check_matter = tb_f3.Text;
                cfm_can_f3 = true;
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cfm_can_f3 = true;
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
