using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Centro_animal.Entities;
using Centro_animalDB;
using Dapper;
using NPOI.SS.Formula.Functions;

namespace Centro_animal_Services
{
    public class DataService
    {
        private int datos;

        public List<Tratamiento> GETtratamientos(int dato)
        {
            datos = dato;
            BDOperation<Tratamiento> listaDB = new BDOperation<Tratamiento>();
            List<Tratamiento> ListClientes = new List<Tratamiento>();
            
            string sql = "SELECT * FROM historialMED where IDAnimalhistorial=" + dato +"";

            ListClientes = listaDB.GBDOperation<Tratamiento>(sql);
            return ListClientes;
        }
        public List<Regisanimal> GETanimalfiltadro(string dato)
        {

            BDOperation<Regisanimal> listaDB = new BDOperation<Regisanimal>();
            List<Regisanimal> ListClientes = new List<Regisanimal>();

            string sql = "select IDDuenio,IDanimal,nombre,apellido,NombreAnimal,PesoAnimal,raza,especie,sexo,fechaIngreso,fechaNacimento from Cliente cl inner join Animal an on Cl.Id = an.IDDuenio where NombreAnimal like('" + dato + "%')";

            ListClientes = listaDB.GBDOperation<Regisanimal>(sql);
            return ListClientes;
        }
        public List<Regisanimal> GETlistaconduenio()
        {



            BDOperation<Regisanimal> listaDB = new BDOperation<Regisanimal>();
            List<Regisanimal> ListClientes = new List<Regisanimal>();

            string sql = "select IDDuenio,IDanimal,nombre,apellido,NombreAnimal,PesoAnimal,raza,especie,sexo,fechaIngreso,fechaNacimento from Cliente cl inner join Animal an on Cl.Id = an.IDDuenio";

            ListClientes = listaDB.GBDOperation<Regisanimal>(sql);
            return ListClientes;
        }

        public List<Cliente> GETCleintes()
        {

            BDOperation<Cliente> listaDB = new BDOperation<Cliente>();
            List<Cliente> ListClientes = new List<Cliente>();

            string sql = "SELECT * FROM Cliente ORDER BY Id";

            ListClientes = listaDB.GBDOperation<Cliente>(sql);
            return ListClientes;
        }
        public List<Cliente> GETCleintesconanimal(int dato)
        {

            BDOperation<Cliente> listaDB = new BDOperation<Cliente>();
            List<Cliente> ListClientes = new List<Cliente>();

            string sql = "SELECT * FROM Cliente where Id=" + dato+"";

            ListClientes = listaDB.GBDOperation<Cliente>(sql);
            return ListClientes;
        }


        //public List<Direccion> GETDireccion()
        //{



        //    BDOperation<Direccion> listaDB = new BDOperation<Direccion>();
        //    List<Direccion> ListDir = new List<Direccion>();

        //    string sql = "SELECT * FROM Direccion ORDER BY IDdireccion";

        //    ListDir = listaDB.GBDOperation<Direccion>(sql);
        //    return ListDir;
        //}

        public List<Veterinario> GETVeterinarios()
        {

            BDOperation<Veterinario> listaDB = new BDOperation<Veterinario>();
            List<Veterinario> Lista = new List<Veterinario>();

            string sql = "SELECT * FROM Empleado ORDER BY Id";

            Lista = listaDB.GBDOperation<Veterinario>(sql);
            return Lista;
        }
        public List<Veterinario> GETVeterinariodepaciente(int dato)
        {

            BDOperation<Veterinario> listaDB = new BDOperation<Veterinario>();
            List<Veterinario> Lista = new List<Veterinario>();

            string sql = "SELECT nombre,Id FROM Empleado where Id=" + dato+"";

            Lista = listaDB.GBDOperation<Veterinario>(sql);
            return Lista;
        }


