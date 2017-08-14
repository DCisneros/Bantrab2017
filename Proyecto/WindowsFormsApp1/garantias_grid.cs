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
    public partial class garantias_grid : Form
    {
        public garantias_grid()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Editar1 = false;
                Garantias a = new Garantias();
                a.StartPosition = FormStartPosition.CenterScreen;
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
