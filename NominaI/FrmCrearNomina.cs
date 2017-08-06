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
    public partial class FrmCrearNomina : Form
    {
        public FrmCrearNomina()
        {
            InitializeComponent();
        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            String descripcion = txtDescripcion.Text;

            if (descripcion.Length <= 0)
            {
                MessageBox.Show("El campo Descripcion nomina es obligatorio.");
            }
            else
            {
                guardarNomina(descripcion);

            }
        }

        private void FrmCrearNomina_Load(object sender, EventArgs e)
        {

        }

        private void guardarNomina(String descripcion)
        {
            try
            {

                SqlConnection con = new SqlConnection(Connection.connectionString);
                con.Open();
                String query = "INSERT INTO Nomina (Fecha, descripcion) VALUES (GETDATE(), '"+descripcion+"')";
                
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("La nomina fue registrada correctamente.");
                    this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("la nomina no pudo ser registrada: " + ex.ToString());
            }
        }

        private void btnCancelarNomina_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
