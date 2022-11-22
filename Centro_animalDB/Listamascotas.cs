using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_animal.Entities;

namespace Centro_animalDB
{
    public class Listamascotas
    {
        List<Animal> listaanimales = new List<Animal>();
        public List<Animal> GetAnimales()
        {
            
            listaanimales.Add(new Animal() { IDDuenio = 1, IDanimal = 1, NombreAnimal = "Thor", PesoAnimal = 20.3, raza="buldog",especie =1 });
            listaanimales.Add(new Animal() { IDDuenio = 1, IDanimal = 2, NombreAnimal = "Pepe", PesoAnimal = 10.3, raza = "Caniche", especie = 1 });
            listaanimales.Add(new Animal() { IDDuenio = 2, IDanimal = 3, NombreAnimal = "Loky", PesoAnimal = 8.3, raza = "Siames", especie = 2 });


            return listaanimales;
        }
    }
}
