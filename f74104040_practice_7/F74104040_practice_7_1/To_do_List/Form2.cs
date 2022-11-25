using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_List
{
    public partial class Form2 : Form
    {
        public bool cfm_can = false;
        public string new_matter = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_f2.Text = "";
            
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (tb_f2.Text == "")
                MessageBox.Show("Please input matters", "", MessageBoxButtons.OK);
            else
            {
                new_matter = tb_f2.Text;
                cfm_can = true;
                this.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cfm_can = true;
            this.Close();
        }
    }
}
