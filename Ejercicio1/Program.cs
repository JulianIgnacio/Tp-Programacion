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
        }
        static void Cargar(int[] Sueldos)
        {
            for(int  i = 0; i < Sueldos.Length; i++)
            {
                Console.Write("Ingrese el sueldo {0}", i + 1);
                Sueldos[i] = Convert.ToInt32(Console.ReadLine());
            }
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
