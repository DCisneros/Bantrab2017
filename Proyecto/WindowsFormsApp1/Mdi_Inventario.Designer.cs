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
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelHardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeHardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garantiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfazDeRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.establecimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vLANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
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
            this.hardwareToolStripMenuItem,
            this.datosDelHardwareToolStripMenuItem,
            this.tipoDeEquipoToolStripMenuItem,
            this.tipoDeHardwareToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.modelosToolStripMenuItem,
            this.garantiasToolStripMenuItem,
            this.interfazDeRedToolStripMenuItem,
            this.establecimientosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.vLANToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            this.catalogoToolStripMenuItem.Click += new System.EventHandler(this.catalogoToolStripMenuItem_Click);
            // 
            // hardwareToolStripMenuItem
            // 
            this.hardwareToolStripMenuItem.Name = "hardwareToolStripMenuItem";
            this.hardwareToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.hardwareToolStripMenuItem.Text = "Hardware";
            this.hardwareToolStripMenuItem.Click += new System.EventHandler(this.hardwareToolStripMenuItem_Click);
            // 
            // datosDelHardwareToolStripMenuItem
            // 
            this.datosDelHardwareToolStripMenuItem.Name = "datosDelHardwareToolStripMenuItem";
            this.datosDelHardwareToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.datosDelHardwareToolStripMenuItem.Text = "Datos del Hardware";
            this.datosDelHardwareToolStripMenuItem.Click += new System.EventHandler(this.datosDelHardwareToolStripMenuItem_Click);
            // 
            // tipoDeEquipoToolStripMenuItem
            // 
            this.tipoDeEquipoToolStripMenuItem.Name = "tipoDeEquipoToolStripMenuItem";
            this.tipoDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.tipoDeEquipoToolStripMenuItem.Text = "Tipo de Equipo";
            this.tipoDeEquipoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeEquipoToolStripMenuItem_Click);
            // 
            // tipoDeHardwareToolStripMenuItem
            // 
            this.tipoDeHardwareToolStripMenuItem.Name = "tipoDeHardwareToolStripMenuItem";
            this.tipoDeHardwareToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.tipoDeHardwareToolStripMenuItem.Text = "Tipo de Hardware";
            this.tipoDeHardwareToolStripMenuItem.Click += new System.EventHandler(this.tipoDeHardwareToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.modelosToolStripMenuItem.Text = "Modelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // garantiasToolStripMenuItem
            // 
            this.garantiasToolStripMenuItem.Name = "garantiasToolStripMenuItem";
            this.garantiasToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.garantiasToolStripMenuItem.Text = "Garantias";
            this.garantiasToolStripMenuItem.Click += new System.EventHandler(this.garantiasToolStripMenuItem_Click);
            // 
            // interfazDeRedToolStripMenuItem
            // 
            this.interfazDeRedToolStripMenuItem.Name = "interfazDeRedToolStripMenuItem";
            this.interfazDeRedToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.interfazDeRedToolStripMenuItem.Text = "Interfaz de Red";
            this.interfazDeRedToolStripMenuItem.Click += new System.EventHandler(this.interfazDeRedToolStripMenuItem_Click);
            // 
            // establecimientosToolStripMenuItem
            // 
            this.establecimientosToolStripMenuItem.Name = "establecimientosToolStripMenuItem";
            this.establecimientosToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.establecimientosToolStripMenuItem.Text = "Establecimientos";
            this.establecimientosToolStripMenuItem.Click += new System.EventHandler(this.establecimientosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.exportarToolStripMenuItem.Text = "Exportar";
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
            // vLANToolStripMenuItem
            // 
            this.vLANToolStripMenuItem.Name = "vLANToolStripMenuItem";
            this.vLANToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.vLANToolStripMenuItem.Text = "VLAN";
            this.vLANToolStripMenuItem.Click += new System.EventHandler(this.vLANToolStripMenuItem_Click);
            // 
            // Mdi_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(760, 482);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mdi_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI_Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem hardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeHardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelHardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garantiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfazDeRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem establecimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vLANToolStripMenuItem;
    }
}

