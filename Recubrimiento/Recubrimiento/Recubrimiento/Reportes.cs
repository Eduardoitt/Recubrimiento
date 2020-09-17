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
    public partial class Reportes : UserControl
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void cb_Opciones_SelectedValueChanged(object sender, EventArgs e)
        {
            var valor = cb_Opciones.SelectedIndex;
            if (valor == 0)
            {
                // por Wo y Nom Serie
                Limpiar();
                label1.Text = "WO";
                label1.Visible = true;
                label2.Text = "No. Serie";
                label2.Visible = true;
                txt_Busqueda.Visible = true;
                txt_B2.Visible = true;
            }else if(valor ==1)//Wo y Posicion
            {
                Limpiar();
                label1.Text = "WO";
                label1.Visible = true;
                label2.Text = "Posicion";
                label2.Visible = true;
                txt_Busqueda.Visible = true;
                txt_B2.Visible = true;
            }else if(valor == 2)//No serie
            {
                Limpiar();
                label1.Text = "No. Serie";
                label1.Visible = true;
                txt_Busqueda.Visible = true;
            }else if(valor == 3) //No parte y fechas
            {
                Limpiar();
                label1.Text = "No. Parte";
                label1.Visible = true;
                txt_Busqueda.Visible = true;
                dt_FI.Location = new Point(203, 143);
                dt_FF.Location = new Point(430, 143);
                dt_FI.Visible = true;
                dt_FF.Visible = true;
            }else if (valor == 4)// Fechas
            {
                Limpiar();
                dt_FI.Location = new Point(3,143);
                dt_FF.Location = new Point(230,143);
                dt_FI.Visible = true;
                dt_FF.Visible = true;
            }else if (valor == 5)//Batch y Posicion
            {
                Limpiar();
                label1.Text = "Batch Quimimco";
                label1.Visible = true;
                label2.Text = "Posicion";
                label2.Visible = true;
                txt_Busqueda.Visible = true;
                txt_B2.Visible = true;

            }else if(valor == 6)//Batch y No Serie
            {
                Limpiar();
                label1.Text = "Batch Quimimco";
                label1.Visible = true;
                label2.Text = "No. Serie";
                label2.Visible = true;
                txt_Busqueda.Visible = true;
                txt_B2.Visible = true;
            }
            else // Batch Nomenclatura
            {
                Limpiar();
                label1.Text = "Batch Quimico";
                label1.Visible = true;
                txt_Busqueda.Visible=true;
            }
        }
        public void Limpiar()
        {
            label1.Text = "";
            label1.Visible = false;
            label2.Text = "";
            label2.Visible = false;
            txt_Busqueda.Visible = false;
            txt_B2.Visible = false;
            dt_FI.Visible = false;
            dt_FF.Visible = false;
        }
    }
}
