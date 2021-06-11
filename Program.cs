using System;

namespace Retangulo_Contorno
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibereatanguloContorno();
        }
        static void ExibereatanguloContorno()
        {
            Console.WriteLine(" - - RETÂNGULO CONTORNO - - \n");
            int qtdLinhas, qtdColunas = 0;
            Console.Write("Quantas linhas: ");
            qtdLinhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas colunas: ");
            qtdColunas = Convert.ToInt32(Console.ReadLine());

            int linhaAtual = 0;
            while (linhaAtual < qtdLinhas)
            {
                linhaAtual += 1;

                int colunaAtual = 0;
                while (colunaAtual < qtdColunas)

                {
                    colunaAtual += 1;
                    if (linhaAtual == 1 || linhaAtual == qtdLinhas)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        if (colunaAtual == 1 || colunaAtual == qtdColunas)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }

                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}





