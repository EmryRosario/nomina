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
    public partial class FrmEliminarEmpleado : Form
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String cedula { get; set; }
        public String salario { get; set; }
        public String puesto { get; set; }
        public FrmEliminarEmpleado(String codigo)
        {
            this.codigo = codigo;

            InitializeComponent();
        }

        private void cargarEmpleado()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT Empleados.Nombres, Empleados.Cedula,Puestos.Nombre, Empleados.Salario_mensual  FROM Empleados INNER JOIN Puestos ON Empleados.Id_puesto = Puestos.Id_puesto WHERE Id_empleado=" + this.codigo;
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.nombre = Convert.ToString(reader.GetValue(0));
                    this.cedula = Convert.ToString(reader.GetValue(1));
                    this.puesto = Convert.ToString(reader.GetValue(2));
                    this.salario = Convert.ToString(reader.GetValue(3));
                }
            }
            con.Close();
            reader.Close();

            txtCodigo.Text = this.codigo;
            txtNombre.Text = this.nombre;
            txtCedula.Text = this.cedula;
            txtSalario.Text = this.salario;
            txtPuesto.Text = this.puesto;
        }

        private void eliminarEmpleado(String codigo)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(Connection.connectionString);
                con.Open();

                String query = "DELETE FROM Empleados WHERE Id_empleado =" + codigo;

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("El Empleado fue eliminado.");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error el Empleado no fue eliminado.");
            }

        }

        private void FrmEliminarEmpleado_Load(object sender, EventArgs e)
        {
            cargarEmpleado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            eliminarEmpleado(this.codigo);
        }
    }
}
