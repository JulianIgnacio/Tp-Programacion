using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main()
        {
            int[] Sueldos = new int[5];
            Cargar(Sueldos);
            Mostrar(Sueldos);
            Console.ReadKey();
        }
        static void Cargar(int[] Sueldos)
        {
            Console.WriteLine("Ingrese los sueldos");
            Sueldos[0] = Convert.ToInt32(Console.ReadLine());
            Sueldos[1] = Convert.ToInt32(Console.ReadLine());
            Sueldos[2] = Convert.ToInt32(Console.ReadLine());
            Sueldos[3] = Convert.ToInt32(Console.ReadLine());
            Sueldos[4] = Convert.ToInt32(Console.ReadLine());
        }
        static void Mostrar(int[] Sueldos)
        {
            for(int i = 0; i < Sueldos.Length; i++)
            {
                Console.WriteLine("El valor de la posicion {0} es: {1}",i+1,Sueldos[i]);
            }
        }
    }
}
