﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;


namespace WindowsFormsApp1
{
    class Conexionmysql
    {
        public static OdbcConnection ObtenerConexion()
        {
            OdbcConnection miconexion = new OdbcConnection("dsn=inventario; server=localhost; uid=root; pwd=;");
            miconexion.Open();
            return miconexion;
        }
        public static OdbcConnection Desconectar()
        {
            OdbcConnection miconexion = new OdbcConnection("dsn=inventario; server=localhost; uid=root; pwd=;");
            miconexion.Close();
            return miconexion;
        }

        public static void EjecutarMySql(String Query)
        {
            OdbcCommand MiComando = new OdbcCommand(Query, ObtenerConexion());
            int FilasAfectadas = MiComando.ExecuteNonQuery();
            if (FilasAfectadas > 0)
            {
                MessageBox.Show("Operacion Realizada Exitosamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la modificacion de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
