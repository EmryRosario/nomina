using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace NominaI
{
    public partial class CrearDepartamento : Form
    {
        SqlConnection con;
        public CrearDepartamento()
        {
            InitializeComponent();
        }

        private void CrearDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDepartamentoDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcionDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            try
            {
                String descripcion = txtDescripcionDepartamento.Text;
                String ubicacion = txtUbicacionDepartamento.Text;

                con = new SqlConnection(Connection.connectionString);
                con.Open();
                String query = "INSERT INTO Departamentos (Nombre, ubicacion_fisica) VALUES";
                query += "('" + descripcion + "','" + ubicacion + "')";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("El Departamento fue registrado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("El departamento no pudo ser registrado: " + ex.ToString());
            }
            
        }

        private void btnCancelarDepartamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
