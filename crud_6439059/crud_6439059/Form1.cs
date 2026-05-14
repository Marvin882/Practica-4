using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_6439059
{
    public partial class frmAlumno : Form
    {
        conexion con = new conexion();

        public frmAlumno()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtCodigo.Clear();
            txtNombre1.Clear();
            txtNombre2.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtEdad.Clear();
            txtDireccion.Clear();
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn1 = con.conec())
                {
                    conn1.Open();
                    string sql = "INSERT INTO Alumno (CodigoAlumno, PrimerNombre, SegundoNombre, " +
                   "PrimerApellido, SegundoApellido, Edad, Direccion) " +
                   "VALUES (@cod, @n1, @n2, @a1, @a2, @ed, @dir)";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    cmd.Parameters.AddWithValue("@cod", txtCodigo.Text.Trim());
                    cmd.Parameters.AddWithValue("@n1", txtNombre1.Text.Trim());
                    cmd.Parameters.AddWithValue("@n2", txtNombre2.Text.Trim());
                    cmd.Parameters.AddWithValue("@a1", txtApellido1.Text.Trim());
                    cmd.Parameters.AddWithValue("@a2", txtApellido2.Text.Trim());
                    cmd.Parameters.AddWithValue("@ed", txtEdad.Text.Trim());
                    cmd.Parameters.AddWithValue("@dir", txtDireccion.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Alumno guardado correctamente");
                    Reset();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn1 = con.conec())
                {
                    conn1.Open();
                    string sql = "SELECT * FROM Alumno WHERE CodigoAlumno = @cod";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    cmd.Parameters.AddWithValue("@cod", txtCodigo.Text.Trim());
                    SqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read())
                    {
                        txtNombre1.Text = leer["PrimerNombre"].ToString();
                        txtNombre2.Text = leer["SegundoNombre"].ToString();
                        txtApellido1.Text = leer["PrimerApellido"].ToString();
                        txtApellido2.Text = leer["SegundoApellido"].ToString();
                        txtEdad.Text = leer["Edad"].ToString();
                        txtDireccion.Text = leer["Direccion"].ToString();
                    }
                    else { MessageBox.Show("No se encontró el registro"); }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn1 = con.conec())
                {
                    conn1.Open();
                    string sql = "DELETE FROM Alumno WHERE CodigoAlumno = @cod";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    cmd.Parameters.Add("@cod", SqlDbType.Char, 8).Value = txtCodigo.Text.Trim();

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        MessageBox.Show("Registro eliminado físicamente de la tabla");
                        Reset();
                    }
                    else { MessageBox.Show("No se encontró el registro con ese código"); }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error crítico: " + ex.Message); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn1 = con.conec())
                {
                    conn1.Open();
                    string sql = "UPDATE Alumno SET PrimerNombre=@n1, SegundoNombre=@n2," +
                    "PrimerApellido=@a1, SegundoApellido=@a2, Edad=@ed," +
                    "Direccion=@dir WHERE CodigoAlumno=@cod";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    cmd.Parameters.AddWithValue("@cod", txtCodigo.Text.Trim());
                    cmd.Parameters.AddWithValue("@n1", txtNombre1.Text.Trim());
                    cmd.Parameters.AddWithValue("@n2", txtNombre2.Text.Trim());
                    cmd.Parameters.AddWithValue("@a1", txtApellido1.Text.Trim());
                    cmd.Parameters.AddWithValue("@a2", txtApellido2.Text.Trim());
                    cmd.Parameters.AddWithValue("@ed", txtEdad.Text.Trim());
                    cmd.Parameters.AddWithValue("@dir", txtDireccion.Text.Trim());

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0) MessageBox.Show("Registro actualizado");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            frmMateria form2 = new frmMateria();
            form2.Show();

            this.Hide();
        }
    }
}
    

