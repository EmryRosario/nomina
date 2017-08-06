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
    public partial class ConsultarDepartamento : Form
    {
        public ConsultarDepartamento()
        {
            InitializeComponent();
        }

        private void VerDepartamento_Load(object sender, EventArgs e)
        {
            cargarDepartamentos("SELECT Id_departamento AS Codigo,  Nombre AS Descripcion, ubicacion_fisica AS Ubicacion FROM Departamentos");
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarDepartamento_Click(object sender, EventArgs e)
        {
            CrearDepartamento crearDepartamento = new CrearDepartamento();
            crearDepartamento.ShowDialog();
        }
        private void cargarDepartamentos(String query)
        {
            SqlConnection con;
            con = new SqlConnection(Connection.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 270;
            dataGridView1.Columns[2].Width = 320;

            con.Close();
        }

        private void ConsultarDepartamento_Activated(object sender, EventArgs e)
        {
            cargarDepartamentos("SELECT Id_departamento AS Codigo,  Nombre AS Descripcion, ubicacion_fisica AS Ubicacion FROM Departamentos");
        }

        private void btnActualizarDepartamento_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = obtenerDepartamentoSeleccionado();

            if (filaSeleccionada != null)
            {
                String codigo = Convert.ToString(filaSeleccionada.Cells[0].Value);
                String descripcion = Convert.ToString(filaSeleccionada.Cells[1].Value);
                String ubicacion = Convert.ToString(filaSeleccionada.Cells[2].Value);
                FrmEditarDepartamento editarDepartamento = new FrmEditarDepartamento(codigo, descripcion, ubicacion);
                editarDepartamento.ShowDialog();
            }
        }
        private DataGridViewRow obtenerDepartamentoSeleccionado ()
        {
            try
            {
                
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                return row;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Debe Seleccionar Un registro.");
                return null;
            }
            
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = obtenerDepartamentoSeleccionado();

            if (filaSeleccionada != null)
            {
                String codigo = Convert.ToString(filaSeleccionada.Cells[0].Value);
                String descripcion = Convert.ToString(filaSeleccionada.Cells[1].Value);
                String ubicacion = Convert.ToString(filaSeleccionada.Cells[2].Value);
                FrmEliminarDepartamento eliminarDepartamento = new FrmEliminarDepartamento(codigo, descripcion, ubicacion);
                eliminarDepartamento.ShowDialog();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String texto = Convert.ToString(txtBuscar.Text);
            String query = "SELECT Id_departamento AS Codigo,  Nombre AS Descripcion, ubicacion_fisica AS Ubicacion ";
            query += "FROM Departamentos WHERE Id_departamento LIKE '%"+texto+"%' OR Nombre LIKE '%"+texto+"%'";
            query += " OR ubicacion_fisica LIKE '%"+texto+"%'";
            cargarDepartamentos(query);
        }
    }
}
