using System;

namespace ComedorTech
{
    public class Registro
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public void Registrar()
        {
            Console.WriteLine("Registro realizado");
        }
    }
}