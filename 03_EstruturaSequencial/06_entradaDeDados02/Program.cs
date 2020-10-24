using System;

//PARA TRABALHAR COM PONTOS FLUTUANTES UTILIZANDO O '.' BASTA TIRAR AS BARRAS DO COMANDO ABAIXO!
//using System.Globalization;

//DEPOIS AJUSTE O COMANDO COMENTADO NA LINHA (20) E (26):
//=> double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCultire);

namespace _06_entradaDeDados02
{
    class Program
    {
        static void Main(string[] args)
        {

            //ATENÇÃO!!!
            //PARA QUE O PROCESSO DA ENTRADA DE DADOS FUNCIONE CORRETAMENTE, NOS PONTOS FLUTUANTES UTILIZE A ','.
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine()); //ATENÇÃO!!! , CultureInfo.InvariantCultire);

            String[] dados = Console.ReadLine().Split(' ');
            String nome = dados[0];
            char sexo = char.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3]); //ATENÇÃO!!! , CultureInfo.InvariantCultire);

            Console.WriteLine("\n" + n1 + "\n" + ch + "\n" + n2 +"\n"+ nome + " "+ sexo + " " + idade + " " + (altura.ToString("F2")) );
        }
    }
}
