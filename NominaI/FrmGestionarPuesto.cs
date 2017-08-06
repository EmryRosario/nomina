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
    public partial class FrmGestionarPuesto : Form
    {
        public FrmGestionarPuesto()
        {
            InitializeComponent();
        }

        private void FrmGestionarPuesto_Load(object sender, EventArgs e)
        {
            String puestosQuery = "SELECT Puestos.Id_puesto AS Codigo, Puestos.Nombre AS Descripcion,";
            puestosQuery += " Puestos.Salario_minimo AS [Salario Minimo], Puestos.Salario_maximo AS [Salario Maximo], Departamentos.Nombre AS Departamento ";
            puestosQuery += "FROM Puestos INNER JOIN Departamentos ON Departamentos.Id_departamento = Puestos.Id_departamento";
            cargarPuestos(puestosQuery);
        }
        private void cargarPuestos(String query)
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
            dataGridView1.Columns[2].Width = 138;
            dataGridView1.Columns[3].Width = 138;
            dataGridView1.Columns[4].Width = 155;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridViewRow obtenerPuestoSeleccionado()
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

        private void modificarPuesto()
        {
            DataGridViewRow filaSeleccionada = obtenerPuestoSeleccionado();

            if (filaSeleccionada != null)
            {
                String codigo = Convert.ToString(filaSeleccionada.Cells[0].Value);
                String descripcion = Convert.ToString(filaSeleccionada.Cells[1].Value);
                String ubicacion = Convert.ToString(filaSeleccionada.Cells[2].Value);
                FrmModificarPuesto modificarPuesto = new FrmModificarPuesto(codigo);
                modificarPuesto.ShowDialog();
            }
            
        }

        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            FrmCrearPuesto crearPuesto = new FrmCrearPuesto();
            crearPuesto.ShowDialog();
        }

        private void btnActualizarPuesto_Click(object sender, EventArgs e)
        {
            modificarPuesto();
        }

        private void FrmGestionarPuesto_Activated(object sender, EventArgs e)
        {
            String puestosQuery = "SELECT Puestos.Id_puesto AS Codigo, Puestos.Nombre AS Descripcion,";
            puestosQuery += " Puestos.Salario_minimo AS [Salario Minimo], Puestos.Salario_maximo AS [Salario Maximo], Departamentos.Nombre AS Departamento ";
            puestosQuery += "FROM Puestos INNER JOIN Departamentos ON Departamentos.Id_departamento = Puestos.Id_departamento";
            cargarPuestos(puestosQuery);
        }

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = obtenerPuestoSeleccionado();

            if (filaSeleccionada != null)
            {
                String codigo = Convert.ToString(filaSeleccionada.Cells[0].Value);

                FrmEliminarPuesto eliminarPuesto = new FrmEliminarPuesto(codigo);
                eliminarPuesto.ShowDialog();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String texto = Convert.ToString(txtBuscar.Text);
            String puestosQuery = "SELECT Puestos.Id_puesto AS Codigo, Puestos.Nombre AS Descripcion,";
            puestosQuery += " Puestos.Salario_minimo AS [Salario Minimo], Puestos.Salario_maximo AS [Salario Maximo], Departamentos.Nombre AS Departamento ";
            puestosQuery += "FROM Puestos INNER JOIN Departamentos ON Departamentos.Id_departamento = Puestos.Id_departamento ";
            puestosQuery += "WHERE Puestos.Id_puesto LIKE '%" + texto + "%' OR Puestos.Nombre LIKE '%" + texto + "%' OR ";
            puestosQuery += "Puestos.Salario_minimo LIKE '%" + texto + "%' OR Puestos.Salario_maximo LIKE '%" + texto + "%' OR Departamentos.Nombre LIKE '%" + texto + "%'";
            cargarPuestos(puestosQuery);
        }
    }
}
