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
    public partial class LoginQA : Form
    {
        public LoginQA()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txtUser.Text !="" && txtPassword.Text != "")
            {
                this.Close();
            }
            else
            {
                lbl_Error.Visible = true;
            }
        }
    }
}
