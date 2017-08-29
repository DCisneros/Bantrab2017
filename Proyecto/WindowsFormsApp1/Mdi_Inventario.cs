using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Mdi_Inventario : Form
    {

        Datos_hardware dt_hw;
        vlan_grid vl;
        tipo_equipo tp_eq;
        Marca mark;
        Modelo mol;
        garantias_grid gar;
        vlan_grid v_lan;
        cluster cl;
        Tipos tp;
        Gabinetes gb;
        Rol rl;
        Lugares lg;
        Redes_y_Telecomunicaciones gr;
        Proveedor_de_Mantenimiento pm;
        tipo_equipo tq;
        Plataforma_TI_grid pl;
        Sistema_Operativo so;
        Dominio dom;
        Seguridad seg;
        Reporte_Redes rep_gest;

        public Mdi_Inventario()
        {
            InitializeComponent();
        }

        private void Mdi_Inventario_Load(object sender, EventArgs e)
        {
            
        }
        

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void datosDelHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
       

        private void tipoDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tp_eq == null)
            {
                tp_eq = new tipo_equipo();
                tp_eq.MdiParent = this;
                tp_eq.FormClosed += new FormClosedEventHandler(tp_eq_FormClosed);
                tp_eq.Show();
            }
        }
        void tp_eq_FormClosed(object sender, EventArgs e)
        {
            tp_eq = null;
        }

       

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mark == null)
            {
                mark = new Marca();
                mark.MdiParent = this;
                mark.FormClosed += new FormClosedEventHandler(mark_FormClosed);
                mark.Show();
            }
        }
        void mark_FormClosed(object sender, EventArgs e)
        {
            mark = null;
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( mol == null)
            {
                mol = new Modelo();
                mol.MdiParent = this;
                mol.FormClosed += new FormClosedEventHandler(mol_FormClosed);
                mol.Show();
            }
        }
        void mol_FormClosed(object sender, EventArgs e)
        {
            mol = null;
        }

        private void garantiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gar == null)
            {
                gar = new garantias_grid();
                gar.MdiParent = this;
                gar.FormClosed += new FormClosedEventHandler(gar_FormClosed);
                gar.Show();
            }

        }
        void gar_FormClosed(object sender, EventArgs e)
        {
            gar = null;
        }

        private void vLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (v_lan == null)
            {
                v_lan = new vlan_grid();
                v_lan.MdiParent = this;
                v_lan.FormClosed += new FormClosedEventHandler(v_lan_FormClosed);
                v_lan.Show();
            }
        }
        void v_lan_FormClosed(object sender, EventArgs e)
        {
            v_lan = null;
        }

        private void clusterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cl == null)
            {
                cl = new cluster();
                cl.MdiParent = this;
                cl.FormClosed += new FormClosedEventHandler(cluster_FormClosed);
                cl.Show();
            }
        }

        void cluster_FormClosed(object sender, EventArgs e)
        {
            cl = null;
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rl == null)
            {
                rl = new Rol();
                rl.MdiParent = this;
                rl.FormClosed += new FormClosedEventHandler(rol_FormClosed);
                rl.Show();
            }
        }

        void rol_FormClosed(object sender, EventArgs e)
        {
            rl = null;
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tp == null)
            {
                tp = new Tipos();
                tp.MdiParent = this;
                tp.FormClosed += new FormClosedEventHandler(tipos_FormClosed);
                tp.Show();
            }
        }

        void tipos_FormClosed(object sender, EventArgs e)
        {
            tp = null;
        }

        private void gabinetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gb == null)
            {
                gb = new Gabinetes();
                gb.MdiParent = this;
                gb.FormClosed += new FormClosedEventHandler(gabinete_FormClosed);
                gb.Show();
            }
        }

        void gabinete_FormClosed(object sender, EventArgs e)
        {
            gb = null;
        }

        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lg == null)
            {
                lg = new Lugares();
                lg.MdiParent = this;
                lg.FormClosed += new FormClosedEventHandler(lugares_FormClosed);
                lg.Show();
            }
        }

        void lugares_FormClosed(object sender, EventArgs e)
        {
            lg = null;
        }

        private void datoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dt_hw == null)
            {
                dt_hw = new Datos_hardware();
                dt_hw.MdiParent = this;
                dt_hw.FormClosed += new FormClosedEventHandler(dt_hw_FormClosed);
                dt_hw.Show();
            }
        }

        void dt_hw_FormClosed(object sender, EventArgs e)
        {
            dt_hw = null;
        }

        private void gestionDeRedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gr == null)
            {
                gr = new Redes_y_Telecomunicaciones();
                gr.MdiParent = this;
                gr.FormClosed += new FormClosedEventHandler(gestion_redes_FormClosed);
                gr.Show();
            }
        }
        void gestion_redes_FormClosed(object sender, EventArgs e)
        {
            gr = null;
        }

        private void proveedorDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pm == null)
            {
                pm = new Proveedor_de_Mantenimiento();
                pm.MdiParent = this;
                pm.FormClosed += new FormClosedEventHandler(prov_mante_FormClosed);
                pm.Show();
            }
        }
        void prov_mante_FormClosed(object sender, EventArgs e)
        {
            pm = null;
        }

        private void tipoDeEquipoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (tq == null)
            {
                tq = new tipo_equipo();
                tq.MdiParent = this;
                tq.FormClosed += new FormClosedEventHandler(tipo_equipo_FormClosed);
                tq.Show();
            }
        }

        void tipo_equipo_FormClosed(object sender, EventArgs e)
        {
            tq = null;
        }

        private void plataformaTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pl == null)
            {
                pl = new Plataforma_TI_grid();
                pl.MdiParent = this;
                pl.FormClosed += new FormClosedEventHandler(pla_ti_FormClosed);
                pl.Show();
            }
        }

        void pla_ti_FormClosed(object sender, EventArgs e)
        {
            pl = null;
        }

        private void sistemaOperativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (so == null)
            {
                so = new Sistema_Operativo();
                so.MdiParent = this;
                so.FormClosed += new FormClosedEventHandler(so_FormClosed);
                so.Show();
            }
        }

        void so_FormClosed(object sender, EventArgs e)
        {
            so = null;
        }

        private void dominioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dom == null)
            {
                dom = new Dominio();
                dom.MdiParent = this;
                dom.FormClosed += new FormClosedEventHandler(dom_FormClosed);
                dom.Show();
            }
        }

        void dom_FormClosed(object sender, EventArgs e)
        {
            dom = null;
        }

        private void seguridadInformaticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seg == null)
            {
                seg = new Seguridad();
                seg.MdiParent = this;
                seg.FormClosed += new FormClosedEventHandler(seg_FormClosed);
                seg.Show();
            }
        }

        void seg_FormClosed(object sender, EventArgs e)
        {
            seg = null;
        }

        private void vlanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (vl == null)
            {
                vl = new vlan_grid();
                vl.MdiParent = this;
                vl.FormClosed += new FormClosedEventHandler(vl_FormClosed);
                vl.Show();
            }
        }

        void vl_FormClosed(object sender, EventArgs e)
        {
            vl = null;
        }

        private void reporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_gest == null)
            {
                rep_gest = new Reporte_Redes();
                rep_gest.MdiParent = this;
                rep_gest.FormClosed += new FormClosedEventHandler(rep_gest_FormClosed);
                rep_gest.Show();
            }
        }

        void rep_gest_FormClosed(object sender, EventArgs e)
        {
            rep_gest = null;
        }
    }
}
