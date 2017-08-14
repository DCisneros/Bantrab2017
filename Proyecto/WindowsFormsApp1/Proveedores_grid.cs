using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Proveedores_grid : Form
    {
        public Proveedores_grid()
        {
            InitializeComponent();
        }

        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        Boolean Editar = false;
        String Codigo;
        String atributo;
        String id_prov_pk, nombre_prov, nit_prov, email_prov, tel_prov, dire_prov;
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Editar1 = false;
                Proveedor a = new Proveedor(dataGridView1, id_prov_pk, nombre_prov, dire_prov, tel_prov, email_prov, nit_prov, Editar);
                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void actualizar()
        {
            string tabla = "proveedor";
            fn.ActualizarGrid(dataGridView1, "Select * from proveedor where estado <> 'INACTIVO' ", tabla);
            dataGridView1.Columns[2].Visible = false;
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar = true;

            id_prov_pk = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nombre_prov = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dire_prov = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tel_prov = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            email_prov = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            nit_prov = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            Proveedor a = new Proveedor(dataGridView1,id_prov_pk,nombre_prov, dire_prov,tel_prov,email_prov,nit_prov, Editar);
            a.StartPosition = FormStartPosition.CenterScreen;
            a.MdiParent = this.ParentForm;
            a.Show();
        }
    }
}
