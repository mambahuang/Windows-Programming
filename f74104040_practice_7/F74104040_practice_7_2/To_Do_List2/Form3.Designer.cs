namespace To_Do_List2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_f3 = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_cfm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of Matter : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_f3
            // 
            this.tb_f3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_f3.Location = new System.Drawing.Point(199, 50);
            this.tb_f3.Name = "tb_f3";
            this.tb_f3.Size = new System.Drawing.Size(624, 36);
            this.tb_f3.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("PMingLiU", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel.Location = new System.Drawing.Point(604, 147);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_cfm
            // 
            this.btn_cfm.Font = new System.Drawing.Font("PMingLiU", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cfm.Location = new System.Drawing.Point(726, 147);
            this.btn_cfm.Name = "btn_cfm";
            this.btn_cfm.Size = new System.Drawing.Size(97, 38);
            this.btn_cfm.TabIndex = 4;
            this.btn_cfm.Text = "Confirm";
            this.btn_cfm.UseVisualStyleBackColor = true;
            this.btn_cfm.Click += new System.EventHandler(this.btn_cfm_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 220);
            this.Controls.Add(this.btn_cfm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_f3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_f3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_cfm;
    }
}