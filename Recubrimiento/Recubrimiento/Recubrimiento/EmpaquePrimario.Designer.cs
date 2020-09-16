namespace Recubrimiento
{
    partial class EmpaquePrimario
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NumSerie = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Batch = new System.Windows.Forms.TextBox();
            this.lbl_Batch = new System.Windows.Forms.Label();
            this.txt_Material = new System.Windows.Forms.TextBox();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.lbl_WO = new System.Windows.Forms.Label();
            this.PanelValidacion = new System.Windows.Forms.Panel();
            this.btn_Correcion = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            this.PanelValidacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentPanel.Controls.Add(this.PanelValidacion);
            this.ContentPanel.Controls.Add(this.btn_Buscar);
            this.ContentPanel.Controls.Add(this.txt_Batch);
            this.ContentPanel.Controls.Add(this.lbl_Batch);
            this.ContentPanel.Controls.Add(this.txtWO);
            this.ContentPanel.Controls.Add(this.lbl_WO);
            this.ContentPanel.Location = new System.Drawing.Point(3, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(827, 554);
            this.ContentPanel.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(502, 55);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(163, 23);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero de Serie";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(275, 81);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 10;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad de Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Material (p/n)";
            // 
            // txt_NumSerie
            // 
            this.txt_NumSerie.Location = new System.Drawing.Point(278, 31);
            this.txt_NumSerie.Name = "txt_NumSerie";
            this.txt_NumSerie.Size = new System.Drawing.Size(163, 20);
            this.txt_NumSerie.TabIndex = 7;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(278, 97);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(242, 47);
            this.txt_Descripcion.TabIndex = 6;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(19, 97);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(163, 20);
            this.txt_Cantidad.TabIndex = 5;
            // 
            // txt_Batch
            // 
            this.txt_Batch.Location = new System.Drawing.Point(251, 57);
            this.txt_Batch.Name = "txt_Batch";
            this.txt_Batch.Size = new System.Drawing.Size(163, 20);
            this.txt_Batch.TabIndex = 4;
            // 
            // lbl_Batch
            // 
            this.lbl_Batch.AutoSize = true;
            this.lbl_Batch.Location = new System.Drawing.Point(248, 41);
            this.lbl_Batch.Name = "lbl_Batch";
            this.lbl_Batch.Size = new System.Drawing.Size(76, 13);
            this.lbl_Batch.TabIndex = 3;
            this.lbl_Batch.Text = "Batch Quimico";
            // 
            // txt_Material
            // 
            this.txt_Material.Location = new System.Drawing.Point(19, 31);
            this.txt_Material.Name = "txt_Material";
            this.txt_Material.Size = new System.Drawing.Size(162, 20);
            this.txt_Material.TabIndex = 1;
            // 
            // txtWO
            // 
            this.txtWO.Location = new System.Drawing.Point(47, 57);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(162, 20);
            this.txtWO.TabIndex = 0;
            // 
            // lbl_WO
            // 
            this.lbl_WO.AutoSize = true;
            this.lbl_WO.Location = new System.Drawing.Point(47, 41);
            this.lbl_WO.Name = "lbl_WO";
            this.lbl_WO.Size = new System.Drawing.Size(26, 13);
            this.lbl_WO.TabIndex = 2;
            this.lbl_WO.Text = "WO";
            // 
            // PanelValidacion
            // 
            this.PanelValidacion.Controls.Add(this.btn_Correcion);
            this.PanelValidacion.Controls.Add(this.label1);
            this.PanelValidacion.Controls.Add(this.txt_Material);
            this.PanelValidacion.Controls.Add(this.label4);
            this.PanelValidacion.Controls.Add(this.txt_Cantidad);
            this.PanelValidacion.Controls.Add(this.lbl_Descripcion);
            this.PanelValidacion.Controls.Add(this.txt_Descripcion);
            this.PanelValidacion.Controls.Add(this.label2);
            this.PanelValidacion.Controls.Add(this.txt_NumSerie);
            this.PanelValidacion.Location = new System.Drawing.Point(47, 137);
            this.PanelValidacion.Name = "PanelValidacion";
            this.PanelValidacion.Size = new System.Drawing.Size(618, 254);
            this.PanelValidacion.TabIndex = 13;
            this.PanelValidacion.Visible = false;
            // 
            // btn_Correcion
            // 
            this.btn_Correcion.Location = new System.Drawing.Point(529, 216);
            this.btn_Correcion.Name = "btn_Correcion";
            this.btn_Correcion.Size = new System.Drawing.Size(75, 23);
            this.btn_Correcion.TabIndex = 14;
            this.btn_Correcion.Text = "Corregir";
            this.btn_Correcion.UseVisualStyleBackColor = true;
            // 
            // EmpaquePrimario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Name = "EmpaquePrimario";
            this.Size = new System.Drawing.Size(833, 554);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.PanelValidacion.ResumeLayout(false);
            this.PanelValidacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NumSerie;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Batch;
        private System.Windows.Forms.Label lbl_Batch;
        private System.Windows.Forms.TextBox txt_Material;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.Label lbl_WO;
        private System.Windows.Forms.Panel PanelValidacion;
        private System.Windows.Forms.Button btn_Correcion;
    }
}
