using System;

namespace BecaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cada Becario deverá criar um metódo para calcular a soma da diagonal principal de uma matriz quadrada 3 x 3 
            // O método deverá ter o nome do participante
            // exemplo: CalculaSomaDiagonalPrincipal_Ricardo();
            int[,] matriz = Matriz();
            CalculoSomaDiagonalPrincipal_Marcelo(matriz);
            Console.ReadLine();
        }
        public static int[,] Matriz()
        {
            Console.WriteLine("Quantas linhas e colunas na matriz quadrada? ");
            int x = int.Parse(Console.ReadLine());

            int[,] matriz = new int[x, x];
            Console.WriteLine("Digite os numeros da matriz");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matriz;
        }

        public static void CalculoSomaDiagonalPrincipal_Marcelo(int[,] matriz)
        {
            int principal = 0;
            for (int i = 0; i <= matriz.GetLength(0) - 1; i++)
            {
                principal += matriz[i, i];
            }
            Console.WriteLine("Soma diagonal pricipal = " + principal);
        }
    }
}

