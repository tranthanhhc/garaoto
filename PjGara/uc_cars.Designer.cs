namespace PjGara
{
    partial class uc_cars
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
            this.lbID = new System.Windows.Forms.Label();
            this.dgv_cars = new System.Windows.Forms.DataGridView();
            this.btn_CAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_CType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CTrademark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CUpdate = new System.Windows.Forms.Button();
            this.txt_COwner = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_PDelete = new System.Windows.Forms.Button();
            this.dtp_CTime = new System.Windows.Forms.DateTimePicker();
            this.btn_ClearInput = new System.Windows.Forms.Button();
            this.btn_CSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Purple;
            this.lbID.Location = new System.Drawing.Point(32, 296);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(37, 20);
            this.lbID.TabIndex = 90;
            this.lbID.Text = "Xe :";
            // 
            // dgv_cars
            // 
            this.dgv_cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cars.Location = new System.Drawing.Point(14, 338);
            this.dgv_cars.Name = "dgv_cars";
            this.dgv_cars.Size = new System.Drawing.Size(849, 328);
            this.dgv_cars.TabIndex = 89;
            this.dgv_cars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cars_CellClick);
            // 
            // btn_CAdd
            // 
            this.btn_CAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CAdd.BackColor = System.Drawing.Color.White;
            this.btn_CAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CAdd.FlatAppearance.BorderSize = 0;
            this.btn_CAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_CAdd.Location = new System.Drawing.Point(78, 218);
            this.btn_CAdd.Name = "btn_CAdd";
            this.btn_CAdd.Size = new System.Drawing.Size(135, 38);
            this.btn_CAdd.TabIndex = 88;
            this.btn_CAdd.Text = "Thêm Xe ";
            this.btn_CAdd.UseVisualStyleBackColor = false;
            this.btn_CAdd.Click += new System.EventHandler(this.btn_CAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(609, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 106;
            this.label4.Text = "Ngày nhận :";
            // 
            // cb_CType
            // 
            this.cb_CType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CType.FormattingEnabled = true;
            this.cb_CType.Items.AddRange(new object[] {
            "Xe sang ( trên 1 tỷ)",
            "Xe trung (trên 500 triệu )",
            "Xe bình dân ( dưới 500 triệu)"});
            this.cb_CType.Location = new System.Drawing.Point(36, 157);
            this.cb_CType.MaxLength = 32767;
            this.cb_CType.Name = "cb_CType";
            this.cb_CType.Size = new System.Drawing.Size(203, 29);
            this.cb_CType.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(32, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 104;
            this.label6.Text = "Loại xe :";
            // 
            // txt_CCode
            // 
            this.txt_CCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CCode.Location = new System.Drawing.Point(36, 74);
            this.txt_CCode.Multiline = true;
            this.txt_CCode.Name = "txt_CCode";
            this.txt_CCode.Size = new System.Drawing.Size(203, 31);
            this.txt_CCode.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(32, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 102;
            this.label3.Text = "Mã Xe :";
            // 
            // txt_CTrademark
            // 
            this.txt_CTrademark.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CTrademark.Location = new System.Drawing.Point(309, 74);
            this.txt_CTrademark.Multiline = true;
            this.txt_CTrademark.Name = "txt_CTrademark";
            this.txt_CTrademark.Size = new System.Drawing.Size(219, 31);
            this.txt_CTrademark.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(292, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 100;
            this.label2.Text = "Thương hiệu :";
            // 
            // txt_CName
            // 
            this.txt_CName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CName.Location = new System.Drawing.Point(612, 74);
            this.txt_CName.Multiline = true;
            this.txt_CName.Name = "txt_CName";
            this.txt_CName.Size = new System.Drawing.Size(202, 31);
            this.txt_CName.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(609, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 98;
            this.label1.Text = "Tên Xe :";
            // 
            // btn_CUpdate
            // 
            this.btn_CUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CUpdate.BackColor = System.Drawing.Color.White;
            this.btn_CUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CUpdate.FlatAppearance.BorderSize = 0;
            this.btn_CUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_CUpdate.Location = new System.Drawing.Point(280, 218);
            this.btn_CUpdate.Name = "btn_CUpdate";
            this.btn_CUpdate.Size = new System.Drawing.Size(135, 38);
            this.btn_CUpdate.TabIndex = 108;
            this.btn_CUpdate.Text = "Cập nhập";
            this.btn_CUpdate.UseVisualStyleBackColor = false;
            this.btn_CUpdate.Click += new System.EventHandler(this.btn_CUpdate_Click);
            // 
            // txt_COwner
            // 
            this.txt_COwner.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_COwner.Location = new System.Drawing.Point(309, 157);
            this.txt_COwner.Multiline = true;
            this.txt_COwner.Name = "txt_COwner";
            this.txt_COwner.Size = new System.Drawing.Size(219, 31);
            this.txt_COwner.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(305, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 109;
            this.label7.Text = "Tên Chủ Xe :";
            // 
            // btn_PDelete
            // 
            this.btn_PDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_PDelete.BackColor = System.Drawing.Color.White;
            this.btn_PDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PDelete.FlatAppearance.BorderSize = 0;
            this.btn_PDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_PDelete.Location = new System.Drawing.Point(473, 218);
            this.btn_PDelete.Name = "btn_PDelete";
            this.btn_PDelete.Size = new System.Drawing.Size(135, 38);
            this.btn_PDelete.TabIndex = 111;
            this.btn_PDelete.Text = "Xóa";
            this.btn_PDelete.UseVisualStyleBackColor = false;
            this.btn_PDelete.Click += new System.EventHandler(this.btn_PDelete_Click);
            // 
            // dtp_CTime
            // 
            this.dtp_CTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_CTime.CustomFormat = "dd-MM-yyyy";
            this.dtp_CTime.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_CTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CTime.Location = new System.Drawing.Point(612, 158);
            this.dtp_CTime.Name = "dtp_CTime";
            this.dtp_CTime.Size = new System.Drawing.Size(219, 30);
            this.dtp_CTime.TabIndex = 112;
            // 
            // btn_ClearInput
            // 
            this.btn_ClearInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ClearInput.BackColor = System.Drawing.Color.White;
            this.btn_ClearInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClearInput.FlatAppearance.BorderSize = 0;
            this.btn_ClearInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearInput.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_ClearInput.Location = new System.Drawing.Point(696, 278);
            this.btn_ClearInput.Name = "btn_ClearInput";
            this.btn_ClearInput.Size = new System.Drawing.Size(135, 38);
            this.btn_ClearInput.TabIndex = 116;
            this.btn_ClearInput.Text = "Nhập mới ";
            this.btn_ClearInput.UseVisualStyleBackColor = false;
            this.btn_ClearInput.Click += new System.EventHandler(this.btn_ClearInput_Click);
            // 
            // btn_CSearch
            // 
            this.btn_CSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CSearch.BackColor = System.Drawing.Color.White;
            this.btn_CSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CSearch.FlatAppearance.BorderSize = 0;
            this.btn_CSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_CSearch.Location = new System.Drawing.Point(655, 218);
            this.btn_CSearch.Name = "btn_CSearch";
            this.btn_CSearch.Size = new System.Drawing.Size(135, 38);
            this.btn_CSearch.TabIndex = 117;
            this.btn_CSearch.Text = "Tìm Kiếm";
            this.btn_CSearch.UseVisualStyleBackColor = false;
            this.btn_CSearch.Click += new System.EventHandler(this.btn_CSearch_Click);
            // 
            // uc_cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.btn_CSearch);
            this.Controls.Add(this.btn_ClearInput);
            this.Controls.Add(this.dtp_CTime);
            this.Controls.Add(this.btn_PDelete);
            this.Controls.Add(this.txt_COwner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_CUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_CType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_CCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CTrademark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dgv_cars);
            this.Controls.Add(this.btn_CAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_cars";
            this.Size = new System.Drawing.Size(879, 686);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView dgv_cars;
        private System.Windows.Forms.Button btn_CAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_CType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CTrademark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CUpdate;
        private System.Windows.Forms.TextBox txt_COwner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_PDelete;
        private System.Windows.Forms.DateTimePicker dtp_CTime;
        private System.Windows.Forms.Button btn_ClearInput;
        private System.Windows.Forms.Button btn_CSearch;
    }
}
