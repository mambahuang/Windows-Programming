namespace Telephone
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_telephone = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.WMP2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tbp_log = new System.Windows.Forms.TabPage();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tbp_telephone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            this.tbp_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_telephone);
            this.tabControl1.Controls.Add(this.tbp_log);
            this.tabControl1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 834);
            this.tabControl1.TabIndex = 1;
            // 
            // tbp_telephone
            // 
            this.tbp_telephone.Controls.Add(this.label1);
            this.tbp_telephone.Controls.Add(this.WMP2);
            this.tbp_telephone.Controls.Add(this.WMP1);
            this.tbp_telephone.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbp_telephone.Location = new System.Drawing.Point(4, 34);
            this.tbp_telephone.Name = "tbp_telephone";
            this.tbp_telephone.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_telephone.Size = new System.Drawing.Size(915, 796);
            this.tbp_telephone.TabIndex = 0;
            this.tbp_telephone.Text = "Telephone";
            this.tbp_telephone.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 84);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telephone";
            // 
            // WMP2
            // 
            this.WMP2.Enabled = true;
            this.WMP2.Location = new System.Drawing.Point(799, 683);
            this.WMP2.Name = "WMP2";
            this.WMP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP2.OcxState")));
            this.WMP2.Size = new System.Drawing.Size(120, 113);
            this.WMP2.TabIndex = 2;
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(0, 683);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(120, 117);
            this.WMP1.TabIndex = 1;
            // 
            // tbp_log
            // 
            this.tbp_log.Controls.Add(this.tb_number);
            this.tbp_log.Controls.Add(this.btn_save);
            this.tbp_log.Controls.Add(this.tb_path);
            this.tbp_log.Controls.Add(this.label2);
            this.tbp_log.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbp_log.Location = new System.Drawing.Point(4, 34);
            this.tbp_log.Name = "tbp_log";
            this.tbp_log.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_log.Size = new System.Drawing.Size(915, 796);
            this.tbp_log.TabIndex = 1;
            this.tbp_log.Text = "Log";
            this.tbp_log.UseVisualStyleBackColor = true;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(39, 120);
            this.tb_number.Multiline = true;
            this.tb_number.Name = "tb_number";
            this.tb_number.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_number.Size = new System.Drawing.Size(845, 645);
            this.tb_number.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(783, 40);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 36);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(102, 40);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(675, 36);
            this.tb_path.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Save";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "clear.png");
            this.imageList1.Images.SetKeyName(1, "smartphone.png");
            this.imageList1.Images.SetKeyName(2, "left-arrow.png");
            this.imageList1.Images.SetKeyName(3, "telephone.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 834);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tbp_telephone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            this.tbp_log.ResumeLayout(false);
            this.tbp_log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_telephone;
        private System.Windows.Forms.TabPage tbp_log;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Button btn_save;
        private AxWMPLib.AxWindowsMediaPlayer WMP2;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private System.Windows.Forms.Label label1;
    }
}

