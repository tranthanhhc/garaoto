namespace PjGara
{
    partial class frm_adddepot
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
            this.btn_PAdd = new System.Windows.Forms.Button();
            this.cb_PType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_PAdd
            // 
            this.btn_PAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_PAdd.BackColor = System.Drawing.Color.White;
            this.btn_PAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PAdd.FlatAppearance.BorderSize = 0;
            this.btn_PAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PAdd.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_PAdd.Location = new System.Drawing.Point(307, 222);
            this.btn_PAdd.Name = "btn_PAdd";
            this.btn_PAdd.Size = new System.Drawing.Size(135, 38);
            this.btn_PAdd.TabIndex = 81;
            this.btn_PAdd.Text = "Thêm";
            this.btn_PAdd.UseVisualStyleBackColor = false;
            // 
            // cb_PType
            // 
            this.cb_PType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PType.FormattingEnabled = true;
            this.cb_PType.Items.AddRange(new object[] {
            "Nhập Khẩu ",
            "Hàng nội địa "});
            this.cb_PType.Location = new System.Drawing.Point(41, 157);
            this.cb_PType.MaxLength = 32767;
            this.cb_PType.Name = "cb_PType";
            this.cb_PType.Size = new System.Drawing.Size(288, 29);
            this.cb_PType.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(26, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "Kiểu hàng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(288, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 31);
            this.label5.TabIndex = 78;
            this.label5.Text = "Thêm Hàng";
            // 
            // txt_PCode
            // 
            this.txt_PCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PCode.Location = new System.Drawing.Point(43, 78);
            this.txt_PCode.Multiline = true;
            this.txt_PCode.Name = "txt_PCode";
            this.txt_PCode.Size = new System.Drawing.Size(286, 31);
            this.txt_PCode.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(26, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 74;
            this.label3.Text = "Mã Hàng :";
            // 
            // txt_PQuantity
            // 
            this.txt_PQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PQuantity.Location = new System.Drawing.Point(445, 157);
            this.txt_PQuantity.Multiline = true;
            this.txt_PQuantity.Name = "txt_PQuantity";
            this.txt_PQuantity.Size = new System.Drawing.Size(286, 31);
            this.txt_PQuantity.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(428, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Số lượng :";
            // 
            // txt_PName
            // 
            this.txt_PName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PName.Location = new System.Drawing.Point(443, 78);
            this.txt_PName.Multiline = true;
            this.txt_PName.Name = "txt_PName";
            this.txt_PName.Size = new System.Drawing.Size(288, 31);
            this.txt_PName.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(428, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tên Hàng :";
            // 
            // frm_adddepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(775, 272);
            this.Controls.Add(this.btn_PAdd);
            this.Controls.Add(this.cb_PType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_adddepot";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm mặt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_PAdd;
        private System.Windows.Forms.ComboBox cb_PType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PName;
        private System.Windows.Forms.Label label1;
    }
}