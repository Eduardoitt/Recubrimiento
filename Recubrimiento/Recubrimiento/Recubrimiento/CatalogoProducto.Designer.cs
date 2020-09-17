namespace Recubrimiento
{
    partial class CatalogoProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pn = new System.Windows.Forms.TextBox();
            this.lbl_pn = new System.Windows.Forms.Label();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.ck_Activo = new System.Windows.Forms.CheckBox();
            this.lbl_CantidadPC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Batchq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Busqueda);
            this.panel1.Controls.Add(this.lbl_pn);
            this.panel1.Controls.Add(this.txt_pn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 554);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lbl_CantidadPC);
            this.panel2.Controls.Add(this.ck_Activo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(261, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 554);
            this.panel2.TabIndex = 1;
            // 
            // txt_pn
            // 
            this.txt_pn.Location = new System.Drawing.Point(17, 52);
            this.txt_pn.Name = "txt_pn";
            this.txt_pn.Size = new System.Drawing.Size(204, 20);
            this.txt_pn.TabIndex = 0;
            // 
            // lbl_pn
            // 
            this.lbl_pn.AutoSize = true;
            this.lbl_pn.Location = new System.Drawing.Point(17, 33);
            this.lbl_pn.Name = "lbl_pn";
            this.lbl_pn.Size = new System.Drawing.Size(66, 13);
            this.lbl_pn.TabIndex = 1;
            this.lbl_pn.Text = "Part Nomber";
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.Location = new System.Drawing.Point(20, 87);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Size = new System.Drawing.Size(75, 23);
            this.btn_Busqueda.TabIndex = 2;
            this.btn_Busqueda.Text = "Buscar";
            this.btn_Busqueda.UseVisualStyleBackColor = true;
            // 
            // ck_Activo
            // 
            this.ck_Activo.AutoSize = true;
            this.ck_Activo.Location = new System.Drawing.Point(13, 36);
            this.ck_Activo.Name = "ck_Activo";
            this.ck_Activo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ck_Activo.Size = new System.Drawing.Size(61, 17);
            this.ck_Activo.TabIndex = 1;
            this.ck_Activo.Text = "Estatus";
            this.ck_Activo.UseVisualStyleBackColor = true;
            // 
            // lbl_CantidadPC
            // 
            this.lbl_CantidadPC.AutoSize = true;
            this.lbl_CantidadPC.Location = new System.Drawing.Point(227, 33);
            this.lbl_CantidadPC.Name = "lbl_CantidadPC";
            this.lbl_CantidadPC.Size = new System.Drawing.Size(97, 13);
            this.lbl_CantidadPC.TabIndex = 2;
            this.lbl_CantidadPC.Text = "Piesas por corrida: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Escaneo en Secado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Batchq,
            this.WO});
            this.dataGridView1.Location = new System.Drawing.Point(218, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 108);
            this.dataGridView1.TabIndex = 5;
            // 
            // Batchq
            // 
            this.Batchq.HeaderText = "Batch Quimico";
            this.Batchq.Name = "Batchq";
            // 
            // WO
            // 
            this.WO.HeaderText = "WO";
            this.WO.Name = "WO";
            // 
            // CatalogoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CatalogoProducto";
            this.Size = new System.Drawing.Size(833, 554);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Busqueda;
        private System.Windows.Forms.Label lbl_pn;
        private System.Windows.Forms.TextBox txt_pn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_CantidadPC;
        private System.Windows.Forms.CheckBox ck_Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batchq;
        private System.Windows.Forms.DataGridViewTextBoxColumn WO;
    }
}
