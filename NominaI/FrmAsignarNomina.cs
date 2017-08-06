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
    public partial class FrmAsignarNomina : Form
    {
        public FrmAsignarNomina()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignarNomina_Load(object sender, EventArgs e)
        {
            cargarComboEmpleado();
            cargarComboNominaNoAsignada();
        }

        private void cargarComboEmpleado ()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "Select  Id_empleado AS codigo, Nombres AS nombre FROM  Empleados";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            cbEmpleado.Items.Clear();

            List<Combo> empleados = new List<Combo>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    empleados.Add(new Combo(Convert.ToString(reader.GetValue(0)), Convert.ToString(reader.GetValue(1))));
                }
            }

            cbEmpleado.DataSource = empleados;
            cbEmpleado.DisplayMember = "nombre";
            cbEmpleado.ValueMember = "codigo";
            cbEmpleado.SelectedValue = "codigo";
            cbEmpleado.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        private void cargarComboNominaNoAsignada()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT Id_nomina AS codigo, descripcion FROM nomina";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            cbNominasNoAsignada.Items.Clear();

            List<Combo> nominasNoAsignadas = new List<Combo>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nominasNoAsignadas.Add(new Combo(Convert.ToString(reader.GetValue(0)), Convert.ToString(reader.GetValue(1))));
                }
            }

         
            cbNominasNoAsignada.DataSource = nominasNoAsignadas;
            cbNominasNoAsignada.DisplayMember = "nombre";
            cbNominasNoAsignada.ValueMember = "codigo";
            cbNominasNoAsignada.SelectedValue = "codigo";
            cbNominasNoAsignada.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        private void cbNominasNoAsignada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
