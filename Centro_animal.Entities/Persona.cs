using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_animal.Entities
{
    public class Persona
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public int DNI { get; set; }
        public Direccion direccion { get; set; }
        public int Telefono { get; set; }


    }




}
