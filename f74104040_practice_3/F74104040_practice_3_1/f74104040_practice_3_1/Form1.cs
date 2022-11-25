using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_manager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_1.Text = "";
            panel3.Visible = false;
        }

        private void btn_A_D_Click(object sender, EventArgs e)
        {
            tb_1.Visible = false;
            tb_1.Text = "";
            panel3.Visible = true;
            label2.Visible = false;
            tb_sch.Enabled = false;
            tb_sch.Text = "";
            btn_sch.Enabled = false;
            btn_rsk.Enabled = false;
            label8.Text = "I am status column";
            tb_link.Text = "";
            tb_user.Text = "";
            tb_psw.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            tb_1.Visible = true;
            panel3.Visible = false;
            label2.Visible = true;
            tb_sch.Enabled = true;
            btn_sch.Enabled = true;
            btn_rsk.Enabled = true;
        }

        List<Account> listaccount = new List<Account>();
        private void btn_add_Click(object sender, EventArgs e)
        {
            Account ac_add = new Account(tb_link.Text, tb_user.Text, tb_psw.Text);
            
            if (listaccount.Count == 0)
            {
                listaccount.Add(ac_add);
                label8.Text = "Add Complete";
                tb_link.Text = "";
                tb_user.Text = "";
                tb_psw.Text = "";
            }
            else
            {
                for (int i = 0; i < listaccount.Count; i++)
                {
                    if (listaccount[i].link == ac_add.link)
                    {
                        label8.Text = "Account already exists";
                        break;
                    }

                    if (i == listaccount.Count - 1)
                    {
                        listaccount.Add(ac_add);
                        label8.Text = "Add Complete";
                        tb_link.Text = "";
                        tb_user.Text = "";
                        tb_psw.Text = "";
                        break;
                    }
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Account ac_dlt = new Account(tb_link.Text, tb_user.Text, tb_psw.Text);

            if (listaccount.Count == 0)
            {
                label8.Text = "Account doesn't exists or passwords Wrong";
            }
            else
            {
                for (int i = 0; i < listaccount.Count; i++)
                {
                    if ((listaccount[i].link == tb_link.Text) && (listaccount[i].user == tb_user.Text) && (listaccount[i].pass == tb_psw.Text))
                    {
                        listaccount.Remove(ac_dlt);
                        label8.Text = "Delete Complete";
                        tb_link.Text = "";
                        tb_user.Text = "";
                        tb_psw.Text = "";
                        break;
                    }


                    if (i == listaccount.Count - 1)
                    {
                        label8.Text = "Account doesn't exists or passwords Wrong";
                        break;
                    }
                }
            }
            
        }

        private void btn_sch_Click(object sender, EventArgs e)
        {
            tb_1.Text = "";
            for(int i=0; i<listaccount.Count; i++)
            {
                if (listaccount[i].link.Contains(tb_sch.Text))
                {
                    tb_1.Text += "Link: " + listaccount[i].link + Environment.NewLine + "User: " + listaccount[i].user + Environment.NewLine + "Password: " + listaccount[i].pass + Environment.NewLine;
                    tb_1.Text += "=========================";
                    tb_1.Text += Environment.NewLine;
                }
                
            }
        }
        
        private void btn_rsk_Click(object sender, EventArgs e)
        {
            List<int> record = new List<int>();
            for (int i=0; i<listaccount.Count; i++)
            {
                for(int j=i+1; j<listaccount.Count; j++)
                {
                    if (listaccount[i].pass == listaccount[j].pass)
                    {
                        if(!record.Contains(i))
                            record.Add(i);
                        if(!record.Contains(j))
                            record.Add(j);
                    }
                }
            }
            tb_1.Text = "";
            for (int i=0; i<record.Count; i++)
            {
                if (i > 0) tb_1.Text += Environment.NewLine;

                tb_1.Text += "Link: " + listaccount[record[i]].link + Environment.NewLine + "User: " + listaccount[record[i]].user + Environment.NewLine + "Password: " + listaccount[record[i]].pass + Environment.NewLine;
                tb_1.Text += "=========================";
            }
        }

        private void tb_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
