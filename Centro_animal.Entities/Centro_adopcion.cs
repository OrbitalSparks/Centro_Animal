using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_animal.Entities
{
    public class Centro_adopcion
    {
        public int idCentro { get; set; }
        public String nombrerefugio { get; set; }
        public String direccion { get; set; }
        public int capacidad { get; set; }
        public List<Animal> listaanimales { get; set; }
        public List<Empleado> listaPersonal { get; set; }
        public List<Cliente> listaAdoptantes { get; set; }
    }
}
