using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJJAdministrator.Entities
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string Login { get; set; }
        public string Password { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public int DNI { get; set; }


    }
}
