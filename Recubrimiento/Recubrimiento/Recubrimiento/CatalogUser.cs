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
    public partial class CatalogUser : UserControl
    {
        public CatalogUser()
        {
            InitializeComponent();
        }

        private void cb_Permisos_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = cb_Permisos.SelectedText.ToString();
            DialogResult dialogResult = MessageBox.Show("Agregar permiso", "Asignacion de Permisos", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txt_Permisos.Text = txt_Permisos.Text + cb_Permisos.Text + "\r\n";
                
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {
            cb_Permisos.Enabled = true;
        }
    }
}
