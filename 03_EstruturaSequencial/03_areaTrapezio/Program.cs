using System;

namespace areaTrapezio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBS: VARIÁVEIS DO TIPO 'DOUBLE' DEVEM TER O PONTO FLUTUANTE.
            //OBS: VARIÁVEIS DO TIPO 'FLOAT' DEVEM TER O 'f' NO FINAL. EX: 'float a; a = 10f;

            double area, h, b, B;

            h = 5.0;
            b = 6.0;
            B = 8.0;

            area = (((b + B) / 2.0) * h);

            Console.WriteLine(area);

            Console.ReadLine();
        }
    }
}
