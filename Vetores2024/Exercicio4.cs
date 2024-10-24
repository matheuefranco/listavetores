using System;
using Arrays;

namespace Vetores2024
{
    class Exercicio4
    {
        static int contaImpares(int[] vetor)
        {
            int cont = 0;
            for(int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i]%2 != 0)
                    cont++;
            }// fim for
            return cont;
        }
        static void Main()
        {


        }
    }
}
