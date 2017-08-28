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
    public partial class Seguridad_Informatica : Form
    {
        public Seguridad_Informatica(DataGridView dt, string id_infra, string nombre_infra, string mante, string id_marca, string id_modelo, string id_so, string id_rol, string id_dominio, string id_tipo, string id_gab, string id_ubi, string id_prov_manm, string id_cluster, Boolean Editar1, int mod)
        {
            InitializeComponent();
            data = dt;
            Editar = Editar1;
            txt_id_hw.Text = id_infra;
            txt_infra.Text = nombre_infra;
            cbo_mant.Text = mante;
            marca = id_marca;
            modelo = id_modelo;
            ubicacion = id_ubi;
            so = id_so;
            rol = id_rol;
            gabinete = id_gab;
            tipo = id_tipo;
            dominio = id_dominio;
            prov_man = id_prov_manm;
            modi = mod;
            clus = id_cluster;
            manteni = mante;

        }

        DataGridView data;
        string marca;
        string modelo;
        string ubicacion;
        string rol;
        string so;
        string gabinete;
        string tipo;
        string dominio;
        string prov_man;
        string clus;
        string manteni;
        int modi = 0;

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

                Query2.CommandText = "SELECT DISTINCT DG.id_detalle_hw_pk, DT.nombre_dato, DG.descripcion_det FROM dato_general DT, detalle_general DG, gestion_redes GR WHERE DT.id_clasi_inv_pk = '2' AND DG.id_infra_pk = " + txt_id_hw.Text + " AND DG.id_dato_hw_pk = DT.id_dato_hw_pk AND DT.estado <> 'INACTIVO' ;";
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

        private void Seguridad_Informatica_Load(object sender, EventArgs e)
        {
            txt_clasifi.Text = "2";
            fn.InhabilitarComponentes(groupBox1);
            dataGridView1.Enabled = false;

            llenarmarca();
            llenarmodelo();
            llenardom();
            llenarcluster();
            llenarproveedor();
            llenarso();
            llenarubicacion();
            llenarrol();
            llenargabinete();
            llenartipo();
            cbo_mant.SelectedIndex = 0;

            if (modi == 0)
            {
                llenardatos();
            }
            else
            {
                para_modificar();
            }

            cbo_marca.SelectedValue = Convert.ToInt32(marca);
            cbo_modelo.SelectedValue = Convert.ToInt32(modelo);
            cbo_prov_man.SelectedValue = Convert.ToInt32(prov_man);
            cbo_so.SelectedValue = Convert.ToInt32(so);
            cbo_gab.SelectedValue = Convert.ToInt32(gabinete);
            cbo_rol.SelectedValue = Convert.ToInt32(rol);
            cbo_tipo.SelectedValue = Convert.ToInt32(tipo);
            cbo_ubi.SelectedValue = Convert.ToInt32(ubicacion);
            cbo_dom.SelectedValue = Convert.ToInt32(dominio);
            cbo_clu.SelectedValue = Convert.ToInt32(clus);
            cbo_mant.Text = manteni;
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


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                String Query = "select id_ubicacion_pk, nombre, detalle from ubicacion where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "ubicacion");
                cbo_ubi.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_ubi.ValueMember = ("id_ubicacion_pk");
                //se indica el valor a desplegar en el combobox
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["detalle"].ToString() == "N/A")
                    {
                        dr["nombre"] = dr["nombre"].ToString();
                    }
                    else
                    {
                        dr["nombre"] = dr["nombre"].ToString() + " Nvl. " + dr["detalle"].ToString();
                    }
                }
                cbo_ubi.DataSource = dt;
                cbo_ubi.DisplayMember = "nombre";
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

        private void llenarcluster()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cluster_pk, nombre_cluster from cluster where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "cluster");
                cbo_clu.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_clu.ValueMember = ("id_cluster_pk");
                //se indica el valor a desplegar en el combobox
                cbo_clu.DisplayMember = ("nombre_cluster");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenarso()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_so_pk, nombre_so, version_so from sistema_operativo where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "sistema_operativo");
                cbo_so.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_so.ValueMember = ("id_so_pk");
                //se indica el valor a desplegar en el combobox

                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["version_so"].ToString() == "N/A")
                    {
                        dr["nombre_so"] = dr["nombre_so"].ToString();
                    }
                    else
                    {
                        dr["nombre_so"] = dr["nombre_so"].ToString() + "Ver. " + dr["version_so"].ToString();
                    }
                }
                cbo_so.DataSource = dt;
                cbo_so.DisplayMember = "nombre_so";

                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenardom()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_dominio_pk, nombre_dominio from dominio where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "dominio");
                cbo_dom.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_dom.ValueMember = ("id_dominio_pk");
                //se indica el valor a desplegar en el combobox
                cbo_dom.DisplayMember = ("nombre_dominio");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenarrol()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_rol_pk, nombre_rol from rol where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "rol");
                cbo_rol.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_rol.ValueMember = ("id_rol_pk");
                //se indica el valor a desplegar en el combobox
                cbo_rol.DisplayMember = ("nombre_rol");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenargabinete()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_gabinete_pk, nombre_gabinete from gabinete where estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "gabinete");
                cbo_gab.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_gab.ValueMember = ("id_gabinete_pk");
                //se indica el valor a desplegar en el combobox
                cbo_gab.DisplayMember = ("nombre_gabinete");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenartipo()
        {
            try
            {
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_tipo_pk, nombre_tipo from tipo where id_clasi_inv_pk = " + txt_clasifi.Text + " and estado <> 'INACTIVO' ";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "tipo");
                cbo_tipo.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_tipo.ValueMember = ("id_tipo_pk");
                //se indica el valor a desplegar en el combobox
                cbo_tipo.DisplayMember = ("nombre_tipo");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                Query2.CommandText = "SELECT id_dato_hw_pk,nombre_dato From dato_general where id_clasi_inv_pk = 2 And estado <> 'INACTIVO' ;";
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
                string selectedItem4 = cbo_rol.SelectedValue.ToString();
                txt_rol.Text = selectedItem4;
                string selectedItem5 = cbo_dom.SelectedValue.ToString();
                txt_dominio.Text = selectedItem5;
                string selectedItem6 = cbo_gab.SelectedValue.ToString();
                txt_gabinete.Text = selectedItem6;
                string selectedItem7 = cbo_clu.SelectedValue.ToString();
                txt_clus.Text = selectedItem7;
                string selectedItem8 = cbo_tipo.SelectedValue.ToString();
                txt_tipo.Text = selectedItem8;
                string selectedItem9 = cbo_so.SelectedValue.ToString();
                txt_so.Text = selectedItem9;


                txt_clasifi.Text = "2";

                TextBox[] textbox = { txt_infra, txt_marca, txt_modelo, txt_ubicacion, txt_rol, txt_so, txt_tipo, txt_clus, txt_gabinete, txt_dominio, txt_mant, txt_prov_mant, txt_clasifi };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "infraestructura";
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
            //
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

                    TextBox[] textbox = { txt_dato_hw, txt_descr, txt_id_hw };
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
                            TextBox[] textbox2 = { txt_descr, txt_id_hw };
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

        public void id_host()
        {
            try
            {

                //dataGridView1.Columns[1].Visible = false;
                int id_dato = 0;
                //MessageBox.Show(Convert.ToString(txt_infra.Text));
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;

                Conexion2 = Conexionmysql.ObtenerConexion();

                Query2.CommandText = "SELECT id_infra_pk from infraestructura where nombre_infra Like " + "'" + "" + txt_infra.Text + "" + "'" + " ;";
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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                fn.ActivarControles(groupBox1);
                atributo = "id_infra_pk";
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

                String atributo2 = "id_infra_pk";
                String codigo2 = txt_id_hw.Text;
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    string tabla = "infraestructura";
                    fn.eliminar(tabla, atributo2, codigo2);

                }

                dataGridView1.Rows.Clear();
                fn.LimpiarComponentes(groupBox1);
                //actualizar();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "infraestructura";
            fn.ActualizarGrid(dataGridView1, "SELECT DISTINCT INF.id_infra_pk, INF.nombre_infra, INF.mantenimiento, M.id_marca_pk, M.nombre_marca, MD.id_modelo_pk, MD.nombre_modelo, SO.id_so_pk, SO.nombre_so, SO.version_so, RL.id_rol_pk, RL.nombre_rol, DOM.id_dominio_pk, DOM.nombre_dominio, TP.id_tipo_pk, TP.nombre_tipo, GA.id_gabinete_pk, GA.nombre_gabinete, UB.id_ubicacion_pk, UB.nombre, UB.detalle, PM.id_prov_mante_pk, PM.nombre_prov_mant, CL.id_cluster_pk, CL.nombre_cluster  FROM infraestructura INF, marca M, modelo MD, sistema_operativo SO, rol RL, dominio DOM, ubicacion UB, tipo TP, cluster CL, gabinete GA, proveedor_mantenimiento PM WHERE INF.id_marca_pk = M.id_marca_pk AND INF.id_modelo_pk = MD.id_modelo_pk AND INF.id_so_pk = SO.id_so_pk AND INF.id_tipo_pk = TP.id_tipo_pk AND INF.id_prov_mante_pk = PM.id_prov_mante_pk AND INF.id_gabinete_pk = GA.id_gabinete_pk AND INF.id_dominio_pk = DOM.id_dominio_pk AND INF.id_rol_pk = RL.id_rol_pk AND INF.id_cluster_pk = CL.id_cluster_pk AND INF.id_ubicacion_pk = UB.id_ubicacion_pk AND INF.id_cluster_pk = CL.id_cluster_pk AND INF.estado <> 'INACTIVO' and INF.id_clasi_inv_pk = '2'", tabla);

        }
    }
}
