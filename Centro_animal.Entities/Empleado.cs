using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDJJAdministrator.Entities;

namespace Centro_animal.Entities
{
    public class Empleado : Persona
    {
        public string cargo { get; set; }
        public double salario { get; set; }

        public Usuario IDusuario { get; set; }



        //public Empleado(int id, string nombre, string apellidos, int dNI, DateTime fechaNacim, Direccion direccion, int telefono,string cargo,double salario) : base(id, nombre, apellidos, dNI, fechaNacim, direccion, telefono)
        // {
        //    this.cargo = cargo;
        //    this.salario = salario;
        // }
    }
}
