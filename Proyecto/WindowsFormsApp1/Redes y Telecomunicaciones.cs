using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncionesNavegador;
using System.Data.Odbc;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Redes_y_Telecomunicaciones : Form
    {
        public Redes_y_Telecomunicaciones()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
        String Codigo;
        String atributo;


        string id_gestion, nombre_gest, mant_real, fecha_gar, id_marca, id_modelo, id_ubicacion, id_prov_mant, id_tipo;
        int modificar =0;


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar = true;
            id_gestion = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nombre_gest = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mant_real = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fecha_gar = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            id_marca = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            id_modelo = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            id_ubicacion = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            id_prov_mant = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            id_tipo = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            modificar = 1;
            Gestion_de_Redes a = new Gestion_de_Redes(dataGridView1, id_gestion, nombre_gest, mant_real, fecha_gar, id_marca, id_modelo, id_ubicacion, id_prov_mant, id_tipo, Editar, modificar);
            a.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Gestion_de_Redes a = new Gestion_de_Redes(dataGridView1, id_gestion, nombre_gest, mant_real, fecha_gar, id_marca, id_modelo, id_ubicacion, id_prov_mant, id_tipo, Editar, modificar);
            a.StartPosition = FormStartPosition.CenterScreen;
            a.MdiParent = this.ParentForm;
            a.Show();
        }


        public void actualizar()
        {
            string tabla = "gestion_redes";
            fn.ActualizarGrid(dataGridView1, "SELECT DISTINCT GR.id_gestion_redes_pk, GR.nombre_gest, GR.mant_real_por, GR.fecha_inicio_garantia, M.id_marca_pk, M.nombre_marca, MD.id_modelo_pk, MD.nombre_modelo, U.id_ubicacion_pk, U.nombre, U.detalle, PM.id_prov_mante_pk, PM.nombre_prov_mant, TE.id_tipo_equipo_pk, TE.nombre_tipo FROM gestion_redes GR, detalle_general DT, marca M, modelo MD, ubicacion U, proveedor_mantenimiento PM, tipo_equipo TE WHERE GR.id_marca_pk = M.id_marca_pk AND MD.id_modelo_pk = GR.id_modelo_pk AND U.id_ubicacion_pk = GR.id_ubicacion_pk AND PM.id_prov_mante_pk = GR.id_prov_mante_pk AND TE.id_tipo_equipo_pk = GR.id_tipo_equipo_pk AND GR.estado <> 'INACTIVO'", tabla);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "gestion_redes";
            fn.ActualizarGrid(dataGridView1, "SELECT DISTINCT GR.id_gestion_redes_pk, GR.nombre_gest, GR.mant_real_por, GR.fecha_inicio_garantia, M.id_marca_pk, M.nombre_marca, MD.id_modelo_pk, MD.nombre_modelo, U.id_ubicacion_pk, U.nombre, U.detalle, PM.id_prov_mante_pk, PM.nombre_prov_mant, TE.id_tipo_equipo_pk, TE.nombre_tipo FROM gestion_redes GR, detalle_general DT, marca M, modelo MD, ubicacion U, proveedor_mantenimiento PM, tipo_equipo TE WHERE GR.id_marca_pk = M.id_marca_pk AND MD.id_modelo_pk = GR.id_modelo_pk AND U.id_ubicacion_pk = GR.id_ubicacion_pk AND PM.id_prov_mante_pk = GR.id_prov_mante_pk AND TE.id_tipo_equipo_pk = GR.id_tipo_equipo_pk AND GR.estado <> 'INACTIVO'", tabla);
        }

        private void Redes_y_Telecomunicaciones_Load(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
