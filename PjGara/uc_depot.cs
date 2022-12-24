
using PjGara.Models;
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
    public partial class uc_depot : UserControl
    {
        public uc_depot()
        {
            InitializeComponent();
            DisplayDepot();
         
        }
        public void DisplayDepot()
        {
            using (GaraDataEntities1 _entity = new GaraDataEntities1())
            {
                List<DepotInfo> _depotList = new List<DepotInfo>();
                _depotList = _entity.db_depot.Select(x => new DepotInfo
                {
                    DeId = x.DeId,
                    DeCode= x.DeCode,
                    DEModel= x.DeModel,
                    DeName= x.DeName,
                    DeQua= x.DeQua
                }).ToList();
                dgv_depot.DataSource = _depotList;
            }
        }

        private void btn_PAdd_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_PUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btn_PDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_PSearch_Click(object sender, EventArgs e)
        {

        }

    }
}
