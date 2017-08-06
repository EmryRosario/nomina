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
    public partial class FrmEditarDepartamento : Form
    {

        String codigoDepartamento, descripcionDepartamento, ubicacionDepartamento;
        public FrmEditarDepartamento(String codigoDepartamento, String descripcionDepartamento, String ubicacionDepartamento)
        {
            this.codigoDepartamento = codigoDepartamento;
            this.descripcionDepartamento = descripcionDepartamento;
            this.ubicacionDepartamento = ubicacionDepartamento;
            InitializeComponent();
        }

        private void lblNuevoDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormEditarDepartamento_Load(object sender, EventArgs e)
        {
            txtCodigoDepartamento.Text = this.codigoDepartamento;
            txtDescripcionDepartamento.Text = this.descripcionDepartamento;
            txtUbicacionDepartamento.Text = this.ubicacionDepartamento;
        }

        private void btnCancelarDepartamento_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection(Connection.connectionString);
            con.Open();

            String codigo = txtCodigoDepartamento.Text;
            String descripcion = txtDescripcionDepartamento.Text;
            String ubicacion = txtUbicacionDepartamento.Text;

            String query = "UPDATE Departamentos SET Nombre='"+descripcion+"', ";
            query += "ubicacion_fisica='"+ubicacion+"' WHERE Id_departamento="+codigo;

            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            MessageBox.Show("El Departamento fue Actualizado correctamente.");
            this.Close();
        }
    }
}
