namespace WindowsFormsApp1
{
    partial class Mdi_Inventario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clusterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gabinetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorDeMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeRedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catalogoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.modelosToolStripMenuItem,
            this.clusterToolStripMenuItem,
            this.rolToolStripMenuItem,
            this.tipoToolStripMenuItem,
            this.gabinetesToolStripMenuItem,
            this.ubicacionToolStripMenuItem,
            this.datoDeInventarioToolStripMenuItem,
            this.proveedorDeMantenimientoToolStripMenuItem,
            this.tipoDeEquipoToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            this.catalogoToolStripMenuItem.Click += new System.EventHandler(this.catalogoToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.modelosToolStripMenuItem.Text = "Modelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // clusterToolStripMenuItem
            // 
            this.clusterToolStripMenuItem.Name = "clusterToolStripMenuItem";
            this.clusterToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.clusterToolStripMenuItem.Text = "Cluster";
            this.clusterToolStripMenuItem.Click += new System.EventHandler(this.clusterToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.tipoToolStripMenuItem.Text = "Tipo";
            this.tipoToolStripMenuItem.Click += new System.EventHandler(this.tipoToolStripMenuItem_Click);
            // 
            // gabinetesToolStripMenuItem
            // 
            this.gabinetesToolStripMenuItem.Name = "gabinetesToolStripMenuItem";
            this.gabinetesToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.gabinetesToolStripMenuItem.Text = "Gabinetes";
            this.gabinetesToolStripMenuItem.Click += new System.EventHandler(this.gabinetesToolStripMenuItem_Click);
            // 
            // ubicacionToolStripMenuItem
            // 
            this.ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            this.ubicacionToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.ubicacionToolStripMenuItem.Text = "Ubicacion";
            this.ubicacionToolStripMenuItem.Click += new System.EventHandler(this.ubicacionToolStripMenuItem_Click);
            // 
            // datoDeInventarioToolStripMenuItem
            // 
            this.datoDeInventarioToolStripMenuItem.Name = "datoDeInventarioToolStripMenuItem";
            this.datoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.datoDeInventarioToolStripMenuItem.Text = "Dato de Inventario";
            this.datoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.datoDeInventarioToolStripMenuItem_Click);
            // 
            // proveedorDeMantenimientoToolStripMenuItem
            // 
            this.proveedorDeMantenimientoToolStripMenuItem.Name = "proveedorDeMantenimientoToolStripMenuItem";
            this.proveedorDeMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.proveedorDeMantenimientoToolStripMenuItem.Text = "Proveedor de Mantenimiento";
            this.proveedorDeMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.proveedorDeMantenimientoToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.gestionDeRedesToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // gestionDeRedesToolStripMenuItem
            // 
            this.gestionDeRedesToolStripMenuItem.Name = "gestionDeRedesToolStripMenuItem";
            this.gestionDeRedesToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.gestionDeRedesToolStripMenuItem.Text = "Gestion de Redes";
            this.gestionDeRedesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeRedesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeInventarioToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeInventarioToolStripMenuItem
            // 
            this.reporteDeInventarioToolStripMenuItem.Name = "reporteDeInventarioToolStripMenuItem";
            this.reporteDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.reporteDeInventarioToolStripMenuItem.Text = "Reporte de Inventario";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tipoDeEquipoToolStripMenuItem
            // 
            this.tipoDeEquipoToolStripMenuItem.Name = "tipoDeEquipoToolStripMenuItem";
            this.tipoDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.tipoDeEquipoToolStripMenuItem.Text = "Tipo de Equipo";
            this.tipoDeEquipoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeEquipoToolStripMenuItem_Click_1);
            // 
            // Mdi_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(760, 482);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mdi_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI_Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mdi_Inventario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clusterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gabinetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeRedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorDeMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEquipoToolStripMenuItem;
    }
}

