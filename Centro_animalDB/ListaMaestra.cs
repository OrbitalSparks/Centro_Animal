using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_animal.Entities;

namespace Centro_animalDB
{
    public class ListaMaestra
    {
        
        public List<Especie> GetEspecie()
        {
            List<Especie> listaEspecie = new List<Especie>();



            listaEspecie.Add(new Especie() { idespecie= 0, nombreEspecie="Selecione" });
            listaEspecie.Add(new Especie() { idespecie = 1, nombreEspecie = "Perro" });
            listaEspecie.Add(new Especie() { idespecie = 2, nombreEspecie = "Gato" });
            listaEspecie.Add(new Especie() { idespecie = 3, nombreEspecie = "Conejo" });
            listaEspecie.Add(new Especie() { idespecie = 4, nombreEspecie = "Otro" });




            return listaEspecie;
        }


    }
}
