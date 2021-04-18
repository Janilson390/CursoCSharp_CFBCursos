using System;

class Veiculo{ //Classe Base
    public int rodas;
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
    public string nome;
    
    public string cor;
    
    public Carro(){
        Desligar();
        rodas = 4;
        velMax = 120;
    }

    public Carro(string nome, string cor){
        Desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}
class Aula34{
    static void Main(){
        Carro c1 = new Carro();

        Console.WriteLine("O carro 1 está {0}\n", c1.getLigado()?"Ligado":"Desligado");

        c1.Ligar();

        Console.WriteLine("O carro 1 está {0}\n", c1.getLigado()?"Ligado":"Desligado");

        Carro c2 = new Carro("Rapidão", "Vermelho");
        
        Console.WriteLine("O carro 2 está {0}", c2.getLigado()?"Ligado":"Desligado");
        Console.WriteLine("Nome...........{0}", c2.nome);
        Console.WriteLine("Cor............{0}", c2.cor);
        Console.WriteLine("Rodas..........{0}", c2.rodas);
        Console.WriteLine("Vel. Máxima....{0}", c2.velMax);
    }
}