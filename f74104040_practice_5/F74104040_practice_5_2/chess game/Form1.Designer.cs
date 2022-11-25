namespace chess_game
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
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Warrior1 = new System.Windows.Forms.Button();
            this.btn_Mage1 = new System.Windows.Forms.Button();
            this.btn_Ranger1 = new System.Windows.Forms.Button();
            this.btn_Ranger2 = new System.Windows.Forms.Button();
            this.btn_Mage2 = new System.Windows.Forms.Button();
            this.btn_Warrior2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lb_WMR1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_WMR2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_finish1 = new System.Windows.Forms.Button();
            this.btn_standby1 = new System.Windows.Forms.Button();
            this.btn_move1 = new System.Windows.Forms.Button();
            this.btn_skill1 = new System.Windows.Forms.Button();
            this.btn_atk1 = new System.Windows.Forms.Button();
            this.lb_move_r1 = new System.Windows.Forms.Label();
            this.lb_atk_r1 = new System.Windows.Forms.Label();
            this.lb_atk1 = new System.Windows.Forms.Label();
            this.lb_mp1 = new System.Windows.Forms.Label();
            this.lb_hp1 = new System.Windows.Forms.Label();
            this.lb_G_WMR1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_finish2 = new System.Windows.Forms.Button();
            this.lb_move_r2 = new System.Windows.Forms.Label();
            this.btn_standby2 = new System.Windows.Forms.Button();
            this.lb_G_WMR2 = new System.Windows.Forms.Label();
            this.btn_move2 = new System.Windows.Forms.Button();
            this.lb_atk_r2 = new System.Windows.Forms.Label();
            this.btn_skill2 = new System.Windows.Forms.Button();
            this.btn_atk2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_atk2 = new System.Windows.Forms.Label();
            this.lb_hp2 = new System.Windows.Forms.Label();
            this.lb_mp2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(479, 295);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(215, 110);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preparation Stage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_time
            // 
            this.lb_time.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(532, 75);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(94, 33);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "label2";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Warrior1
            // 
            this.btn_Warrior1.Location = new System.Drawing.Point(138, 237);
            this.btn_Warrior1.Name = "btn_Warrior1";
            this.btn_Warrior1.Size = new System.Drawing.Size(100, 40);
            this.btn_Warrior1.TabIndex = 3;
            this.btn_Warrior1.Text = "Warrior : 1";
            this.btn_Warrior1.UseVisualStyleBackColor = true;
            this.btn_Warrior1.Click += new System.EventHandler(this.btn_Warrior1_Click);
            // 
            // btn_Mage1
            // 
            this.btn_Mage1.Location = new System.Drawing.Point(138, 322);
            this.btn_Mage1.Name = "btn_Mage1";
            this.btn_Mage1.Size = new System.Drawing.Size(100, 40);
            this.btn_Mage1.TabIndex = 4;
            this.btn_Mage1.Text = "Mage : 1";
            this.btn_Mage1.UseVisualStyleBackColor = true;
            this.btn_Mage1.Click += new System.EventHandler(this.btn_Mage1_Click);
            // 
            // btn_Ranger1
            // 
            this.btn_Ranger1.Location = new System.Drawing.Point(138, 411);
            this.btn_Ranger1.Name = "btn_Ranger1";
            this.btn_Ranger1.Size = new System.Drawing.Size(100, 40);
            this.btn_Ranger1.TabIndex = 5;
            this.btn_Ranger1.Text = "Ranger : 1";
            this.btn_Ranger1.UseVisualStyleBackColor = true;
            this.btn_Ranger1.Click += new System.EventHandler(this.btn_Ranger1_Click);
            // 
            // btn_Ranger2
            // 
            this.btn_Ranger2.Location = new System.Drawing.Point(926, 411);
            this.btn_Ranger2.Name = "btn_Ranger2";
            this.btn_Ranger2.Size = new System.Drawing.Size(100, 40);
            this.btn_Ranger2.TabIndex = 8;
            this.btn_Ranger2.Text = "Ranger : 1";
            this.btn_Ranger2.UseVisualStyleBackColor = true;
            this.btn_Ranger2.Click += new System.EventHandler(this.btn_Ranger2_Click);
            // 
            // btn_Mage2
            // 
            this.btn_Mage2.Location = new System.Drawing.Point(926, 322);
            this.btn_Mage2.Name = "btn_Mage2";
            this.btn_Mage2.Size = new System.Drawing.Size(100, 40);
            this.btn_Mage2.TabIndex = 7;
            this.btn_Mage2.Text = "Mage : 1";
            this.btn_Mage2.UseVisualStyleBackColor = true;
            this.btn_Mage2.Click += new System.EventHandler(this.btn_Mage2_Click);
            // 
            // btn_Warrior2
            // 
            this.btn_Warrior2.Location = new System.Drawing.Point(926, 237);
            this.btn_Warrior2.Name = "btn_Warrior2";
            this.btn_Warrior2.Size = new System.Drawing.Size(100, 40);
            this.btn_Warrior2.TabIndex = 6;
            this.btn_Warrior2.Text = "Warrior : 1";
            this.btn_Warrior2.UseVisualStyleBackColor = true;
            this.btn_Warrior2.Click += new System.EventHandler(this.btn_Warrior2_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(160, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 47);
            this.label2.TabIndex = 9;
            this.label2.Text = "P1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_WMR1
            // 
            this.lb_WMR1.AutoSize = true;
            this.lb_WMR1.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_WMR1.Location = new System.Drawing.Point(151, 144);
            this.lb_WMR1.Name = "lb_WMR1";
            this.lb_WMR1.Size = new System.Drawing.Size(87, 32);
            this.lb_WMR1.TabIndex = 10;
            this.lb_WMR1.Text = "label3";
            this.lb_WMR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(954, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 47);
            this.label4.TabIndex = 11;
            this.label4.Text = "P2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_WMR2
            // 
            this.lb_WMR2.AutoSize = true;
            this.lb_WMR2.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_WMR2.Location = new System.Drawing.Point(939, 144);
            this.lb_WMR2.Name = "lb_WMR2";
            this.lb_WMR2.Size = new System.Drawing.Size(87, 32);
            this.lb_WMR2.TabIndex = 12;
            this.lb_WMR2.Text = "label5";
            this.lb_WMR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_finish1);
            this.panel1.Controls.Add(this.btn_standby1);
            this.panel1.Controls.Add(this.btn_move1);
            this.panel1.Controls.Add(this.btn_skill1);
            this.panel1.Controls.Add(this.btn_atk1);
            this.panel1.Controls.Add(this.lb_move_r1);
            this.panel1.Controls.Add(this.lb_atk_r1);
            this.panel1.Controls.Add(this.lb_atk1);
            this.panel1.Controls.Add(this.lb_mp1);
            this.panel1.Controls.Add(this.lb_hp1);
            this.panel1.Controls.Add(this.lb_G_WMR1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 694);
            this.panel1.TabIndex = 13;
            // 
            // btn_finish1
            // 
            this.btn_finish1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_finish1.Location = new System.Drawing.Point(76, 504);
            this.btn_finish1.Name = "btn_finish1";
            this.btn_finish1.Size = new System.Drawing.Size(157, 51);
            this.btn_finish1.TabIndex = 11;
            this.btn_finish1.Text = "Finish";
            this.btn_finish1.UseVisualStyleBackColor = true;
            this.btn_finish1.Click += new System.EventHandler(this.btn_finish1_Click);
            // 
            // btn_standby1
            // 
            this.btn_standby1.Location = new System.Drawing.Point(163, 437);
            this.btn_standby1.Name = "btn_standby1";
            this.btn_standby1.Size = new System.Drawing.Size(70, 39);
            this.btn_standby1.TabIndex = 10;
            this.btn_standby1.Text = "Standby";
            this.btn_standby1.UseVisualStyleBackColor = true;
            this.btn_standby1.Click += new System.EventHandler(this.btn_standby1_Click);
            // 
            // btn_move1
            // 
            this.btn_move1.Location = new System.Drawing.Point(163, 378);
            this.btn_move1.Name = "btn_move1";
            this.btn_move1.Size = new System.Drawing.Size(70, 39);
            this.btn_move1.TabIndex = 9;
            this.btn_move1.Text = "Move";
            this.btn_move1.UseVisualStyleBackColor = true;
            this.btn_move1.Click += new System.EventHandler(this.btn_move1_Click);
            // 
            // btn_skill1
            // 
            this.btn_skill1.Location = new System.Drawing.Point(76, 437);
            this.btn_skill1.Name = "btn_skill1";
            this.btn_skill1.Size = new System.Drawing.Size(70, 39);
            this.btn_skill1.TabIndex = 8;
            this.btn_skill1.Text = "Skill";
            this.btn_skill1.UseVisualStyleBackColor = true;
            this.btn_skill1.Click += new System.EventHandler(this.btn_skill1_Click);
            // 
            // btn_atk1
            // 
            this.btn_atk1.Location = new System.Drawing.Point(76, 378);
            this.btn_atk1.Name = "btn_atk1";
            this.btn_atk1.Size = new System.Drawing.Size(70, 39);
            this.btn_atk1.TabIndex = 7;
            this.btn_atk1.Text = "Attack";
            this.btn_atk1.UseVisualStyleBackColor = true;
            this.btn_atk1.Click += new System.EventHandler(this.btn_atk1_Click);
            // 
            // lb_move_r1
            // 
            this.lb_move_r1.AutoSize = true;
            this.lb_move_r1.Location = new System.Drawing.Point(111, 321);
            this.lb_move_r1.Name = "lb_move_r1";
            this.lb_move_r1.Size = new System.Drawing.Size(58, 18);
            this.lb_move_r1.TabIndex = 6;
            this.lb_move_r1.Text = "label10";
            // 
            // lb_atk_r1
            // 
            this.lb_atk_r1.AutoSize = true;
            this.lb_atk_r1.Location = new System.Drawing.Point(111, 294);
            this.lb_atk_r1.Name = "lb_atk_r1";
            this.lb_atk_r1.Size = new System.Drawing.Size(50, 18);
            this.lb_atk_r1.TabIndex = 5;
            this.lb_atk_r1.Text = "label9";
            // 
            // lb_atk1
            // 
            this.lb_atk1.AutoSize = true;
            this.lb_atk1.Location = new System.Drawing.Point(111, 267);
            this.lb_atk1.Name = "lb_atk1";
            this.lb_atk1.Size = new System.Drawing.Size(50, 18);
            this.lb_atk1.TabIndex = 4;
            this.lb_atk1.Text = "label8";
            this.lb_atk1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_mp1
            // 
            this.lb_mp1.AutoSize = true;
            this.lb_mp1.Location = new System.Drawing.Point(111, 236);
            this.lb_mp1.Name = "lb_mp1";
            this.lb_mp1.Size = new System.Drawing.Size(50, 18);
            this.lb_mp1.TabIndex = 3;
            this.lb_mp1.Text = "label7";
            this.lb_mp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_hp1
            // 
            this.lb_hp1.AutoSize = true;
            this.lb_hp1.Location = new System.Drawing.Point(111, 207);
            this.lb_hp1.Name = "lb_hp1";
            this.lb_hp1.Size = new System.Drawing.Size(50, 18);
            this.lb_hp1.TabIndex = 2;
            this.lb_hp1.Text = "label6";
            this.lb_hp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_G_WMR1
            // 
            this.lb_G_WMR1.AutoSize = true;
            this.lb_G_WMR1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_G_WMR1.Location = new System.Drawing.Point(108, 119);
            this.lb_G_WMR1.Name = "lb_G_WMR1";
            this.lb_G_WMR1.Size = new System.Drawing.Size(97, 36);
            this.lb_G_WMR1.TabIndex = 1;
            this.lb_G_WMR1.Text = "label5";
            this.lb_G_WMR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(111, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "P1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_finish2);
            this.panel2.Controls.Add(this.lb_move_r2);
            this.panel2.Controls.Add(this.btn_standby2);
            this.panel2.Controls.Add(this.lb_G_WMR2);
            this.panel2.Controls.Add(this.btn_move2);
            this.panel2.Controls.Add(this.lb_atk_r2);
            this.panel2.Controls.Add(this.btn_skill2);
            this.panel2.Controls.Add(this.btn_atk2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lb_atk2);
            this.panel2.Controls.Add(this.lb_hp2);
            this.panel2.Controls.Add(this.lb_mp2);
            this.panel2.Location = new System.Drawing.Point(891, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 694);
            this.panel2.TabIndex = 14;
            // 
            // btn_finish2
            // 
            this.btn_finish2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_finish2.Location = new System.Drawing.Point(80, 506);
            this.btn_finish2.Name = "btn_finish2";
            this.btn_finish2.Size = new System.Drawing.Size(157, 51);
            this.btn_finish2.TabIndex = 16;
            this.btn_finish2.Text = "Finish";
            this.btn_finish2.UseVisualStyleBackColor = true;
            this.btn_finish2.Click += new System.EventHandler(this.btn_finish2_Click);
            // 
            // lb_move_r2
            // 
            this.lb_move_r2.AutoSize = true;
            this.lb_move_r2.Location = new System.Drawing.Point(114, 323);
            this.lb_move_r2.Name = "lb_move_r2";
            this.lb_move_r2.Size = new System.Drawing.Size(58, 18);
            this.lb_move_r2.TabIndex = 13;
            this.lb_move_r2.Text = "label11";
            // 
            // btn_standby2
            // 
            this.btn_standby2.Location = new System.Drawing.Point(167, 439);
            this.btn_standby2.Name = "btn_standby2";
            this.btn_standby2.Size = new System.Drawing.Size(70, 39);
            this.btn_standby2.TabIndex = 15;
            this.btn_standby2.Text = "Standby";
            this.btn_standby2.UseVisualStyleBackColor = true;
            this.btn_standby2.Click += new System.EventHandler(this.btn_standby2_Click);
            // 
            // lb_G_WMR2
            // 
            this.lb_G_WMR2.AutoSize = true;
            this.lb_G_WMR2.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_G_WMR2.Location = new System.Drawing.Point(111, 121);
            this.lb_G_WMR2.Name = "lb_G_WMR2";
            this.lb_G_WMR2.Size = new System.Drawing.Size(114, 36);
            this.lb_G_WMR2.TabIndex = 8;
            this.lb_G_WMR2.Text = "label16";
            // 
            // btn_move2
            // 
            this.btn_move2.Location = new System.Drawing.Point(167, 380);
            this.btn_move2.Name = "btn_move2";
            this.btn_move2.Size = new System.Drawing.Size(70, 39);
            this.btn_move2.TabIndex = 14;
            this.btn_move2.Text = "Move";
            this.btn_move2.UseVisualStyleBackColor = true;
            this.btn_move2.Click += new System.EventHandler(this.btn_move2_Click);
            // 
            // lb_atk_r2
            // 
            this.lb_atk_r2.AutoSize = true;
            this.lb_atk_r2.Location = new System.Drawing.Point(114, 296);
            this.lb_atk_r2.Name = "lb_atk_r2";
            this.lb_atk_r2.Size = new System.Drawing.Size(58, 18);
            this.lb_atk_r2.TabIndex = 12;
            this.lb_atk_r2.Text = "label12";
            // 
            // btn_skill2
            // 
            this.btn_skill2.Location = new System.Drawing.Point(80, 439);
            this.btn_skill2.Name = "btn_skill2";
            this.btn_skill2.Size = new System.Drawing.Size(70, 39);
            this.btn_skill2.TabIndex = 13;
            this.btn_skill2.Text = "Skill";
            this.btn_skill2.UseVisualStyleBackColor = true;
            this.btn_skill2.Click += new System.EventHandler(this.btn_skill2_Click);
            // 
            // btn_atk2
            // 
            this.btn_atk2.Location = new System.Drawing.Point(80, 380);
            this.btn_atk2.Name = "btn_atk2";
            this.btn_atk2.Size = new System.Drawing.Size(70, 39);
            this.btn_atk2.TabIndex = 12;
            this.btn_atk2.Text = "Attack";
            this.btn_atk2.UseVisualStyleBackColor = true;
            this.btn_atk2.Click += new System.EventHandler(this.btn_atk2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(114, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 32);
            this.label17.TabIndex = 7;
            this.label17.Text = "P2";
            // 
            // lb_atk2
            // 
            this.lb_atk2.AutoSize = true;
            this.lb_atk2.Location = new System.Drawing.Point(114, 269);
            this.lb_atk2.Name = "lb_atk2";
            this.lb_atk2.Size = new System.Drawing.Size(58, 18);
            this.lb_atk2.TabIndex = 11;
            this.lb_atk2.Text = "label13";
            // 
            // lb_hp2
            // 
            this.lb_hp2.AutoSize = true;
            this.lb_hp2.Location = new System.Drawing.Point(114, 209);
            this.lb_hp2.Name = "lb_hp2";
            this.lb_hp2.Size = new System.Drawing.Size(58, 18);
            this.lb_hp2.TabIndex = 9;
            this.lb_hp2.Text = "label15";
            // 
            // lb_mp2
            // 
            this.lb_mp2.AutoSize = true;
            this.lb_mp2.Location = new System.Drawing.Point(114, 238);
            this.lb_mp2.Name = "lb_mp2";
            this.lb_mp2.Size = new System.Drawing.Size(58, 18);
            this.lb_mp2.TabIndex = 10;
            this.lb_mp2.Text = "label14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_WMR2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_WMR1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Ranger2);
            this.Controls.Add(this.btn_Mage2);
            this.Controls.Add(this.btn_Warrior2);
            this.Controls.Add(this.btn_Ranger1);
            this.Controls.Add(this.btn_Mage1);
            this.Controls.Add(this.btn_Warrior1);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Warrior1;
        private System.Windows.Forms.Button btn_Mage1;
        private System.Windows.Forms.Button btn_Ranger1;
        private System.Windows.Forms.Button btn_Ranger2;
        private System.Windows.Forms.Button btn_Mage2;
        private System.Windows.Forms.Button btn_Warrior2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_WMR1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_WMR2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_atk1;
        private System.Windows.Forms.Label lb_move_r1;
        private System.Windows.Forms.Label lb_atk_r1;
        private System.Windows.Forms.Label lb_atk1;
        private System.Windows.Forms.Label lb_mp1;
        private System.Windows.Forms.Label lb_hp1;
        private System.Windows.Forms.Label lb_G_WMR1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_move_r2;
        private System.Windows.Forms.Label lb_G_WMR2;
        private System.Windows.Forms.Label lb_atk_r2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_atk2;
        private System.Windows.Forms.Label lb_hp2;
        private System.Windows.Forms.Label lb_mp2;
        private System.Windows.Forms.Button btn_finish1;
        private System.Windows.Forms.Button btn_standby1;
        private System.Windows.Forms.Button btn_move1;
        private System.Windows.Forms.Button btn_skill1;
        private System.Windows.Forms.Button btn_finish2;
        private System.Windows.Forms.Button btn_standby2;
        private System.Windows.Forms.Button btn_move2;
        private System.Windows.Forms.Button btn_skill2;
        private System.Windows.Forms.Button btn_atk2;
    }
}

