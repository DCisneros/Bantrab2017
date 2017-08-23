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
    public partial class Gestion_de_Redes : Form
    {
        public Gestion_de_Redes()
        {
            InitializeComponent();
        }

        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
        String Codigo;
        String atributo;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(groupBox1);
                fn.LimpiarComponentes(groupBox1);
                //dataGridView1.Rows.Clear();
                dataGridView1.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(groupBox1);
                fn.InhabilitarComponentes(groupBox1);
                dataGridView1.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void llenarmarca()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_marca_pk, nombre_marca from marca where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "marca");
                cbo_marca.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_marca.ValueMember = ("id_marca_pk");
                //se indica el valor a desplegar en el combobox
                cbo_marca.DisplayMember = ("nombre_marca");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenarmodelo()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_modelo_pk, nombre_modelo from modelo where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "modelo");
                cbo_modelo.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_modelo.ValueMember = ("id_modelo_pk");
                //se indica el valor a desplegar en el combobox
                cbo_modelo.DisplayMember = ("nombre_modelo");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenarubicacion()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_ubicacion_pk, nombre from ubicacion where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "ubicacion");
                cbo_ubi.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_ubi.ValueMember = ("id_ubicacion_pk");
                //se indica el valor a desplegar en el combobox
                cbo_ubi.DisplayMember = ("nombre");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenarproveedor()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_prov_mante_pk, nombre_prov_mant from proveedor_mantenimiento where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "proveedor_mantenimiento");
                cbo_prov_man.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_prov_man.ValueMember = ("id_prov_mante_pk");
                //se indica el valor a desplegar en el combobox
                cbo_prov_man.DisplayMember = ("nombre_prov_mant");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenartipo_equipo()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_tipo_equipo_pk, nombre_tipo from tipo_equipo where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "tipo_equipo");
                cbo_tipo_eq.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_tipo_eq.ValueMember = ("id_tipo_equipo_pk");
                //se indica el valor a desplegar en el combobox
                cbo_tipo_eq.DisplayMember = ("nombre_tipo");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Gestion_de_Redes_Load(object sender, EventArgs e)
        {
            llenarmarca();
            llenarmodelo();
            llenarubicacion();
            llenartipo_equipo();
            llenarproveedor();
            cbo_fecha.SelectedIndex = 0;
            cbo_mant.SelectedIndex = 0;
            dateTimePicker1.Visible = false;
            llenardatos();
            dataGridView1.Enabled = false;
        }

        private void llenardatos()
        {
            try
            {
                int cont1 = 0;
                //dataGridView1.Columns[1].Visible = false;
                int id_dato = 0;
                string dato;
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                //string sql = "dsn=inventario;server=localhost;database=inventario;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                //Conexion2 = new OdbcConnection();
                Conexion2 = Conexionmysql.ObtenerConexion();
                //Conexion2.ConnectionString = sql;
               // Conexion2.Open();
                Query2.CommandText = "SELECT id_dato_hw_pk,nombre_dato From dato_general where id_clasi_inv_pk = 3 And estado <> 'INACTIVO' ;";
                Query2.Connection = Conexion2;
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {
                    dataGridView1.Rows.Add(1);
                    if (cont1 == 0)
                    {
                        id_dato = consultar2.GetInt32(0);
                        dato = consultar2.GetString(1);
                        dataGridView1.Rows[0].Cells[0].Value = id_dato;
                        dataGridView1.Rows[0].Cells[1].Value = dato;
                        // MessageBox.Show(Convert.ToString(id));
                    }
                    else
                    {
                        id_dato = consultar2.GetInt32(0);
                        dato = consultar2.GetString(1);
                        dataGridView1.Rows[cont1].Cells[0].Value = id_dato;
                        dataGridView1.Rows[cont1].Cells[1].Value = dato;

                    }
                    cont1++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Conexionmysql.Desconectar();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_fecha.Text == "Aplica")
            {
                dateTimePicker1.Visible = true;
                dateTimePicker1.Enabled = true;
            } else
            {
                dateTimePicker1.Visible = false;
                dateTimePicker1.Enabled = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
