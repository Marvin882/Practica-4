using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace crud_6439059
{
    internal class conexion
    {
        public string servidor, usuario, clave, db;
        public string cadena;

        // Cambiamos a 'public' para que el formulario pueda usar este método
        public SqlConnection conec()
        {
            servidor = @"MARVIN\SQLEXPRESS";
            db = "BD_6439059";
            usuario = "sa";
            clave = "123";

            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;

            return new SqlConnection(cadena);
        }
    }
}
    

