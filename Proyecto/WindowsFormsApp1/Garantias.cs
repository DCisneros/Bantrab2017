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

namespace WindowsFormsApp1
{
    public partial class Garantias : Form
    {
        public Garantias()
        {
            InitializeComponent();
        }

        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
        String Codigo;
        String atributo;
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(groupBox1);
                fn.LimpiarComponentes(groupBox1);
                //dataGridView1.Rows.Clear();
                dateTimePicker2.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Garantias_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(groupBox1);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(groupBox1);
                fn.InhabilitarComponentes(groupBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenartipo_hw()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_hw_pk, nombre_hw from hardware Where estado <>'INACTIVO'";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "hardware");
                cbo_hw.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_hw.ValueMember = ("id_hw_pk");
                //se indica el valor a desplegar en el combobox
                cbo_hw.DisplayMember = ("nombre_hw");
                Conexionmysql.Desconectar();
            }
            catch 
            {
                
            }
        }

        public void fechacompra() {

            try
            {
                string cadena_id;
                string selectedItem = cbo_hw.SelectedValue.ToString();
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                //string sql = "server = 127.0.0.1; database = hotelsancarlos; uid = root; pwd =; ";
                Conexion2 = new OdbcConnection();
                Conexion2.ConnectionString = sql;
                Conexion2.Open();
                Query2.CommandText = "SELECT fecha_compra from hardware where hardware = '" + selectedItem + "' ;";
                Query2.Connection = Conexionmysql.ObtenerConexion();
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {

                    cadena_id = consultar2.GetString(0);
                    txt_fecha_compra.Text = cadena_id;
                    dateTimePicker1.Text = txt_fecha_compra.Text;
                    // MessageBox.Show(Convert.ToString(cadena_act));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void cbo_hw_SelectedIndexChanged(object sender, EventArgs e)
        {
            fechacompra();
        }
    }
}
