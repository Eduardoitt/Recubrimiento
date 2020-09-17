namespace Recubrimiento
{
    partial class Secado
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
            this.PanelCaptura = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_batchQ = new System.Windows.Forms.TextBox();
            this.lbl_BatchWo = new System.Windows.Forms.Label();
            this.CK_TB = new System.Windows.Forms.CheckBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dt_Secado = new System.Windows.Forms.DataGridView();
            this.Ordenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Scope = new System.Windows.Forms.Label();
            this.lbl_Retrabajo = new System.Windows.Forms.Label();
            this.PanelCaptura.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Secado)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCaptura
            // 
            this.PanelCaptura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCaptura.Controls.Add(this.btn_Buscar);
            this.PanelCaptura.Controls.Add(this.CK_TB);
            this.PanelCaptura.Controls.Add(this.lbl_BatchWo);
            this.PanelCaptura.Controls.Add(this.txt_batchQ);
            this.PanelCaptura.Location = new System.Drawing.Point(4, 0);
            this.PanelCaptura.Name = "PanelCaptura";
            this.PanelCaptura.Size = new System.Drawing.Size(245, 523);
            this.PanelCaptura.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Retrabajo);
            this.panel1.Controls.Add(this.lbl_Scope);
            this.panel1.Controls.Add(this.dt_Secado);
            this.panel1.Location = new System.Drawing.Point(255, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 526);
            this.panel1.TabIndex = 1;
            // 
            // txt_batchQ
            // 
            this.txt_batchQ.Location = new System.Drawing.Point(17, 54);
            this.txt_batchQ.Name = "txt_batchQ";
            this.txt_batchQ.Size = new System.Drawing.Size(167, 20);
            this.txt_batchQ.TabIndex = 0;
            // 
            // lbl_BatchWo
            // 
            this.lbl_BatchWo.AutoSize = true;
            this.lbl_BatchWo.Location = new System.Drawing.Point(14, 28);
            this.lbl_BatchWo.Name = "lbl_BatchWo";
            this.lbl_BatchWo.Size = new System.Drawing.Size(106, 13);
            this.lbl_BatchWo.TabIndex = 1;
            this.lbl_BatchWo.Text = "Batch Quimico / WO";
            // 
            // CK_TB
            // 
            this.CK_TB.AutoSize = true;
            this.CK_TB.Location = new System.Drawing.Point(139, 27);
            this.CK_TB.Name = "CK_TB";
            this.CK_TB.Size = new System.Drawing.Size(45, 17);
            this.CK_TB.TabIndex = 2;
            this.CK_TB.Text = "T/B";
            this.CK_TB.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(17, 91);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // dt_Secado
            // 
            this.dt_Secado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_Secado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_Secado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Secado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordenes,
            this.Material,
            this.CantidadO,
            this.Descripcion});
            this.dt_Secado.Location = new System.Drawing.Point(41, 54);
            this.dt_Secado.Name = "dt_Secado";
            this.dt_Secado.Size = new System.Drawing.Size(465, 150);
            this.dt_Secado.TabIndex = 0;
            // 
            // Ordenes
            // 
            this.Ordenes.HeaderText = "Ordenes";
            this.Ordenes.Name = "Ordenes";
            // 
            // Material
            // 
            this.Material.HeaderText = "Material (p/n)";
            this.Material.Name = "Material";
            // 
            // CantidadO
            // 
            this.CantidadO.HeaderText = "Cantidad de Orden";
            this.CantidadO.Name = "CantidadO";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // lbl_Scope
            // 
            this.lbl_Scope.AutoSize = true;
            this.lbl_Scope.Location = new System.Drawing.Point(38, 28);
            this.lbl_Scope.Name = "lbl_Scope";
            this.lbl_Scope.Size = new System.Drawing.Size(41, 13);
            this.lbl_Scope.TabIndex = 1;
            this.lbl_Scope.Text = "Scope:";
            // 
            // lbl_Retrabajo
            // 
            this.lbl_Retrabajo.AutoSize = true;
            this.lbl_Retrabajo.Location = new System.Drawing.Point(259, 28);
            this.lbl_Retrabajo.Name = "lbl_Retrabajo";
            this.lbl_Retrabajo.Size = new System.Drawing.Size(59, 13);
            this.lbl_Retrabajo.TabIndex = 2;
            this.lbl_Retrabajo.Text = "Retrabajo: ";
            // 
            // Secado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCaptura);
            this.Name = "Secado";
            this.Size = new System.Drawing.Size(878, 526);
            this.PanelCaptura.ResumeLayout(false);
            this.PanelCaptura.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Secado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCaptura;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.CheckBox CK_TB;
        private System.Windows.Forms.Label lbl_BatchWo;
        private System.Windows.Forms.TextBox txt_batchQ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Retrabajo;
        private System.Windows.Forms.Label lbl_Scope;
        private System.Windows.Forms.DataGridView dt_Secado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}
