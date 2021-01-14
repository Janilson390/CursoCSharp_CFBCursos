using System;
class Aula25{
    static void Main()
    {
        int num = 50;

        Console.Write("Por Passagem de Valor!\n");
        dobrar1(num);
        Console.WriteLine("{0}", num);
        
        Console.Write("Por Passagem de Referência!\n");
        dobrar2(ref num);
        Console.WriteLine("{0}", num);
    }

    static void dobrar1(int valor){
        valor*=2;
    }

    static void dobrar2(ref int valor){
        valor*=2;
    }
}
