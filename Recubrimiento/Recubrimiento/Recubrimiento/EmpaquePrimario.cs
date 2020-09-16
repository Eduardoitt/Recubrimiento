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
    public partial class EmpaquePrimario : UserControl
    {
        public EmpaquePrimario()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(txtWO.Text !="" && txt_Batch.Text != "")
            {
                PanelValidacion.Visible = true;
                txt_Cantidad.Text = "100";
                txt_Material.Text = "220618769";
                txt_Descripcion.Text = "Material";
                txt_NumSerie.Text = "51136988";
                MessageBox.Show("Escanear");
            }
        }
    }
}
