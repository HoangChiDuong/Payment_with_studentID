namespace scansText
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.txt_IdStd = new System.Windows.Forms.TextBox();
            this.btn_Hitsory = new System.Windows.Forms.Button();
            this.btn_Cleardata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lb_valid1 = new System.Windows.Forms.Label();
            this.txt_studentNameShow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox.Location = new System.Drawing.Point(72, 115);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 359);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btn_Pay
            // 
            this.btn_Pay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Pay.BackColor = System.Drawing.Color.Teal;
            this.btn_Pay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Pay.Location = new System.Drawing.Point(68, 574);
            this.btn_Pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(160, 55);
            this.btn_Pay.TabIndex = 1;
            this.btn_Pay.Text = "THAM GIA";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // txt_IdStd
            // 
            this.txt_IdStd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_IdStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_IdStd.Enabled = false;
            this.txt_IdStd.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdStd.Location = new System.Drawing.Point(68, 499);
            this.txt_IdStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IdStd.Name = "txt_IdStd";
            this.txt_IdStd.Size = new System.Drawing.Size(243, 46);
            this.txt_IdStd.TabIndex = 2;
            // 
            // btn_Hitsory
            // 
            this.btn_Hitsory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Hitsory.BackColor = System.Drawing.Color.Green;
            this.btn_Hitsory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hitsory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Hitsory.Location = new System.Drawing.Point(255, 572);
            this.btn_Hitsory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Hitsory.Name = "btn_Hitsory";
            this.btn_Hitsory.Size = new System.Drawing.Size(163, 58);
            this.btn_Hitsory.TabIndex = 3;
            this.btn_Hitsory.Text = "SAO KÊ";
            this.btn_Hitsory.UseVisualStyleBackColor = false;
            this.btn_Hitsory.Click += new System.EventHandler(this.btn_Hitsory_Click);
            // 
            // btn_Cleardata
            // 
            this.btn_Cleardata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cleardata.BackColor = System.Drawing.Color.Maroon;
            this.btn_Cleardata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cleardata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cleardata.Location = new System.Drawing.Point(626, 654);
            this.btn_Cleardata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cleardata.Name = "btn_Cleardata";
            this.btn_Cleardata.Size = new System.Drawing.Size(141, 38);
            this.btn_Cleardata.TabIndex = 6;
            this.btn_Cleardata.Text = "ĐẶT LẠI";
            this.btn_Cleardata.UseVisualStyleBackColor = false;
            this.btn_Cleardata.Click += new System.EventHandler(this.btn_Cleardata_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(221, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUÉT THẺ SINH VIÊN CỦA BẠN";
            // 
            // btn_Register
            // 
            this.btn_Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Register.BackColor = System.Drawing.Color.Navy;
            this.btn_Register.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Register.Location = new System.Drawing.Point(68, 575);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(160, 55);
            this.btn_Register.TabIndex = 9;
            this.btn_Register.Text = "ĐĂNG KÝ";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // lb_valid1
            // 
            this.lb_valid1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_valid1.AutoSize = true;
            this.lb_valid1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valid1.ForeColor = System.Drawing.Color.Navy;
            this.lb_valid1.Location = new System.Drawing.Point(337, 513);
            this.lb_valid1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_valid1.Name = "lb_valid1";
            this.lb_valid1.Size = new System.Drawing.Size(290, 26);
            this.lb_valid1.TabIndex = 10;
            this.lb_valid1.Text = "Mã tài khoản chưa tồn tại !";
            // 
            // txt_studentNameShow
            // 
            this.txt_studentNameShow.AutoSize = true;
            this.txt_studentNameShow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentNameShow.ForeColor = System.Drawing.Color.Black;
            this.txt_studentNameShow.Location = new System.Drawing.Point(284, 513);
            this.txt_studentNameShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_studentNameShow.Name = "txt_studentNameShow";
            this.txt_studentNameShow.Size = new System.Drawing.Size(0, 26);
            this.txt_studentNameShow.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(175, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "LỚP HỌC THẦY PHƯƠNG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 705);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_studentNameShow);
            this.Controls.Add(this.lb_valid1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cleardata);
            this.Controls.Add(this.btn_Hitsory);
            this.Controls.Add(this.txt_IdStd);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.TextBox txt_IdStd;
        private System.Windows.Forms.Button btn_Hitsory;
        private System.Windows.Forms.Button btn_Cleardata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lb_valid1;
        private System.Windows.Forms.Label txt_studentNameShow;
        private System.Windows.Forms.Label label3;
    }
}

