using System;

class Aula08{
    static void Main(){
        int Valor = 10;

        Console.WriteLine("O Valor é de {0}", Valor);

        Valor = Valor << 1;

        Console.WriteLine("Agora o Valor com << é de {0}", Valor);

        Valor = 10;
        Valor = Valor >> 1;

        Console.WriteLine("Agora o Valor com >> é de {0}", Valor);

        Valor = 10;
        Valor = Valor << 2;

        Console.WriteLine("Agora o Valor com << 2 é de {0}", Valor);

        Valor = Valor >> 2;

        Console.WriteLine("Agora o Valor com >> 2 é de {0}", Valor);
    }   
}