namespace Recubrimiento
{
    partial class SetUp
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
            this.PnCapBatch = new System.Windows.Forms.Panel();
            this.lbl_BatchQuimico = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_BatchQuimico = new System.Windows.Forms.TextBox();
            this.lbl_WO = new System.Windows.Forms.Label();
            this.txt_WO = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelCapProceso = new System.Windows.Forms.Panel();
            this.btn_BuscarWO = new System.Windows.Forms.Button();
            this.PnCapBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelCapProceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnCapBatch
            // 
            this.PnCapBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnCapBatch.Controls.Add(this.lbl_BatchQuimico);
            this.PnCapBatch.Controls.Add(this.btn_Buscar);
            this.PnCapBatch.Controls.Add(this.txt_BatchQuimico);
            this.PnCapBatch.Location = new System.Drawing.Point(0, 1);
            this.PnCapBatch.Name = "PnCapBatch";
            this.PnCapBatch.Size = new System.Drawing.Size(243, 552);
            this.PnCapBatch.TabIndex = 0;
            // 
            // lbl_BatchQuimico
            // 
            this.lbl_BatchQuimico.AutoSize = true;
            this.lbl_BatchQuimico.Location = new System.Drawing.Point(23, 33);
            this.lbl_BatchQuimico.Name = "lbl_BatchQuimico";
            this.lbl_BatchQuimico.Size = new System.Drawing.Size(76, 13);
            this.lbl_BatchQuimico.TabIndex = 2;
            this.lbl_BatchQuimico.Text = "Batch Quimico";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(52, 107);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_BatchQuimico
            // 
            this.txt_BatchQuimico.Location = new System.Drawing.Point(23, 52);
            this.txt_BatchQuimico.Name = "txt_BatchQuimico";
            this.txt_BatchQuimico.Size = new System.Drawing.Size(200, 20);
            this.txt_BatchQuimico.TabIndex = 0;
            // 
            // lbl_WO
            // 
            this.lbl_WO.AutoSize = true;
            this.lbl_WO.Location = new System.Drawing.Point(22, 31);
            this.lbl_WO.Name = "lbl_WO";
            this.lbl_WO.Size = new System.Drawing.Size(26, 13);
            this.lbl_WO.TabIndex = 4;
            this.lbl_WO.Text = "WO";
            // 
            // txt_WO
            // 
            this.txt_WO.Location = new System.Drawing.Point(22, 50);
            this.txt_WO.Name = "txt_WO";
            this.txt_WO.Size = new System.Drawing.Size(200, 20);
            this.txt_WO.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.CantidadOrden,
            this.Descripcion});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.Width = 173;
            // 
            // CantidadOrden
            // 
            this.CantidadOrden.HeaderText = "Cantidad";
            this.CantidadOrden.Name = "CantidadOrden";
            this.CantidadOrden.Width = 172;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 173;
            // 
            // PanelCapProceso
            // 
            this.PanelCapProceso.Controls.Add(this.btn_BuscarWO);
            this.PanelCapProceso.Controls.Add(this.lbl_WO);
            this.PanelCapProceso.Controls.Add(this.txt_WO);
            this.PanelCapProceso.Controls.Add(this.dataGridView1);
            this.PanelCapProceso.Location = new System.Drawing.Point(249, 3);
            this.PanelCapProceso.Name = "PanelCapProceso";
            this.PanelCapProceso.Size = new System.Drawing.Size(583, 549);
            this.PanelCapProceso.TabIndex = 1;
            // 
            // btn_BuscarWO
            // 
            this.btn_BuscarWO.Location = new System.Drawing.Point(266, 47);
            this.btn_BuscarWO.Name = "btn_BuscarWO";
            this.btn_BuscarWO.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarWO.TabIndex = 5;
            this.btn_BuscarWO.Text = "Buscar";
            this.btn_BuscarWO.UseVisualStyleBackColor = true;
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.PanelCapProceso);
            this.Controls.Add(this.PnCapBatch);
            this.Name = "SetUp";
            this.Size = new System.Drawing.Size(833, 554);
            this.PnCapBatch.ResumeLayout(false);
            this.PnCapBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelCapProceso.ResumeLayout(false);
            this.PanelCapProceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnCapBatch;
        private System.Windows.Forms.Label lbl_BatchQuimico;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_BatchQuimico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label lbl_WO;
        private System.Windows.Forms.TextBox txt_WO;
        private System.Windows.Forms.Panel PanelCapProceso;
        private System.Windows.Forms.Button btn_BuscarWO;
    }
}
