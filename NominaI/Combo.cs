using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaI
{
    class Combo
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public Combo(String codigo, String nombre) {
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
