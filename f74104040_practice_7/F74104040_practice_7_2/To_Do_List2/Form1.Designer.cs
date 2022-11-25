namespace To_Do_List2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.new_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.open_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.save_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.close_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.view_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSize_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showFinishedMatters_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.hideFinishedMatters_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.find_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newMatter_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedMatters_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMatters_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_finished = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_cs = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_TSMI,
            this.view_TSMI,
            this.edit_TSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 38);
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
            this.file_TSMI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_TSMI.Name = "file_TSMI";
            this.file_TSMI.Size = new System.Drawing.Size(58, 34);
            this.file_TSMI.Text = "File";
            // 
            // new_TSMI
            // 
            this.new_TSMI.Name = "new_TSMI";
            this.new_TSMI.Size = new System.Drawing.Size(252, 34);
            this.new_TSMI.Text = "New";
            this.new_TSMI.Click += new System.EventHandler(this.new_TSMI_Click);
            // 
            // open_TSMI
            // 
            this.open_TSMI.Name = "open_TSMI";
            this.open_TSMI.Size = new System.Drawing.Size(252, 34);
            this.open_TSMI.Text = "Open";
            this.open_TSMI.Click += new System.EventHandler(this.open_TSMI_Click);
            // 
            // save_TSMI
            // 
            this.save_TSMI.Name = "save_TSMI";
            this.save_TSMI.Size = new System.Drawing.Size(252, 34);
            this.save_TSMI.Text = "Save";
            this.save_TSMI.Click += new System.EventHandler(this.save_TSMI_Click);
            // 
            // saveAs_TSMI
            // 
            this.saveAs_TSMI.Name = "saveAs_TSMI";
            this.saveAs_TSMI.Size = new System.Drawing.Size(252, 34);
            this.saveAs_TSMI.Text = "Save as ...";
            this.saveAs_TSMI.Click += new System.EventHandler(this.saveAs_TSMI_Click);
            // 
            // close_TSMI
            // 
            this.close_TSMI.Name = "close_TSMI";
            this.close_TSMI.Size = new System.Drawing.Size(252, 34);
            this.close_TSMI.Text = "Close";
            this.close_TSMI.Click += new System.EventHandler(this.close_TSMI_Click);
            // 
            // view_TSMI
            // 
            this.view_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSize_TSMI,
            this.showFinishedMatters_TSMI,
            this.hideFinishedMatters_TSMI});
            this.view_TSMI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_TSMI.Name = "view_TSMI";
            this.view_TSMI.Size = new System.Drawing.Size(72, 34);
            this.view_TSMI.Text = "View";
            // 
            // fontSize_TSMI
            // 
            this.fontSize_TSMI.Name = "fontSize_TSMI";
            this.fontSize_TSMI.Size = new System.Drawing.Size(316, 34);
            this.fontSize_TSMI.Text = "Font Size";
            this.fontSize_TSMI.Click += new System.EventHandler(this.fontSize_TSMI_Click);
            // 
            // showFinishedMatters_TSMI
            // 
            this.showFinishedMatters_TSMI.Name = "showFinishedMatters_TSMI";
            this.showFinishedMatters_TSMI.Size = new System.Drawing.Size(316, 34);
            this.showFinishedMatters_TSMI.Text = "Show Finished Matters";
            this.showFinishedMatters_TSMI.Click += new System.EventHandler(this.showFinishedMatters_TSMI_Click);
            // 
            // hideFinishedMatters_TSMI
            // 
            this.hideFinishedMatters_TSMI.Name = "hideFinishedMatters_TSMI";
            this.hideFinishedMatters_TSMI.Size = new System.Drawing.Size(316, 34);
            this.hideFinishedMatters_TSMI.Text = "Hide Finished Matters";
            this.hideFinishedMatters_TSMI.Click += new System.EventHandler(this.hideFinishedMatters_TSMI_Click);
            // 
            // edit_TSMI
            // 
            this.edit_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.find_TSMI,
            this.newMatter_TSMI,
            this.finishedMatters_TSMI,
            this.deleteMatters_TSMI});
            this.edit_TSMI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_TSMI.Name = "edit_TSMI";
            this.edit_TSMI.Size = new System.Drawing.Size(61, 34);
            this.edit_TSMI.Text = "Edit";
            // 
            // find_TSMI
            // 
            this.find_TSMI.Name = "find_TSMI";
            this.find_TSMI.Size = new System.Drawing.Size(257, 34);
            this.find_TSMI.Text = "Find";
            this.find_TSMI.Click += new System.EventHandler(this.find_TSMI_Click);
            // 
            // newMatter_TSMI
            // 
            this.newMatter_TSMI.Name = "newMatter_TSMI";
            this.newMatter_TSMI.Size = new System.Drawing.Size(257, 34);
            this.newMatter_TSMI.Text = "New Matters";
            this.newMatter_TSMI.Click += new System.EventHandler(this.newMatter_TSMI_Click);
            // 
            // finishedMatters_TSMI
            // 
            this.finishedMatters_TSMI.Name = "finishedMatters_TSMI";
            this.finishedMatters_TSMI.Size = new System.Drawing.Size(257, 34);
            this.finishedMatters_TSMI.Text = "Finished Matters";
            this.finishedMatters_TSMI.Click += new System.EventHandler(this.finishedMatters_TSMI_Click);
            // 
            // deleteMatters_TSMI
            // 
            this.deleteMatters_TSMI.Name = "deleteMatters_TSMI";
            this.deleteMatters_TSMI.Size = new System.Drawing.Size(257, 34);
            this.deleteMatters_TSMI.Text = "Delete Matters";
            this.deleteMatters_TSMI.Click += new System.EventHandler(this.deleteMatters_TSMI_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(862, 605);
            this.textBox1.TabIndex = 1;
            // 
            // btn_finished
            // 
            this.btn_finished.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_finished.Location = new System.Drawing.Point(613, 647);
            this.btn_finished.Name = "btn_finished";
            this.btn_finished.Size = new System.Drawing.Size(126, 43);
            this.btn_finished.TabIndex = 2;
            this.btn_finished.Text = "Finished";
            this.btn_finished.UseVisualStyleBackColor = true;
            this.btn_finished.Click += new System.EventHandler(this.btn_finished_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_new.Location = new System.Drawing.Point(770, 647);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(104, 43);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_cs
            // 
            this.btn_cs.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cs.Location = new System.Drawing.Point(705, 647);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(169, 43);
            this.btn_cs.TabIndex = 4;
            this.btn_cs.Text = "Close Search";
            this.btn_cs.UseVisualStyleBackColor = true;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 702);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_finished);
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
        private System.Windows.Forms.ToolStripMenuItem new_TSMI;
        private System.Windows.Forms.ToolStripMenuItem open_TSMI;
        private System.Windows.Forms.ToolStripMenuItem save_TSMI;
        private System.Windows.Forms.ToolStripMenuItem saveAs_TSMI;
        private System.Windows.Forms.ToolStripMenuItem close_TSMI;
        private System.Windows.Forms.ToolStripMenuItem view_TSMI;
        private System.Windows.Forms.ToolStripMenuItem fontSize_TSMI;
        private System.Windows.Forms.ToolStripMenuItem showFinishedMatters_TSMI;
        private System.Windows.Forms.ToolStripMenuItem hideFinishedMatters_TSMI;
        private System.Windows.Forms.ToolStripMenuItem edit_TSMI;
        private System.Windows.Forms.ToolStripMenuItem find_TSMI;
        private System.Windows.Forms.ToolStripMenuItem newMatter_TSMI;
        private System.Windows.Forms.ToolStripMenuItem finishedMatters_TSMI;
        private System.Windows.Forms.ToolStripMenuItem deleteMatters_TSMI;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_finished;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_cs;
    }
}

