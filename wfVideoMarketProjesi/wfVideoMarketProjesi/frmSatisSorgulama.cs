using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketProjesi
{
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }

        private void btngetir_Click(object sender, EventArgs e)
        {
            cFilmSatis fs = new cFilmSatis();
            DataTable dt = fs.SatislariGetirByTarihlerArasi(dtpTarih1.Value, dtpTarih2.Value);
            dgvsatislar.DataSource = dt;
        }
    }
}
