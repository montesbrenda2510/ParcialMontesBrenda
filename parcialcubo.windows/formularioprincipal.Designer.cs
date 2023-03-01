
namespace parcialcubo.windows
{
    partial class formularioprincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioprincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nuevoButton = new System.Windows.Forms.ToolStripButton();
            this.editarButton = new System.Windows.Forms.ToolStripButton();
            this.borrarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filtarButton = new System.Windows.Forms.ToolStripButton();
            this.refrescarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ordenarButton = new System.Windows.Forms.ToolStripButton();
            this.SalirButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColArista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoButton,
            this.editarButton,
            this.borrarButton,
            this.toolStripSeparator1,
            this.filtarButton,
            this.refrescarButton,
            this.toolStripSeparator2,
            this.ordenarButton,
            this.SalirButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(753, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nuevoButton
            // 
            this.nuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoButton.Image")));
            this.nuevoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(46, 35);
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Image = ((System.Drawing.Image)(resources.GetObject("editarButton.Image")));
            this.editarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(41, 35);
            this.editarButton.Text = "Editar";
            this.editarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // borrarButton
            // 
            this.borrarButton.Image = ((System.Drawing.Image)(resources.GetObject("borrarButton.Image")));
            this.borrarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(43, 35);
            this.borrarButton.Text = "Borrar";
            this.borrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // filtarButton
            // 
            this.filtarButton.Image = ((System.Drawing.Image)(resources.GetObject("filtarButton.Image")));
            this.filtarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtarButton.Name = "filtarButton";
            this.filtarButton.Size = new System.Drawing.Size(41, 35);
            this.filtarButton.Text = "Filtrar";
            this.filtarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // refrescarButton
            // 
            this.refrescarButton.Image = ((System.Drawing.Image)(resources.GetObject("refrescarButton.Image")));
            this.refrescarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refrescarButton.Name = "refrescarButton";
            this.refrescarButton.Size = new System.Drawing.Size(59, 35);
            this.refrescarButton.Text = "Refrescar";
            this.refrescarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // ordenarButton
            // 
            this.ordenarButton.Image = ((System.Drawing.Image)(resources.GetObject("ordenarButton.Image")));
            this.ordenarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ordenarButton.Name = "ordenarButton";
            this.ordenarButton.Size = new System.Drawing.Size(54, 35);
            this.ordenarButton.Text = "Ordenar";
            this.ordenarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SalirButton
            // 
            this.SalirButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirButton.Image")));
            this.SalirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(33, 35);
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColArista,
            this.ColRelleno,
            this.ColTrazo,
            this.ColArea,
            this.ColVolumen});
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(766, 412);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColArista
            // 
            this.ColArista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColArista.HeaderText = "Arista";
            this.ColArista.Name = "ColArista";
            this.ColArista.ReadOnly = true;
            // 
            // ColRelleno
            // 
            this.ColRelleno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRelleno.HeaderText = "Relleno";
            this.ColRelleno.Name = "ColRelleno";
            this.ColRelleno.ReadOnly = true;
            // 
            // ColTrazo
            // 
            this.ColTrazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTrazo.HeaderText = "Trazo";
            this.ColTrazo.Name = "ColTrazo";
            this.ColTrazo.ReadOnly = true;
            // 
            // ColArea
            // 
            this.ColArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColArea.HeaderText = "Area";
            this.ColArea.Name = "ColArea";
            this.ColArea.ReadOnly = true;
            // 
            // ColVolumen
            // 
            this.ColVolumen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColVolumen.HeaderText = "Volumen";
            this.ColVolumen.Name = "ColVolumen";
            this.ColVolumen.ReadOnly = true;
            // 
            // formularioprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 251);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "formularioprincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formularioprincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nuevoButton;
        private System.Windows.Forms.ToolStripButton editarButton;
        private System.Windows.Forms.ToolStripButton borrarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton filtarButton;
        private System.Windows.Forms.ToolStripButton refrescarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ordenarButton;
        private System.Windows.Forms.ToolStripButton SalirButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVolumen;
    }
}

