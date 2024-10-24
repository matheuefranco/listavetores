﻿using System;

namespace Arrays
{
    public class BibliotecaArray
    {
        public static void leiaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        } // fim leia vetor

        public static void leiaVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"[{i}]:");
                vetor[i] = double.Parse(Console.ReadLine());
            }
        } // fim leia vetor

        public static void geraVetor(int[] vetor)
        {
            Random random = new Random(); // gerador de aleatorios
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
            }
        } // fim gera vetor

        public static void geraVetor(double[] vetor)
        {
            Random random = new Random(); // gerador de aleatorios
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100)+random.NextDouble();
            }
        } // fim gera vetor

        public static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($" | {vetor[i]}");

            Console.WriteLine("");
        }//  fim mostra vetor

        public static void mostraVetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write($" | {vetor[i]:F2}");
            
            Console.WriteLine("");
        }//  fim mostra vetor


    }
}
