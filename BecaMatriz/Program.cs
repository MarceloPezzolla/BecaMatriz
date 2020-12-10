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
            int[,] matriz = new int[3, 3] { { 2, 1, 1 }, { 2, 3, 2 }, { 3, 3, 4 } };
            CalculoSomaDiagonalPrincipal_Marcelo(matriz, 3);
            Console.Read();

            void CalculoSomaDiagonalPrincipal_Marcelo(int[,] mat, int n)
            {
                int principal = 0;
                for (int i = 0; i <= n - 1; i++)
                {
                    principal += mat[i, i];
                }
                Console.WriteLine("Soma diagonal pricipal = " + principal);

            }

        }
    }
}
