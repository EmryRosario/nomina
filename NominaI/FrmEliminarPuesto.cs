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
    public partial class FrmEliminarPuesto : Form
    {
        public String codigo { get; set; }
        public String descripcion { get; set; }
        public String salarioMinimo { get; set; }
        public String salarioMaximo { get; set; }
        public String departamento { get; set; }
        public FrmEliminarPuesto(String codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void FrmEliminarPuesto_Load(object sender, EventArgs e)
        {
            cargarPuesto();
        }

        private void cargarPuesto()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT Puestos.Nombre, Puestos.Salario_minimo, Puestos.Salario_maximo, Departamentos.Nombre ";
            query += "FROM Puestos INNER JOIN Departamentos ON Puestos.Id_departamento = Departamentos.Id_departamento WHERE Id_puesto =" + this.codigo;
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.descripcion = Convert.ToString(reader.GetValue(0));
                    this.salarioMinimo = Convert.ToString(reader.GetValue(1));
                    this.salarioMaximo = Convert.ToString(reader.GetValue(2));
                    this.departamento = Convert.ToString(reader.GetValue(3));
                }
            }
            con.Close();
            reader.Close();

            txtCodigo.Text = this.codigo;
            txtDescripcion.Text = this.descripcion;
            txtSalarioMinimo.Text = this.salarioMinimo;
            txtSalarioMaximo.Text = this.salarioMaximo;
            cbDepartamento.SelectedText = this.departamento;
        }

        private void eliminarPuesto(String codigo)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(Connection.connectionString);
                con.Open();

                String query = "DELETE FROM Puestos WHERE Id_puesto =" + codigo;

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("El Puesto fue eliminado.");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error el puesto no fue eliminado.");
            }

        }

        private void btnCancelarPuesto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarPuesto_Click(object sender, EventArgs e)
        {
            eliminarPuesto(txtCodigo.Text);
        }
    }
}
