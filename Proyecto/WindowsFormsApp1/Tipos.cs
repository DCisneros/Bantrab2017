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
    public partial class Tipos : Form
    {
        public Tipos()
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
                treeView1.Enabled = true;
                //dataGridView1.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tipos_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(groupBox1);
            llenartipo_hw();
            treeView1.Enabled = false;
            nivel();

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
                String Query = "select id_clasi_inv_pk, nombre_clasi from clasificacion_inventario WHERE id_clasi_inv_pk <> 3";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "clasificacion_inventario");
                cbo_inv.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_inv.ValueMember = ("id_clasi_inv_pk");
                //se indica el valor a desplegar en el combobox
                cbo_inv.DisplayMember = ("nombre_clasi");
                Conexionmysql.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        OdbcConnection con = new OdbcConnection("dsn=inventario;server=localhost;database=inventario;uid=root;password=");
        public void nivel()
        {
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter("SELECT * FROM clasificacion_inventario WHERE id_clasi_inv_pk <> 3 ", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TreeNode parent = new TreeNode(dr["nombre_clasi"].ToString());
                string value = dr["id_clasi_inv_pk"].ToString();
                parent.Tag = dr["id_clasi_inv_pk"].ToString();
                //MessageBox.Show(value);
                parent.Expand();
                treeView1.Nodes.Add(parent);
                sublevel(parent, value);
            }
        }

        public void sublevel(TreeNode parent, string value)
        {
            DataTable dt = new DataTable();
            string selectedItem = cbo_inv.SelectedValue.ToString();
            OdbcDataAdapter da = new OdbcDataAdapter("SELECT * FROM tipo where id_tipo_pk ='" + value + "' AND estado <> 'INACTIVO'", con);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode child = new TreeNode(dr["nombre_tipo"].ToString().Trim());
                child.Tag = dr["id_tipo_pk"].ToString();
                
                string temp = dr["id_clasi_inv_pk"].ToString();
                // string value = dr["id_area_pk"].ToString();
                // MessageBox.Show(temp);
                child.Collapse();
                parent.Nodes.Add(child);
                // sublevel(child, temp);

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cbo_inv.SelectedValue.ToString();
                txt_id_tipo.Text = selectedItem;

                TextBox[] textbox = { txt_tipo, txt_id_tipo };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "tipo";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        contador = 0;

                    }
                    else
                    {
                        fn.insertar(datos, tabla);

                    }
                    fn.LimpiarComponentes(groupBox1);
                    treeView1.Nodes.Clear();
                    nivel();

                }
                // actualizar();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int contador = 0;
        public void opciones_multiples()
        {
            int cont = 0;
            foreach (TreeNode n in treeView1.Nodes)
            {
                foreach (TreeNode n_child in n.Nodes)
                {
                    if (n_child.Checked == true)
                    {
                        cont++;
                        //MessageBox.Show(Convert.ToString(cont));
                    }

                }
            }


            validacion(cont);
        }
        public void validacion(int x)
        {
            //MessageBox.Show(Convert.ToString(contador));
            if (x == 1)
            {
                edicion();

            }
            else if (x == 0)
            {
                MessageBox.Show("NO HAY DATOS SELECCIONADOS");
            }
            else
            {
                MessageBox.Show("ERROR, SOLO SE PUEDE SELECCIONAR UN DATO PARA MODIFICAR");
            }

        }
        public void edicion()
        {
            foreach (TreeNode n in treeView1.Nodes)
            {
                foreach (TreeNode n_child in n.Nodes)
                {
                    if (n_child.Checked == true)
                    {
                        txt_tree.Text = n_child.Tag.ToString();
                        txt_copia.Text = n_child.Text;
                    }
                    else
                    {

                    }
                }
            }

            modificar();
        }

        public void modificar()
        {
            try
            {
                Editar = true;
                fn.ActivarControles(groupBox1);
                atributo = "id_tipo_pk";
                Codigo = txt_tree.Text;
                txt_tipo.Text = txt_copia.Text;
                // actualizar();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            opciones_multiples();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    foreach (TreeNode n in treeView1.Nodes)
                    {

                        foreach (TreeNode n_child in n.Nodes)
                        {
                            if (n_child.Checked == true)
                            {
                                string codigo_ac = n_child.Tag.ToString();
                                String atributo2 = "id_tipo_pk ";
                                CapaNegocio fn = new CapaNegocio();
                                string tabla = "tipo";
                                fn.eliminar(tabla, atributo2, codigo_ac);
                            }
                            else
                            {

                            }
                        }
                    }

                }
                treeView1.Nodes.Clear();
                nivel();
                //string tabla2 = "capacitacion";
                //fn.ActualizarGrid(data, "SELECT DISTINCT  actividad, objetivo, recursos, fecha_inicio, fecha_fin, horario_inicio, horario_fin, id_ubicacion_pk, id_empresa_pk FROM capacitacion WHERE estado <>'INACTIVO' ", tabla2);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            nivel();
        }
    }
}
