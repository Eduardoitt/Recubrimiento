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
    public partial class Login : Form
    {
        Set_UpEmp frmSetup;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != ""  && txtPassword.Text != "")
            {
                if (frmSetup != null)
                {
                    frmSetup.Close();
                }
                frmSetup =new Set_UpEmp();
                this.Hide();
                frmSetup.Show();

            }
            else
            {
                lbl_Error.Visible=true;
            }
        }
    }
}
