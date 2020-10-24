using System;

namespace _06_entradaDeDados01
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase, x, y, z, abc, a, b, c;

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            //PEGANDO UMA FRASE (Amarelo Laranja Cinza)
            // CRIANDO UM VETOR UTILIZANDO O COMANDO 'Split' PARA SEPARA CADA PALAVRA ONDE CONTEM UM ESPAÇO ENTRE ELAS!
            String[] vetor = Console.ReadLine().Split(' ');
            //APÓS OCORRER A SEPARAÇÃO DAS VARIÁVEIS PELO COMANDO ACIMA 'Split', TODAS ELAS ESTÃO SENDO GUARDADAS EM UMA OUTRA VARIÁVEL:
            a = vetor[0];
            b = vetor[1];
            c = vetor[2];

            //IMPRIMINDO TODOS OS DADOS COMO SOLICITADO PELO PROFESSOR!
            Console.WriteLine("\nVocê digitou:\n" + frase +"\n"+ x + "\n" + y + "\n" + z + "\n" + a + " " + b + " " + c);

        }
    }
}
