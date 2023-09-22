using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base:");
            int num1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente:");
            int num2=int.Parse(Console.ReadLine());
            int resultado = 1;
            for(int i = 0; i < num2; i++)
            {
                resultado *= num1;
            }
            Console.WriteLine("La potencia es:" + resultado);
            Console.ReadKey();
        }
    }
}
