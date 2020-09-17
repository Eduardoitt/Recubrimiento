namespace Recubrimiento
{
    partial class Reportes
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
            this.cb_Opciones = new System.Windows.Forms.ComboBox();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_FI = new System.Windows.Forms.DateTimePicker();
            this.dt_FF = new System.Windows.Forms.DateTimePicker();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_B2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Opciones
            // 
            this.cb_Opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Opciones.FormattingEnabled = true;
            this.cb_Opciones.Items.AddRange(new object[] {
            "WO y No. Serie",
            "WO y Posicion",
            "Numero de Serie",
            "Numero de Parte",
            "Por Fechas",
            "Batch Quimico y Posicion",
            "Batch Quimico y No. Serie",
            "Batch Quimico (Nomenclatura Produccion)"});
            this.cb_Opciones.Location = new System.Drawing.Point(3, 49);
            this.cb_Opciones.Name = "cb_Opciones";
            this.cb_Opciones.Size = new System.Drawing.Size(168, 21);
            this.cb_Opciones.TabIndex = 0;
            this.cb_Opciones.SelectedValueChanged += new System.EventHandler(this.cb_Opciones_SelectedValueChanged);
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.Location = new System.Drawing.Point(3, 143);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(176, 20);
            this.txt_Busqueda.TabIndex = 1;
            this.txt_Busqueda.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dt_FI
            // 
            this.dt_FI.Location = new System.Drawing.Point(403, 143);
            this.dt_FI.Name = "dt_FI";
            this.dt_FI.Size = new System.Drawing.Size(200, 20);
            this.dt_FI.TabIndex = 3;
            this.dt_FI.Visible = false;
            // 
            // dt_FF
            // 
            this.dt_FF.Location = new System.Drawing.Point(630, 143);
            this.dt_FF.Name = "dt_FF";
            this.dt_FF.Size = new System.Drawing.Size(200, 20);
            this.dt_FF.TabIndex = 4;
            this.dt_FF.Visible = false;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(228, 47);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_B2
            // 
            this.txt_B2.Location = new System.Drawing.Point(203, 143);
            this.txt_B2.Name = "txt_B2";
            this.txt_B2.Size = new System.Drawing.Size(176, 20);
            this.txt_B2.TabIndex = 6;
            this.txt_B2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_B2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dt_FF);
            this.Controls.Add(this.dt_FI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Busqueda);
            this.Controls.Add(this.cb_Opciones);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(833, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Opciones;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_FI;
        private System.Windows.Forms.DateTimePicker dt_FF;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_B2;
        private System.Windows.Forms.Label label2;
    }
}
