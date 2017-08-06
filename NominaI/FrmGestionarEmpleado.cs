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
    public partial class FrmGestionarEmpleado : Form
    {
        public FrmGestionarEmpleado()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmGestionarEmpleado_Load(object sender, EventArgs e)
        {
            String EmpleadoQuery = "SELECT Empleados.Id_empleado AS Codigo, Empleados.Nombres AS Nombre, Empleados.Cedula, Departamentos.Nombre AS Departamento, ";
            EmpleadoQuery += "Puestos.Nombre AS Puesto, Empleados.Salario_mensual AS Salario, Empleados.Responsable AS Encargado ";
            EmpleadoQuery += "FROM Empleados ";
            EmpleadoQuery += "INNER JOIN Puestos ON Empleados.Id_puesto = Puestos.Id_puesto ";
            EmpleadoQuery += "INNER JOIN Departamentos ON Puestos.Id_departamento = Departamentos.Id_departamento ";
            cargarEmpleados(EmpleadoQuery);

        }

        private void cargarEmpleados(String query)
        {
            SqlConnection con;
            con = new SqlConnection(Connection.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 148;
            dataGridView1.Columns[2].Width = 128;
            dataGridView1.Columns[3].Width = 138;
            dataGridView1.Columns[4].Width = 155;
            dataGridView1.Columns[5].Width = 135;
            dataGridView1.Columns[6].Width = 155;

            con.Close();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FrmCrearEmpleado crearEmpleado = new FrmCrearEmpleado();
            crearEmpleado.ShowDialog();
        }

        private void FrmGestionarEmpleado_Activated(object sender, EventArgs e)
        {
            String EmpleadoQuery = "SELECT Empleados.Id_empleado AS Codigo, Empleados.Nombres AS Nombre, Empleados.Cedula, Departamentos.Nombre AS Departamento, ";
            EmpleadoQuery += "Puestos.Nombre AS Puesto, Empleados.Salario_mensual AS Salario, Empleados.Responsable AS Encargado ";
            EmpleadoQuery += "FROM Empleados ";
            EmpleadoQuery += "INNER JOIN Puestos ON Empleados.Id_puesto = Puestos.Id_puesto ";
            EmpleadoQuery += "INNER JOIN Departamentos ON Puestos.Id_departamento = Departamentos.Id_departamento ";
            cargarEmpleados(EmpleadoQuery);
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            modificarEmpleado();
        }
        private void modificarEmpleado()
        {
            DataGridViewRow filaSeleccionada = obtenerEmpleadoSeleccionado();

            if (filaSeleccionada != null)
            {
                String codigo = Convert.ToString(filaSeleccionada.Cells[0].Value);
                FrmModificarEmpleado modificarEmpleado = new FrmModificarEmpleado(codigo);
                modificarEmpleado.ShowDialog();
            }

        }
        private DataGridViewRow obtenerEmpleadoSeleccionado()
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                return row;
            }
            catch (Exception)
            {
                MessageBox.Show("Debe Seleccionar un registro.");

                return null;
            }

        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = obtenerEmpleadoSeleccionado();

            if (filaSeleccionada != null)
            {
                String codigo = Convert.ToString(filaSeleccionada.Cells[0].Value);
                FrmEliminarEmpleado eliminarEmpleado = new FrmEliminarEmpleado(codigo);
                eliminarEmpleado.ShowDialog();
            }


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String texto = Convert.ToString(txtBuscar.Text);
            String EmpleadoQuery = "SELECT Empleados.Id_empleado AS Codigo, Empleados.Nombres AS Nombre, Empleados.Cedula, Departamentos.Nombre AS Departamento, ";
            EmpleadoQuery += "Puestos.Nombre AS Puesto, Empleados.Salario_mensual AS Salario, Empleados.Responsable AS Encargado ";
            EmpleadoQuery += "FROM Empleados ";
            EmpleadoQuery += "INNER JOIN Puestos ON Empleados.Id_puesto = Puestos.Id_puesto ";
            EmpleadoQuery += "INNER JOIN Departamentos ON Puestos.Id_departamento = Departamentos.Id_departamento ";
            EmpleadoQuery += "WHERE Empleados.Id_empleado LIKE '%" + texto + "%' OR Empleados.Nombres LIKE '%" + texto + "%' OR Empleados.Cedula LIKE '%" + texto + "%' ";
            EmpleadoQuery += "OR Departamentos.Nombre LIKE '%" + texto + "%' OR Puestos.Nombre LIKE '%" + texto + "%' OR Empleados.Salario_mensual LIKE '%" + texto + "%' OR Empleados.Responsable LIKE '%" + texto + "%'";
            cargarEmpleados(EmpleadoQuery);
        }
    }
}
