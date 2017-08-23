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
    public partial class Sistema_Operativo : Form
    {
        public Sistema_Operativo()
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
                treeView1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sistema_Operativo_Load(object sender, EventArgs e)
        {
            actualizar();
            treeView1.Enabled = false;
            fn.InhabilitarComponentes(groupBox1);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(groupBox1);
                fn.InhabilitarComponentes(groupBox1);
                treeView1.Enabled = false;
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
            OdbcDataAdapter da = new OdbcDataAdapter("SELECT * FROM sistema_operativo where estado <> 'INACTIVO'", con);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TreeNode parent = new TreeNode(dr["nombre_so"].ToString() + ", Ver. " + dr["version_so"].ToString());
                string value = dr["id_so_pk"].ToString();
                parent.Tag = dr["id_so_pk"].ToString();
                //MessageBox.Show(value);
                parent.Expand();
                treeView1.Nodes.Add(parent);
                //sublevel(parent, value);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {


                TextBox[] textbox = { txt_so, txt_version };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "sistema_operativo";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);


                    }
                    else
                    {
                        fn.insertar(datos, tabla);

                    }
                    fn.LimpiarComponentes(groupBox1);
                }
                actualizar();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        public void opciones_multiples()
        {
            int cont = 0;
            foreach (TreeNode n in treeView1.Nodes)
            {

                if (n.Checked == true)
                {
                    cont++;
                    //MessageBox.Show(Convert.ToString(cont));
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
                MessageBox.Show("NO HAY DATO SELECCIONADO");
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
                if (n.Checked == true)
                {
                    txt_id_copia.Text = n.Tag.ToString();
                    txt_copia.Text = n.Text;
                }
                else
                {

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
                atributo = "id_ubicacion_pk";
                Codigo = txt_id_copia.Text;
                txt_so.Text = txt_copia.Text;
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
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    foreach (TreeNode n in treeView1.Nodes)
                    {


                        if (n.Checked == true)
                        {
                            string codigo_ac = n.Tag.ToString();
                            String atributo2 = "id_so_pk ";
                            CapaNegocio fn = new CapaNegocio();
                            string tabla = "sistema_operativo";
                            fn.eliminar(tabla, atributo2, codigo_ac);
                        }
                        else
                        {

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

        public void actualizar()
        {
            treeView1.Nodes.Clear();
            nivel();
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
