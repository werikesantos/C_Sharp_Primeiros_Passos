using System;

namespace _07_exercicioFixacao_EntradaESaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            String nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha e separados com espaços):");
            String[] dados = Console.ReadLine().Split(' ');
            String ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2]);

            Console.WriteLine(nome + "\n" + qtdQuarto + "\n" + precoProduto.ToString("F2") + "\n" + ultimoNome + "\n" + idade + "\n" + altura);
        }
    }
}
