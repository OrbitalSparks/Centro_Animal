using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_animal.Entities;

namespace Centro_animalDB
{
    public class ListaPersonas
    {
        List<Cliente> listaClientes = new List<Cliente>();
        public List<Cliente> GetClientes()
        {

            listaClientes.Add(new Cliente() { id = 1, nombre="Carlos",apellidos="Perez",DNI=12354556,Telefono=44555445 });
            listaClientes.Add(new Cliente() { id = 2, nombre = "Sara", apellidos = "Gonzales", DNI = 3236445, Telefono = 77555422 });



            return listaClientes;
        }


    }
}
