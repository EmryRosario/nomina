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
            query += "INNER JOIN Usuarios ON Usuarios.Id_usuario = accesos.Id_usuario WHERE menu.nivel=1 AND accesos.Id_usuario=" +Id_usuario+ " ORDER BY menu.Id_menu";
            command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            
            List<String> MenuId = new List<String>();
            List<String> MenuDescripcion = new List<String>();
            Funcionalidades Func = new Funcionalidades();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MenuId.Add(Convert.ToString(reader.GetValue(0)));
                    MenuDescripcion.Add(Convert.ToString(reader.GetValue(1)));
                }
                String[] MenuIdArreglo = MenuId.ToArray();
                String[] MenuDescripcionArreglo = MenuDescripcion.ToArray();
                reader.Close();
                SqlDataReader submenuReader;
                for (int i = 0; i < MenuDescripcionArreglo.Length; i++)
                {
                    ToolStripMenuItem mItem;
                    mItem = new ToolStripMenuItem();
                    mItem.Text = MenuDescripcionArreglo[i];

                     menuStrip1.Items.Add(mItem);

                     query = "SELECT menu.Id_menu, menu.descripcion, menu.nivel, accesos.menu_padre ";
                     query += "FROM menu INNER JOIN accesos ON accesos.Id_menu=menu.Id_menu ";
                     query += "INNER JOIN Usuarios ON Usuarios.Id_usuario = accesos.Id_usuario WHERE menu.nivel=2 AND accesos.Id_usuario=" + Id_usuario;
                     query += "AND accesos.menu_padre=" + MenuIdArreglo[i] + " ORDER BY menu.Id_menu";
                     SqlCommand submenuCommand = new SqlCommand(query, con);
                     submenuReader = submenuCommand.ExecuteReader();

                     if (submenuReader.HasRows)
                     {
                     while (submenuReader.Read())
                     {
                       ToolStripMenuItem SubOpcion;
                       SubOpcion = new ToolStripMenuItem();
                       SubOpcion.Text = Convert.ToString(submenuReader.GetValue(1));
                       mItem.DropDownItems.Add(SubOpcion);

                       switch (Convert.ToInt32(submenuReader.GetValue(0)))
                       {
                           case 10:
                               SubOpcion.Click += new System.EventHandler(Func.crearDepartamento_Click);
                               break;
                           default:
                               break;
                       }
                       
                     }
                     submenuReader.Close(); 
                    }
                    
                }        
              
            }
            else
            {
                MessageBox.Show("Este usuario no tiene ningun acceso habilitado.");
            }
        }
       
       
    }

     
}
