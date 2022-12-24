using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjGara
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cars_Click(object sender, EventArgs e)
        {
            pnl_SideBot.Height = 5;
            pnl_SideBot.Width = btn_Cars.Width;
            pnl_SideBot.Top = btn_Cars.Bottom;
            uc_cars1.BringToFront();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            pnl_SideBot.Height = 5;
            pnl_SideBot.Width = btn_Stock.Width;
            pnl_SideBot.Top = btn_Stock.Bottom;
            uc_stock1.BringToFront();
        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            pnl_SideBot.Height = 5;
            pnl_SideBot.Width = btn_Employees.Width;
            pnl_SideBot.Top = btn_Employees.Bottom;
            uc_employees1.BringToFront();
        }

        private void btn_Billing_Click(object sender, EventArgs e)
        {
            pnl_SideBot.Height = 5;
            pnl_SideBot.Width = btn_Billing.Width;
            pnl_SideBot.Top = btn_Billing.Bottom;
            uc_billing1.BringToFront();
        }

        private void btn_Analytics_Click(object sender, EventArgs e)
        {
            pnl_SideBot.Height = 5;
            pnl_SideBot.Width = btn_Analytics.Width;
            pnl_SideBot.Top = btn_Analytics.Bottom;
            uc_analyist1.BringToFront();
        }

        private void pnl_SideBot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
