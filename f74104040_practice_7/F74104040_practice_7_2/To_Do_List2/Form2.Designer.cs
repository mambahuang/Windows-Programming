namespace To_Do_List2
{
    partial class Form2
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
            this.tb_f2 = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_cfm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Matter : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_f2
            // 
            this.tb_f2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_f2.Location = new System.Drawing.Point(213, 65);
            this.tb_f2.Name = "tb_f2";
            this.tb_f2.Size = new System.Drawing.Size(624, 36);
            this.tb_f2.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("PMingLiU", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel.Location = new System.Drawing.Point(606, 161);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 38);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_cfm
            // 
            this.btn_cfm.Font = new System.Drawing.Font("PMingLiU", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cfm.Location = new System.Drawing.Point(727, 161);
            this.btn_cfm.Name = "btn_cfm";
            this.btn_cfm.Size = new System.Drawing.Size(97, 38);
            this.btn_cfm.TabIndex = 3;
            this.btn_cfm.Text = "Confirm";
            this.btn_cfm.UseVisualStyleBackColor = true;
            this.btn_cfm.Click += new System.EventHandler(this.btn_cfm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 232);
            this.Controls.Add(this.btn_cfm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_f2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_f2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_cfm;
    }
}