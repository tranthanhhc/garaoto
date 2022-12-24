namespace PjGara
{
    partial class frm_addcar
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
            this.btn_CAdd = new System.Windows.Forms.Button();
            this.cb_CType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CTrademark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_COwner = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CAdd
            // 
            this.btn_CAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CAdd.BackColor = System.Drawing.Color.White;
            this.btn_CAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CAdd.FlatAppearance.BorderSize = 0;
            this.btn_CAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CAdd.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_CAdd.Location = new System.Drawing.Point(330, 335);
            this.btn_CAdd.Name = "btn_CAdd";
            this.btn_CAdd.Size = new System.Drawing.Size(135, 38);
            this.btn_CAdd.TabIndex = 93;
            this.btn_CAdd.Text = "Thêm";
            this.btn_CAdd.UseVisualStyleBackColor = false;
            // 
            // cb_CType
            // 
            this.cb_CType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CType.FormattingEnabled = true;
            this.cb_CType.Items.AddRange(new object[] {
            "Xe sang ( trên 1 tỷ)",
            "Xe trung (trên 500 triệu )",
            "Xe bình dân ( dưới 500 triệu)"});
            this.cb_CType.Location = new System.Drawing.Point(43, 166);
            this.cb_CType.MaxLength = 32767;
            this.cb_CType.Name = "cb_CType";
            this.cb_CType.Size = new System.Drawing.Size(288, 29);
            this.cb_CType.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(28, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 91;
            this.label6.Text = "Loại xe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(335, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 31);
            this.label5.TabIndex = 90;
            this.label5.Text = "Thêm Xe";
            // 
            // txt_CCode
            // 
            this.txt_CCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CCode.Location = new System.Drawing.Point(45, 86);
            this.txt_CCode.Multiline = true;
            this.txt_CCode.Name = "txt_CCode";
            this.txt_CCode.Size = new System.Drawing.Size(286, 31);
            this.txt_CCode.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(28, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 88;
            this.label3.Text = "Mã Xe :";
            // 
            // txt_CTrademark
            // 
            this.txt_CTrademark.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CTrademark.Location = new System.Drawing.Point(447, 166);
            this.txt_CTrademark.Multiline = true;
            this.txt_CTrademark.Name = "txt_CTrademark";
            this.txt_CTrademark.Size = new System.Drawing.Size(286, 31);
            this.txt_CTrademark.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(430, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 86;
            this.label2.Text = "Thương hiệu :";
            // 
            // txt_CName
            // 
            this.txt_CName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CName.Location = new System.Drawing.Point(445, 86);
            this.txt_CName.Multiline = true;
            this.txt_CName.Name = "txt_CName";
            this.txt_CName.Size = new System.Drawing.Size(288, 31);
            this.txt_CName.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(430, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 84;
            this.label1.Text = "Tên Xe :";
            // 
            // txt_CDay
            // 
            this.txt_CDay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CDay.Location = new System.Drawing.Point(43, 263);
            this.txt_CDay.Multiline = true;
            this.txt_CDay.Name = "txt_CDay";
            this.txt_CDay.Size = new System.Drawing.Size(286, 31);
            this.txt_CDay.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(26, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 96;
            this.label4.Text = "Ngày nhận :";
            // 
            // txt_COwner
            // 
            this.txt_COwner.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_COwner.Location = new System.Drawing.Point(447, 263);
            this.txt_COwner.Multiline = true;
            this.txt_COwner.Name = "txt_COwner";
            this.txt_COwner.Size = new System.Drawing.Size(286, 31);
            this.txt_COwner.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(430, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 98;
            this.label7.Text = "Tên Chủ Xe :";
            // 
            // frm_addcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(790, 398);
            this.Controls.Add(this.txt_COwner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CAdd);
            this.Controls.Add(this.cb_CType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CTrademark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_addcar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm xe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CAdd;
        private System.Windows.Forms.ComboBox cb_CType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CTrademark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_COwner;
        private System.Windows.Forms.Label label7;
    }
}