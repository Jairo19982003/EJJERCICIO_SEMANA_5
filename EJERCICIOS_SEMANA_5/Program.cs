using System;
using System.Collections.Generic;

namespace EjercicioModular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio Modular");

            // Ejemplo de uso de las funciones
            Console.WriteLine($"Área de un círculo con radio 5: {CalcularAreaCirculo(5)}");
            Console.WriteLine($"Perímetro de un rectángulo de ancho 3 y altura 4: {CalcularPerimetroRectangulo(3, 4)}");
            List<int> numeros = new List<int> { 4, 5, 6, 7, 8 };
            Console.WriteLine($"Promedio de la lista de números [4, 5, 6, 7, 8]: {CalcularPromedio(numeros)}");
            Console.WriteLine($"El número 7 es par: {EsPar(7)}");
            Console.WriteLine($"Convertir la cadena 'Hola Mundo' a mayúsculas: {ConvertirAMayusculas("Hola Mundo")}");
            Console.WriteLine($"Distancia entre los puntos (1, 2) y (4, 6): {CalcularDistanciaEntrePuntos(1, 2, 4, 6)}");
            Console.WriteLine($"Suma de los primeros 5 números naturales: {CalcularSumaNaturales(5)}");
            Console.WriteLine($"Factorial de 5: {CalcularFactorial(5)}");
        }

        // Función que calcula el área de un círculo
        static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        // Función que calcula el perímetro de un rectángulo
        static double CalcularPerimetroRectangulo(double ancho, double altura)
        {
            return 2 * (ancho + altura);
        }

        // Función que calcula el promedio de una lista de números
        static double CalcularPromedio(List<int> numeros)
        {
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            return (double)suma / numeros.Count;
        }

        // Función que determina si un número es par o impar
        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }

        // Función que convierte una cadena a mayúsculas
        static string ConvertirAMayusculas(string cadena)
        {
            return cadena.ToUpper();
        }

        // Función que calcula la distancia entre dos puntos en un plano cartesiano
        static double CalcularDistanciaEntrePuntos(double x1, double y1, double x2, double y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }

        // Función que calcula la suma de los primeros n números naturales
        static int CalcularSumaNaturales(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        }

        // Función que calcula el factorial de un número
        static int CalcularFactorial(int numero)
        {
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}