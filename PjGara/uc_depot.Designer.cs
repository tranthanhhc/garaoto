namespace PjGara
{
    partial class uc_depot
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_depot = new System.Windows.Forms.DataGridView();
            this.btn_PAdd = new System.Windows.Forms.Button();
            this.btn_PSearch = new System.Windows.Forms.Button();
            this.txt_PQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_PType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_PUpdate = new System.Windows.Forms.Button();
            this.btn_PDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_depot)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(32, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 90;
            this.label5.Text = "Kho :";
            // 
            // dgv_depot
            // 
            this.dgv_depot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_depot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_depot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_depot.Location = new System.Drawing.Point(36, 346);
            this.dgv_depot.Name = "dgv_depot";
            this.dgv_depot.Size = new System.Drawing.Size(808, 322);
            this.dgv_depot.TabIndex = 89;
            // 
            // btn_PAdd
            // 
            this.btn_PAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_PAdd.BackColor = System.Drawing.Color.White;
            this.btn_PAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PAdd.FlatAppearance.BorderSize = 0;
            this.btn_PAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_PAdd.Location = new System.Drawing.Point(38, 235);
            this.btn_PAdd.Name = "btn_PAdd";
            this.btn_PAdd.Size = new System.Drawing.Size(135, 38);
            this.btn_PAdd.TabIndex = 88;
            this.btn_PAdd.Text = "Thêm hàng";
            this.btn_PAdd.UseVisualStyleBackColor = false;
            this.btn_PAdd.Click += new System.EventHandler(this.btn_PAdd_Click);
            // 
            // btn_PSearch
            // 
            this.btn_PSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_PSearch.BackColor = System.Drawing.Color.White;
            this.btn_PSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PSearch.FlatAppearance.BorderSize = 0;
            this.btn_PSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_PSearch.Location = new System.Drawing.Point(377, 108);
            this.btn_PSearch.Name = "btn_PSearch";
            this.btn_PSearch.Size = new System.Drawing.Size(135, 38);
            this.btn_PSearch.TabIndex = 87;
            this.btn_PSearch.Text = "Tìm kiếm";
            this.btn_PSearch.UseVisualStyleBackColor = false;
            this.btn_PSearch.Click += new System.EventHandler(this.btn_PSearch_Click);
            // 
            // txt_PQuantity
            // 
            this.txt_PQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PQuantity.Location = new System.Drawing.Point(559, 169);
            this.txt_PQuantity.Multiline = true;
            this.txt_PQuantity.Name = "txt_PQuantity";
            this.txt_PQuantity.Size = new System.Drawing.Size(275, 31);
            this.txt_PQuantity.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(555, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 83;
            this.label3.Text = "Số lượng :";
            // 
            // txt_PName
            // 
            this.txt_PName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PName.Location = new System.Drawing.Point(38, 169);
            this.txt_PName.Multiline = true;
            this.txt_PName.Name = "txt_PName";
            this.txt_PName.Size = new System.Drawing.Size(286, 31);
            this.txt_PName.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 79;
            this.label2.Text = "Mã Hàng :";
            // 
            // txt_PCode
            // 
            this.txt_PCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PCode.Location = new System.Drawing.Point(36, 74);
            this.txt_PCode.Multiline = true;
            this.txt_PCode.Name = "txt_PCode";
            this.txt_PCode.Size = new System.Drawing.Size(288, 31);
            this.txt_PCode.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 77;
            this.label1.Text = "Tên Hàng :";
            // 
            // cb_PType
            // 
            this.cb_PType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PType.FormattingEnabled = true;
            this.cb_PType.Items.AddRange(new object[] {
            "Nhập Khẩu ",
            "Hàng nội địa "});
            this.cb_PType.Location = new System.Drawing.Point(553, 74);
            this.cb_PType.MaxLength = 32767;
            this.cb_PType.Name = "cb_PType";
            this.cb_PType.Size = new System.Drawing.Size(288, 29);
            this.cb_PType.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(549, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 91;
            this.label6.Text = "Kiểu hàng :";
            // 
            // btn_PUpdate
            // 
            this.btn_PUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_PUpdate.BackColor = System.Drawing.Color.White;
            this.btn_PUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PUpdate.FlatAppearance.BorderSize = 0;
            this.btn_PUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_PUpdate.Location = new System.Drawing.Point(377, 210);
            this.btn_PUpdate.Name = "btn_PUpdate";
            this.btn_PUpdate.Size = new System.Drawing.Size(135, 38);
            this.btn_PUpdate.TabIndex = 93;
            this.btn_PUpdate.Text = "Cập nhập";
            this.btn_PUpdate.UseVisualStyleBackColor = false;
            this.btn_PUpdate.Click += new System.EventHandler(this.btn_PUpdate_Click);
            // 
            // btn_PDelete
            // 
            this.btn_PDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_PDelete.BackColor = System.Drawing.Color.White;
            this.btn_PDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PDelete.FlatAppearance.BorderSize = 0;
            this.btn_PDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_PDelete.Location = new System.Drawing.Point(706, 235);
            this.btn_PDelete.Name = "btn_PDelete";
            this.btn_PDelete.Size = new System.Drawing.Size(135, 38);
            this.btn_PDelete.TabIndex = 94;
            this.btn_PDelete.Text = "Xóa";
            this.btn_PDelete.UseVisualStyleBackColor = false;
            this.btn_PDelete.Click += new System.EventHandler(this.btn_PDelete_Click);
            // 
            // uc_depot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.btn_PDelete);
            this.Controls.Add(this.btn_PUpdate);
            this.Controls.Add(this.cb_PType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_depot);
            this.Controls.Add(this.btn_PAdd);
            this.Controls.Add(this.btn_PSearch);
            this.Controls.Add(this.txt_PQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_depot";
            this.Size = new System.Drawing.Size(879, 686);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_depot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_depot;
        private System.Windows.Forms.Button btn_PAdd;
        private System.Windows.Forms.Button btn_PSearch;
        private System.Windows.Forms.TextBox txt_PQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_PType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PUpdate;
        private System.Windows.Forms.Button btn_PDelete;
    }
}
