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
    public partial class vlan : Form
    {
        public vlan(DataGridView dt, string id_vlan, string vlan, string nombre_vlan, string segmento, string mask, string puerta_enlace, string descripcio, string id_ubiacion, Boolean Editar)
        {
            InitializeComponent();
            dg = dt;
            txt_id_vlan.Text = id_vlan;
            txt_vlan.Text = vlan;
            txt_nombre_vlan.Text = nombre_vlan;
            txt_segmento.Text = segmento;
            txt_mask.Text = mask;
            txt_puerta_enlace.Text = puerta_enlace;
            txt_desc.Text = descripcio;
            txt_ubicacion.Text = id_ubiacion;
            
        

        }

        DataGridView dg;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vlan_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(groupBox1);
            llenarubicacion();
            cbo_ubi.SelectedValue = Convert.ToInt32(txt_ubicacion.Text);
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                string selectedItem = cbo_ubi.SelectedValue.ToString();
                txt_ubicacion.Text = selectedItem;
                TextBox[] textbox = { txt_vlan, txt_nombre_vlan,txt_segmento,txt_mask,txt_puerta_enlace, txt_desc,txt_ubicacion };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "vlan";
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
                //actualizar();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                fn.ActivarControles(groupBox1);
                atributo = "id_vlan_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_vlan.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_nombre_vlan.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_segmento.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_mask.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_puerta_enlace.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                this.txt_desc.Text = this.dg.CurrentRow.Cells[6].Value.ToString();
                this.txt_ubicacion.Text = this.dg.CurrentRow.Cells[7].Value.ToString();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
