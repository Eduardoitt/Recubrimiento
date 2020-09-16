namespace Recubrimiento
{
    partial class CatalogUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.cb_Permisos = new System.Windows.Forms.ComboBox();
            this.lbl_Permisos = new System.Windows.Forms.Label();
            this.txt_Permisos = new System.Windows.Forms.TextBox();
            this.lbl_PermisosAsignados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(34, 41);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(43, 13);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "Usuario";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(37, 66);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(170, 20);
            this.txt_User.TabIndex = 1;
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            // 
            // cb_Permisos
            // 
            this.cb_Permisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Permisos.Enabled = false;
            this.cb_Permisos.FormattingEnabled = true;
            this.cb_Permisos.Items.AddRange(new object[] {
            "Set Up | Jefe de Linea / Utility / Operador",
            "Seador | Jefe de Linea / Utility / Operador",
            "Empaque | Jefe de Linea / Utility / Operador",
            "Calidad",
            "Super user (ING / QA)"});
            this.cb_Permisos.Location = new System.Drawing.Point(291, 65);
            this.cb_Permisos.Name = "cb_Permisos";
            this.cb_Permisos.Size = new System.Drawing.Size(160, 21);
            this.cb_Permisos.TabIndex = 2;
            this.cb_Permisos.SelectedValueChanged += new System.EventHandler(this.cb_Permisos_SelectedValueChanged);
            // 
            // lbl_Permisos
            // 
            this.lbl_Permisos.AutoSize = true;
            this.lbl_Permisos.Location = new System.Drawing.Point(291, 40);
            this.lbl_Permisos.Name = "lbl_Permisos";
            this.lbl_Permisos.Size = new System.Drawing.Size(49, 13);
            this.lbl_Permisos.TabIndex = 3;
            this.lbl_Permisos.Text = "Permisos";
            // 
            // txt_Permisos
            // 
            this.txt_Permisos.Location = new System.Drawing.Point(34, 198);
            this.txt_Permisos.Multiline = true;
            this.txt_Permisos.Name = "txt_Permisos";
            this.txt_Permisos.ReadOnly = true;
            this.txt_Permisos.Size = new System.Drawing.Size(274, 192);
            this.txt_Permisos.TabIndex = 4;
            // 
            // lbl_PermisosAsignados
            // 
            this.lbl_PermisosAsignados.AutoSize = true;
            this.lbl_PermisosAsignados.Location = new System.Drawing.Point(34, 179);
            this.lbl_PermisosAsignados.Name = "lbl_PermisosAsignados";
            this.lbl_PermisosAsignados.Size = new System.Drawing.Size(101, 13);
            this.lbl_PermisosAsignados.TabIndex = 5;
            this.lbl_PermisosAsignados.Text = "Permisos Asignados";
            // 
            // CatalogUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_PermisosAsignados);
            this.Controls.Add(this.txt_Permisos);
            this.Controls.Add(this.lbl_Permisos);
            this.Controls.Add(this.cb_Permisos);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lbl_User);
            this.Name = "CatalogUser";
            this.Size = new System.Drawing.Size(833, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.ComboBox cb_Permisos;
        private System.Windows.Forms.Label lbl_Permisos;
        private System.Windows.Forms.TextBox txt_Permisos;
        private System.Windows.Forms.Label lbl_PermisosAsignados;
    }
}
