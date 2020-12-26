using System;

class Aula10{
    enum DiasSemanda{Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};
    static void Main()
    {
        DiasSemanda ds = (DiasSemanda)3;

        Console.WriteLine("O dia da semana é {0}", ds);

    }   
}