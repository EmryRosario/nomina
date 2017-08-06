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
    public partial class FrmModificarEmpleado : Form
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String cedula { get; set; }
        public String salario { get; set; }
        public String puesto { get; set; }
        public FrmModificarEmpleado(String codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
        }

        private void cargarEmpleado()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT Nombres, Cedula, Id_Puesto, Salario_mensual FROM Empleados WHERE Id_empleado="+this.codigo;
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
            cargarComboPuesto();
        }
        private void cargarComboPuesto()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT Id_puesto, Nombre FROM Puestos";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            int index = -1;
            List<Combo> puestos = new List<Combo>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    puestos.Add(new Combo(Convert.ToString(reader.GetValue(0)), Convert.ToString(reader.GetValue(1))));

                    if (index == -1)
                    {
                        if (this.puesto == Convert.ToString(reader.GetValue(0)))
                        {
                            index = i;
                        }
                        i++;
                    }

                }
            }

            cbPuesto.DataSource = puestos;
            cbPuesto.DisplayMember = "nombre";
            cbPuesto.ValueMember = "codigo";
            cbPuesto.SelectedIndex = index;
            reader.Close();
            con.Close();
        }

        private void FrmModificarEmpleado_Load(object sender, EventArgs e)
        {
            cargarEmpleado();
        }

        private void modificarEmpleado(String codigo, String nombre, String cedula, String puesto, String salario)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(Connection.connectionString);
                con.Open();

                String query = "UPDATE Empleados SET Nombres='"+nombre+"', Cedula='"+cedula+"', Id_puesto="+puesto+", ";
                query += "Salario_mensual="+salario+" WHERE Id_empleado=" + codigo;
                if (!validarCedula(cedula))
                {
                    MessageBox.Show("La cedula es invalida, favor registrar una cedula valida.");
                } else {
                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("El Empleado fue Actualizado correctamente.");
                    this.Close();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error el Empleado no fue actualizado.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            String cedula = txtCedula.Text;
            String salario = txtSalario.Text;
            String puesto = cbPuesto.SelectedValue.ToString();

            modificarEmpleado(codigo, nombre, cedula, puesto, salario);
        }

        public bool validarCedula(string cedula)
        {
            int verificador = 0;
            int digito = 0;
            int digitoVerificador = 0;
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
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
