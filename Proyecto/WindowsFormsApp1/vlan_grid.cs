using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using FuncionesNavegador;

namespace WindowsFormsApp1
{
    public partial class vlan_grid : Form
    {
        public vlan_grid()
        {
            InitializeComponent();
        }

        string id_vlan, vlan, nombre_vlan, segmento, mask, puerta_enlace, descripcion, id_ubicacion;

        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
       


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Editar1 = false;
                vlan a = new vlan(dgv_capacitacion, id_vlan, vlan, nombre_vlan, segmento, mask, puerta_enlace, descripcion, id_ubicacion, Editar);

                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void actualizar()
        {
            string tabla = "vlan";
            fn.ActualizarGrid(dgv_capacitacion, "SELECT VL.id_vlan_pk, VL.vlan, VL.nombre_vlan, VL.segmento, VL.mascara, VL.puerta_enlace, VL.descripcion, VL.id_ubicacion_pk, UB.nombre, UB.detalle FROM vlan VL, ubicacion UB WHERE VL.id_ubicacion_pk = UB.id_ubicacion_pk AND VL.estado <> 'INACTIVO'", tabla);
        }

        private void vlan_grid_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void dgv_capacitacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar = true;
            id_vlan = dgv_capacitacion.CurrentRow.Cells[0].Value.ToString();
            vlan = dgv_capacitacion.CurrentRow.Cells[1].Value.ToString();
            nombre_vlan = dgv_capacitacion.CurrentRow.Cells[2].Value.ToString();
            segmento = dgv_capacitacion.CurrentRow.Cells[3].Value.ToString();
            mask = dgv_capacitacion.CurrentRow.Cells[4].Value.ToString();
            puerta_enlace = dgv_capacitacion.CurrentRow.Cells[5].Value.ToString();
            descripcion = dgv_capacitacion.CurrentRow.Cells[6].Value.ToString();
            id_ubicacion = dgv_capacitacion.CurrentRow.Cells[7].Value.ToString();

            vlan a = new vlan(dgv_capacitacion, id_vlan, vlan, nombre_vlan, segmento, mask, puerta_enlace, descripcion, id_ubicacion, Editar);
            a.Show();

        }

        private void gpb_navegador_Enter(object sender, EventArgs e)
        {

        }
    }
}
