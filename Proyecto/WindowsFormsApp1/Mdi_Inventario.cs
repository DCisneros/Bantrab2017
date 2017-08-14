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

        hardware_grid hw;
        Datos_hardware dt_hw;
        tipo_equipo tp_eq;
        Tipo_Hardware tp_hw;
        lugares_grid l_grid;
        Marca mark;
        Modelo mol;
        Proveedores_grid prov_grid;
        Interfaz_red int_red;
        garantias_grid gar;
        vlan_grid v_lan;


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

        private void hardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hw == null)
            {
                hw = new hardware_grid();
                hw.MdiParent = this.MdiParent;
                hw.FormClosed += new FormClosedEventHandler(hw_FormClosed);
                hw.Show();
            }
        }
        void hw_FormClosed(object sender, EventArgs e)
        {
            hw = null;
        }

        private void datosDelHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dt_hw == null)
            {
                dt_hw = new Datos_hardware();
                dt_hw.MdiParent = MdiParent;
                dt_hw.FormClosed += new FormClosedEventHandler(dt_hw_FormClosed);
                dt_hw.Show();
            }
        }
        void dt_hw_FormClosed(object sender, EventArgs e)
        {
            dt_hw = null;
        }

        private void tipoDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tp_eq == null)
            {
                tp_eq = new tipo_equipo();
                tp_eq.MdiParent = this.MdiParent;
                tp_eq.FormClosed += new FormClosedEventHandler(tp_eq_FormClosed);
                tp_eq.Show();
            }
        }
        void tp_eq_FormClosed(object sender, EventArgs e)
        {
            tp_eq = null;
        }

        private void tipoDeHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tp_hw == null)
            {
                tp_hw = new Tipo_Hardware();
                tp_hw.MdiParent = this.MdiParent;
                tp_hw.FormClosed += new FormClosedEventHandler(tp_hw_FormClosed);
                tp_hw.Show();
            }
        }
        void tp_hw_FormClosed(object sender, EventArgs e)
        {
            tp_hw = null;
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mark == null)
            {
                mark = new Marca();
                mark.MdiParent = this.MdiParent;
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
                mol.MdiParent = this.MdiParent;
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
                gar.MdiParent = this.MdiParent;
                gar.FormClosed += new FormClosedEventHandler(gar_FormClosed);
                gar.Show();
            }

        }
        void gar_FormClosed(object sender, EventArgs e)
        {
            gar = null;
        }

        private void interfazDeRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int_red == null)
            {
                int_red = new Interfaz_red();
                int_red.MdiParent = this.MdiParent;
                int_red.FormClosed += new FormClosedEventHandler(int_red_FormClosed);
                int_red.Show();
            }
        }
        void int_red_FormClosed(object sender, EventArgs e)
        {
            int_red = null;
        }

        private void establecimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l_grid == null)
            {
                l_grid = new lugares_grid();
                l_grid.MdiParent = this.MdiParent;
                l_grid.FormClosed += new FormClosedEventHandler(l_grid_FormClosed);
                l_grid.Show();
            }
        }
        void l_grid_FormClosed(object sender, EventArgs e)
        {
            l_grid = null;
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (prov_grid == null)
            {
                prov_grid = new Proveedores_grid();
                prov_grid.MdiParent = this.MdiParent;
                prov_grid.FormClosed += new FormClosedEventHandler(prov_grid_FormClosed);
                prov_grid.Show();
            }
        }
        void prov_grid_FormClosed(object sender, EventArgs e)
        {
            prov_grid = null;
        }

        private void vLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (v_lan == null)
            {
                v_lan = new vlan_grid();
                v_lan.MdiParent = this.MdiParent;
                v_lan.FormClosed += new FormClosedEventHandler(v_lan_FormClosed);
                v_lan.Show();
            }
        }
        void v_lan_FormClosed(object sender, EventArgs e)
        {
            v_lan = null;
        }

       
    }
}
