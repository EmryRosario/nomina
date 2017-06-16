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
    public partial class Menu : Form
    {
        SqlConnection con;
        SqlCommand command;
        String Id_usuario;
        public Menu(String Id_usuario)
        {
            this.Id_usuario = Id_usuario;
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cargarMenu();
        }
        private void cargarMenu()
        {
            String query = "SELECT menu.Id_menu, menu.descripcion, menu.nivel, accesos.menu_padre ";
            query += "FROM menu INNER JOIN accesos ON accesos.Id_menu=menu.Id_menu ";
            query += "INNER JOIN Usuarios ON Usuarios.Id_usuario = menu.Id_menu WHERE menu.nivel=1 AND accesos.Id_usuario=" +Id_usuario+ " ORDER BY menu.Id_menu";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ToolStripMenuItem mItem;
                    mItem = new System.Windows.Forms.ToolStripMenuItem();
                    mItem.Text = Convert.ToString(reader.GetValue(1));
                    menuStrip1.Items.Add(mItem);
                }
            }
            else
            {
                MessageBox.Show("Este usuario no tiene ningun acceso habilitado.");
            }
        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

     
}
