using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Services;

namespace Tienda.Entities
{
    public class Persona
    {
        public string Nombre;
        public string ApellidoP;
        public string ApellidoM;
        public string Correo;
        public double Telefono;

        public void PedirDatos()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ingresa tu Nombre");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu Apellido Paterno");
            this.ApellidoP = Console.ReadLine();
            Console.WriteLine("Ingresa tu Apellido Materno");
            this.ApellidoM = Console.ReadLine();
            Console.WriteLine("Ingresa tu Correo Electronico");
            this.Correo = Console.ReadLine();
            Console.WriteLine("Ingresa tu Telefono");
           this.Telefono = double.Parse(Console.ReadLine());

            Menu menu = new Menu();
            menu.Sumar();
        }
       
        

    }
   
      
    
}
