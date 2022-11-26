using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_animal.Entities
{
    public class Empleado : Persona
    {
        public string cargo { get; set; }
        public double salario { get; set; }
        public Usuario IDusuario { get; set; }

    }
}
