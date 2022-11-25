namespace CardGame2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_restart = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_conti = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usr_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Flip Card Game";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("PMingLiU", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 868);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_restart);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btn_conti);
            this.tabPage1.Controls.Add(this.btn_start);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.usr_name);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 832);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(780, 335);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(102, 40);
            this.btn_restart.TabIndex = 7;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(783, 643);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Leave";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_conti
            // 
            this.btn_conti.Location = new System.Drawing.Point(780, 225);
            this.btn_conti.Name = "btn_conti";
            this.btn_conti.Size = new System.Drawing.Size(102, 40);
            this.btn_conti.TabIndex = 5;
            this.btn_conti.Text = "Continue";
            this.btn_conti.UseVisualStyleBackColor = true;
            this.btn_conti.Click += new System.EventHandler(this.btn_conti_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(780, 125);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(102, 40);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(239, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "User name : ";
            // 
            // usr_name
            // 
            this.usr_name.Location = new System.Drawing.Point(373, 23);
            this.usr_name.Name = "usr_name";
            this.usr_name.Size = new System.Drawing.Size(183, 34);
            this.usr_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(105, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 832);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.jpg");
            this.imageList1.Images.SetKeyName(1, "02.jpg");
            this.imageList1.Images.SetKeyName(2, "03.jpg");
            this.imageList1.Images.SetKeyName(3, "04.jpg");
            this.imageList1.Images.SetKeyName(4, "05.jpg");
            this.imageList1.Images.SetKeyName(5, "06.jpg");
            this.imageList1.Images.SetKeyName(6, "07.jpg");
            this.imageList1.Images.SetKeyName(7, "08.jpg");
            this.imageList1.Images.SetKeyName(8, "01.jpg");
            this.imageList1.Images.SetKeyName(9, "02.jpg");
            this.imageList1.Images.SetKeyName(10, "03.jpg");
            this.imageList1.Images.SetKeyName(11, "04.jpg");
            this.imageList1.Images.SetKeyName(12, "05.jpg");
            this.imageList1.Images.SetKeyName(13, "06.jpg");
            this.imageList1.Images.SetKeyName(14, "07.jpg");
            this.imageList1.Images.SetKeyName(15, "08.jpg");
            this.imageList1.Images.SetKeyName(16, "card.jpg");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-4, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(954, 836);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_conti;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usr_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

