using System;
class Aula26{
    static void Main()
    {
        int divid, divis, quoc, rest;

        divid = 10;
        divis = 7;
        quoc = divide(divid, divis, out rest);

        Console.WriteLine("{0}/{1} = {2} (Resto = {3})!", divid, divis, quoc, rest);
    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo/divisor;
        resto = dividendo%divisor;
        return quociente;
    }
}