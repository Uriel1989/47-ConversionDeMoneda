using System;

namespace ConversionDeMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al convertidor de moneda, ingrese el nombre de la moneda extrangera en cuestion para hacer el calculo:");

            string NombreDeMoneda = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de pesos a convertir:");
            decimal pesos = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la unidad de la moneda extragera en relacion a la moneda nacional:");
            decimal monedaextrangera = Convert.ToDecimal(Console.ReadLine());

            ConversionCambiaria conversionCambiaria = new ConversionCambiaria();

            Console.WriteLine("Los pesos ingresados equivalen a: " + conversionCambiaria.PasajeDeMoneda(pesos, monedaextrangera)+" "+ NombreDeMoneda);

            Console.ReadKey();
        }
    }
}
