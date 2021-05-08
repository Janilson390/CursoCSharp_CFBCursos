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

    public Veiculo (int rodas)
    {
        this.rodas = rodas;
    }

    public int getRodas(){
        return rodas;
    }

    public void setRodas(int rodas){
        if(rodas < 0){
            this.rodas = 0;
        }else if(rodas > 40){
            this.rodas = 40;
        }else{
            this.rodas = rodas;
        }
    }
}

class Carro:Veiculo{
    public string nome;
    
    public string cor;
    
    public Carro():base(4){
        Desligar();
        velMax = 120;
    }

    public Carro(string nome, string cor):base(4){
        Desligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate:Carro{
    public int municao;

    public CarroCombate():base("Carro Combate", "Verde")
    {
        this.municao = 100;
    }

    public int getMunicao(){
        return municao;
    }
}

class Aula35{
    static void Main(){
        Carro c1 = new Carro();

        Console.WriteLine("O carro 1 está {0}\n", c1.getLigado()?"Ligado":"Desligado");

        c1.Ligar();

        Console.WriteLine("O carro 1 está {0}\n", c1.getLigado()?"Ligado":"Desligado");

        Carro c2 = new Carro("Rapidão", "Vermelho");
        
        Console.WriteLine("O carro 2 está {0}", c2.getLigado()?"Ligado":"Desligado");
        Console.WriteLine("Nome...........{0}", c2.nome);
        Console.WriteLine("Cor............{0}", c2.cor);
        Console.WriteLine("Rodas..........{0}", c2.getRodas());
        Console.WriteLine("Vel. Máxima....{0}", c2.velMax);

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("---------------Carro de Combate---------------");

        CarroCombate cc1 = new CarroCombate();
        
        Console.WriteLine("O carro está...{0}", cc1.getLigado()?"Ligado":"Desligado");
        Console.WriteLine("Nome...........{0}", cc1.nome);
        Console.WriteLine("Cor............{0}", cc1.cor);
        Console.WriteLine("Rodas..........{0}", cc1.getRodas());
        Console.WriteLine("Vel. Máxima....{0}", cc1.velMax);
        Console.WriteLine("Munição........{0}", cc1.getMunicao());
    }
}