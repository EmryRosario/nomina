using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace NominaI
{
    class Funcionalidades
    {
        public void crearDepartamento_Click(object sender, System.EventArgs e)
        {
            CrearDepartamento crearDepartamento = new CrearDepartamento();
            crearDepartamento.ShowDialog();
        } 
    }
}
