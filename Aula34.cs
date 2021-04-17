using System;

class Veiculo{ //Classe Base
    public int velMax;
    public bool ligado;
    public void Ligar(){
        ligado = true;
    }   
    public void Desligar(){
        ligado = false;
    }
}

class Carro:Veiculo{
    public Carro(){
        ligado = true;
    }
}
class Aula34{
    static void Main(){
        Carro c1 = new Carro();

        c1.Ligar();

        Console.WriteLine("O carro está {0}", c1.ligado?"Ligado":"Desligado");
    }
}