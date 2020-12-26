using System;

class Aula10{
    enum DiasSemanda{Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};
    static void Main()
    {
        int ds = Convert.ToInt32(DiasSemanda.Sexta);
        int ds2 = (int)DiasSemanda.Sabado;
        Console.WriteLine("O dia da semana é {0}\nO dia da semana é {1}", ds, ds2);
    }   
}