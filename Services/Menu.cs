using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Services
{
    public class Menu
    {
        public void Sumar()
        {
          
            Console.WriteLine("COLOCA EL PRECIO DE TUS ARTICULOS");
            Console.WriteLine("Ingresa el costo del primer articulo");
           int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el costo del segundo articulo");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el costo del tercer articulo");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el costo del cuarto articulo");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el costo del quinto articulo");
            int num5 = int.Parse(Console.ReadLine());

            int resultado = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine("El resultado es " + resultado);
            
         
          

        }
        
        

       
    }
}

