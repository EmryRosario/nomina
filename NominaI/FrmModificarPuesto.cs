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
    public partial class FrmModificarPuesto : Form
    {
        public String codigo { get; set; }
        public String descripcion { get; set; }
        public String salarioMinimo { get; set; }
        public String salarioMaximo { get; set; }
        public String departamento { get; set; }
        public FrmModificarPuesto(String codigo)
        {
            this.codigo = codigo;
            InitializeComponent();
            cargarPuesto();
            cargarComboPuesto();
            
        }

        private void btnCancelarPuesto_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void FrmModificarPuesto_Load(object sender, EventArgs e)
        {
            
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
        private void cargarComboPuesto()
        {
            SqlConnection con = new SqlConnection(Connection.connectionString);
            con.Open();

            String query = "SELECT Id_departamento AS Codigo, Nombre FROM Departamentos";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            int index = -1;
            List<Combo> departamentos = new List<Combo>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    departamentos.Add(new Combo(Convert.ToString(reader.GetValue(0)), Convert.ToString(reader.GetValue(1))));

                    if (index == -1)
                    {
                        if (this.departamento == Convert.ToString(reader.GetValue(1)))
                        {
                            index = i;
                        }
                        i++;
                    }
                    
                }
            }

            cbDepartamento.DataSource = departamentos;
            cbDepartamento.DisplayMember = "nombre";
            cbDepartamento.ValueMember = "codigo";
            cbDepartamento.SelectedIndex = index;
            reader.Close();
            con.Close();
        }
        private void modificarPuesto(String codigo, String descripcion, String salarioMinimo, String salarioMaximo, String departamento)
        {
            try
            {
                SqlConnection con;
                con = new SqlConnection(Connection.connectionString);
                con.Open();

                String query = "UPDATE Puestos SET Nombre='" + descripcion + "', Salario_minimo='" + salarioMinimo + "', Salario_maximo='" + salarioMaximo + "',";
                query += " Id_departamento=" + departamento + " WHERE Id_puesto=" + codigo;

                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("El Puesto fue Actualizado correctamente.");
                this.Close();
            }
            catch (Exception)
            {
               
                MessageBox.Show("Ha ocurrido un error el puesto no fue actualizado.");
            }
            
        }

        private void btnModificarPuesto_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String descripcion = txtDescripcion.Text;
            String salarioMinimo = txtSalarioMinimo.Text;
            String salarioMaximo = txtSalarioMaximo.Text;
            String departamento = cbDepartamento.SelectedValue.ToString();

            modificarPuesto(codigo, descripcion, salarioMinimo, salarioMaximo, departamento);
        }
    }
}
