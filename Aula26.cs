using System;
class Aula26{
    static void Main()
    {
        int divid, divis, quoc, rest;
        string msg;

        divid = 10;
        divis = 0;
        quoc = divide(divid, divis, out rest, out msg);

        Console.WriteLine("{0}!\n{1}/{2} = {3}\nResto = {4}!", msg, divid, divis, quoc, rest);
    }

    static int divide(int dividendo, int divisor, out int resto, out string mensagem){
        int quociente;

        if (divisor == 0){
            mensagem = "Impossível dividir por zero!";
            resto = 0;
            quociente = 0;
        }else{
            mensagem = "Operação realizada com sucesso!";
            quociente = dividendo/divisor;
            resto = dividendo%divisor;
        }
        
        return quociente;
    }
}