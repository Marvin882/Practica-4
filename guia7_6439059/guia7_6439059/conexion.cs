using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace guia7_6439059
{
     class conexion
    {
        //Parámetros para la cadena conexión
        public string servidor, usuario, clave, db;
        public string cadena;
        // función que tendrá la cadena de conexión
        public void conec()
        {
            // Agregar el nombre del servidor como se conectó a SQL Server
            servidor = "MARVIN\\SQLEXPRESS";
            db = "BD_6439059";
            usuario = "sa";
            clave = "123";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;
        }
    }
}
