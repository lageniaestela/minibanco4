﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector1
{
    class PruebaVector1
    {
        private int[] sueldos; //Declaramos un vector

        public void Cargar()
        {
            sueldos = new int[6]; //Inicializamos el vector en 5
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("Ingrese sueldo del operario "+f+": ");
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea); //Asignamos los 5 sueldos al vector
            }
        }
        //Muestra los sueldos de los operarios en el vector sueldos[f]
        public void Imprimir()
        {
            Console.Write("Los 5 sueldos de los aperarios \n");
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("["+sueldos[f]+"] ");
            }
            Console.ReadKey();
        }
        //main principal
        static void Main(string[] args)
        {
            PruebaVector1 pv = new PruebaVector1();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}

