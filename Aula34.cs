using System;

class Veiculo{ //Classe Base
    public int velMax;
    private bool ligado;
    public void Ligar(){
        ligado = true;
    }   
    public void Desligar(){
        ligado = false;
    }

    public bool getLigado(){
        return ligado;
    }
}

class Carro:Veiculo{
    public Carro(){
        Desligar();
    }
}
class Aula34{
    static void Main(){
        Carro c1 = new Carro();

        Console.WriteLine("O carro está {0}", c1.getLigado()?"Ligado":"Desligado");

        c1.Ligar();

        Console.WriteLine("O carro está {0}", c1.getLigado()?"Ligado":"Desligado");
    }
}