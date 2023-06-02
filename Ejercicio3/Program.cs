﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main()
        {
            int[] Vector1 = new int[5];
            int[] Vector2 = new int[5];
            Console.WriteLine("ingrese los valores del primer vector:");
            Cargar(Vector1);
            Console.WriteLine("ingrese los valores del segundo vector:");
            Cargar(Vector2);
            Mostrar(Vector1);
            Mostrar(Vector2);

            Sumar(Vector1, Vector2);

            Console.WriteLine("El vector resultante es: {0}",Sumar(Vector1,Vector2));
            Console.ReadKey();
        }
        static void Cargar(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("ingrese los valores de cada posicion del vector:");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Mostrar(int[] vector)
        {
            for(int i=0; i < vector.Length; i++)
            {
                Console.WriteLine("El valor {0} del vector es:{1}",i+1, vector[i]);
            }
        }
        static int Sumar(int[] vr1, int[] vr2) {
            int[] vrf = new int[5];
            vrf[5] = vr1[5]+vr2[5];
            return vrf[5];
        }
    }
}
