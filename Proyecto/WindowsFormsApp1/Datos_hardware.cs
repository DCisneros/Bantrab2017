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
    public partial class Datos_hardware : Form
    {
        public Datos_hardware()
        {
            InitializeComponent();
        }
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
        String Codigo;
        String atributo;
        private void Datos_hardware_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(groupBox1);
            llenartipo_hw();
            treeView1.Enabled = false;
            nivel();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(groupBox1);
                fn.LimpiarComponentes(groupBox1);
                treeView1.Enabled = true;
                foreach (TreeNode n in treeView1.Nodes)
                {
                    n.Checked = false;

                    foreach (TreeNode n_child in n.Nodes)
                    {
                        n_child.Checked = false;
                    }
                }

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
                String Query = "select id_tipo_hw_pk, nombre_tipo_hw from tipo_hardware Where estado <>'INACTIVO'";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "tipo-hardware");
                cbo_tipo.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_tipo.ValueMember = ("id_tipo_hw_pk");
                //se indica el valor a desplegar en el combobox
                cbo_tipo.DisplayMember = ("nombre_tipo_hw");
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
            OdbcDataAdapter da = new OdbcDataAdapter("SELECT * FROM tipo_hardware where estado <> 'INACTIVO'", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TreeNode parent = new TreeNode(dr["nombre_tipo_hw"].ToString());
                string value = dr["id_tipo_hw_pk"].ToString();
                parent.Tag = dr["id_tipo_hw_pk"].ToString();
                //MessageBox.Show(value);
                parent.Expand();
                treeView1.Nodes.Add(parent);
                sublevel(parent, value);
            }
        }

        public void sublevel(TreeNode parent, string value)
        {
            DataTable dt = new DataTable();
            string selectedItem = cbo_tipo.SelectedValue.ToString();
            OdbcDataAdapter da = new OdbcDataAdapter("SELECT * FROM dato_hardware where id_tipo_hw_pk ='" + value + "' AND estado <> 'INACTIVO'", con);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode child = new TreeNode(dr["nombre_dato"].ToString().Trim());
                child.Tag = dr["id_dato_hw_pk"].ToString();
                string temp = dr["id_tipo_hw_pk"].ToString();
                // string value = dr["id_area_pk"].ToString();
                // MessageBox.Show(temp);
                child.Collapse();
                parent.Nodes.Add(child);
                // sublevel(child, temp);

            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cbo_tipo.SelectedValue.ToString();
                txt_id_tipo.Text = selectedItem;

                TextBox[] textbox = { txt_dato_hw, txt_id_tipo};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "dato_hardware";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);


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

        private void cbo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nivel();
        }
    }
}
