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
        public void consultarDepartamento_Click(object sender, System.EventArgs e)
        {
            ConsultarDepartamento verDepartamento = new ConsultarDepartamento();
            verDepartamento.ShowDialog();
        }
        public void gestionarPuesto_Click(object sender, System.EventArgs e)
        {
            FrmGestionarPuesto gestionarPuesto = new FrmGestionarPuesto();
            gestionarPuesto.ShowDialog();
        }

        public void gestionarEmpleado_Click(object sender, System.EventArgs e)
        {
            FrmGestionarEmpleado gestionarEmpleado = new FrmGestionarEmpleado();
            gestionarEmpleado.ShowDialog();
        }
        public void gestionarNomina_Click(object sender, System.EventArgs e)
        {
            FrmGestionarNomina gestionarNomina = new FrmGestionarNomina();
            gestionarNomina.ShowDialog();
        }
        public void asignarNomina_CLick(object sender, System.EventArgs e)
        {
            FrmAsignarNomina asignarNomina = new FrmAsignarNomina();
            asignarNomina.ShowDialog();
        }
    }
}
