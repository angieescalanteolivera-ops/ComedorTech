using System;

namespace ComedorTech
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Password { get; set; }

        public void Ingresar()
        {
            Console.WriteLine("Bienvenido al sistema");
        }
    }
}