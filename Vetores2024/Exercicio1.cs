using System;
using Arrays;
    class Exercicio1
    {
       static int somaVetor(int[] vetor) {
        int soma = 0;
         for (int i = 0;i<vetor.Length;i++)
        {
            soma += vetor[i];
        }

        return soma;
       } 
       static void Main()
        {
            int n;
            Console.WriteLine("Tamanho do vetor:");
            n = int.Parse(Console.ReadLine());
            int[] meuVetor = new int[n];
            BibliotecaArray.geraVetor(meuVetor);
            Console.WriteLine("Vetor gerado:");
            BibliotecaArray.mostraVetor(meuVetor);
            Console.Write("\nSoma do vetor:");
            Console.WriteLine($"{somaVetor(meuVetor)}");
            Console.ReadKey();
        }
    }

