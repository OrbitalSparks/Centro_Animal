using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_animal.Entities
{
    public class Tratamiento
    {
        public int IDAnimalhistoiral { get; set; }
        public string datoshistorial { get; set; }
        public int IDVeterinario { get; set; }
        public DateTime Ultimafecha { get; set; }
        public DateTime Proximafecha { get; set; }
        public int idtrat { get; set; }
        




    }
}
