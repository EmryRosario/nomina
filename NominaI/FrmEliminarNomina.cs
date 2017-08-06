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
    public partial class FrmEliminarNomina : Form
    {
        public String codigo { get; set; }
        public String descripcion { get; set; }
        public FrmEliminarNomina(String codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void btnCancelarNomina_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEliminarNomina_Load(object sender, EventArgs e)
        {
            cargarNomina();
        }

        private void cargarNomina()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT descripcion FROM Nomina WHERE Id_nomina=" + this.codigo;
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.descripcion = Convert.ToString(reader.GetValue(0));
                }
            }
            con.Close();
            reader.Close();

            txtDescripcion.Text = this.descripcion;
        }
        private void eliminarNomina(String codigo)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(Connection.connectionString);
                con.Open();

                String query = "DELETE FROM Nomina WHERE Id_nomina =" + codigo;

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("La nomina fue Eliminada");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error la nomina no fue eliminada.");
            }

        }

        private void btnModificarNomina_Click(object sender, EventArgs e)
        {
            eliminarNomina(this.codigo);
        }

    }
}
