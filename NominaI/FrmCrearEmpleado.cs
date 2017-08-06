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
    public partial class FrmCrearEmpleado : Form
    {
        public FrmCrearEmpleado()
        {
            InitializeComponent();
        }

        private void FrmCrearEmpleado_Load(object sender, EventArgs e)
        {
            cargarComboDepartamento();

        }

        private void guardarEmpleado(String nombre, String cedula, String salario, String puesto)
        {
            try
            {

                SqlConnection con = new SqlConnection(Connection.connectionString);
                con.Open();
                String query = "INSERT INTO Empleados (Nombres, Cedula, Id_puesto, ";
                query += "Salario_mensual, Responsable) VALUES('"+nombre+"', '"+cedula+"','"+puesto+"', '"+salario+"','0')";
                if (!validarCedula(cedula))
                {
                    MessageBox.Show("Cedula Invalida favor ingresar una cedula valida.");
                }
                else
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("El Empleado fue registrado correctamente.");
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("El Empleado no pudo ser registrado: " + ex.ToString());
            }
        }

        private void cargarComboDepartamento()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT Id_puesto, Nombre FROM Puestos";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            cbPuesto.Items.Clear();

            List<Combo> puestos = new List<Combo>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    puestos.Add(new Combo(Convert.ToString(reader.GetValue(0)), Convert.ToString(reader.GetValue(1))));
                }
            }

            cbPuesto.DataSource = puestos;
            cbPuesto.DisplayMember = "nombre";
            cbPuesto.ValueMember = "codigo";
            cbPuesto.SelectedValue = "codigo";
            cbPuesto.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String salario = txtSalario.Text;
            String cedula = txtCedula.Text;
            String puesto = (String)cbPuesto.SelectedValue;

            guardarEmpleado(nombre, cedula, salario, puesto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validarCedula(string cedula)
            {
                int verificador = 0;
                int digito = 0;
                int digitoVerificador=0;
                int digitoImpar = 0;
                int sumaPar = 0;
                int sumaImpar = 0;
               int longitud = Convert.ToInt32(cedula.Length);
              
            try
               {
                   if (longitud == 11)
                   {
                    digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));

                      for (int i = 9; i >= 0; i--)
                      {
                          digito = Convert.ToInt32(cedula.Substring(i, 1));
                          if ((i % 2) != 0)
                         {
                              digitoImpar = digito * 2;
                              if (digitoImpar >= 10)
                              {
                                  digitoImpar = digitoImpar - 9;
                              }
                              sumaImpar = sumaImpar + digitoImpar;
                          }
                           else
                           {
                               sumaPar = sumaPar + digito;
                           }
                       }
                      verificador = 10 - ((sumaPar + sumaImpar) % 10);
                 if (((verificador == 10) && (digitoVerificador == 0))
                     || (verificador == digitoVerificador))
                      {
                           return true;
                      }
                  }
                  else
                 {
                  MessageBox.Show("La cédula debe contener once(11) digitos");
                 }
              }
             catch
              {
                MessageBox.Show("No se pudo validar la cédula");
             }
              return false;
         }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
