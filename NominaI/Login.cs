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
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataReader reader;
        String Id_usuario;

        public Login()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-9KK6HN4\\SQLEXPRESS;Initial Catalog=nomina;Integrated Security=True");
                con.Open();

            }
            catch (Exception)
            {
            }
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String contrasena = txtPassword.Text;
            String query = "SELECT usuario, Id_usuario FROM Usuarios WHERE usuario='";
            query += user + "' AND contrasena='" + contrasena + "'";
            command = new SqlCommand(query, con);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Id_usuario = Convert.ToString(reader.GetValue(1));

                }
                Menu menu = new Menu(Id_usuario);
                menu.Show();
                con.Close();
                this.Hide();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Usuario y/o contraseña incorrecto");
            }

        }

    }
}