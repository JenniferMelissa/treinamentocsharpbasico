using System;

namespace CursoGitHub.InterfaceConsole
{   //inicio do namespace

    internal class Program
    {//inicio da classe

        static void Main(string[] args)
        {//inicio do método
            /*
             * Main - principal
             * O método inicia-se com a letra maiuscula
             */
            //Variável 
            /*
             * É um espaço reservado na memória
            */
            /*Tipos de Dados
             * Inteiro - int
             * Reak - Double
             * Texto - String
             */
            /*
             * + - Adição 
             * - - Subtração
             * * - Multiplicação
             * - - Divisão
             * % - Mod (módulo de divisão)
             */

            string comando;
            double pontos = 0;

            string resposta = "git remote add origin";
            Console.WriteLine("Qual comando para adicionar repositório remoto");
            comando = Console.ReadLine();
            string[] subcomando = comando.Split(' ');
            if (comando.Equals(resposta))
            {
                Console.WriteLine("acertou");
            }
            else
            {
                Console.WriteLine("errou");
            }


            foreach (var item in subcomando)
            {
                if (subcomando.Length < 2)
                {
                    Console.WriteLine("poxa você nem lembra dos comandos");
                    break;
                }
                else if (subcomando.Length == 2)
                {
                    pontos = 50.00;
                }
                else
                {
                    pontos = 100.00;
                }
                Console.WriteLine(item);
            }



            Console.WriteLine($"A resposta é {resposta}");
            string resultadoFinal = pontos > 50 ? "elogio" : "continue tentando";
            Console.WriteLine($"Você obteve {pontos} e teve o resultado {resultadoFinal}");
            Console.ReadKey();




        }//fim do método
    }//fim da classe
}//fim do namespace
