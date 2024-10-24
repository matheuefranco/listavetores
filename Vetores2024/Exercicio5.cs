using System;

namespace Vetores2024
{
     class Exercicio5
    {
        static void Main()
        {
            string dna;
            Console.WriteLine("Entre com as bases:");
            dna = Console.ReadLine();
            int n = dna.Length;
            char[] complementar = new char[n];
            // percorrer a string dna e preencher
            // o vetor complementar 
            for(int i = 0; i < n; i++)
            {
                switch(dna[i])
                {
                    case 'T':
                        complementar[i] = 'A';
                        break;
                    case 'A':
                        complementar[i] = 'T';
                        break;
                    case 'G':
                        complementar[i] = 'C';
                        break;
                    case 'C':
                        complementar[i] = 'G';
                        break;
                }
            }// fim for
            // vetor complementar
            Console.WriteLine("*** DNA *** ");
            Console.WriteLine(dna);
            for(int i = 0; i < n; ++i)
               Console.Write(complementar[i]);

            Console.ReadKey();
        }
    }
}
