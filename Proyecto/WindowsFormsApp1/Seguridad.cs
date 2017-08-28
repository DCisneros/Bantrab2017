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
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
        String Codigo;
        String atributo;

        string id_infra, id_marca, id_modelo, id_so, id_prov_man, id_rol, id_cluster, id_ubicacion, id_gabinete, id_tipo, id_dominio, nombre_infra, mante;

        private void Seguridad_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        int modificar = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar = true;
            id_infra = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nombre_infra = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mante = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            id_marca = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            id_modelo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            id_so = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            id_rol = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            id_dominio = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            id_tipo = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            id_gabinete = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            id_ubicacion = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            id_prov_man = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            id_cluster = dataGridView1.CurrentRow.Cells[23].Value.ToString();

            modificar = 1;
            Seguridad_Informatica a = new Seguridad_Informatica(dataGridView1, id_infra, nombre_infra, mante, id_marca, id_modelo, id_so, id_rol, id_dominio, id_tipo, id_gabinete, id_ubicacion, id_prov_man, id_cluster, Editar, modificar);
            a.Show();
        }

        public void actualizar()
        {
            string tabla = "infraestructura";
            fn.ActualizarGrid(dataGridView1, "SELECT DISTINCT INF.id_infra_pk, INF.nombre_infra, INF.mantenimiento, M.id_marca_pk, M.nombre_marca, MD.id_modelo_pk, MD.nombre_modelo, SO.id_so_pk, SO.nombre_so, SO.version_so, RL.id_rol_pk, RL.nombre_rol, DOM.id_dominio_pk, DOM.nombre_dominio, TP.id_tipo_pk, TP.nombre_tipo, GA.id_gabinete_pk, GA.nombre_gabinete, UB.id_ubicacion_pk, UB.nombre, UB.detalle, PM.id_prov_mante_pk, PM.nombre_prov_mant, CL.id_cluster_pk, CL.nombre_cluster  FROM infraestructura INF, marca M, modelo MD, sistema_operativo SO, rol RL, dominio DOM, ubicacion UB, tipo TP, cluster CL, gabinete GA, proveedor_mantenimiento PM WHERE INF.id_marca_pk = M.id_marca_pk AND INF.id_modelo_pk = MD.id_modelo_pk AND INF.id_so_pk = SO.id_so_pk AND INF.id_tipo_pk = TP.id_tipo_pk AND INF.id_prov_mante_pk = PM.id_prov_mante_pk AND INF.id_gabinete_pk = GA.id_gabinete_pk AND INF.id_dominio_pk = DOM.id_dominio_pk AND INF.id_rol_pk = RL.id_rol_pk AND INF.id_cluster_pk = CL.id_cluster_pk AND INF.id_ubicacion_pk = UB.id_ubicacion_pk AND INF.id_cluster_pk = CL.id_cluster_pk AND INF.estado <> 'INACTIVO' and INF.id_clasi_inv_pk = '2'", tabla);

        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Seguridad_Informatica a = new Seguridad_Informatica(dataGridView1, id_infra, nombre_infra, mante, id_marca, id_modelo, id_so, id_rol, id_dominio, id_tipo, id_gabinete, id_ubicacion, id_prov_man, id_cluster, Editar, modificar);
            a.StartPosition = FormStartPosition.CenterScreen;
            a.MdiParent = this.ParentForm;
            a.Show();
        }
    }
}
