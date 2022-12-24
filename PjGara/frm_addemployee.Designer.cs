namespace PjGara
{
    partial class frm_addemployee
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
            this.btn_SAdd = new System.Windows.Forms.Button();
            this.cb_SGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SAdd
            // 
            this.btn_SAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SAdd.BackColor = System.Drawing.Color.White;
            this.btn_SAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SAdd.FlatAppearance.BorderSize = 0;
            this.btn_SAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAdd.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_SAdd.Location = new System.Drawing.Point(392, 235);
            this.btn_SAdd.Name = "btn_SAdd";
            this.btn_SAdd.Size = new System.Drawing.Size(135, 38);
            this.btn_SAdd.TabIndex = 67;
            this.btn_SAdd.Text = "Thêm";
            this.btn_SAdd.UseVisualStyleBackColor = false;
            // 
            // cb_SGender
            // 
            this.cb_SGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SGender.FormattingEnabled = true;
            this.cb_SGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_SGender.Location = new System.Drawing.Point(27, 298);
            this.cb_SGender.MaxLength = 32767;
            this.cb_SGender.Name = "cb_SGender";
            this.cb_SGender.Size = new System.Drawing.Size(288, 29);
            this.cb_SGender.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Giới Tính Nhân Viên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(146, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 31);
            this.label5.TabIndex = 63;
            this.label5.Text = "Thêm Nhân Viên";
            // 
            // txt_SCode
            // 
            this.txt_SCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SCode.Location = new System.Drawing.Point(29, 466);
            this.txt_SCode.Multiline = true;
            this.txt_SCode.Name = "txt_SCode";
            this.txt_SCode.Size = new System.Drawing.Size(286, 31);
            this.txt_SCode.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(12, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Mã Nhân Viên :";
            // 
            // txt_SAddress
            // 
            this.txt_SAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SAddress.Location = new System.Drawing.Point(29, 376);
            this.txt_SAddress.Multiline = true;
            this.txt_SAddress.Name = "txt_SAddress";
            this.txt_SAddress.Size = new System.Drawing.Size(286, 31);
            this.txt_SAddress.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Địa Chỉ Nhân Viên :";
            // 
            // txt_SAge
            // 
            this.txt_SAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SAge.Location = new System.Drawing.Point(29, 192);
            this.txt_SAge.Multiline = true;
            this.txt_SAge.Name = "txt_SAge";
            this.txt_SAge.Size = new System.Drawing.Size(286, 31);
            this.txt_SAge.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tuổi Nhân Viên :";
            // 
            // txt_SName
            // 
            this.txt_SName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SName.Location = new System.Drawing.Point(27, 92);
            this.txt_SName.Multiline = true;
            this.txt_SName.Name = "txt_SName";
            this.txt_SName.Size = new System.Drawing.Size(288, 31);
            this.txt_SName.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tên Nhân Viên :";
            // 
            // frm_addemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(548, 530);
            this.Controls.Add(this.btn_SAdd);
            this.Controls.Add(this.cb_SGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_addemployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.frm_addemployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SAdd;
        private System.Windows.Forms.ComboBox cb_SGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SName;
        private System.Windows.Forms.Label label1;
    }
}