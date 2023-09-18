using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_caso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base: ");
            int numB = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine());

            int resultado = 1;

            for (int i = 1; i <= exponente; i++) 
            {
                resultado = resultado * numB;
            }
            Console.Write("La potencia es: "+resultado);
            Console.ReadKey();
        }
    }
}
