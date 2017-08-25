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
        public Gestion_de_Redes(DataGridView dt, string id_gestion, string nombre_gest, string mant_real, string fecha, string id_marca, string id_modelo, string id_ubicacion, string prove_mant, string tipom, Boolean Editar1, int mod)
        {
           
            InitializeComponent();
            txt_id_hw.Text = id_gestion;
            txt_host.Text = nombre_gest;
            cbo_mant.Text = mant_real;
            marca = id_marca;
            fecha_in = fecha;
            tipoe = tipom;
            modelo = id_modelo;
            prov_man = prove_mant;
            ubicacion = id_ubicacion;
            modi = mod;
            data = dt;


        }
        DataGridView data;
        string marca;
        string fecha_in;
        string modelo;
        string ubicacion;
        string prov_man;
        int modi = 0;
        string tipoe;

        public void para_modificar()
        {
            try
            {
                
                int cont1 = 0;
                //dataGridView1.Columns[1].Visible = false;
                int id_dato = 0;
                string dato;
                string cadena;
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;

                Conexion2 = Conexionmysql.ObtenerConexion();

                Query2.CommandText = "SELECT DISTINCT DG.id_detalle_hw_pk, DT.nombre_dato, DG.descripcion_det FROM dato_general DT, detalle_general DG, gestion_redes GR WHERE DT.id_clasi_inv_pk = '3' AND DG.id_gestion_redes_pk = "+txt_id_hw.Text+" AND DG.id_dato_hw_pk = DT.id_dato_hw_pk AND DT.estado <> 'INACTIVO' ;";
                Query2.Connection = Conexion2;
                
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {
                    
                    dataGridView1.Rows.Add(1);
                    if (cont1 == 0)
                    {
                        
                        id_dato = consultar2.GetInt32(0);
                        dato = consultar2.GetString(1);
                        cadena = consultar2.GetString(2);
                        dataGridView1.Rows[0].Cells[0].Value = id_dato;
                        dataGridView1.Rows[0].Cells[1].Value = dato;
                        dataGridView1.Rows[0].Cells[2].Value = cadena;
                        // MessageBox.Show(Convert.ToString(id));
                    }
                    else
                    {
                        id_dato = consultar2.GetInt32(0);
                        dato = consultar2.GetString(1);
                        cadena = consultar2.GetString(2);
                        dataGridView1.Rows[cont1].Cells[0].Value = id_dato;
                        dataGridView1.Rows[cont1].Cells[1].Value = dato;
                        dataGridView1.Rows[cont1].Cells[2].Value = cadena;

                    }
                    cont1++;
                }
            }
            catch 
            {
                
            }

            Conexionmysql.Desconectar();

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
                dataGridView1.Rows.Clear();
                fn.ActivarControles(groupBox1);
                fn.LimpiarComponentes(groupBox1);
                //dataGridView1.Rows.Clear();
                dataGridView1.Enabled = true;
                txt_host.Enabled = true;
                llenardatos();

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
                dataGridView1.Rows.Clear();
                txt_host.Enabled = true;
                
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
            //MessageBox.Show(marca);
            llenarmarca();
            llenarmodelo();
            llenarubicacion();
            llenartipo_equipo();
            llenarproveedor();
            cbo_fecha.SelectedIndex = 0;
            cbo_mant.SelectedIndex = 0;
            dateTimePicker1.Visible = false;
            txt_host.Enabled = false;
            fn.InhabilitarComponentes(groupBox1);
            
            dataGridView1.Rows.Clear();
            if (modi == 0)
            {
                llenardatos();
            }
            else
            {
                para_modificar();
            }
            dataGridView1.Enabled = false;
            //MessageBox.Show(Convert.ToString(marca.Length));

            cbo_marca.SelectedValue = Convert.ToInt32(marca);

            if (fecha_in == "No Aplica")
            {
                cbo_fecha.Text = fecha_in;
            }
            else if (fecha_in == "Sin garantia ")
            {
                cbo_fecha.Text = fecha_in;
            }
            else if (fecha_in == "N/A")
            {
                cbo_fecha.Text = fecha_in;
            }
            else
            {
                cbo_fecha.Text = "Aplica";
                dateTimePicker1.Text = fecha_in;
            }

            cbo_modelo.SelectedValue = Convert.ToInt32(modelo);
            cbo_prov_man.SelectedValue = Convert.ToInt32(prov_man);
            cbo_tipo_eq.SelectedValue = Convert.ToInt32(tipoe);

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
                
                Conexion2 = Conexionmysql.ObtenerConexion();
                
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

        public void id_host()
        {
            try
            {
                
                //dataGridView1.Columns[1].Visible = false;
                int id_dato = 0;
                MessageBox.Show(Convert.ToString(txt_host.Text));
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;

                Conexion2 = Conexionmysql.ObtenerConexion();

                Query2.CommandText = "SELECT id_gestion_redes_pk from gestion_redes where nombre_gest Like "+"'"+""+ txt_host.Text +""+"'"+" ;";
                Query2.Connection = Conexion2;
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {
                    id_dato = consultar2.GetInt32(0);
                    txt_id_hw.Text = Convert.ToString(id_dato);
                    MessageBox.Show(Convert.ToString(id_dato));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Conexionmysql.Desconectar();
        }

        public void detalle_hostname()
        {
            id_host();
            try
            {
                for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
                {
                    txt_dato_hw.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                    txt_descr.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                    //MessageBox.Show(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                    //MessageBox.Show(dataGridView1.Rows[fila].Cells[2].Value.ToString());

                    TextBox[] textbox = {txt_dato_hw, txt_descr, txt_id_hw};
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tabla = "detalle_general";
                        if (Editar)
                        {
                            TextBox[] textbox2 = {txt_descr, txt_id_hw };
                            DataTable datos2 = fn.construirDataTable(textbox2);
                            atributo = "id_detalle_hw_pk";
                            Codigo = txt_dato_hw.Text;
                            fn.modificar(datos2, tabla, atributo, Codigo);


                        }
                        else
                        {
                            fn.insertar(datos, tabla);

                        }
                        //
                    }
                    // actualizar();
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                string selectedItem = cbo_marca.SelectedValue.ToString();
                txt_marca.Text = selectedItem;
                string selectedItem1 = cbo_modelo.SelectedValue.ToString();
                txt_modelo.Text = selectedItem1;
                string selectedItem2 = cbo_ubi.SelectedValue.ToString();
                txt_ubicacion.Text = selectedItem2;
                txt_mant.Text = cbo_mant.Text;
                string selectedItem3 = cbo_prov_man.SelectedValue.ToString();
                txt_prov_mant.Text = selectedItem3;
                string selectedItem4 = cbo_tipo_eq.SelectedValue.ToString();
                txt_equipo.Text = selectedItem4;
                if (cbo_fecha.Text == "Aplica")
                {
                    txt_fecha.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                } else
                {
                    txt_fecha.Text = cbo_fecha.Text;
                }

                txt_clasifi.Text ="3";

                TextBox[] textbox = { txt_host, txt_fecha, txt_mant, txt_marca, txt_modelo, txt_ubicacion, txt_prov_mant, txt_equipo, txt_clasifi};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "gestion_redes";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);


                    }
                    else
                    {
                        fn.insertar(datos, tabla);

                    }
                    //fn.LimpiarComponentes(groupBox1);
                }
                // actualizar();
                detalle_hostname();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fn.LimpiarComponentes(groupBox1);

            dataGridView1.Rows.Clear();
            actualizar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                fn.ActivarControles(groupBox1);
                atributo = "id_gestion_redes_pk";
                Codigo = txt_id_hw.Text;
                
                // actualizar();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                String atributo2 = "nombre_gest";
                String codigo2 = txt_host.Text;
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "gestion_redes";
                    fn.eliminar(tabla, atributo2, codigo2);
                    
                }

                dataGridView1.Rows.Clear();
                fn.LimpiarComponentes(groupBox1);
                actualizar();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizar()
        {
            string tabla = "gestion_redes";
            fn.ActualizarGrid(data, "SELECT DISTINCT GR.id_gestion_redes_pk, GR.nombre_gest, GR.mant_real_por, GR.fecha_inicio_garantia, M.id_marca_pk, M.nombre_marca, MD.id_modelo_pk, MD.nombre_modelo, U.id_ubicacion_pk, U.nombre, U.detalle, PM.id_prov_mante_pk, PM.nombre_prov_mant, TE.id_tipo_equipo_pk, TE.nombre_tipo FROM gestion_redes GR, detalle_general DT, marca M, modelo MD, ubicacion U, proveedor_mantenimiento PM, tipo_equipo TE WHERE GR.id_marca_pk = M.id_marca_pk AND MD.id_modelo_pk = GR.id_modelo_pk AND U.id_ubicacion_pk = GR.id_ubicacion_pk AND PM.id_prov_mante_pk = GR.id_prov_mante_pk AND TE.id_tipo_equipo_pk = GR.id_tipo_equipo_pk AND GR.estado <> 'INACTIVO'", tabla);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
