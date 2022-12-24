namespace PjGara
{
    partial class uc_billing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_BDelete = new System.Windows.Forms.Button();
            this.btn_BUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_bill = new System.Windows.Forms.DataGridView();
            this.txt_BUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_BType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_BName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BGrandTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_BQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BDelete
            // 
            this.btn_BDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_BDelete.BackColor = System.Drawing.Color.White;
            this.btn_BDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BDelete.FlatAppearance.BorderSize = 0;
            this.btn_BDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_BDelete.Location = new System.Drawing.Point(581, 153);
            this.btn_BDelete.Name = "btn_BDelete";
            this.btn_BDelete.Size = new System.Drawing.Size(135, 38);
            this.btn_BDelete.TabIndex = 111;
            this.btn_BDelete.Text = "Xóa";
            this.btn_BDelete.UseVisualStyleBackColor = false;
            // 
            // btn_BUpdate
            // 
            this.btn_BUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_BUpdate.BackColor = System.Drawing.Color.White;
            this.btn_BUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BUpdate.FlatAppearance.BorderSize = 0;
            this.btn_BUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_BUpdate.Location = new System.Drawing.Point(328, 153);
            this.btn_BUpdate.Name = "btn_BUpdate";
            this.btn_BUpdate.Size = new System.Drawing.Size(135, 38);
            this.btn_BUpdate.TabIndex = 110;
            this.btn_BUpdate.Text = "Thêm";
            this.btn_BUpdate.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(32, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 109;
            this.label5.Text = "Bill :";
            // 
            // dgv_bill
            // 
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill.Location = new System.Drawing.Point(36, 258);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.Size = new System.Drawing.Size(808, 347);
            this.dgv_bill.TabIndex = 108;
            // 
            // txt_BUnitPrice
            // 
            this.txt_BUnitPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BUnitPrice.Location = new System.Drawing.Point(662, 73);
            this.txt_BUnitPrice.Multiline = true;
            this.txt_BUnitPrice.Name = "txt_BUnitPrice";
            this.txt_BUnitPrice.Size = new System.Drawing.Size(135, 31);
            this.txt_BUnitPrice.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(658, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 102;
            this.label3.Text = "Đơn Giá :";
            // 
            // cb_BType
            // 
            this.cb_BType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BType.FormattingEnabled = true;
            this.cb_BType.Items.AddRange(new object[] {
            "Tư Nhân ",
            "Doanh Nghiệp",
            "Khách lẻ"});
            this.cb_BType.Location = new System.Drawing.Point(234, 75);
            this.cb_BType.MaxLength = 32767;
            this.cb_BType.Name = "cb_BType";
            this.cb_BType.Size = new System.Drawing.Size(135, 29);
            this.cb_BType.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(241, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 100;
            this.label6.Text = "Loại Bill :";
            // 
            // txt_BName
            // 
            this.txt_BName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BName.Location = new System.Drawing.Point(454, 73);
            this.txt_BName.Multiline = true;
            this.txt_BName.Name = "txt_BName";
            this.txt_BName.Size = new System.Drawing.Size(150, 31);
            this.txt_BName.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(450, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 98;
            this.label2.Text = "Tên Người Nhận :";
            // 
            // txt_BCode
            // 
            this.txt_BCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BCode.Location = new System.Drawing.Point(36, 74);
            this.txt_BCode.Multiline = true;
            this.txt_BCode.Name = "txt_BCode";
            this.txt_BCode.Size = new System.Drawing.Size(135, 31);
            this.txt_BCode.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "Mã Bill :";
            // 
            // txt_BGrandTotal
            // 
            this.txt_BGrandTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BGrandTotal.Location = new System.Drawing.Point(709, 639);
            this.txt_BGrandTotal.Multiline = true;
            this.txt_BGrandTotal.Name = "txt_BGrandTotal";
            this.txt_BGrandTotal.Size = new System.Drawing.Size(135, 31);
            this.txt_BGrandTotal.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(596, 649);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 112;
            this.label4.Text = "Tổng tiền :";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(36, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 38);
            this.button1.TabIndex = 114;
            this.button1.Text = "Lưu Bill";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_BQuantity
            // 
            this.txt_BQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BQuantity.Location = new System.Drawing.Point(36, 159);
            this.txt_BQuantity.Multiline = true;
            this.txt_BQuantity.Name = "txt_BQuantity";
            this.txt_BQuantity.Size = new System.Drawing.Size(135, 31);
            this.txt_BQuantity.TabIndex = 116;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(32, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 115;
            this.label7.Text = "Số Lượng : ";
            // 
            // uc_billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.txt_BQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_BGrandTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_BDelete);
            this.Controls.Add(this.btn_BUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_bill);
            this.Controls.Add(this.txt_BUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_BType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_BName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_billing";
            this.Size = new System.Drawing.Size(879, 686);
            this.Load += new System.EventHandler(this.uc_billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BDelete;
        private System.Windows.Forms.Button btn_BUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_bill;
        private System.Windows.Forms.TextBox txt_BUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_BType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_BName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BGrandTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_BQuantity;
        private System.Windows.Forms.Label label7;
    }
}
