using System;
using Arrays;
class Program
{
   
    static void Main()
    {
        double[] meuVetor = new double[5]; // declarando o vetor
        
        Console.WriteLine("*** Vetores em C# ***");
        Console.WriteLine("Entre com os valores para o vetor:");
        //  dados para o vetor
        BibliotecaArray.geraVetor(meuVetor);
        // mostrar dados do vetor
        Console.WriteLine("*** Vetor recebido ***");
        BibliotecaArray.mostraVetor(meuVetor);
        Console.ReadKey();
    }
}
