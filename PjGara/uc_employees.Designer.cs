namespace PjGara
{
    partial class uc_employees
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_EName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_EAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ECode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ESearch = new System.Windows.Forms.Button();
            this.btn_EAdd = new System.Windows.Forms.Button();
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_SUpdate = new System.Windows.Forms.Button();
            this.btn_SDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_EName
            // 
            this.txt_EName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EName.Location = new System.Drawing.Point(36, 74);
            this.txt_EName.Multiline = true;
            this.txt_EName.Name = "txt_EName";
            this.txt_EName.Size = new System.Drawing.Size(288, 31);
            this.txt_EName.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tên Nhân Viên :";
            // 
            // txt_EAge
            // 
            this.txt_EAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EAge.Location = new System.Drawing.Point(36, 165);
            this.txt_EAge.Multiline = true;
            this.txt_EAge.Name = "txt_EAge";
            this.txt_EAge.Size = new System.Drawing.Size(286, 31);
            this.txt_EAge.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Tuổi Nhân Viên :";
            // 
            // cb_Gender
            // 
            this.cb_Gender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_Gender.Location = new System.Drawing.Point(571, 74);
            this.cb_Gender.MaxLength = 32767;
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(267, 29);
            this.cb_Gender.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(567, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "Giới Tính Nhân Viên :";
            // 
            // txt_EAddress
            // 
            this.txt_EAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EAddress.Location = new System.Drawing.Point(571, 165);
            this.txt_EAddress.Multiline = true;
            this.txt_EAddress.Name = "txt_EAddress";
            this.txt_EAddress.Size = new System.Drawing.Size(267, 31);
            this.txt_EAddress.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(567, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Địa Chỉ Nhân Viên :";
            // 
            // txt_ECode
            // 
            this.txt_ECode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ECode.Location = new System.Drawing.Point(318, 284);
            this.txt_ECode.Multiline = true;
            this.txt_ECode.Name = "txt_ECode";
            this.txt_ECode.Size = new System.Drawing.Size(286, 31);
            this.txt_ECode.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(314, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 71;
            this.label4.Text = "Mã Nhân Viên :";
            // 
            // btn_ESearch
            // 
            this.btn_ESearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ESearch.BackColor = System.Drawing.Color.White;
            this.btn_ESearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ESearch.FlatAppearance.BorderSize = 0;
            this.btn_ESearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ESearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_ESearch.Location = new System.Drawing.Point(383, 86);
            this.btn_ESearch.Name = "btn_ESearch";
            this.btn_ESearch.Size = new System.Drawing.Size(135, 38);
            this.btn_ESearch.TabIndex = 73;
            this.btn_ESearch.Text = "Tìm kiếm";
            this.btn_ESearch.UseVisualStyleBackColor = false;
            // 
            // btn_EAdd
            // 
            this.btn_EAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_EAdd.BackColor = System.Drawing.Color.White;
            this.btn_EAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EAdd.FlatAppearance.BorderSize = 0;
            this.btn_EAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_EAdd.Location = new System.Drawing.Point(36, 245);
            this.btn_EAdd.Name = "btn_EAdd";
            this.btn_EAdd.Size = new System.Drawing.Size(135, 38);
            this.btn_EAdd.TabIndex = 74;
            this.btn_EAdd.Text = "Thêm nhân viên ";
            this.btn_EAdd.UseVisualStyleBackColor = false;
            this.btn_EAdd.Click += new System.EventHandler(this.btn_EAdd_Click);
            // 
            // dgv_employees
            // 
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Location = new System.Drawing.Point(36, 364);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.Size = new System.Drawing.Size(808, 311);
            this.dgv_employees.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(32, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "Nhân Viên :";
            // 
            // btn_SUpdate
            // 
            this.btn_SUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SUpdate.BackColor = System.Drawing.Color.White;
            this.btn_SUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SUpdate.FlatAppearance.BorderSize = 0;
            this.btn_SUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SUpdate.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_SUpdate.Location = new System.Drawing.Point(383, 176);
            this.btn_SUpdate.Name = "btn_SUpdate";
            this.btn_SUpdate.Size = new System.Drawing.Size(135, 38);
            this.btn_SUpdate.TabIndex = 77;
            this.btn_SUpdate.Text = "Cập nhập";
            this.btn_SUpdate.UseVisualStyleBackColor = false;
            // 
            // btn_SDelete
            // 
            this.btn_SDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SDelete.BackColor = System.Drawing.Color.White;
            this.btn_SDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SDelete.FlatAppearance.BorderSize = 0;
            this.btn_SDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_SDelete.Location = new System.Drawing.Point(692, 245);
            this.btn_SDelete.Name = "btn_SDelete";
            this.btn_SDelete.Size = new System.Drawing.Size(135, 38);
            this.btn_SDelete.TabIndex = 95;
            this.btn_SDelete.Text = "Xóa";
            this.btn_SDelete.UseVisualStyleBackColor = false;
            // 
            // uc_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.btn_SDelete);
            this.Controls.Add(this.btn_SUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_employees);
            this.Controls.Add(this.btn_EAdd);
            this.Controls.Add(this.btn_ESearch);
            this.Controls.Add(this.txt_ECode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_EAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_EAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_EName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_employees";
            this.Size = new System.Drawing.Size(879, 686);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_EName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_EAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_EAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ECode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ESearch;
        private System.Windows.Forms.Button btn_EAdd;
        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_SUpdate;
        private System.Windows.Forms.Button btn_SDelete;
    }
}
