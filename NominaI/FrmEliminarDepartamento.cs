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
    public partial class FrmEliminarDepartamento : Form
    {
        String codigoDepartamento, descripcionDepartamento, ubicacionDepartamento;
        public FrmEliminarDepartamento(String codigoDepartamento, String descripcionDepartamento, String ubicacionDepartamento)
        {
            this.codigoDepartamento = codigoDepartamento;
            this.descripcionDepartamento = descripcionDepartamento;
            this.ubicacionDepartamento = ubicacionDepartamento;
            InitializeComponent();
        }

        private void FrmEliminarDepartamento_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = codigoDepartamento;
            txtDescripcion.Text = descripcionDepartamento;
            txtUbicacion.Text = ubicacionDepartamento;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(Connection.connectionString);
            con.Open();

            String codigo = txtCodigo.Text;
            String descripcion = txtDescripcion.Text;
            String ubicacion = txtUbicacion.Text;

            String query = "DELETE FROM Departamentos WHERE Id_departamento='"+codigo+"'";

            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            MessageBox.Show("El Departamento "+descripcion+" fue Actualizado correctamente.");
            this.Close();
        }
    }
}
