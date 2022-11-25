namespace To_do_List
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.view_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.new_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.open_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.save_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.close_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSize_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_TSMI,
            this.view_TSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_TSMI
            // 
            this.file_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_TSMI,
            this.open_TSMI,
            this.save_TSMI,
            this.saveAs_TSMI,
            this.close_TSMI});
            this.file_TSMI.Name = "file_TSMI";
            this.file_TSMI.Size = new System.Drawing.Size(51, 28);
            this.file_TSMI.Text = "File";
            // 
            // view_TSMI
            // 
            this.view_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSize_TSMI});
            this.view_TSMI.Name = "view_TSMI";
            this.view_TSMI.Size = new System.Drawing.Size(63, 28);
            this.view_TSMI.Text = "View";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(937, 526);
            this.textBox1.TabIndex = 1;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_new.Location = new System.Drawing.Point(802, 566);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(135, 42);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // new_TSMI
            // 
            this.new_TSMI.Name = "new_TSMI";
            this.new_TSMI.Size = new System.Drawing.Size(252, 30);
            this.new_TSMI.Text = "New";
            this.new_TSMI.Click += new System.EventHandler(this.new_TSMI_Click);
            // 
            // open_TSMI
            // 
            this.open_TSMI.Name = "open_TSMI";
            this.open_TSMI.Size = new System.Drawing.Size(252, 30);
            this.open_TSMI.Text = "Open";
            this.open_TSMI.Click += new System.EventHandler(this.open_TSMI_Click);
            // 
            // save_TSMI
            // 
            this.save_TSMI.Name = "save_TSMI";
            this.save_TSMI.Size = new System.Drawing.Size(252, 30);
            this.save_TSMI.Text = "Save";
            this.save_TSMI.Click += new System.EventHandler(this.save_TSMI_Click);
            // 
            // saveAs_TSMI
            // 
            this.saveAs_TSMI.Name = "saveAs_TSMI";
            this.saveAs_TSMI.Size = new System.Drawing.Size(252, 30);
            this.saveAs_TSMI.Text = "Save as ...";
            // 
            // close_TSMI
            // 
            this.close_TSMI.Name = "close_TSMI";
            this.close_TSMI.Size = new System.Drawing.Size(252, 30);
            this.close_TSMI.Text = "Close";
            // 
            // fontSize_TSMI
            // 
            this.fontSize_TSMI.Name = "fontSize_TSMI";
            this.fontSize_TSMI.Size = new System.Drawing.Size(252, 30);
            this.fontSize_TSMI.Text = "Font Size";
            this.fontSize_TSMI.Click += new System.EventHandler(this.fontSize_TSMI_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 610);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_TSMI;
        private System.Windows.Forms.ToolStripMenuItem view_TSMI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ToolStripMenuItem new_TSMI;
        private System.Windows.Forms.ToolStripMenuItem open_TSMI;
        private System.Windows.Forms.ToolStripMenuItem save_TSMI;
        private System.Windows.Forms.ToolStripMenuItem saveAs_TSMI;
        private System.Windows.Forms.ToolStripMenuItem close_TSMI;
        private System.Windows.Forms.ToolStripMenuItem fontSize_TSMI;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

