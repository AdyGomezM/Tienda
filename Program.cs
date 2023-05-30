using System;
using Tienda.Entities;

namespace Tienda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++BIENVENIDOS++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Persona persona= new Persona();
            persona.PedirDatos();
          
            

        }
    }
}
