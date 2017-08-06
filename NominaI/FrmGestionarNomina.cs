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
    public partial class FrmGestionarNomina : Form
    {
        public FrmGestionarNomina()
        {
            InitializeComponent();
        }

        private void FrmGestionarNomina_Load(object sender, EventArgs e)
        {

        }

        private void cargarNominas(String query)
        {
            SqlConnection con;
            con = new SqlConnection(Connection.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[2].Width = 350;
           

            con.Close();
        }

        private void FrmGestionarNomina_Activated(object sender, EventArgs e)
        {
            String query = "SELECT Id_nomina AS Codigo, Fecha AS [Fecha de Creacion], ";
            query += "descripcion AS Descripcion  FROM Nomina";
            cargarNominas(query);
        }

        private DataGridViewRow obtenerNominaSeleccionada()
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

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FrmCrearNomina crearNomina = new FrmCrearNomina();
            crearNomina.ShowDialog();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = obtenerNominaSeleccionada();

            if (filaSeleccionada != null)
            {
                String codigo = Convert.ToString(filaSeleccionada.Cells[0].Value);
                FrmEliminarNomina eliminarNomina = new FrmEliminarNomina(codigo);
                eliminarNomina.ShowDialog();
            }
        }
    }
}
