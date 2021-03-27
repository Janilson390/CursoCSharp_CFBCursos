using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){
        energia = 100;
        vivo = true;
    }
    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

    ~Jogador(){
        Console.WriteLine("Jogador {0} Destruido!", nome);
    }
}
class Aula29{
    static void Main(){
        Jogador j1 = new Jogador("Bruno");
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador("Théo");

        j1.energia =50;
        Console.WriteLine("Nome do Jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome do Jogador 2: {0}", j2.nome);
        Console.WriteLine("Nome do Jogador 3: {0}", j3.nome);

        j2.nome = Console.ReadLine().ToString();

        Console.WriteLine("\nNome do Jogador 2: {0}", j2.nome);
    }
}