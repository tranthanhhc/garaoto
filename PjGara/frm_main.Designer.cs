namespace PjGara
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_SideBot = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Analytics = new System.Windows.Forms.Button();
            this.btn_Billing = new System.Windows.Forms.Button();
            this.btn_Employees = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.btn_Cars = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.uc_billing1 = new PjGara.uc_billing();
            this.uc_cars1 = new PjGara.uc_cars();
            this.uc_employees1 = new PjGara.uc_employees();
            this.uc_stock1 = new PjGara.uc_depot();
            this.uc_analyist1 = new PjGara.uc_analyist();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnl_SideBot);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.btn_Analytics);
            this.panel1.Controls.Add(this.btn_Billing);
            this.panel1.Controls.Add(this.btn_Employees);
            this.panel1.Controls.Add(this.btn_Stock);
            this.panel1.Controls.Add(this.btn_Cars);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 700);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "GARA MANEGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_SideBot
            // 
            this.pnl_SideBot.BackColor = System.Drawing.Color.Cornsilk;
            this.pnl_SideBot.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_SideBot.Location = new System.Drawing.Point(0, 687);
            this.pnl_SideBot.Name = "pnl_SideBot";
            this.pnl_SideBot.Size = new System.Drawing.Size(214, 10);
            this.pnl_SideBot.TabIndex = 1;
            this.pnl_SideBot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_SideBot_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_LogOut.Location = new System.Drawing.Point(32, 648);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(135, 35);
            this.btn_LogOut.TabIndex = 5;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Analytics
            // 
            this.btn_Analytics.BackColor = System.Drawing.Color.Transparent;
            this.btn_Analytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Analytics.FlatAppearance.BorderSize = 0;
            this.btn_Analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Analytics.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Analytics.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Analytics.Location = new System.Drawing.Point(0, 514);
            this.btn_Analytics.Name = "btn_Analytics";
            this.btn_Analytics.Size = new System.Drawing.Size(214, 42);
            this.btn_Analytics.TabIndex = 2;
            this.btn_Analytics.Text = "Tổng Quan";
            this.btn_Analytics.UseVisualStyleBackColor = false;
            this.btn_Analytics.Click += new System.EventHandler(this.btn_Analytics_Click);
            // 
            // btn_Billing
            // 
            this.btn_Billing.BackColor = System.Drawing.Color.Transparent;
            this.btn_Billing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Billing.FlatAppearance.BorderSize = 0;
            this.btn_Billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Billing.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Billing.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Billing.Location = new System.Drawing.Point(0, 434);
            this.btn_Billing.Name = "btn_Billing";
            this.btn_Billing.Size = new System.Drawing.Size(214, 42);
            this.btn_Billing.TabIndex = 4;
            this.btn_Billing.Text = "Thanh Toán";
            this.btn_Billing.UseVisualStyleBackColor = false;
            this.btn_Billing.Click += new System.EventHandler(this.btn_Billing_Click);
            // 
            // btn_Employees
            // 
            this.btn_Employees.BackColor = System.Drawing.Color.Transparent;
            this.btn_Employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Employees.FlatAppearance.BorderSize = 0;
            this.btn_Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employees.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employees.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Employees.Location = new System.Drawing.Point(0, 354);
            this.btn_Employees.Name = "btn_Employees";
            this.btn_Employees.Size = new System.Drawing.Size(214, 42);
            this.btn_Employees.TabIndex = 3;
            this.btn_Employees.Text = "Nhân Viên";
            this.btn_Employees.UseVisualStyleBackColor = false;
            this.btn_Employees.Click += new System.EventHandler(this.btn_Employees_Click);
            // 
            // btn_Stock
            // 
            this.btn_Stock.BackColor = System.Drawing.Color.Transparent;
            this.btn_Stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stock.FlatAppearance.BorderSize = 0;
            this.btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stock.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Stock.Location = new System.Drawing.Point(0, 274);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(214, 42);
            this.btn_Stock.TabIndex = 2;
            this.btn_Stock.Text = "Kho";
            this.btn_Stock.UseVisualStyleBackColor = false;
            this.btn_Stock.Click += new System.EventHandler(this.btn_Stock_Click);
            // 
            // btn_Cars
            // 
            this.btn_Cars.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cars.FlatAppearance.BorderSize = 0;
            this.btn_Cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cars.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cars.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Cars.Location = new System.Drawing.Point(0, 194);
            this.btn_Cars.Name = "btn_Cars";
            this.btn_Cars.Size = new System.Drawing.Size(214, 42);
            this.btn_Cars.TabIndex = 1;
            this.btn_Cars.Text = "CARS";
            this.btn_Cars.UseVisualStyleBackColor = false;
            this.btn_Cars.Click += new System.EventHandler(this.btn_Cars_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(214, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(886, 7);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1093, 7);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 693);
            this.panel8.TabIndex = 2;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(214, 693);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(879, 7);
            this.panel9.TabIndex = 3;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Main.Controls.Add(this.uc_analyist1);
            this.pnl_Main.Controls.Add(this.uc_stock1);
            this.pnl_Main.Controls.Add(this.uc_employees1);
            this.pnl_Main.Controls.Add(this.uc_cars1);
            this.pnl_Main.Controls.Add(this.uc_billing1);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(214, 7);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(879, 686);
            this.pnl_Main.TabIndex = 4;
            this.pnl_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Main_Paint);
            // 
            // uc_billing1
            // 
            this.uc_billing1.BackColor = System.Drawing.Color.MistyRose;
            this.uc_billing1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_billing1.Location = new System.Drawing.Point(0, 0);
            this.uc_billing1.Name = "uc_billing1";
            this.uc_billing1.Size = new System.Drawing.Size(879, 686);
            this.uc_billing1.TabIndex = 0;
            // 
            // uc_cars1
            // 
            this.uc_cars1.BackColor = System.Drawing.Color.MistyRose;
            this.uc_cars1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_cars1.Location = new System.Drawing.Point(0, 0);
            this.uc_cars1.Name = "uc_cars1";
            this.uc_cars1.Size = new System.Drawing.Size(879, 686);
            this.uc_cars1.TabIndex = 1;
            // 
            // uc_employees1
            // 
            this.uc_employees1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.uc_employees1.BackColor = System.Drawing.Color.MistyRose;
            this.uc_employees1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_employees1.Location = new System.Drawing.Point(0, 0);
            this.uc_employees1.Name = "uc_employees1";
            this.uc_employees1.Size = new System.Drawing.Size(879, 686);
            this.uc_employees1.TabIndex = 2;
            // 
            // uc_stock1
            // 
            this.uc_stock1.BackColor = System.Drawing.Color.MistyRose;
            this.uc_stock1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_stock1.Location = new System.Drawing.Point(0, 0);
            this.uc_stock1.Name = "uc_stock1";
            this.uc_stock1.Size = new System.Drawing.Size(879, 686);
            this.uc_stock1.TabIndex = 3;
            // 
            // uc_analyist1
            // 
            this.uc_analyist1.BackColor = System.Drawing.Color.MistyRose;
            this.uc_analyist1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_analyist1.Location = new System.Drawing.Point(0, 0);
            this.uc_analyist1.Name = "uc_analyist1";
            this.uc_analyist1.Size = new System.Drawing.Size(879, 686);
            this.uc_analyist1.TabIndex = 4;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Analytics;
        private System.Windows.Forms.Button btn_Billing;
        private System.Windows.Forms.Button btn_Employees;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.Button btn_Cars;
        private System.Windows.Forms.Panel pnl_SideBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnl_Main;
        private uc_analyist uc_analyist1;
        private uc_depot uc_stock1;
        private uc_employees uc_employees1;
        private uc_cars uc_cars1;
        private uc_billing uc_billing1;
    }
}