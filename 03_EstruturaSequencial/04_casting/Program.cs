using System;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEGUE O EXEMPLO DE UM PROBLEMA COM TIPOS:

            //O RESULTADO DEVERIA APARECER COM PONTO FLUTUANTE!
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = a / b;

            Console.WriteLine(resultado);
            

            
            //SEGUE ABAIXO A RESOLUÇÃO DESTE PROBLEMA:

            int x, y;
            double resultadoFinal;

            x = 5;
            y = 2;

            resultadoFinal = (double) x / y;

            Console.WriteLine(resultadoFinal);

           
            //SEGUE OUTRO EXEMPLO:
            
            double r;
            int s;

            // A VARIÁVEL 'r' RECEBEU UM VALOR COM PONTO FLUTUANTE.
            r = 5.0;
            // AGORA QUERO PEGAR ESSE VALOR DENTRO DA VARIÁVEL 'r' E GUARDAR DENTRO DA VARIÁVEL 's'.
            // PORÉM, ELA RECEBEU UM TIPO 'inteiro-int' E PARA RESOLVER, BASTA UTILIZAR O 'CASTING' ANTES DE GUARDAR A INFORMAÇÃO.
            s = (int) r;
            //ATENÇÃO!!! ESSE PROCESSO PERDE DADOS, COMO POR EXEMPLO O PONTO FLUTUANTE NÃO SERÁ GUARDADO.

            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}