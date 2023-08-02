namespace scansText
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
            this.lblScannedText = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.lb_valid1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScannedText
            // 
            this.lblScannedText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScannedText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScannedText.Location = new System.Drawing.Point(112, 116);
            this.lblScannedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScannedText.Name = "lblScannedText";
            this.lblScannedText.Size = new System.Drawing.Size(504, 32);
            this.lblScannedText.TabIndex = 0;
            // 
            // btn_Register
            // 
            this.btn_Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Register.BackColor = System.Drawing.Color.Teal;
            this.btn_Register.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Register.Location = new System.Drawing.Point(390, 353);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(108, 39);
            this.btn_Register.TabIndex = 2;
            this.btn_Register.Text = "ĐĂNG KÝ";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(212, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "HỦY BỎ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Name";
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_StudentName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentName.Location = new System.Drawing.Point(277, 193);
            this.txt_StudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(279, 30);
            this.txt_StudentName.TabIndex = 5;
            this.txt_StudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PriceAddorUpdate_KeyPress);
            // 
            // lb_valid1
            // 
            this.lb_valid1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_valid1.AutoSize = true;
            this.lb_valid1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valid1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_valid1.Location = new System.Drawing.Point(273, 229);
            this.lb_valid1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_valid1.Name = "lb_valid1";
            this.lb_valid1.Size = new System.Drawing.Size(183, 17);
            this.lb_valid1.TabIndex = 6;
            this.lb_valid1.Text = "Vui lòng điền tên Sinh Viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(87, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(566, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "ĐĂNG KÝ THÀNH VIÊN LỚP HỌC THẦY PHƯƠNG";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(723, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_valid1);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lblScannedText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScannedText;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Label lb_valid1;
        private System.Windows.Forms.Label label3;
    }
}