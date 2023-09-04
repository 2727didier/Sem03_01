using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {        // Solicitar al usuario el tipo de fruta y la distancia en kilómetros
            Console.WriteLine("Ingrese el tipo de fruta (naranja, fresa o mango):");
            string tipoFruta = Console.ReadLine();

            Console.WriteLine("Ingrese la distancia en kilómetros:");
            int distanciaKm = int.Parse(Console.ReadLine());

            // Definir los precios por caja de frutas según la tabla
            double precioPorCaja = 0;

            if (distanciaKm < 30)
            {
                switch (tipoFruta.ToLower())
                {
                    case "naranja":
                        precioPorCaja = 2;
                        break;
                    case "fresa":
                        precioPorCaja = 6;
                        break;
                    case "mango":
                        precioPorCaja = 3;
                        break;
                    default:
                        Console.WriteLine("Tipo de fruta no válido.");
                        return;
                }
            }
            else
            {
                switch (tipoFruta.ToLower())
                {
                    case "naranja":
                        precioPorCaja = 4;
                        break;
                    case "fresa":
                        precioPorCaja = 9;
                        break;
                    case "mango":
                        precioPorCaja = 5;
                        break;
                    default:
                        Console.WriteLine("Tipo de fruta no válido.");
                        return;
                }
            }

            // Calcular el pago total
            Console.WriteLine("Ingrese la cantidad de cajas de frutas:");
            int cantidadCajas = int.Parse(Console.ReadLine());

            double pagoTotal = cantidadCajas * precioPorCaja;

            // Mostrar el resultado
            Console.WriteLine("El pago total por la carga es: S/ " + pagoTotal);
        }
    }

}
    

