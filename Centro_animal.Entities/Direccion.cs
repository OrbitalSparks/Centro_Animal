namespace Centro_animal.Entities
{
    public class Direccion
    {
        public int ID { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }

        public Direccion(int iD, string calle, int numero)
        {
            ID = iD;
            Calle = calle;
            Numero = numero;
        }
    }


}