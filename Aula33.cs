using System;

class Jogador{
    private int energia;
    public string nome;
    public Jogador(string nome){
        this.nome = nome;
        energia=100;
    }
}

class Aula33{
    static void Main(){
        Jogador j1 = new Jogador("Janilson");

        Console.WriteLine("Nome: {0} \nEnergia: {1}", j1.nome, j1.energia);
    }
}