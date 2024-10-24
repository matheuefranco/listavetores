using System;


    class Exercicio11
    {
        static void Main()
    {
        string frase;
        Console.WriteLine("Entre com a frase com p:");
        frase= Console.ReadLine();
        for(int i = 1;i<frase.Length;i++)
        {
            if (frase[i]!='p')
              Console.Write(frase[i]);
            else
                if (frase[i-1]=='p' && frase[i+1]=='p')
                  Console.Write(frase[i]);
        }
        
        Console.ReadKey();
    }
  }

