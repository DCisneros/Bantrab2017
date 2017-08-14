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

namespace WindowsFormsApp1
{
    public partial class Proveedor : Form
    {
        Boolean Editar = false;
        String Codigo;
        String atributo;
        DataGridView data;

        public Proveedor(DataGridView dt, string id, string nombre_prv, string dire_prov, string tel_prov, string email_prov, string nit_prov, Boolean Editar1)
        {

            InitializeComponent();
            this.data = dt;
            this.Editar = Editar1;
            this.txt_id_prov.Text = id;
            this.txt_nom_prov.Text = nombre_prv;
            this.txt_dir_prov.Text = dire_prov;
            this.txt_tel_prov.Text = tel_prov;
            this.txt_email_prov.Text = email_prov;
            this.txt_nit_prov.Text = nit_prov;


        }

        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
       

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(groupBox1);
                fn.LimpiarComponentes(groupBox1);

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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {


                TextBox[] textbox = { txt_nom_prov,txt_nit_prov, txt_email_prov, txt_dir_prov,txt_tel_prov };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "proveedor";
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
                atributo = "id_modelo_pk";
                Codigo = txt_id_prov.Text;
                
                // actualizar();

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a modificar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

        }

       
    }
}
