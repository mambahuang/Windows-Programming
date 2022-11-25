namespace password_manager
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rsk = new System.Windows.Forms.Button();
            this.btn_sch = new System.Windows.Forms.Button();
            this.tb_sch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_A_D = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_psw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_rsk);
            this.panel1.Controls.Add(this.btn_sch);
            this.panel1.Controls.Add(this.tb_sch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 153);
            this.panel1.TabIndex = 0;
            // 
            // btn_rsk
            // 
            this.btn_rsk.Location = new System.Drawing.Point(19, 106);
            this.btn_rsk.Name = "btn_rsk";
            this.btn_rsk.Size = new System.Drawing.Size(786, 30);
            this.btn_rsk.TabIndex = 6;
            this.btn_rsk.Text = "Risk account";
            this.btn_rsk.UseVisualStyleBackColor = true;
            this.btn_rsk.Click += new System.EventHandler(this.btn_rsk_Click);
            // 
            // btn_sch
            // 
            this.btn_sch.Location = new System.Drawing.Point(730, 43);
            this.btn_sch.Name = "btn_sch";
            this.btn_sch.Size = new System.Drawing.Size(75, 35);
            this.btn_sch.TabIndex = 5;
            this.btn_sch.Text = "Search";
            this.btn_sch.UseVisualStyleBackColor = true;
            this.btn_sch.Click += new System.EventHandler(this.btn_sch_Click);
            // 
            // tb_sch
            // 
            this.tb_sch.Location = new System.Drawing.Point(104, 48);
            this.tb_sch.Name = "tb_sch";
            this.tb_sch.Size = new System.Drawing.Size(607, 29);
            this.tb_sch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search bar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search result : ";
            // 
            // btn_A_D
            // 
            this.btn_A_D.Location = new System.Drawing.Point(659, 175);
            this.btn_A_D.Name = "btn_A_D";
            this.btn_A_D.Size = new System.Drawing.Size(149, 36);
            this.btn_A_D.TabIndex = 8;
            this.btn_A_D.Text = "Add or Delete";
            this.btn_A_D.UseVisualStyleBackColor = true;
            this.btn_A_D.Click += new System.EventHandler(this.btn_A_D_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.tb_link);
            this.panel3.Controls.Add(this.tb_user);
            this.panel3.Controls.Add(this.tb_psw);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(0, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 393);
            this.panel3.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(455, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 30);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(553, 280);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 30);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(634, 23);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(171, 35);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(243, 118);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(385, 29);
            this.tb_link.TabIndex = 16;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(243, 170);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(385, 29);
            this.tb_user.TabIndex = 15;
            // 
            // tb_psw
            // 
            this.tb_psw.Location = new System.Drawing.Point(243, 221);
            this.tb_psw.Name = "tb_psw";
            this.tb_psw.Size = new System.Drawing.Size(385, 29);
            this.tb_psw.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "User :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Link :";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(154, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 37);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(19, 249);
            this.tb_1.Multiline = true;
            this.tb_1.Name = "tb_1";
            this.tb_1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_1.Size = new System.Drawing.Size(786, 277);
            this.tb_1.TabIndex = 10;
            this.tb_1.TextChanged += new System.EventHandler(this.tb_1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 547);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_A_D);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_rsk;
        private System.Windows.Forms.Button btn_sch;
        private System.Windows.Forms.TextBox tb_sch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_A_D;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_psw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_1;
    }
}

