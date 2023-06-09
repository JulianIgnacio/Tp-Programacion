using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de nombres de estudiantes que desea guardar:");
            string[] Estudiantes = new string[Convert.ToInt32(Console.ReadLine())];
            Cargar(Estudiantes);
            Mostrar(Estudiantes);
            Array.Sort(Estudiantes);
            Console.WriteLine("Los estudiantes ordenados en orden alfabetico:");
            Mostrar(Estudiantes);
        }
        static void Cargar(string[] Estudiantes)
        {
            for(int i = 0; i < Estudiantes.Length; i++)
            {
                Console.Write("Ingrese el nombre del estudiante:");
                Estudiantes[i] = Console.ReadLine();
            }
        }
        static void Mostrar(string[] Estudiantes)
        {
            for( int i = 0;i < Estudiantes.Length;i++)
            {
                Console.WriteLine("El estudiante es:{0}", Estudiantes[i]);
            }
        }
    }
}
