using System;
class Aula10{
    static void Main()
    {
        int num = 10;
        long numLong = num;

        Console.WriteLine("Valor de numLong {0}", numLong);

        short numShort = (short)num;

        Console.WriteLine("Valor de numShort {0}", numShort);
    }   
}