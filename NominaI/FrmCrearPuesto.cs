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
    public partial class FrmCrearPuesto : Form
    {
        public FrmCrearPuesto()
        {
            InitializeComponent();
        }

        private void FrmCrearPuesto_Load(object sender, EventArgs e)
        {
            cargarComboDepartamento();

        }

        private void cargarComboDepartamento() {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT Id_departamento AS Codigo, Nombre FROM Departamentos";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            cbDepartamento.Items.Clear();

            List<Combo> departamentos = new List<Combo>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    departamentos.Add(new Combo(Convert.ToString(reader.GetValue(0)), Convert.ToString(reader.GetValue(1))));
                }
            }

            cbDepartamento.DataSource = departamentos;
            cbDepartamento.DisplayMember = "nombre";
            cbDepartamento.ValueMember = "codigo";
            cbDepartamento.SelectedValue = "codigo";
            cbDepartamento.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        private void guardarPuesto(String descripcion, String salarioMinimo, String salarioMaximo, String departamento)
        {
            try
            {
                
                SqlConnection con = new SqlConnection(Connection.connectionString);
                con.Open();
                String query = "INSERT INTO Puestos (Nombre, Salario_maximo, Salario_minimo, Id_departamento) VALUES ";
                query += "('" + descripcion + "'," + salarioMaximo +"," +salarioMinimo+ ","+departamento+")";

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("El Puesto fue registrado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("El departamento no pudo ser registrado: " + ex.ToString());
            }
        }

        private void btnCancelarPuesto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearPuesto_Click(object sender, EventArgs e)
        {
            String descripcion = txtDescripcion.Text;
            String salarioMinimo = txtSalarioMinimo.Text;
            String salarioMaximo = txtSalarioMaximo.Text;
            String departamento = cbDepartamento.SelectedValue.ToString();
            
            if (descripcion.Length == 0 || salarioMinimo.Length == 0 ||
                salarioMaximo.Length == 0 || departamento.Length == 0)
            {
                MessageBox.Show("Favor llenar todos los campos.");
            }
            else
            {
                if (Convert.ToInt32(salarioMinimo) > Convert.ToInt32(salarioMaximo))
                {
                    MessageBox.Show("El salario Minimo no puede ser mayor que el salario maximo.");
                }
                else
                {
                    guardarPuesto(descripcion, salarioMinimo, salarioMaximo, departamento);
                }
            }

        }

        private void txtSalarioMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) 
                {
                    e.Handled = false;
                }
                else
                { 
                    e.Handled = true;
                } 
        }

        private void txtSalarioMaximo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalarioMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
           } 
        }

        private void txtSalarioMinimo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
