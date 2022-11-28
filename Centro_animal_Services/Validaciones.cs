using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centro_animal.Entities;
using NPOI.OpenXmlFormats.Dml;

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

        public string VerGenero(int numero)
        {
            if (numero == 1) return "Macho";
            if (numero == 2) return "Hembra";

            return String.Empty;
        }

        public string Validator(Cliente datosToValidate)
        {
            if (datosToValidate.apellido.Trim() == "") return "Debes elegir Apellido.";
            if (datosToValidate.nombre.Trim()=="" ) return "Debes elegir un Nombre.";
            if (datosToValidate.DNI < 8) return "Error en el DNI.";
            if (datosToValidate.id == 0) return "Cliente vacio.";
            if (datosToValidate.Calle.Trim() == "") return "Debes elegir una Direccion.";
            if (datosToValidate.Numero < 1  ) return "Debes elegir un numero de calle";
            if (datosToValidate.Telefono < 1 || datosToValidate.Telefono==0) return "Debes elegir un numero de telefono";
            return String.Empty;


        }
        public string Validatormasc(Animal animal)
        {
            if (animal.NombreAnimal.Trim() == "") return "Debes elegir un Nombre.";
            if (animal.PesoAnimal <= 0) return "Debes elegir un Peso.";
            if (animal.raza.Trim() == "") return "Establece una Raza.";
            return String.Empty;


          
        }

        public string Validatorfecha(Tratamiento tratamiento) {
            if (tratamiento.datoshistorial.Trim() == "") return "Escriba una consulta";
            if (tratamiento.Proximafecha < DateTime.Now) return "Error de fecha";         
            return String.Empty;
        }
        
        public void Autenticar(string login, string password)
        {
            List<Usuario> listusers = new List<Usuario>();
            DataService dataService = new DataService();
            
            return ;

        }
    }
}
