using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using System.Data.Odbc;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Reporte_Redes : Form
    {
        public Reporte_Redes()
        {
            InitializeComponent();
            
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        

        public void actualizar()
        {
            string tabla = "gestion_redes";
            fn.ActualizarGrid(dataGridView1, "SELECT DISTINCT GR.id_gestion_redes_pk, GR.nombre_gest, GR.mant_real_por, GR.fecha_inicio_garantia, M.nombre_marca, MD.nombre_modelo, U.nombre, U.detalle AS Nivel, PM.nombre_prov_mant, TE.nombre_tipo FROM gestion_redes GR, detalle_general DT, marca M, modelo MD, ubicacion U, proveedor_mantenimiento PM, tipo_equipo TE WHERE GR.id_marca_pk = M.id_marca_pk AND MD.id_modelo_pk = GR.id_modelo_pk AND U.id_ubicacion_pk = GR.id_ubicacion_pk AND PM.id_prov_mante_pk = GR.id_prov_mante_pk AND TE.id_tipo_equipo_pk = GR.id_tipo_equipo_pk AND GR.estado <> 'INACTIVO'", tabla);
            columnas();
            datos();
            
        }

        private void Reporte_Redes_Load(object sender, EventArgs e)
        {
            //actualizar();
            //datos();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
            borracolumnas();
            actualizar();
            //columnas();
            //llenardatos();
            //dataGridView1.Rows.Clear();

        }

        
        int cont1 = 1;
        public void columnas()
        {
            try
            {

                
                //dataGridView1.Columns[1].Visible = false;
                
                string cadena;
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;

                Conexion2 = Conexionmysql.ObtenerConexion();

                Query2.CommandText = "SELECT DT.nombre_dato FROM dato_general DT WHERE DT.id_clasi_inv_pk = 3 AND DT.estado <> 'INACTIVO';";
                Query2.Connection = Conexion2;

                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {

                    cadena = consultar2.GetString(0);
                    dataGridView1.Columns.Add(cadena, cadena);
                    cont1++;
                    
                }
            }
            catch
            {

            }
            
            Conexionmysql.Desconectar();
        }

        public void datos()
        {
           //MessageBox.Show("entra");
            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                string cadena;
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;
                
                Conexion2 = Conexionmysql.ObtenerConexion();

                Query2.CommandText = "SELECT DISTINCT DG.descripcion_det FROM gestion_redes GR, dato_general DT, detalle_general DG WHERE DG.id_gestion_redes_pk = '" + ca + "' AND DG.id_dato_hw_pk = DT.id_dato_hw_pk  AND DT.id_clasi_inv_pk = 3 AND DT.estado <> 'INACTIVO';";
                Query2.Connection = Conexion2;
                int cont2 = 10;
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {

                    cadena = consultar2.GetString(0);
                    dataGridView1.Rows[fila].Cells[cont2].Value = cadena;
                    cont2++;
                    

                }
            }
        }


        public void borracolumnas()
        {
            int Total = int.Parse(dataGridView1.ColumnCount.ToString());
            //MessageBox.Show(Convert.ToString(Total));
            int cont = 0;
            for (int i = 0; i <= Total - 1; i++)
            {
                //MessageBox.Show(Convert.ToString(i));
                dataGridView1.Columns.RemoveAt(i - cont);
                cont++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportardatos(dataGridView1);
        }

        public void exportardatos(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach(DataGridViewColumn col in tabla.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }


            int IndiceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }

            }

            excel.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
