using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recubrimiento
{
    public partial class SetUp : UserControl
    {
        public SetUp()
        {
            InitializeComponent();
        }

        private void txt_BatchQuimico_TextChanged(object sender, EventArgs e)
        {
            if (txt_BatchQuimico.Text != "")
            {
                txt_WO.Enabled = true;
                btn_BuscarWO.Enabled = true;
            }
        }

        private void btn_BuscarWO_Click(object sender, EventArgs e)
        {
            if (txt_WO.Text != "")
            {
                this.dt_SetUp.Rows.Add();
                this.dt_SetUp.Rows[0].Cells[0].Value="498609207";
                this.dt_SetUp.Rows[0].Cells[1].Value="250";
                this.dt_SetUp.Rows[0].Cells[2].Value="BIOACTIVE BATCH B250, CARMEDA";   
            }
        }
    }
}
