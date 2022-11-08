using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_animal.Entities
{
    public class Animal
    {
        public int IDDuenio { get; set; }
        public int IDanimal { get; set; }
        public String NombreAnimal { get; set; }
        public double PesoAnimal { get; set; }
        public DateTime fechaNacimento { get; set; }
        public DateTime fechaIngreso { get; set; }
        public String raza { get; set; }

        public Animal(int iDDuenio, int iDanimal, string nombreAnimal, double pesoAnimal, DateTime fechaNacimento, DateTime fechaIngreso, string raza)
        {
            IDDuenio = iDDuenio;
            IDanimal = iDanimal;
            NombreAnimal = nombreAnimal;
            PesoAnimal = pesoAnimal;
            this.fechaNacimento = fechaNacimento;
            this.fechaIngreso = fechaIngreso;
            this.raza = raza;
        }

        public Animal()
        {
        }
    }

}
