namespace To_do_List
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matter Name : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_f2
            // 
            this.tb_f2.Location = new System.Drawing.Point(185, 59);
            this.tb_f2.Name = "tb_f2";
            this.tb_f2.Size = new System.Drawing.Size(579, 29);
            this.tb_f2.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel.Location = new System.Drawing.Point(549, 134);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 45);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Confirm.Location = new System.Drawing.Point(660, 134);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(104, 45);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 192);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_f2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "New To Do List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_f2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Confirm;
    }
}