        public List<Animal> GETAnimales()
        {

            BDOperation<Animal> listaDB = new BDOperation<Animal>();
            List<Animal> Lista = new List<Animal>();

            string sql = "SELECT * FROM Animal ORDER BY IDanimal";

            Lista = listaDB.GBDOperation<Animal>(sql);
            return Lista;
        }



        public List<Especie> GETESpecie()
        {

            BDOperation<Especie> listaDB = new BDOperation<Especie>();
            List<Especie> Lista = new List<Especie>();

            string sql = "SELECT * FROM Especie ORDER BY idespecie";

            Lista = listaDB.GBDOperation<Especie>(sql);
            return Lista;
        }
        public List<AnimalSEXO> GETsexo()
        {

            BDOperation<AnimalSEXO> listaDB = new BDOperation<AnimalSEXO>();
            List<AnimalSEXO> Lista = new List<AnimalSEXO>();

            string sql = "SELECT * FROM animalsexo ORDER BY id";

            Lista = listaDB.GBDOperation<AnimalSEXO>(sql);
            return Lista;
        }



        public string CrearCliente(Cliente cliente)
        {

            BDOperation<Cliente> listaDB = new BDOperation<Cliente>();

            string sql = "INSERT INTO Cliente (nombre,apellido,DNI,Telefono,Calle,Numero) VALUES (@nombre,@apellido,@DNI,@telefono,@calle,@numero)";

            var listparams = new
            {

                nombre = cliente.nombre,
                apellido = cliente.apellido,
                DNI = cliente.DNI,
                telefono = cliente.Telefono,
                calle = cliente.Calle,
                numero = cliente.Numero

            };




            listaDB.OperationExecute(sql, listparams);
            return "Exitoso";
        }
        public string CrearConsulta(Tratamiento tratamiento)
        {

            BDOperation<Tratamiento> listaDB = new BDOperation<Tratamiento>();

            string sql = "insert into historialMED (IDAnimalhistorial,IDVeterinario,Datoshistorial,Ultimafecha,Proximafecha) values(@idanimal,@idvet,@datoshisto,@ultfec,@proxfe)";

            var listparams = new
            {

               idanimal=  tratamiento.IDanimalhistoiral,
               idvet=tratamiento.IDVeterinario,
               datoshisto=tratamiento.datoshistorial,
               ultfec=tratamiento.fechaactual,
               proxfe=tratamiento.fechaproxima
            };




            listaDB.OperationExecute(sql, listparams);
            return "Exitoso";
        }


        public string CrearMascota(Cliente cliente, Animal animal)
        {

            BDOperation<Cliente> listaDB = new BDOperation<Cliente>();

            string sql = "insert into Animal(NombreAnimal,PesoAnimal,especie,fechaIngreso,fechaNacimento,IDDuenio,raza,sexo) VALUES (@nombreA,@pesoanimal,@especie,@fecI,@fecN,@id,@raza,@sexo)";
            var listparams = new
            {

                 nombreA=animal.NombreAnimal,
                 pesoanimal= animal.PesoAnimal,
                 especie =animal.especie,
                 fecI = animal.fechaIngreso,
                 fecN = animal.fechaNacimento,
                 id = cliente.id,
                 raza= animal.raza,
                 sexo= animal.sexo
                

            };

            listaDB.OperationExecute(sql, listparams);
            return "Exitoso";
        }

        public string MODIFCliente(Cliente cliente)
        {

            BDOperation<Cliente> listaDB = new BDOperation<Cliente>();

            string sql = "UPDATE Cliente SET nombre=@nombre,apellido=@apellido,DNI=@DNI,Telefono=@telefono,Calle=@calle,Numero=@numero WHERE Id=@id";
            var listparams = new
            {

                nombre = cliente.nombre,
                apellido = cliente.apellido,
                DNI = cliente.DNI,
                telefono = cliente.Telefono,
                id =cliente.id,
                calle = cliente.Calle,
                numero = cliente.Numero,

            };




            listaDB.OperationExecute(sql, listparams);

            return "Exitoso";
        }



    }


}
