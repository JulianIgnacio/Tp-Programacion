﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main()
        {
            int[] temperaturas = new int[7];
            Cargar(temperaturas);
            Console.WriteLine("Las temperaturas de la semana son:");
            Mostrar(temperaturas);
            Console.ReadKey();
        }
        static void Cargar(int[] ingresotemp )
        {
            for ( int i = 0; i < ingresotemp.Length; i++ )
            {
                Console.Write("Ingrese la temperatura numero {0}:",i+1 );
                ingresotemp[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Mostrar(int[] mostrartemp)
        {
            for( int i = 0;i < mostrartemp.Length;i++ )
            {
                Console.WriteLine("dia {0}:{1}",i+1,mostrartemp[i]);
            }
        }
    }
}