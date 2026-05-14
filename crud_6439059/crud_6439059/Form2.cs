using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud_6439059
{
    public partial class frmMateria : Form
    {
        conexion con = new conexion();
        public frmMateria()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtCodMat.Clear();
            txtNomMat.Clear();
            txtUV.Clear();
            txtPre.Clear();
            txtCodMat.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn1 = con.conec())
                {
                    conn1.Open();
                    string sql = "INSERT INTO Materia (CodigoMateria, " +
                    "NombreMateria, UV, Prerequisitos) VALUES (@cod, @nom, @uv, @pre)";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    cmd.Parameters.AddWithValue("@cod", txtCodMat.Text.Trim());
                    cmd.Parameters.AddWithValue("@nom", txtNomMat.Text.Trim());
                    cmd.Parameters.AddWithValue("@uv", txtUV.Text.Trim());
                    cmd.Parameters.AddWithValue("@pre", txtPre.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Materia registrada con éxito");
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
                    string sql = "SELECT * FROM Materia WHERE CodigoMateria = @cod";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    cmd.Parameters.AddWithValue("@cod", txtCodMat.Text.Trim());
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        txtNomMat.Text = rd["NombreMateria"].ToString();
                        txtUV.Text = rd["UV"].ToString();
                        txtPre.Text = rd["Prerequisitos"].ToString();
                    }
                    else { MessageBox.Show("Materia no encontrada"); }
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
                    string sql = "DELETE FROM Materia WHERE CodigoMateria = @cod";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    // char(5) según tu foto
                    cmd.Parameters.Add("@cod", SqlDbType.Char, 5).Value = txtCodMat.Text.Trim();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Materia eliminada físicamente");
                        Reset();
                    }
                    else { MessageBox.Show("No se encontró la materia"); }
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
                    string sql = "UPDATE Materia SET NombreMateria=@nom, " +
                    "UV=@uv, Prerequisitos=@pre WHERE CodigoMateria=@cod";
                    SqlCommand cmd = new SqlCommand(sql, conn1);
                    cmd.Parameters.AddWithValue("@cod", txtCodMat.Text.Trim());
                    cmd.Parameters.AddWithValue("@nom", txtNomMat.Text.Trim());
                    cmd.Parameters.AddWithValue("@uv", txtUV.Text.Trim());
                    cmd.Parameters.AddWithValue("@pre", txtPre.Text.Trim());

                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Materia actualizada");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
