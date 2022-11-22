using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_animal.Entities
{
    public class Animal
    {
        public int? IDDuenio { get; set; }
        public int? IDanimal { get; set; }
        public string? NombreAnimal { get; set; }
        public double? PesoAnimal { get; set; }
        public DateTime? fechaNacimento { get; set; }
        public DateTime fechaIngreso { get; set; }
        public string? raza { get; set; }
        public int sexo { get; set; }
        public int? especie { get; set; }



        public Animal()
        {
        }
    }

}
