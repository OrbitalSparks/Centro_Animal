using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_animal.Entities;

namespace Centro_animal_Services
{
    public class Validaciones
    {
        public string VerEspecie(int numero)
        {
            if (numero == 1) return "Perro";
            if (numero == 2) return "Gato";
            if (numero == 3) return "Conejo";
            if (numero == 4) return "Otro";
            return String.Empty;
        }

        public string Validator(Cliente datosToValidate)
        {
            if (datosToValidate.apellido.Trim() == "") return "Debes elegir Apellido.";
            if (datosToValidate.nombre.Trim()=="" ) return "Debes elegir un Nombre.";
            if (datosToValidate.DNI < 8) return "Error en el DNI.";
            if (datosToValidate.Calle.Trim() == "") return "Debes elegir una Direccion.";
            if (datosToValidate.Numero <1) return "Debes elegir un numero de calle";
            return String.Empty;


        }
    }
}
