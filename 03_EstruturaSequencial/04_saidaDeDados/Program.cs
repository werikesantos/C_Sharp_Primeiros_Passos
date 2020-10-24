using System;
//BIBLIOTECA PARA FORMATAR A UTILIZAÇÃO DO PONTO FLUTUANTE '.'
using System.Globalization;

namespace _04_saidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;

            //INPRIMINDO O DADO:
            Console.WriteLine(x);
            //IMPRIMINDO O DADO COM DUAS CASAS DECIMAIS:
            Console.WriteLine(x.ToString("F2"));
            //IMPRIMINDO O DADO COM 4 CASAS DECIMAIS:
            Console.WriteLine(x.ToString("F4"));
            //IMPRIMINDO O DADO COM '.' AO INVÉS DA UTILIZAÇÃO DA ','.
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
