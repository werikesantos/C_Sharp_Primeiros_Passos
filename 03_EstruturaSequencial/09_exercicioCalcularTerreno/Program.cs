using System;
using System.Globalization;

namespace _09_exercicioCalcularTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler as medidas da largura e comprimento de um terreno
            //retangular com uma casa decimal, bem como o valor do metro quadrado do
            //terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor
            //da área do terreno, bem como o valor do preço do terreno, ambos com duas
            //casas decimais, conforme exemplo.

            double largura, comprimento, area, valorMetro, valorTotal;

            Console.WriteLine("Digite o valor da largura:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor da comprimento:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do metrô quadrado:");
            valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            valorTotal = valorMetro * area;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture) + "\nPRECO = " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
