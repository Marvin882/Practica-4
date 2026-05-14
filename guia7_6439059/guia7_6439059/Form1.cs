using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace guia7_6439059
{
    public partial class Form1 : Form
    {
        //Defino una variable de tipo Connection
        private SqlConnection conn1;
        //Defino una variable de tipo DataAdapter
        private SqlDataAdapter da1;
        //Defino una variable de tipo DataReader
        private SqlDataReader dr1;
        //define una variable que contendrá la cadena de conexión
        private string sCn1;
        //instacio un variable OleDbConection
        OleDbConnection cnn = new OleDbConnection();
        public Form1()
        {
           
                InitializeComponent();
                //línea de conexión con el servido de base de datos SQL por OLEDB
                cnn.ConnectionString =
                // Agregar el nombre del servidor como se conectó a SQL Server
                @"PROVIDER=SQLOLEDB;Server=MARVIN\SQLEXPRESS;Database=BD_6439059;Uid=sa;Pwd=123";
                // ocultamos el botón modificar
                modificar1.Visible = false;
                //conexión por medio de SQLCLIENT
                conexion cn1 = new
                conexion();
                cn1.conec();
                sCn1 = cn1.cadena;
                conn1 = new SqlConnection(sCn1);
                conn1.Open();
            
        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            //Mostramos los textbox ocultos
            textedad1.Visible = true;
            textnom1.Visible = true;
            textapel1.Visible = true;
            modificar1.Visible = true;
            //variable que tendrá la consulta.
            string seleccion;
            seleccion = "Select *From Participantes where Codigo= '" + textcod1.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn1);
            SqlParameter prm = new SqlParameter("Codigo", SqlDbType.VarChar);
            prm.Value = textcod1.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                textnom1.Text = dr1["Nombres"].ToString().Trim();
                textapel1.Text = dr1["Apellidos"].ToString().Trim();
                textedad1.Text = dr1["Edad"].ToString().Trim();
            }
            if (dr1 != null)
            {
                MessageBox.Show("Datos Encontrados");
                dr1.Close();
            }
        }

        private void modificar1_Click(object sender, EventArgs e)
        {
            string actualizar;
            actualizar = "update Participantes set ";
            actualizar += " Nombres= '" + textnom1.Text + "', Apellidos= '" +
            textapel1.Text;

            actualizar += "', Edad=" + textedad1.Text + " where Codigo= '" + textcod1.Text + "'";
            OleDbCommand datos = new OleDbCommand(actualizar, cnn);
            cnn.Open();
            //mandando sql a base de datos
            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("REGISTRO ACTUALIZADO");
            Reset();
        }
        private void Reset()
        {
            textcod1.Text = "";
            textnom1.Text = "";
            textapel1.Text = "";
            textedad1.Text = "";
            textedad1.Visible = false;
            textnom1.Visible = false;
            textapel1.Visible = false;
            modificar1.Visible = false;
            Form2 formu2 = new Form2();
            //Mostramos el Form2
            formu2.Show();
            // ocultamos el Form1
            this.Hide();
        }
    }
}
