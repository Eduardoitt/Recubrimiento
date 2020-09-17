using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recubrimiento
{
    public partial class Set_UpEmp : Form
    {
        public Set_UpEmp()
        {
            InitializeComponent();
        }

        private void Set_Up_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_CatalogoUsuario_Click(object sender, EventArgs e)
        {
            this.Panel_Content.Controls.Clear();
            CatalogUser catloguser = new CatalogUser();
            catloguser.Width = this.Panel_Content.Width - 5;
            catloguser.Height = this.Panel_Content.Height - 5;
            catloguser.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            this.Panel_Content.Controls.Add(catloguser);

        }
        private void btn_setup_Click(object sender, EventArgs e)
        {
            this.Panel_Content.Controls.Clear();
            SetUp setup = new SetUp();
            setup.Width = this.Panel_Content.Width - 5;
            setup.Height = this.Panel_Content.Height - 5;
            setup.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            this.Panel_Content.Controls.Add(setup);
        }

        private void btn_EmpaquePrimario_Click(object sender, EventArgs e)
        {
            this.Panel_Content.Controls.Clear();
            EmpaquePrimario empp = new EmpaquePrimario();
            empp.Width = this.Panel_Content.Width - 5;
            empp.Height = this.Panel_Content.Height - 5;
            empp.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            this.Panel_Content.Controls.Add(empp);
        }

        private void btn_Sorteo_Click(object sender, EventArgs e)
        {
            LoginQA loginQA = new LoginQA();
            loginQA.Show();
            this.Panel_Content.Controls.Clear();
            Sorteo sorteo = new Sorteo();
            sorteo.Width = this.Panel_Content.Width - 5;
            sorteo.Height = this.Panel_Content.Height - 5;
            sorteo.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            this.Panel_Content.Controls.Add(sorteo);
        }

        private void btn_Secado_Click(object sender, EventArgs e)
        {
            this.Panel_Content.Controls.Clear();
            Secado secado = new Secado();
            secado.Width = this.Panel_Content.Width - 5;
            secado.Height = this.Panel_Content.Height - 5;
            secado.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            this.Panel_Content.Controls.Add(secado);

        }

        private void btn_CatalogoProducto_Click(object sender, EventArgs e)
        {
            this.Panel_Content.Controls.Clear();
            CatalogoProducto CatProduc = new CatalogoProducto();
            CatProduc.Width = this.Panel_Content.Width - 5;
            CatProduc.Height = this.Panel_Content.Height - 5;
            CatProduc.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            this.Panel_Content.Controls.Add(CatProduc);
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            this.Panel_Content.Controls.Clear();
            Reportes rp = new Reportes();
            rp.Width = this.Panel_Content.Width - 5;
            rp.Height = this.Panel_Content.Height - 5;
            rp.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            this.Panel_Content.Controls.Add(rp);
        }
    }
}
